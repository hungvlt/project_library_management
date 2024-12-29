using QLThuVien_3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLThuVien_3
{
  public partial class UserControlDocGia : UserControl
  {
    private List<DocGia> danhSachDocGia = new List<DocGia>();
    private List<DocGia> filteredList = new List<DocGia>();
    private DocGia docGiaHienTai = null;
    private bool isChangingText = false;

    public UserControlDocGia()
    {
      InitializeComponent();
      InitializeDataGridView();
      LoadData();
      txtMaDocGia.ReadOnly = true;  // Đảm bảo trường mã độc giả chỉ đọc
    }

    private void InitializeDataGridView()
    {
      dgvQuanLyDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

      dgvQuanLyDocGia.Columns.Add("MaDocGia", "Mã độc giả");
      dgvQuanLyDocGia.Columns.Add("TenDocGia", "Tên độc giả");
      dgvQuanLyDocGia.Columns.Add("SoDienThoai", "Số điện thoại");
      dgvQuanLyDocGia.Columns.Add("GioiTinh", "Giới tính");
      dgvQuanLyDocGia.Columns.Add("DiaChi", "Địa chỉ");
      dgvQuanLyDocGia.Columns.Add("Email", "Email");

      foreach (DataGridViewColumn column in dgvQuanLyDocGia.Columns)
      {
        column.HeaderCell.Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
      }

      dgvQuanLyDocGia.RowTemplate.Height = 35;
    }

    private void LoadData()
    {
      try
      {
        using (var context = new QLThuVienContextDB())
        {
          // Kiểm tra xem bảng DocGias có dữ liệu không
          danhSachDocGia = context.DocGias.ToList();
          if (danhSachDocGia.Count == 0)
          {
            MessageBox.Show("Không có dữ liệu độc giả trong cơ sở dữ liệu.");
          }
        }
        HienThiDanhSachDocGia(danhSachDocGia);
        UpdateTongDocGia();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
      }
    }

    private void HienThiDanhSachDocGia(List<DocGia> list)
    {
      dgvQuanLyDocGia.Rows.Clear();
      foreach (var docGia in list)
      {
        AddDocGiaToGrid(docGia);
      }
    }

    private void AddDocGiaToGrid(DocGia docGia)
    {
      int rowIndex = dgvQuanLyDocGia.Rows.Add();
      DataGridViewRow row = dgvQuanLyDocGia.Rows[rowIndex];

      row.Cells["MaDocGia"].Value = docGia.MaDocGia;
      row.Cells["TenDocGia"].Value = docGia.TenDocGia;
      row.Cells["SoDienThoai"].Value = docGia.SoDienThoai;
      row.Cells["GioiTinh"].Value = docGia.GioiTinh;
      row.Cells["DiaChi"].Value = docGia.DiaChi;
      row.Cells["Email"].Value = docGia.Email;
    }

    private void ClearInputFields()
    {
      txtMaDocGia.Clear();
      txtTenDocGia.Clear();
      txtSoDienThoai.Clear();
      txtDiaChi.Clear();
      txtEmail.Clear();
      rdoNam.Checked = false;
      rdoNu.Checked = false;
      txtTenDocGia.Focus();
    }

    private bool ValidateInput()
    {
      if (string.IsNullOrWhiteSpace(txtTenDocGia.Text) ||
          !Regex.IsMatch(txtTenDocGia.Text, @"^[\p{L}\d\s]+$"))
      {
        MessageBox.Show("Tên độc giả chỉ chứa chữ cái tiếng Việt và khoảng trắng.");
        txtTenDocGia.Focus();
        return false;
      }

      if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ||
          txtSoDienThoai.Text.Length != 10 ||
          !txtSoDienThoai.Text.StartsWith("0") ||
          !long.TryParse(txtSoDienThoai.Text, out _))
      {
        MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0 và có độ dài 10.");
        txtSoDienThoai.Focus();
        return false;
      }

      if (string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
          !Regex.IsMatch(txtDiaChi.Text, @"^[\p{L}\d\s,.]+$"))
      {
        MessageBox.Show("Địa chỉ chỉ chứa chữ cái tiếng Việt, số, khoảng trắng, dấu ',' và dấu '.'.");
        txtDiaChi.Focus();
        return false;
      }

      if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
          !Regex.IsMatch(txtEmail.Text, @"^[\w\.-]+@gmail\.com$"))
      {
        MessageBox.Show("Email phải có đuôi @gmail.com và chỉ chứa chữ cái, số.");
        txtEmail.Focus();
        return false;
      }
      return true;
    }

    private bool IsPhoneNumberExists(string phoneNumber)
    {
      using (var context = new QLThuVienContextDB())
      {
        return context.DocGias.Any(dg => dg.SoDienThoai == phoneNumber);
      }
    }

    private bool IsEmailExists(string email)
    {
      using (var context = new QLThuVienContextDB())
      {
        return context.DocGias.Any(dg => dg.Email == email);
      }
    }

    private string GenerateDocGiaCode()
    {
      using (var context = new QLThuVienContextDB())
      {
        var maxMaDocGia = context.DocGias
            .Where(dg => dg.MaDocGia.StartsWith("DG"))
            .Select(dg => dg.MaDocGia)
            .DefaultIfEmpty("DG000")
            .Max();

        int maxId = int.Parse(maxMaDocGia.Substring(2));
        int newId = maxId + 1;

        return $"DG{newId.ToString("D3")}";
      }
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
      if (ValidateInput())
      {
        // Kiểm tra trùng lặp số điện thoại và email
        if (IsPhoneNumberExists(txtSoDienThoai.Text) || IsEmailExists(txtEmail.Text))
        {
          MessageBox.Show("Số điện thoại hoặc email đã tồn tại. Vui lòng nhập lại.");
          return;
        }

        docGiaHienTai = new DocGia
        {
          MaDocGia = GenerateDocGiaCode(),
          TenDocGia = txtTenDocGia.Text,
          SoDienThoai = txtSoDienThoai.Text,
          GioiTinh = rdoNam.Checked ? "Nam" : "Nữ",
          DiaChi = txtDiaChi.Text,
          Email = txtEmail.Text
        };

        try
        {
          using (var context = new QLThuVienContextDB())
          {
            context.DocGias.Add(docGiaHienTai);
            context.SaveChanges();
          }

          MessageBox.Show("Thêm độc giả thành công.");
          LoadData();
          ClearInputFields();
        }
        catch (Exception ex)
        {
          MessageBox.Show("Lỗi khi thêm độc giả: " + ex.InnerException?.Message ?? ex.Message);
        }
      }
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
      if (docGiaHienTai != null)
      {
        if (ValidateInput())
        {
          // Kiểm tra trùng lặp số điện thoại và email
          if (txtSoDienThoai.Text != docGiaHienTai.SoDienThoai && IsPhoneNumberExists(txtSoDienThoai.Text))
          {
            MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng nhập số khác.");
            txtSoDienThoai.Focus();
            return;
          }

          if (txtEmail.Text != docGiaHienTai.Email && IsEmailExists(txtEmail.Text))
          {
            MessageBox.Show("Email đã tồn tại. Vui lòng nhập email khác.");
            txtEmail.Focus();
            return;
          }

          docGiaHienTai.TenDocGia = txtTenDocGia.Text;
          docGiaHienTai.SoDienThoai = txtSoDienThoai.Text;
          docGiaHienTai.GioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
          docGiaHienTai.DiaChi = txtDiaChi.Text;
          docGiaHienTai.Email = txtEmail.Text;

          try
          {
            using (var context = new QLThuVienContextDB())
            {
              context.Entry(docGiaHienTai).State = EntityState.Modified;
              context.SaveChanges();
            }

            MessageBox.Show("Cập nhật thông tin độc giả thành công.");
            LoadData();
            ClearInputFields();
          }
          catch (Exception ex)
          {
            MessageBox.Show("Lỗi khi cập nhật độc giả: " + ex.Message);
          }
        }
      }
      else
      {
        MessageBox.Show("Vui lòng chọn một hàng để sửa.");
      }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
      if (docGiaHienTai != null)
      {
        using (var context = new QLThuVienContextDB())
        {
          if (MessageBox.Show("Bạn có chắc chắn muốn xóa độc giả này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
          {
            try
            {
              if (context.MuonSaches.Any(ms => ms.MaDocGia == docGiaHienTai.MaDocGia))
              {
                MessageBox.Show("Không thể xóa độc giả này vì vẫn còn bản ghi mượn sách liên quan.");
                return;
              }

              var docGiaToDelete = context.DocGias.Find(docGiaHienTai.MaDocGia);
              if (docGiaToDelete != null)
              {
                context.DocGias.Remove(docGiaToDelete);
                context.SaveChanges();
              }

              MessageBox.Show("Xóa độc giả thành công.");
              LoadData();
              ClearInputFields();
              docGiaHienTai = null;
            }
            catch (Exception ex)
            {
              MessageBox.Show("Lỗi khi xóa độc giả: " + ex.Message);
            }
          }
        }
      }
      else
      {
        MessageBox.Show("Vui lòng chọn một hàng để xóa.");
      }
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
      ClearInputFields();
      LoadData();
    }

    private void UpdateTongDocGia()
    {
      lblTongDocGia.Text = $"Tổng độc giả: {danhSachDocGia.Count}";
    }

    private void dgvQuanLyDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0 && e.RowIndex < (filteredList.Count > 0 ? filteredList.Count : danhSachDocGia.Count))
      {
        docGiaHienTai = filteredList.Count > 0 ? filteredList[e.RowIndex] : danhSachDocGia[e.RowIndex];

        if (docGiaHienTai != null)
        {
          txtMaDocGia.Text = docGiaHienTai.MaDocGia;
          txtTenDocGia.Text = docGiaHienTai.TenDocGia;
          txtSoDienThoai.Text = docGiaHienTai.SoDienThoai;
          txtDiaChi.Text = docGiaHienTai.DiaChi;
          rdoNam.Checked = docGiaHienTai.GioiTinh == "Nam";
          rdoNu.Checked = docGiaHienTai.GioiTinh == "Nữ";
          txtEmail.Text = docGiaHienTai.Email;
        }
      }
    }

    private void dgvQuanLyDocGia_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
    {
      if (e.RowIndex % 2 == 0)
      {
        dgvQuanLyDocGia.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
      }
      else
      {
        dgvQuanLyDocGia.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
      }
    }

    private void SetWatermark()
    {
      if (isChangingText) return; // Ngăn chặn việc gọi lại do thay đổi văn bản

      // Kiểm tra và thiết lập watermark
      if (string.IsNullOrEmpty(txtTimKiemTheoTen.Text) || txtTimKiemTheoTen.Text == "Tìm kiếm theo tên")
      {
        isChangingText = true; // Đánh dấu là đang thay đổi văn bản
        txtTimKiemTheoTen.Text = "Tìm kiếm theo tên"; // Thiết lập watermark
        txtTimKiemTheoTen.ForeColor = Color.Gray; // Đặt màu chữ
        txtTimKiemTheoTen.BackColor = Color.LightGray; // Đặt màu nền
        isChangingText = false; // Đánh dấu kết thúc thay đổi
      }
      else
      {
        txtTimKiemTheoTen.ForeColor = Color.Black; // Đặt lại màu chữ
        txtTimKiemTheoTen.BackColor = Color.White; // Đặt lại màu nền
      }
    }

    private void txtTimKiemTheoTen_Leave(object sender, EventArgs e)
    {
      // Kiểm tra và hiển thị watermark nếu TextBox trống
      if (string.IsNullOrEmpty(txtTimKiemTheoTen.Text))
      {
        SetWatermark();
      }
    }

    private void txtTimKiemTheoTen_Click(object sender, EventArgs e)
    {
      if (txtTimKiemTheoTen.Text == "Tìm kiếm theo tên")
      {
        isChangingText = true; // Đánh dấu là đang thay đổi văn bản
        txtTimKiemTheoTen.Text = ""; // Xóa watermark
        txtTimKiemTheoTen.ForeColor = Color.Black; // Đặt lại màu chữ
        txtTimKiemTheoTen.BackColor = Color.White; // Đặt lại màu nền
        isChangingText = false; // Đánh dấu kết thúc thay đổi
      }
    }

    private void txtTimKiemTheoTen_TextChanged(object sender, EventArgs e)
    {
      // Ngăn chặn thay đổi văn bản
      if (isChangingText) return;

      // Nếu người dùng nhập ký tự, không hiển thị watermark
      string searchText = txtTimKiemTheoTen.Text.ToLower().Trim();

      // Cập nhật danh sách độc giả chỉ nếu người dùng không nhập watermark
      if (searchText != "tìm kiếm theo tên")
      {
        filteredList = danhSachDocGia
            .Where(docGia => docGia.TenDocGia.ToLower().Contains(searchText))
            .ToList();

        HienThiDanhSachDocGia(filteredList);
      }
    }

    private void UserControlDocGia_Load(object sender, EventArgs e)
    {
      SetWatermark();
    }
  }
}
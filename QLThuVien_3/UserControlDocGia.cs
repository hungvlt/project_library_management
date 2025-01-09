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
    }

    private void UserControlDocGia_Load(object sender, EventArgs e)
    {
      LoadData(); // Gọi LoadData tại đây

      cmbGioiTinh.Items.Add("Nam");
      cmbGioiTinh.Items.Add("Nữ");
      cmbGioiTinh.Items.Add("Khác");
      cmbGioiTinh.SelectedIndex = -1;

      cmbLocTheoGioiTinh.Items.Clear();
      cmbLocTheoGioiTinh.Items.Add("Tất cả");
      cmbLocTheoGioiTinh.Items.Add("Nam");
      cmbLocTheoGioiTinh.Items.Add("Nữ");
      cmbLocTheoGioiTinh.Items.Add("Khác");
      cmbLocTheoGioiTinh.SelectedIndex = 0;

      SetWatermark();
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

      dgvQuanLyDocGia.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
      dgvQuanLyDocGia.RowTemplate.Height = 35;
    }

    private void LoadData()
    {
      try
      {
        using (var context = new QLThuVienContextDB())
        {
          danhSachDocGia = context.DocGias.ToList();
          if (danhSachDocGia.Count == 0)
          {
            MessageBox.Show("Không có dữ liệu độc giả trong cơ sở dữ liệu.");
          }
        }
        HienThiDanhSachDocGia(danhSachDocGia);
        UpdateTongDocGia(); // Cập nhật tổng số độc giả
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
      UpdateTongDocGia();
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
      cmbGioiTinh.SelectedIndex = -1;
      txtTimKiemTheoTen.Clear();
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

      if (string.IsNullOrWhiteSpace(cmbGioiTinh.SelectedItem?.ToString()))
      {
        MessageBox.Show("Vui lòng chọn giới tính.");
        cmbGioiTinh.Focus();
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
        if (IsPhoneNumberExists(txtSoDienThoai.Text))
        {
          MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng nhập số điện thoại khác.");
          txtSoDienThoai.Focus();
          return;
        }

        if (IsEmailExists(txtEmail.Text))
        {
          MessageBox.Show("Email đã tồn tại. Vui lòng nhập email khác.");
          txtEmail.Focus();
          return;
        }

        docGiaHienTai = new DocGia
        {
          MaDocGia = GenerateDocGiaCode(),
          TenDocGia = txtTenDocGia.Text,
          SoDienThoai = txtSoDienThoai.Text,
          GioiTinh = cmbGioiTinh.SelectedItem.ToString(),
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
      if (docGiaHienTai != null && !string.IsNullOrEmpty(docGiaHienTai.MaDocGia))
      {
        if (ValidateInput())
        {
          if (txtSoDienThoai.Text != docGiaHienTai.SoDienThoai && IsPhoneNumberExists(txtSoDienThoai.Text))
          {
            MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng nhập số điện thoại khác.");
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
          docGiaHienTai.GioiTinh = cmbGioiTinh.SelectedItem.ToString();
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
        MessageBox.Show("Vui lòng chọn một độc giả hợp lệ để sửa.");
      }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
      if (docGiaHienTai != null && !string.IsNullOrEmpty(docGiaHienTai.MaDocGia))
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
        MessageBox.Show("Vui lòng chọn một độc giả hợp lệ để xóa.");
      }
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
      ClearInputFields();
      LoadData();
    }

    private void UpdateTongDocGia()
    {
      lblTongDocGia.Text = danhSachDocGia.Count().ToString();
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
          cmbGioiTinh.SelectedItem = docGiaHienTai.GioiTinh;
          txtEmail.Text = docGiaHienTai.Email;
        }
        else
        {
          ClearInputFields();
        }
      }
      else
      {
        ClearInputFields();
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
      if (isChangingText) return;

      if (string.IsNullOrEmpty(txtTimKiemTheoTen.Text) || txtTimKiemTheoTen.Text == "Tìm kiếm theo mã hoặc tên")
      {
        isChangingText = true;
        txtTimKiemTheoTen.Text = "Tìm kiếm theo mã hoặc tên";
        txtTimKiemTheoTen.ForeColor = Color.Gray;
        txtTimKiemTheoTen.BackColor = Color.LightGray;
        isChangingText = false;
      }
      else
      {
        txtTimKiemTheoTen.ForeColor = Color.Black;
        txtTimKiemTheoTen.BackColor = Color.White;
      }
    }

    private void txtTimKiemTheoTen_Leave(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtTimKiemTheoTen.Text))
      {
        SetWatermark();
      }
    }

    private void txtTimKiemTheoTen_Click(object sender, EventArgs e)
    {
      if (txtTimKiemTheoTen.Text == "Tìm kiếm theo mã hoặc tên")
      {
        isChangingText = true;
        txtTimKiemTheoTen.Text = "";
        txtTimKiemTheoTen.ForeColor = Color.Black;
        txtTimKiemTheoTen.BackColor = Color.White;
        isChangingText = false;
      }
    }

    private void txtTimKiemTheoTen_TextChanged(object sender, EventArgs e)
    {
      if (isChangingText) return;
      string searchText = txtTimKiemTheoTen.Text.ToLower().Trim();

      if (searchText != "tìm kiếm theo mã hoặc tên")
      {
        filteredList = danhSachDocGia
            .Where(docGia => docGia.TenDocGia.ToLower().Contains(searchText) ||
                             docGia.MaDocGia.ToLower().Contains(searchText))
            .ToList();

        HienThiDanhSachDocGia(filteredList);
        lblTongDocGia.Text = filteredList.Count().ToString();
      }
    }

    private void cmbLocTheoGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
    {
      string selectedGender = cmbLocTheoGioiTinh.SelectedItem?.ToString();

      if (selectedGender == "Tất cả" || string.IsNullOrEmpty(selectedGender))
      {
        HienThiDanhSachDocGia(danhSachDocGia);
      }
      else
      {
        filteredList = danhSachDocGia
            .Where(docGia => docGia.GioiTinh == selectedGender)
            .ToList();

        HienThiDanhSachDocGia(filteredList);
        lblTongDocGia.Text = filteredList.Count().ToString();
      }
    }
  }
}
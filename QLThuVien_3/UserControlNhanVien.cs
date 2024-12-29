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
  public partial class UserControlNhanVien : UserControl
  {
    private List<NhanVien> danhSachNhanVien = new List<NhanVien>();
    private List<NhanVien> filteredList = new List<NhanVien>(); // Danh sách nhân viên đã lọc
    private NhanVien nhanVienHienTai = null;
    private bool isChangingText = false;

    public UserControlNhanVien()
    {
      InitializeComponent();
      InitializeDataGridView();
      LoadData();
      LoadQuyenOptions();
      txtMaNhanVien.ReadOnly = true; // Đặt mã nhân viên là ReadOnly
    }

    private void InitializeDataGridView()
    {
      dgvQuanLyNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

      dgvQuanLyNhanVien.Columns.Add("MaNhanVien", "Mã nhân viên");
      dgvQuanLyNhanVien.Columns.Add("TenNhanVien", "Tên nhân viên");
      dgvQuanLyNhanVien.Columns.Add("SoDienThoai", "Số điện thoại");
      dgvQuanLyNhanVien.Columns.Add("DiaChi", "Địa chỉ");
      dgvQuanLyNhanVien.Columns.Add("Email", "Email");
      dgvQuanLyNhanVien.Columns.Add("NgaySinh", "Ngày sinh");
      dgvQuanLyNhanVien.Columns.Add("GioiTinh", "Giới tính");
      dgvQuanLyNhanVien.Columns.Add("Quyen", "Quyền");

      foreach (DataGridViewColumn column in dgvQuanLyNhanVien.Columns)
      {
        column.HeaderCell.Style.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
      }

      dgvQuanLyNhanVien.RowTemplate.Height = 35;
    }

    private void LoadData()
    {
      try
      {
        using (var context = new QLThuVienContextDB())
        {
          danhSachNhanVien = context.NhanViens.ToList();
        }
        HienThiDanhSachNhanVien(danhSachNhanVien);
        UpdateTotalEmployees();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
      }
    }

    private void HienThiDanhSachNhanVien(List<NhanVien> list)
    {
      dgvQuanLyNhanVien.Rows.Clear();
      foreach (var nhanVien in list)
      {
        AddEmployeeToGrid(nhanVien);
      }
    }

    private void AddEmployeeToGrid(NhanVien nhanVien)
    {
      int rowIndex = dgvQuanLyNhanVien.Rows.Add();
      DataGridViewRow row = dgvQuanLyNhanVien.Rows[rowIndex];

      row.Cells["MaNhanVien"].Value = nhanVien.MaNhanVien;
      row.Cells["TenNhanVien"].Value = nhanVien.TenNhanVien;
      row.Cells["SoDienThoai"].Value = nhanVien.SoDienThoai;
      row.Cells["DiaChi"].Value = nhanVien.DiaChi;
      row.Cells["Email"].Value = nhanVien.Email;
      row.Cells["NgaySinh"].Value = nhanVien.NgaySinh.ToShortDateString();
      row.Cells["GioiTinh"].Value = nhanVien.GioiTinh;
      row.Cells["Quyen"].Value = nhanVien.Quyen;
    }

    private void LoadQuyenOptions()
    {
      cmbQuyen.Items.Clear();
      cmbQuyen.Items.Add("Admin");
      cmbQuyen.Items.Add("ThuThu");
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
        filteredList = danhSachNhanVien
            .Where(docGia => docGia.TenNhanVien.ToLower().Contains(searchText))
            .ToList();

        HienThiDanhSachNhanVien(filteredList);
      }
    }

    private bool ValidateInput(bool isAdding)
    {
      if (string.IsNullOrWhiteSpace(txtTenNhanVien.Text) || !Regex.IsMatch(txtTenNhanVien.Text, @"^[\p{L}\d\s]+$"))
      {
        MessageBox.Show("Tên nhân viên chỉ chứa chữ cái tiếng Việt và chữ số với khoảng trắng.");
        return false;
      }

      if (isAdding && (string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ||
          !txtSoDienThoai.Text.StartsWith("0") ||
          txtSoDienThoai.Text.Length != 10 ||
          danhSachNhanVien.Any(nv => nv.SoDienThoai == txtSoDienThoai.Text)))
      {
        MessageBox.Show("Số điện thoại phải bắt đầu bằng '0', dài 10 ký tự và không được trùng với số đã có.");
        return false;
      }

      if (string.IsNullOrWhiteSpace(txtDiaChi.Text) || !Regex.IsMatch(txtDiaChi.Text, @"^[\p{L}\d\s,\.]+$"))
      {
        MessageBox.Show("Địa chỉ chỉ chứa chữ cái tiếng Việt, dấu phẩy, chấm, số và khoảng trắng.");
        return false;
      }

      if (isAdding && (string.IsNullOrWhiteSpace(txtEmail.Text) ||
          !txtEmail.Text.EndsWith("@gmail.com") ||
          danhSachNhanVien.Any(nv => nv.Email == txtEmail.Text)))
      {
        MessageBox.Show("Email phải kết thúc bằng '@gmail.com' và không được trùng với email đã có.");
        return false;
      }

      if (dtpNgaySinh.Value >= DateTime.Now || (DateTime.Now.Year - dtpNgaySinh.Value.Year < 18))
      {
        MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại và nhân viên phải đủ 18 tuổi.");
        return false;
      }

      return true;
    }

    private void ClearInputFields()
    {
      txtMaNhanVien.Clear(); // Không cần xóa vì mã nhân viên tự động sinh
      txtTenNhanVien.Clear();
      txtSoDienThoai.Clear();
      txtDiaChi.Clear();
      txtEmail.Clear();
      dtpNgaySinh.Value = DateTime.Now;
      rdoNam.Checked = false;
      rdoNu.Checked = false;
      cmbQuyen.SelectedIndex = -1; // Đặt lại ComboBox
      txtTenDangNhap.Clear();
      txtMatKhau.Clear();
      txtTenNhanVien.Focus();
    }

    private string GenerateMaNhanVien()
    {
      using (var context = new QLThuVienContextDB())
      {
        // Tìm mã lớn nhất hiện tại
        var maxMa = context.NhanViens
            .Where(nv => nv.MaNhanVien.StartsWith("NV"))
            .Select(nv => nv.MaNhanVien)
            .DefaultIfEmpty("NV000")
            .Max();

        int maxId = int.Parse(maxMa.Substring(2));
        int newId = maxId + 1;

        return $"NV{newId:D3}"; // Định dạng NVxxx
      }
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
      if (ValidateInput(true)) // true cho thêm mới
      {
        var nhanVien = new NhanVien
        {
          MaNhanVien = GenerateMaNhanVien(), // Sinh mã nhân viên mới
          TenNhanVien = txtTenNhanVien.Text,
          SoDienThoai = txtSoDienThoai.Text,
          DiaChi = txtDiaChi.Text,
          Email = txtEmail.Text,
          NgaySinh = dtpNgaySinh.Value,
          Quyen = cmbQuyen.SelectedItem?.ToString(), // Lấy quyền từ ComboBox
          TenDangNhap = txtTenDangNhap.Text,
          MatKhau = txtMatKhau.Text,
          GioiTinh = rdoNam.Checked ? "Nam" : "Nữ"
        };

        try
        {
          using (var context = new QLThuVienContextDB())
          {
            context.NhanViens.Add(nhanVien);
            context.SaveChanges();
          }
          danhSachNhanVien.Add(nhanVien);
          HienThiDanhSachNhanVien(danhSachNhanVien);
          ClearInputFields();
          UpdateTotalEmployees();
        }
        catch (Exception ex)
        {
          MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message);
        }
      }
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
      if (nhanVienHienTai != null && ValidateInput(false)) // false cho sửa thông tin
      {
        nhanVienHienTai.TenNhanVien = txtTenNhanVien.Text;

        if (txtSoDienThoai.Text != nhanVienHienTai.SoDienThoai)
        {
          if (danhSachNhanVien.Any(nv => nv.SoDienThoai == txtSoDienThoai.Text))
          {
            MessageBox.Show("Số điện thoại đã tồn tại trong cơ sở dữ liệu.");
            return;
          }
          nhanVienHienTai.SoDienThoai = txtSoDienThoai.Text;
        }

        if (txtEmail.Text != nhanVienHienTai.Email)
        {
          if (danhSachNhanVien.Any(nv => nv.Email == txtEmail.Text))
          {
            MessageBox.Show("Email đã tồn tại trong cơ sở dữ liệu.");
            return;
          }
          nhanVienHienTai.Email = txtEmail.Text;
        }

        nhanVienHienTai.DiaChi = txtDiaChi.Text;
        nhanVienHienTai.NgaySinh = dtpNgaySinh.Value;
        nhanVienHienTai.Quyen = cmbQuyen.SelectedItem?.ToString();
        nhanVienHienTai.TenDangNhap = txtTenDangNhap.Text;
        nhanVienHienTai.MatKhau = txtMatKhau.Text;
        nhanVienHienTai.GioiTinh = rdoNam.Checked ? "Nam" : "Nữ";

        try
        {
          using (var context = new QLThuVienContextDB())
          {
            context.Entry(nhanVienHienTai).State = EntityState.Modified;
            context.SaveChanges();
          }
          HienThiDanhSachNhanVien(danhSachNhanVien);
          ClearInputFields();
          UpdateTotalEmployees();
        }
        catch (Exception ex)
        {
          MessageBox.Show("Lỗi khi sửa nhân viên: " + ex.Message);
        }
      }
      else
      {
        MessageBox.Show("Vui lòng chọn nhân viên để sửa.");
      }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
      if (nhanVienHienTai != null)
      {
        var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
        if (confirmResult == DialogResult.Yes)
        {
          try
          {
            using (var context = new QLThuVienContextDB())
            {
              var nhanVienToDelete = context.NhanViens
                  .Include(nv => nv.MuonSaches) // Giả sử có bảng mượn sách liên kết
                  .FirstOrDefault(nv => nv.MaNhanVien == nhanVienHienTai.MaNhanVien);

              if (nhanVienToDelete != null)
              {
                // Kiểm tra xem có bản ghi nào còn liên kết không
                if (nhanVienToDelete.MuonSaches.Any())
                {
                  MessageBox.Show("Không thể xóa nhân viên này vì còn bản ghi liên kết trong bảng mượn sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  return;
                }

                // Xóa nhân viên nếu không còn liên kết
                context.NhanViens.Remove(nhanVienToDelete);
                context.SaveChanges();
              }
              else
              {
                MessageBox.Show("Nhân viên không tồn tại trong cơ sở dữ liệu.");
              }
            }

            danhSachNhanVien.Remove(nhanVienHienTai);
            HienThiDanhSachNhanVien(danhSachNhanVien);
            ClearInputFields();
            nhanVienHienTai = null;
            UpdateTotalEmployees();
          }
          catch (Exception ex)
          {
            MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message);
          }
        }
      }
      else
      {
        MessageBox.Show("Vui lòng chọn nhân viên để xóa.");
      }
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
      ClearInputFields();
      LoadData();
    }

    private void UpdateTotalEmployees()
    {
      lblTongNhanVien.Text = $"Tổng nhân viên: {danhSachNhanVien.Count}";
    }

    private void dgvQuanLyNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0 && e.RowIndex < (filteredList.Count > 0 ? filteredList.Count : danhSachNhanVien.Count))
      {
        nhanVienHienTai = filteredList.Count > 0 ? filteredList[e.RowIndex] : danhSachNhanVien[e.RowIndex];

        if (nhanVienHienTai != null)
        {
          txtMaNhanVien.Text = nhanVienHienTai.MaNhanVien; // Mã nhân viên được tự động sinh
          txtTenNhanVien.Text = nhanVienHienTai.TenNhanVien;
          txtSoDienThoai.Text = nhanVienHienTai.SoDienThoai;
          txtDiaChi.Text = nhanVienHienTai.DiaChi;
          txtEmail.Text = nhanVienHienTai.Email;
          dtpNgaySinh.Value = nhanVienHienTai.NgaySinh;
          rdoNam.Checked = nhanVienHienTai.GioiTinh == "Nam";
          rdoNu.Checked = nhanVienHienTai.GioiTinh == "Nữ";
          cmbQuyen.SelectedItem = nhanVienHienTai.Quyen;
          txtTenDangNhap.Text = nhanVienHienTai.TenDangNhap;
          txtMatKhau.Text = nhanVienHienTai.MatKhau;
        }
      }
    }

    private void dgvQuanLyNhanVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
    {
      if (e.RowIndex % 2 == 0)
      {
        dgvQuanLyNhanVien.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
      }
      else
      {
        dgvQuanLyNhanVien.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
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

    private void UserControlNhanVien_Load(object sender, EventArgs e)
    {
      SetWatermark();
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
  }
}
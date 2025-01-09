using QLThuVien_3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLThuVien_3
{
  public partial class UserControlNhanVien : UserControl
  {
    private List<NhanVien> danhSachNhanVien = new List<NhanVien>();
    private List<NhanVien> filteredList = new List<NhanVien>();
    private NhanVien nhanVienHienTai = null;
    private bool isChangingText = false;

    public UserControlNhanVien()
    {
      InitializeComponent();
      InitializeDataGridView();
      LoadData();
      LoadQuyenOptions();
      txtMaNhanVien.ReadOnly = true;
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

      dgvQuanLyNhanVien.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
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

      cmbGioiTinh.Items.Clear();
      cmbGioiTinh.Items.Add("Nam");
      cmbGioiTinh.Items.Add("Nữ");
      cmbGioiTinh.Items.Add("Khác");
      cmbGioiTinh.SelectedIndex = -1;
    }

    private void txtTimKiemTheoTen_TextChanged(object sender, EventArgs e)
    {
      if (isChangingText) return;

      string searchText = txtTimKiemTheoTen.Text.ToLower().Trim();

      if (!string.IsNullOrEmpty(searchText) && searchText != "tìm kiếm theo mã/tên")
      {
        filteredList = danhSachNhanVien
            .Where(nv => nv.TenNhanVien.ToLower().Contains(searchText) || nv.MaNhanVien.ToLower().Contains(searchText))
            .ToList();
      }
      else
      {
        filteredList = danhSachNhanVien;
      }

      HienThiDanhSachNhanVien(filteredList);
    }

    private bool ValidateInput(bool isAdding)
    {
      if (string.IsNullOrWhiteSpace(txtTenNhanVien.Text) || !Regex.IsMatch(txtTenNhanVien.Text, @"^[\p{L}\d\s]+$"))
      {
        MessageBox.Show("Tên nhân viên chỉ chứa chữ cái tiếng Việt và chữ số với khoảng trắng.");
        txtTenNhanVien.Focus();
        return false;
      }

      if (isAdding && (string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ||
          !txtSoDienThoai.Text.StartsWith("0") ||
          txtSoDienThoai.Text.Length != 10 ||
          danhSachNhanVien.Any(nv => nv.SoDienThoai == txtSoDienThoai.Text)))
      {
        MessageBox.Show("Số điện thoại phải bắt đầu bằng '0', dài 10 ký tự và không được trùng với số đã có.");
        txtSoDienThoai.Focus();
        return false;
      }

      if (string.IsNullOrWhiteSpace(cmbGioiTinh.SelectedItem?.ToString()))
      {
        MessageBox.Show("Vui lòng chọn giới tính.");
        cmbGioiTinh.Focus();
        return false;
      }

      if (string.IsNullOrWhiteSpace(txtDiaChi.Text) || !Regex.IsMatch(txtDiaChi.Text, @"^[\p{L}\d\s,\.]+$"))
      {
        MessageBox.Show("Địa chỉ chỉ chứa chữ cái tiếng Việt, dấu phẩy, chấm, số và khoảng trắng.");
        txtDiaChi.Focus();
        return false;
      }

      if (isAdding && (string.IsNullOrWhiteSpace(txtEmail.Text) ||
          !txtEmail.Text.EndsWith("@gmail.com") ||
          danhSachNhanVien.Any(nv => nv.Email == txtEmail.Text)))
      {
        MessageBox.Show("Email phải kết thúc bằng '@gmail.com' và không được trùng với email đã có.");
        txtEmail.Focus();
        return false;
      }

      if (dtpNgaySinh.Value >= DateTime.Now || (DateTime.Now.Year - dtpNgaySinh.Value.Year < 18))
      {
        MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại và nhân viên phải đủ 18 tuổi.");
        dtpNgaySinh.Focus();
        return false;
      }

      if (string.IsNullOrWhiteSpace(cmbQuyen.SelectedItem?.ToString()))
      {
        MessageBox.Show("Vui lòng chọn quyền.");
        cmbQuyen.Focus();
        return false;
      }

      if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
      {
        MessageBox.Show("Tên đăng nhập không được để trống.");
        txtTenDangNhap.Focus();
        return false;
      }

      if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
      {
        MessageBox.Show("Mật khẩu không được để trống.");
        txtMatKhau.Focus();
        return false;
      }

      return true;
    }

    private void ClearInputFields()
    {
      txtMaNhanVien.Clear();
      txtTenNhanVien.Clear();
      txtSoDienThoai.Clear();
      txtDiaChi.Clear();
      txtEmail.Clear();
      dtpNgaySinh.Value = DateTime.Now;
      cmbGioiTinh.SelectedIndex = -1;
      cmbQuyen.SelectedIndex = -1;
      txtTenDangNhap.Clear();
      txtMatKhau.Clear();
      txtTimKiemTheoTen.Clear();
      txtTenNhanVien.Focus();
    }

    private string GenerateMaNhanVien()
    {
      using (var context = new QLThuVienContextDB())
      {
        var maxMa = context.NhanViens
            .Where(nv => nv.MaNhanVien.StartsWith("NV"))
            .Select(nv => nv.MaNhanVien)
            .DefaultIfEmpty("NV000")
            .Max();

        int maxId = int.Parse(maxMa.Substring(2));
        int newId = maxId + 1;

        return $"NV{newId:D3}";
      }
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
      if (ValidateInput(true))
      {
        var nhanVien = new NhanVien
        {
          MaNhanVien = GenerateMaNhanVien(),
          TenNhanVien = txtTenNhanVien.Text,
          SoDienThoai = txtSoDienThoai.Text,
          DiaChi = txtDiaChi.Text,
          Email = txtEmail.Text,
          NgaySinh = dtpNgaySinh.Value,
          Quyen = cmbQuyen.SelectedItem?.ToString(),
          TenDangNhap = txtTenDangNhap.Text,
          MatKhau = HashPassword(txtMatKhau.Text),
          GioiTinh = cmbGioiTinh.SelectedItem?.ToString()
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
      if (nhanVienHienTai != null && ValidateInput(false))
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
        if (txtMatKhau.Text != nhanVienHienTai.MatKhau)
        {
          nhanVienHienTai.MatKhau = HashPassword(txtMatKhau.Text);
        }
        nhanVienHienTai.GioiTinh = cmbGioiTinh.SelectedItem?.ToString();

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
                  .Include(nv => nv.MuonSaches)
                  .FirstOrDefault(nv => nv.MaNhanVien == nhanVienHienTai.MaNhanVien);

              if (nhanVienToDelete != null)
              {
                if (nhanVienToDelete.MuonSaches.Any())
                {
                  MessageBox.Show("Không thể xóa nhân viên này vì còn bản ghi liên kết trong bảng mượn sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  return;
                }

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
      int totalEmployees = danhSachNhanVien.Count;
      int maleCount = danhSachNhanVien.Count(nv => nv.GioiTinh == "Nam");
      int femaleCount = danhSachNhanVien.Count(nv => nv.GioiTinh == "Nữ");
      int adminCount = danhSachNhanVien.Count(nv => nv.Quyen == "Admin");
      int librarianCount = danhSachNhanVien.Count(nv => nv.Quyen == "ThuThu");

      lblTongNhanVien.Text = $"Tổng: {totalEmployees} | Nam: {maleCount} | Nữ: {femaleCount} | Admin: {adminCount} | Thủ thư: {librarianCount}";
    }

    private void dgvQuanLyNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0 && e.RowIndex < (filteredList.Count > 0 ? filteredList.Count : danhSachNhanVien.Count))
      {
        nhanVienHienTai = filteredList.Count > 0 ? filteredList[e.RowIndex] : danhSachNhanVien[e.RowIndex];

        if (nhanVienHienTai != null)
        {
          txtMaNhanVien.Text = nhanVienHienTai.MaNhanVien;
          txtTenNhanVien.Text = nhanVienHienTai.TenNhanVien;
          txtSoDienThoai.Text = nhanVienHienTai.SoDienThoai;
          txtDiaChi.Text = nhanVienHienTai.DiaChi;
          txtEmail.Text = nhanVienHienTai.Email;
          dtpNgaySinh.Value = nhanVienHienTai.NgaySinh;
          cmbGioiTinh.SelectedItem = nhanVienHienTai.GioiTinh;
          cmbQuyen.SelectedItem = nhanVienHienTai.Quyen;
          txtTenDangNhap.Text = nhanVienHienTai.TenDangNhap;
          txtMatKhau.Text = nhanVienHienTai.MatKhau;
          txtTenDangNhap.ReadOnly = true;
          txtTenDangNhap.Enabled = false;
          txtTenDangNhap.BackColor = SystemColors.Control;
        }
      }
      else
      {
        ClearInputFields();
        nhanVienHienTai = null;
        txtTenDangNhap.ReadOnly = false;
        txtTenDangNhap.Enabled = true;
        txtTimKiemTheoTen.BackColor = Color.FromArgb(240, 240, 240);
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
      if (string.IsNullOrEmpty(txtTimKiemTheoTen.Text)) SetWatermark();
    }

    private void txtTimKiemTheoTen_Click(object sender, EventArgs e)
    {
      if (txtTimKiemTheoTen.Text == "Tìm kiếm theo mã/tên")
      {
        isChangingText = true;
        txtTimKiemTheoTen.Text = "";
        txtTimKiemTheoTen.ForeColor = Color.Black;
        txtTimKiemTheoTen.BackColor = Color.White;
        isChangingText = false;
      }
    }

    private void UserControlNhanVien_Load(object sender, EventArgs e)
    {
      SetWatermark();
    }

    private void SetWatermark()
    {
      if (isChangingText) return;

      if (string.IsNullOrEmpty(txtTimKiemTheoTen.Text) || txtTimKiemTheoTen.Text == "Tìm kiếm theo mã/tên")
      {
        isChangingText = true;
        txtTimKiemTheoTen.Text = "Tìm kiếm theo mã/tên";
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

    private string HashPassword(string password)
    {
      using (SHA256 sha256 = SHA256.Create())
      {
        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        StringBuilder builder = new StringBuilder();
        foreach (byte b in bytes)
        {
          builder.Append(b.ToString("x2"));
        }
        return builder.ToString();
      }
    }
  }
}
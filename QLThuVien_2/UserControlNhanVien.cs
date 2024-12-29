using QLThuVien_2.Models; // Giả sử bạn đã có lớp mô hình NhanVien
using System;
using System.Collections.Generic;
using System.ComponentModel; // Để sử dụng BindingList
using System.Data.Entity; // Đảm bảo bạn đã cài đặt Entity Framework
using System.Linq;
using System.Windows.Forms;

namespace QLThuVien
{
  public partial class UserControlNhanVien : UserControl
  {
    private BindingList<NhanVien> danhSachNhanVien = new BindingList<NhanVien>();
    private NhanVien nhanVienHienTai = null;

    public UserControlNhanVien()
    {
      InitializeComponent();
      LoadData();
    }

    private void LoadData()
    {
      try
      {
        using (var context = new QLThuVienContextDB_1())
        {
          danhSachNhanVien = new BindingList<NhanVien>(context.NhanViens.ToList()); // Tải danh sách nhân viên từ cơ sở dữ liệu
        }
        HienThiDanhSachNhanVien();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
      }
    }

    private void HienThiDanhSachNhanVien()
    {
      dgvQuanLyNhanVien.DataSource = null;
      dgvQuanLyNhanVien.DataSource = danhSachNhanVien; // Cập nhật DataGridView với danh sách
    }

    private bool ValidateInput()
    {
      // Kiểm tra dữ liệu nhập vào
      if (string.IsNullOrWhiteSpace(txtMaNhanVien.Text))
      {
        MessageBox.Show("Mã nhân viên không được để trống.");
        return false;
      }

      if (string.IsNullOrWhiteSpace(txtTenNhanVien.Text))
      {
        MessageBox.Show("Tên nhân viên không được để trống.");
        return false;
      }

      if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
      {
        MessageBox.Show("Số điện thoại không được để trống.");
        return false;
      }

      // Kiểm tra thêm các trường khác nếu cần

      return true; // Nếu tất cả đều hợp lệ
    }

    private void ClearInputFields()
    {
      txtMaNhanVien.Clear();
      txtTenNhanVien.Clear();
      txtSoDienThoai.Clear();
      txtDiaChi.Clear();
      txtEmail.Clear();
      dtpNgaySinh.Value = DateTime.Now; // Hoặc giá trị mặc định khác
      rdoNam.Checked = false; // Reset giớ tính
      rdoNu.Checked = false;   // Reset giớ tính
      cmbQuyen.SelectedIndex = -1; // Đặt chỉ mục chưa chọn
      txtTenDangNhap.Clear();
      txtMatKhau.Clear();
      txtMaNhanVien.Focus();
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
      if (ValidateInput())
      {
        var nhanVien = new NhanVien
        {
          MaNhanVien = txtMaNhanVien.Text,
          TenNhanVien = txtTenNhanVien.Text,
          SoDienThoai = txtSoDienThoai.Text,
          DiaChi = txtDiaChi.Text,
          Email = txtEmail.Text,
          NgaySinh = dtpNgaySinh.Value,
          Quyen = "ThuThu", // Gán quyền mặc định là "ThuThu"
          TenDangNhap = txtTenDangNhap.Text,
          MatKhau = txtMatKhau.Text,
          GioiTinh = rdoNam.Checked ? "Nam" : "Nữ" // Gán giới tính
        };

        // Lưu nhân viên vào cơ sở dữ liệu
        try
        {
          using (var context = new QLThuVienContextDB_1())
          {
            context.NhanViens.Add(nhanVien);
            context.SaveChanges();
          }
          danhSachNhanVien.Add(nhanVien);
          HienThiDanhSachNhanVien();
          ClearInputFields();
        }
        catch (Exception ex)
        {
          MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message);
        }
      }
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
      if (nhanVienHienTai != null && ValidateInput())
      {
        nhanVienHienTai.TenNhanVien = txtTenNhanVien.Text;
        nhanVienHienTai.SoDienThoai = txtSoDienThoai.Text;
        nhanVienHienTai.DiaChi = txtDiaChi.Text;
        nhanVienHienTai.Email = txtEmail.Text;
        nhanVienHienTai.NgaySinh = dtpNgaySinh.Value;
        nhanVienHienTai.Quyen = "ThuThu"; // Giữ nguyên quyền
        nhanVienHienTai.TenDangNhap = txtTenDangNhap.Text;
        nhanVienHienTai.MatKhau = txtMatKhau.Text;
        nhanVienHienTai.GioiTinh = rdoNam.Checked ? "Nam" : "Nữ"; // Cập nhật giới tính

        try
        {
          using (var context = new QLThuVienContextDB_1())
          {
            context.Entry(nhanVienHienTai).State = EntityState.Modified; // Đánh dấu là đã thay đổi
            context.SaveChanges();
          }
          HienThiDanhSachNhanVien(); // Cập nhật danh sách
          ClearInputFields();
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
        var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?",
                                             "Xác nhận xóa",
                                             MessageBoxButtons.YesNo);
        if (confirmResult == DialogResult.Yes)
        {
          try
          {
            using (var context = new QLThuVienContextDB_1())
            {
              context.NhanViens.Remove(nhanVienHienTai);
              context.SaveChanges();
            }
            danhSachNhanVien.Remove(nhanVienHienTai); // Xóa khỏi danh sách
            HienThiDanhSachNhanVien(); // Cập nhật danh sách
            ClearInputFields();
            nhanVienHienTai = null; // Reset nhân viên hiện tại
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
      LoadData(); // Tải lại danh sách nhân viên
    }

    private void txtTimKiemTheoTen_TextChanged(object sender, EventArgs e)
    {
      string searchText = txtTimKiemTheoTen.Text.ToLower();
      var filteredList = danhSachNhanVien
          .Where(nv => nv.TenNhanVien.ToLower().Contains(searchText))
          .ToList();

      dgvQuanLyNhanVien.DataSource = null;
      dgvQuanLyNhanVien.DataSource = filteredList; // Cập nhật danh sách hiển thị
    }

    private void dgvQuanLyNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0 && e.RowIndex < danhSachNhanVien.Count)
      {
        nhanVienHienTai = danhSachNhanVien[e.RowIndex];
        txtMaNhanVien.Text = nhanVienHienTai.MaNhanVien;
        txtTenNhanVien.Text = nhanVienHienTai.TenNhanVien;
        txtSoDienThoai.Text = nhanVienHienTai.SoDienThoai;
        txtDiaChi.Text = nhanVienHienTai.DiaChi;
        txtEmail.Text = nhanVienHienTai.Email;
        dtpNgaySinh.Value = nhanVienHienTai.NgaySinh;

        // Đặt giới tính
        rdoNam.Checked = nhanVienHienTai.GioiTinh == "Nam";
        rdoNu.Checked = nhanVienHienTai.GioiTinh == "Nữ";

        cmbQuyen.SelectedItem = nhanVienHienTai.Quyen; // Nếu cần thiết
        txtTenDangNhap.Text = nhanVienHienTai.TenDangNhap;
        txtMatKhau.Text = nhanVienHienTai.MatKhau;
      }
    }
  }
}
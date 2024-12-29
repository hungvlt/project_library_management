using System;
using System.Linq;
using System.Windows.Forms;
using QLThuVien_3.Models;

namespace QLThuVien_3
{
  public partial class FormDangNhap : Form
  {
    public FormDangNhap()
    {
      InitializeComponent();
      chkShowPassword.CheckedChanged += new EventHandler(chkShowPassword_CheckedChanged);
      txtPassword.UseSystemPasswordChar = true;
      txtPassword.KeyDown += new KeyEventHandler(txtPassword_KeyDown);
      btnLogin.Click += new EventHandler(btnLogin_Click);
    }

    private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
    {
      txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
    }

    private void txtPassword_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        btnLogin.PerformClick();
      }
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
      string username = txtUsername.Text.Trim();
      string password = txtPassword.Text;

      if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
      {
        MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      using (var context = new QLThuVienContextDB())
      {
        // Tìm nhân viên theo tên đăng nhập
        var nhanVien = context.NhanViens.SingleOrDefault(nv => nv.TenDangNhap == username);

        // Kiểm tra thông tin đăng nhập và quyền
        if (nhanVien != null && nhanVien.MatKhau == password)
        {
          // Kiểm tra quyền
          if (nhanVien.Quyen == "Admin" || nhanVien.Quyen == "ThuThu")
          {
            MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();

            FormTrangChu trangChu = new FormTrangChu(nhanVien); // Truyền thông tin nhân viên
            trangChu.ShowDialog();
            this.Close();
          }
          else
          {
            MessageBox.Show("Bạn không có quyền truy cập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
        else
        {
          MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void FormDangNhap_Load(object sender, EventArgs e)
    {
      // Xử lý sự kiện khi form tải nếu cần
    }
  }
}
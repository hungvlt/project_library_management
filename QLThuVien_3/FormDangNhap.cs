using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
        var nhanVien = context.NhanViens.SingleOrDefault(nv => nv.TenDangNhap == username);
        string hashedPassword = HashPassword(password);

        if (nhanVien != null && nhanVien.MatKhau == hashedPassword)
        {
          if (nhanVien.Quyen == "Admin" || nhanVien.Quyen == "ThuThu")
          {
            MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();

            // Truyền nhanVien vào FormTrangChu
            FormTrangChu trangChu = new FormTrangChu(nhanVien);
            trangChu.ShowDialog();
            this.Close();
          }
        }
        else
        {
          MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
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
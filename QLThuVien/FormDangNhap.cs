using System;
using System.Windows.Forms;

namespace QLThuVien
{
  public partial class FormDangNhap : Form
  {
    public FormDangNhap()
    {
      InitializeComponent();
      chkShowPassword.CheckedChanged += new EventHandler(chkShowPassword_CheckedChanged);
      txtPassword.UseSystemPasswordChar = true;
      txtPassword.KeyDown += new KeyEventHandler(txtPassword_KeyDown);
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
    {
      txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
    }

    private void txtPassword_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        btnLogin_Click_1(sender, e);
      }
    }

    private void btnLogin_Click_1(object sender, EventArgs e)
    {
      string username = txtUsername.Text.Trim();
      string password = txtPassword.Text;

      if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
      {
        MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (username == "1" && password == "1")
      {
        MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Hide();

        FormTrangChu trangChu = new FormTrangChu();
        trangChu.ShowDialog();
        this.Close();
      }
      else
      {
        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
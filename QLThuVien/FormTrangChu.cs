using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
  public partial class FormTrangChu : Form
  {
    public FormTrangChu()
    {
      InitializeComponent();
    }

    private void btndanhmucsach_Click(object sender, EventArgs e)
    {
      productPanel.Controls.Clear();
      UserControlDanhMucSach danhMucSach = new UserControlDanhMucSach();
      danhMucSach.Dock = DockStyle.Fill;
      productPanel.Controls.Add(danhMucSach);
    }

    private void btnDocGia_Click(object sender, EventArgs e)
    {
      pictureBox1.Visible = false;
      productPanel.Controls.Clear();
      UserControlDocGia docGia = new UserControlDocGia();
      docGia.Dock = DockStyle.Fill;
      productPanel.Controls.Add(docGia);
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
      FormDangNhap formDangNhap = new FormDangNhap();

      this.Hide();
      formDangNhap.ShowDialog();
      this.Show();
      this.Close();
    }

    private void btnMuonTra_Click(object sender, EventArgs e)
    {
      pictureBox1.Visible = false;
      productPanel.Controls.Clear();
      UserControlMuonTra muonTra = new UserControlMuonTra();
      muonTra.Dock = DockStyle.Fill;
    }

    private void btnBaoCao_Click(object sender, EventArgs e)
    {
      pictureBox1.Visible = false;
      productPanel.Controls.Clear();
      UserControlBaoCaoThongKe baoCao = new UserControlBaoCaoThongKe();
      baoCao.Dock = DockStyle.Fill;
    }

    private void btnNhanVien_Click(object sender, EventArgs e)
    {
      pictureBox1.Visible = false;
      productPanel.Controls.Clear();
      UserControlNhanVien nhanVien = new UserControlNhanVien();
      nhanVien.Dock = DockStyle.Fill;
    }

    private void btnGioiThieu_Click(object sender, EventArgs e)
    {
      pictureBox1.Visible = false;
      productPanel.Controls.Clear();
      UserControlGioiThieu gioiThieu = new UserControlGioiThieu();
      gioiThieu.Dock = DockStyle.Fill;
    }

    private void btnTacGia_Click(object sender, EventArgs e)
    {
      pictureBox1.Visible = false;
      UserControlTacGia userControlTacGia = new UserControlTacGia();

      productPanel.Controls.Clear();
      productPanel.Controls.Add(userControlTacGia);
      userControlTacGia.Dock = DockStyle.Fill;
    }

    private void btnTacGia_MouseEnter(object sender, EventArgs e)
    {
      btnTacGia.BackColor = Color.FromArgb(70, 130, 180);
    }

    private void btnTacGia_MouseLeave(object sender, EventArgs e)
    {
      btnTacGia.BackColor = Color.FromArgb(100, 149, 237);
    }

    private void btnNhanVien_MouseEnter(object sender, EventArgs e)
    {
      btnNhanVien.BackColor = Color.FromArgb(70, 130, 180);
    }

    private void btnNhanVien_MouseLeave(object sender, EventArgs e)
    {
      btnNhanVien.BackColor = Color.FromArgb(100, 149, 237);
    }

    private void btnBaoCao_MouseEnter(object sender, EventArgs e)
    {
      btnBaoCao.BackColor = Color.FromArgb(70, 130, 180);
    }

    private void btnBaoCao_MouseLeave(object sender, EventArgs e)
    {
      btnBaoCao.BackColor = Color.FromArgb(100, 149, 237);
    }

    private void btnMuonTra_MouseEnter(object sender, EventArgs e)
    {
      btnMuonTra.BackColor = Color.FromArgb(70, 130, 180);
    }

    private void btnMuonTra_MouseLeave(object sender, EventArgs e)
    {
      btnMuonTra.BackColor = Color.FromArgb(100, 149, 237);
    }

    private void btnDocGia_MouseEnter(object sender, EventArgs e)
    {
      btnDocGia.BackColor = Color.FromArgb(70, 130, 180);
    }

    private void btnDocGia_MouseLeave(object sender, EventArgs e)
    {
      btnDocGia.BackColor = Color.FromArgb(100, 149, 237);
    }

    private void btndanhmucsach_MouseEnter(object sender, EventArgs e)
    {
      btndanhmucsach.BackColor = Color.FromArgb(70, 130, 180);
    }

    private void btndanhmucsach_MouseLeave(object sender, EventArgs e)
    {
      btndanhmucsach.BackColor = Color.FromArgb(100, 149, 237);
    }

    private void btnGioiThieu_MouseEnter(object sender, EventArgs e)
    {
      btnGioiThieu.BackColor = Color.FromArgb(70, 130, 180);
    }

    private void btnGioiThieu_MouseLeave(object sender, EventArgs e)
    {
      btnGioiThieu.BackColor = Color.FromArgb(100, 149, 237);
    }
  }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using QLThuVien_3.Models;

namespace QLThuVien_3
{
  public partial class FormTrangChu : Form
  {
    private NhanVien _nhanVien;
    private string _vaiTro;

    public FormTrangChu(NhanVien nhanVien)
    {
      InitializeComponent();
      _nhanVien = nhanVien;
      _vaiTro = nhanVien.Quyen;
      lblThongTinTaiKhoan.Text = $"{nhanVien.TenNhanVien} ({nhanVien.MaNhanVien})";
   
      if (nhanVien.Quyen == "ThuThu")
      {
        btnNhanVien.Visible = false;
        btnBaoCaoThongKe.Visible = false;
        btnDangXuat.Location = new System.Drawing.Point(btnDangXuat.Location.X, btnNhanVien.Location.Y);
      }
    }

    private void btnDanhMucSach_Click(object sender, EventArgs e)
    {
      pnlHienThi.Controls.Clear();
      UserControlDanhMucSach userControlDanhMucSach = new UserControlDanhMucSach();
      userControlDanhMucSach.Dock = DockStyle.Fill;
      pnlHienThi.Controls.Add(userControlDanhMucSach);
    }

    private void btnDocGia_Click(object sender, EventArgs e)
    {
      picAnhNen.Visible = false;
      pnlHienThi.Controls.Clear();
      UserControlDocGia userControlDocGia = new UserControlDocGia();
      userControlDocGia.Dock = DockStyle.Fill;
      pnlHienThi.Controls.Add(userControlDocGia);
    }

    private void btnMuonTra_Click(object sender, EventArgs e)
    {
      pnlHienThi.Controls.Clear();
      UserControlMuonTra userControlMuonTra = new UserControlMuonTra(_nhanVien, _vaiTro);
      userControlMuonTra.Dock = DockStyle.Fill;
      pnlHienThi.Controls.Add(userControlMuonTra);
    }

    private void btnBaoCao_Click(object sender, EventArgs e)
    {
      picAnhNen.Visible = false;
      pnlHienThi.Controls.Clear();
      UserControlBaoCaoThongKe userControlBaoCao = new UserControlBaoCaoThongKe();
      userControlBaoCao.Dock = DockStyle.Fill;
      pnlHienThi.Controls.Add(userControlBaoCao);
    }

    private void btnNhanVien_Click(object sender, EventArgs e)
    {
      picAnhNen.Visible = false;
      pnlHienThi.Controls.Clear();
      UserControlNhanVien userControlNhanVien = new UserControlNhanVien();
      userControlNhanVien.Dock = DockStyle.Fill;
      pnlHienThi.Controls.Add(userControlNhanVien);
    }

    private void btnTacGia_Click(object sender, EventArgs e)
    {
      picAnhNen.Visible = false;
      pnlHienThi.Controls.Clear();
      UserControlTacGia userControlTacGia = new UserControlTacGia();
      userControlTacGia.Dock = DockStyle.Fill;
      pnlHienThi.Controls.Add(userControlTacGia);
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
      var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (result == DialogResult.Yes)
      {
        FormDangNhap formDangNhap = new FormDangNhap();
        this.Hide();
        formDangNhap.ShowDialog();
        this.Show();
        this.Close();
      }
    }

    // Sự kiện cho nút TacGia
    private void btnTacGia_MouseEnter(object sender, EventArgs e) => btnTacGia.BackColor = Color.FromArgb(70, 130, 180);
    private void btnTacGia_MouseLeave(object sender, EventArgs e) => btnTacGia.BackColor = Color.FromArgb(100, 149, 237);
    private void btnTacGia_MouseDown(object sender, MouseEventArgs e) => btnTacGia.BackColor = Color.FromArgb(50, 100, 160);
    private void btnTacGia_MouseUp(object sender, MouseEventArgs e) => btnTacGia.BackColor = Color.FromArgb(70, 130, 180);

    // Sự kiện cho nút NhanVien
    private void btnNhanVien_MouseEnter(object sender, EventArgs e) => btnNhanVien.BackColor = Color.FromArgb(70, 130, 180);
    private void btnNhanVien_MouseLeave(object sender, EventArgs e) => btnNhanVien.BackColor = Color.FromArgb(100, 149, 237);
    private void btnNhanVien_MouseDown(object sender, MouseEventArgs e) => btnNhanVien.BackColor = Color.FromArgb(50, 100, 160);
    private void btnNhanVien_MouseUp(object sender, MouseEventArgs e) => btnNhanVien.BackColor = Color.FromArgb(70, 130, 180);

    // Sự kiện cho nút BaoCao
    private void btnBaoCao_MouseEnter(object sender, EventArgs e) => btnBaoCaoThongKe.BackColor = Color.FromArgb(70, 130, 180);
    private void btnBaoCao_MouseLeave(object sender, EventArgs e) => btnBaoCaoThongKe.BackColor = Color.FromArgb(100, 149, 237);
    private void btnBaoCao_MouseDown(object sender, MouseEventArgs e) => btnBaoCaoThongKe.BackColor = Color.FromArgb(50, 100, 160);
    private void btnBaoCao_MouseUp(object sender, MouseEventArgs e) => btnBaoCaoThongKe.BackColor = Color.FromArgb(70, 130, 180);

    // Sự kiện cho nút MuonTra
    private void btnMuonTra_MouseEnter(object sender, EventArgs e) => btnMuonTraSach.BackColor = Color.FromArgb(70, 130, 180);
    private void btnMuonTra_MouseLeave(object sender, EventArgs e) => btnMuonTraSach.BackColor = Color.FromArgb(100, 149, 237);
    private void btnMuonTra_MouseDown(object sender, MouseEventArgs e) => btnMuonTraSach.BackColor = Color.FromArgb(50, 100, 160);
    private void btnMuonTra_MouseUp(object sender, MouseEventArgs e) => btnMuonTraSach.BackColor = Color.FromArgb(70, 130, 180);

    // Sự kiện cho nút DocGia
    private void btnDocGia_MouseEnter(object sender, EventArgs e) => btnDocGia.BackColor = Color.FromArgb(70, 130, 180);
    private void btnDocGia_MouseLeave(object sender, EventArgs e) => btnDocGia.BackColor = Color.FromArgb(100, 149, 237);
    private void btnDocGia_MouseDown(object sender, MouseEventArgs e) => btnDocGia.BackColor = Color.FromArgb(50, 100, 160);
    private void btnDocGia_MouseUp(object sender, MouseEventArgs e) => btnDocGia.BackColor = Color.FromArgb(70, 130, 180);

    // Sự kiện cho nút DanhMucSach
    private void btnDanhMucSach_MouseEnter(object sender, EventArgs e) => btnDanhMucSach.BackColor = Color.FromArgb(70, 130, 180);
    private void btnDanhMucSach_MouseLeave(object sender, EventArgs e) => btnDanhMucSach.BackColor = Color.FromArgb(100, 149, 237);
    private void btnDanhMucSach_MouseDown(object sender, MouseEventArgs e) => btnDanhMucSach.BackColor = Color.FromArgb(50, 100, 160);
    private void btnDanhMucSach_MouseUp(object sender, MouseEventArgs e) => btnDanhMucSach.BackColor = Color.FromArgb(70, 130, 180);

    private void FormTrangChu_Load(object sender, EventArgs e)
    {
    }
  }
}
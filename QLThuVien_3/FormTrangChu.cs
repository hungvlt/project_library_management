using System;
using System.Drawing;
using System.Windows.Forms;
using QLThuVien_3.Models;

namespace QLThuVien_3
{
  public partial class FormTrangChu : Form
  {
    private NhanVien _nhanVien;

    public FormTrangChu(NhanVien nhanVien)
    {
      InitializeComponent();
      _nhanVien = nhanVien;
      if (nhanVien.Quyen == "ThuThu")
      {
        btnNhanVien.Visible = false;
        btnBaoCaoThongKe.Visible = false;
        // Đẩy các nút khác lên vị trí của các nút bị ẩn
        btnGioiThieu.Location = new System.Drawing.Point(btnGioiThieu.Location.X, btnNhanVien.Location.Y);
        btnDangXuat.Location = new System.Drawing.Point(btnDangXuat.Location.X, btnBaoCaoThongKe.Location.Y);
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
      picAnhNen.Visible = false;
      pnlHienThi.Controls.Clear();
      UserControlMuonTra userControlMuonTra = new UserControlMuonTra();
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

    private void btnGioiThieu_Click(object sender, EventArgs e)
    {
      picAnhNen.Visible = false;
      pnlHienThi.Controls.Clear();
      UserControlGioiThieu userControlGioiThieu = new UserControlGioiThieu();
      userControlGioiThieu.Dock = DockStyle.Fill;
      pnlHienThi.Controls.Add(userControlGioiThieu);
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
      FormDangNhap formDangNhap = new FormDangNhap();
      this.Hide();
      formDangNhap.ShowDialog();
      this.Show();
      this.Close();
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

    // Sự kiện cho nút GioiThieu
    private void btnGioiThieu_MouseEnter(object sender, EventArgs e) => btnGioiThieu.BackColor = Color.FromArgb(70, 130, 180);
    private void btnGioiThieu_MouseLeave(object sender, EventArgs e) => btnGioiThieu.BackColor = Color.FromArgb(100, 149, 237);
    private void btnGioiThieu_MouseDown(object sender, MouseEventArgs e) => btnGioiThieu.BackColor = Color.FromArgb(50, 100, 160);
    private void btnGioiThieu_MouseUp(object sender, MouseEventArgs e) => btnGioiThieu.BackColor = Color.FromArgb(70, 130, 180);

    // Sự kiện cho nút DanhMucSach
    private void btnDanhMucSach_MouseEnter(object sender, EventArgs e) => btnDanhMucSach.BackColor = Color.FromArgb(70, 130, 180);
    private void btnDanhMucSach_MouseLeave(object sender, EventArgs e) => btnDanhMucSach.BackColor = Color.FromArgb(100, 149, 237);
    private void btnDanhMucSach_MouseDown(object sender, MouseEventArgs e) => btnDanhMucSach.BackColor = Color.FromArgb(50, 100, 160);
    private void btnDanhMucSach_MouseUp(object sender, MouseEventArgs e) => btnDanhMucSach.BackColor = Color.FromArgb(70, 130, 180);

    private void FormTrangChu_Load(object sender, EventArgs e)
    {
      // Bạn có thể thêm mã khởi tạo ở đây nếu cần
    }
  }
}
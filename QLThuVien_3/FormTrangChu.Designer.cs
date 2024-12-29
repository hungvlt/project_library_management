using System.Drawing;
using System.Windows.Forms;

namespace QLThuVien_3
{
  partial class FormTrangChu
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>

    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChu));
      this.pnlDanhSachButton = new System.Windows.Forms.Panel();
      this.lblChaoMung = new System.Windows.Forms.Label();
      this.btnDangXuat = new System.Windows.Forms.Button();
      this.btnTacGia = new System.Windows.Forms.Button();
      this.btnNhanVien = new System.Windows.Forms.Button();
      this.btnGioiThieu = new System.Windows.Forms.Button();
      this.btnBaoCaoThongKe = new System.Windows.Forms.Button();
      this.btnMuonTraSach = new System.Windows.Forms.Button();
      this.btnDocGia = new System.Windows.Forms.Button();
      this.btnDanhMucSach = new System.Windows.Forms.Button();
      this.pnlHienThi = new System.Windows.Forms.Panel();
      this.picAnhNen = new System.Windows.Forms.PictureBox();
      this.pnlDanhSachButton.SuspendLayout();
      this.pnlHienThi.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picAnhNen)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlDanhSachButton
      // 
      this.pnlDanhSachButton.BackColor = System.Drawing.Color.LightGray;
      this.pnlDanhSachButton.Controls.Add(this.lblChaoMung);
      this.pnlDanhSachButton.Controls.Add(this.btnDangXuat);
      this.pnlDanhSachButton.Controls.Add(this.btnTacGia);
      this.pnlDanhSachButton.Controls.Add(this.btnNhanVien);
      this.pnlDanhSachButton.Controls.Add(this.btnGioiThieu);
      this.pnlDanhSachButton.Controls.Add(this.btnBaoCaoThongKe);
      this.pnlDanhSachButton.Controls.Add(this.btnMuonTraSach);
      this.pnlDanhSachButton.Controls.Add(this.btnDocGia);
      this.pnlDanhSachButton.Controls.Add(this.btnDanhMucSach);
      this.pnlDanhSachButton.Location = new System.Drawing.Point(0, 0);
      this.pnlDanhSachButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.pnlDanhSachButton.Name = "pnlDanhSachButton";
      this.pnlDanhSachButton.Size = new System.Drawing.Size(367, 1217);
      this.pnlDanhSachButton.TabIndex = 0;
      // 
      // lblChaoMung
      // 
      this.lblChaoMung.AutoSize = true;
      this.lblChaoMung.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
      this.lblChaoMung.ForeColor = System.Drawing.Color.DarkBlue;
      this.lblChaoMung.Location = new System.Drawing.Point(6, 22);
      this.lblChaoMung.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.lblChaoMung.Name = "lblChaoMung";
      this.lblChaoMung.Size = new System.Drawing.Size(301, 49);
      this.lblChaoMung.TabIndex = 2;
      this.lblChaoMung.Text = "CHÀO MỪNG,";
      // 
      // btnDangXuat
      // 
      this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
      this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.btnDangXuat.ForeColor = System.Drawing.Color.White;
      this.btnDangXuat.Location = new System.Drawing.Point(0, 1124);
      this.btnDangXuat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.btnDangXuat.Name = "btnDangXuat";
      this.btnDangXuat.Size = new System.Drawing.Size(367, 70);
      this.btnDangXuat.TabIndex = 1;
      this.btnDangXuat.Text = "Đăng xuất";
      this.btnDangXuat.UseVisualStyleBackColor = false;
      this.btnDangXuat.Click += new System.EventHandler(this.btnLogout_Click);
      // 
      // btnTacGia
      // 
      this.btnTacGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
      this.btnTacGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnTacGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.btnTacGia.ForeColor = System.Drawing.Color.White;
      this.btnTacGia.Location = new System.Drawing.Point(0, 262);
      this.btnTacGia.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.btnTacGia.Name = "btnTacGia";
      this.btnTacGia.Size = new System.Drawing.Size(367, 111);
      this.btnTacGia.TabIndex = 1;
      this.btnTacGia.Text = "Tác giả";
      this.btnTacGia.UseVisualStyleBackColor = false;
      this.btnTacGia.Click += new System.EventHandler(this.btnTacGia_Click);
      this.btnTacGia.MouseEnter += new System.EventHandler(this.btnTacGia_MouseEnter);
      this.btnTacGia.MouseLeave += new System.EventHandler(this.btnTacGia_MouseLeave);
      // 
      // btnNhanVien
      // 
      this.btnNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
      this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.btnNhanVien.ForeColor = System.Drawing.Color.White;
      this.btnNhanVien.Location = new System.Drawing.Point(0, 681);
      this.btnNhanVien.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.btnNhanVien.Name = "btnNhanVien";
      this.btnNhanVien.Size = new System.Drawing.Size(367, 111);
      this.btnNhanVien.TabIndex = 1;
      this.btnNhanVien.Text = "Nhân viên";
      this.btnNhanVien.UseVisualStyleBackColor = false;
      this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
      this.btnNhanVien.MouseEnter += new System.EventHandler(this.btnNhanVien_MouseEnter);
      this.btnNhanVien.MouseLeave += new System.EventHandler(this.btnNhanVien_MouseLeave);
      // 
      // btnGioiThieu
      // 
      this.btnGioiThieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
      this.btnGioiThieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnGioiThieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.btnGioiThieu.ForeColor = System.Drawing.Color.White;
      this.btnGioiThieu.Location = new System.Drawing.Point(0, 962);
      this.btnGioiThieu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.btnGioiThieu.Name = "btnGioiThieu";
      this.btnGioiThieu.Size = new System.Drawing.Size(367, 111);
      this.btnGioiThieu.TabIndex = 1;
      this.btnGioiThieu.Text = "Giới thiệu";
      this.btnGioiThieu.UseVisualStyleBackColor = false;
      this.btnGioiThieu.Click += new System.EventHandler(this.btnGioiThieu_Click);
      this.btnGioiThieu.MouseEnter += new System.EventHandler(this.btnGioiThieu_MouseEnter);
      this.btnGioiThieu.MouseLeave += new System.EventHandler(this.btnGioiThieu_MouseLeave);
      // 
      // btnBaoCaoThongKe
      // 
      this.btnBaoCaoThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
      this.btnBaoCaoThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBaoCaoThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.btnBaoCaoThongKe.ForeColor = System.Drawing.Color.White;
      this.btnBaoCaoThongKe.Location = new System.Drawing.Point(0, 820);
      this.btnBaoCaoThongKe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.btnBaoCaoThongKe.Name = "btnBaoCaoThongKe";
      this.btnBaoCaoThongKe.Size = new System.Drawing.Size(367, 111);
      this.btnBaoCaoThongKe.TabIndex = 1;
      this.btnBaoCaoThongKe.Text = "Báo cáo thống kê";
      this.btnBaoCaoThongKe.UseVisualStyleBackColor = false;
      this.btnBaoCaoThongKe.Click += new System.EventHandler(this.btnBaoCao_Click);
      this.btnBaoCaoThongKe.MouseEnter += new System.EventHandler(this.btnBaoCao_MouseEnter);
      this.btnBaoCaoThongKe.MouseLeave += new System.EventHandler(this.btnBaoCao_MouseLeave);
      // 
      // btnMuonTraSach
      // 
      this.btnMuonTraSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
      this.btnMuonTraSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMuonTraSach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.btnMuonTraSach.ForeColor = System.Drawing.Color.White;
      this.btnMuonTraSach.Location = new System.Drawing.Point(0, 543);
      this.btnMuonTraSach.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.btnMuonTraSach.Name = "btnMuonTraSach";
      this.btnMuonTraSach.Size = new System.Drawing.Size(367, 111);
      this.btnMuonTraSach.TabIndex = 1;
      this.btnMuonTraSach.Text = "Mượn trả sách";
      this.btnMuonTraSach.UseVisualStyleBackColor = false;
      this.btnMuonTraSach.Click += new System.EventHandler(this.btnMuonTra_Click);
      this.btnMuonTraSach.MouseEnter += new System.EventHandler(this.btnMuonTra_MouseEnter);
      this.btnMuonTraSach.MouseLeave += new System.EventHandler(this.btnMuonTra_MouseLeave);
      // 
      // btnDocGia
      // 
      this.btnDocGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
      this.btnDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDocGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.btnDocGia.ForeColor = System.Drawing.Color.White;
      this.btnDocGia.Location = new System.Drawing.Point(0, 402);
      this.btnDocGia.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.btnDocGia.Name = "btnDocGia";
      this.btnDocGia.Size = new System.Drawing.Size(367, 111);
      this.btnDocGia.TabIndex = 1;
      this.btnDocGia.Text = "Độc giả";
      this.btnDocGia.UseVisualStyleBackColor = false;
      this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
      this.btnDocGia.MouseEnter += new System.EventHandler(this.btnDocGia_MouseEnter);
      this.btnDocGia.MouseLeave += new System.EventHandler(this.btnDocGia_MouseLeave);
      // 
      // btnDanhMucSach
      // 
      this.btnDanhMucSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
      this.btnDanhMucSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDanhMucSach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.btnDanhMucSach.ForeColor = System.Drawing.Color.White;
      this.btnDanhMucSach.Location = new System.Drawing.Point(0, 122);
      this.btnDanhMucSach.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.btnDanhMucSach.Name = "btnDanhMucSach";
      this.btnDanhMucSach.Size = new System.Drawing.Size(367, 111);
      this.btnDanhMucSach.TabIndex = 1;
      this.btnDanhMucSach.Text = "Danh mục sách";
      this.btnDanhMucSach.UseVisualStyleBackColor = false;
      this.btnDanhMucSach.Click += new System.EventHandler(this.btnDanhMucSach_Click);
      this.btnDanhMucSach.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDanhMucSach_MouseDown);
      this.btnDanhMucSach.MouseEnter += new System.EventHandler(this.btnDanhMucSach_MouseEnter);
      this.btnDanhMucSach.MouseLeave += new System.EventHandler(this.btnDanhMucSach_MouseLeave);
      this.btnDanhMucSach.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDanhMucSach_MouseUp);
      // 
      // pnlHienThi
      // 
      this.pnlHienThi.Controls.Add(this.picAnhNen);
      this.pnlHienThi.Location = new System.Drawing.Point(361, 0);
      this.pnlHienThi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.pnlHienThi.Name = "pnlHienThi";
      this.pnlHienThi.Size = new System.Drawing.Size(2141, 1300);
      this.pnlHienThi.TabIndex = 1;
      // 
      // picAnhNen
      // 
      this.picAnhNen.Dock = System.Windows.Forms.DockStyle.Fill;
      this.picAnhNen.Image = ((System.Drawing.Image)(resources.GetObject("picAnhNen.Image")));
      this.picAnhNen.Location = new System.Drawing.Point(0, 0);
      this.picAnhNen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.picAnhNen.Name = "picAnhNen";
      this.picAnhNen.Size = new System.Drawing.Size(2141, 1300);
      this.picAnhNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picAnhNen.TabIndex = 0;
      this.picAnhNen.TabStop = false;
      // 
      // FormTrangChu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(2504, 1300);
      this.Controls.Add(this.pnlHienThi);
      this.Controls.Add(this.pnlDanhSachButton);
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "FormTrangChu";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FormTrangChu";
      this.Load += new System.EventHandler(this.FormTrangChu_Load);
      this.pnlDanhSachButton.ResumeLayout(false);
      this.pnlDanhSachButton.PerformLayout();
      this.pnlHienThi.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.picAnhNen)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlDanhSachButton;
    private System.Windows.Forms.Label lblChaoMung;
    private System.Windows.Forms.Button btnDangXuat;
    private System.Windows.Forms.Button btnTacGia;
    private System.Windows.Forms.Button btnNhanVien;
    private System.Windows.Forms.Button btnBaoCaoThongKe;
    private System.Windows.Forms.Button btnMuonTraSach;
    private System.Windows.Forms.Button btnDocGia;
    private System.Windows.Forms.Button btnDanhMucSach;
    private System.Windows.Forms.Button btnGioiThieu;
    private System.Windows.Forms.Panel pnlHienThi;
    private System.Windows.Forms.PictureBox picAnhNen;
  }
}
using System.Drawing;
using System.Windows.Forms;

namespace QLThuVien
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.btnLogout = new System.Windows.Forms.Button();
      this.btnTacGia = new System.Windows.Forms.Button();
      this.btnNhanVien = new System.Windows.Forms.Button();
      this.btnGioiThieu = new System.Windows.Forms.Button();
      this.btnBaoCao = new System.Windows.Forms.Button();
      this.btnMuonTra = new System.Windows.Forms.Button();
      this.btnDocGia = new System.Windows.Forms.Button();
      this.btndanhmucsach = new System.Windows.Forms.Button();
      this.productPanel = new System.Windows.Forms.Panel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panel1.SuspendLayout();
      this.productPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.LightGray;
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.btnLogout);
      this.panel1.Controls.Add(this.btnTacGia);
      this.panel1.Controls.Add(this.btnNhanVien);
      this.panel1.Controls.Add(this.btnGioiThieu);
      this.panel1.Controls.Add(this.btnBaoCao);
      this.panel1.Controls.Add(this.btnMuonTra);
      this.panel1.Controls.Add(this.btnDocGia);
      this.panel1.Controls.Add(this.btndanhmucsach);
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(200, 659);
      this.panel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
      this.label1.ForeColor = System.Drawing.Color.DarkBlue;
      this.label1.Location = new System.Drawing.Point(3, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(173, 29);
      this.label1.TabIndex = 2;
      this.label1.Text = "CHÀO MỪNG,";
      // 
      // btnLogout
      // 
      this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
      this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.btnLogout.ForeColor = System.Drawing.Color.White;
      this.btnLogout.Location = new System.Drawing.Point(0, 609);
      this.btnLogout.Name = "btnLogout";
      this.btnLogout.Size = new System.Drawing.Size(200, 38);
      this.btnLogout.TabIndex = 1;
      this.btnLogout.Text = "Đăng xuất";
      this.btnLogout.UseVisualStyleBackColor = false;
      this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
      // 
      // btnTacGia
      // 
      this.btnTacGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
      this.btnTacGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnTacGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.btnTacGia.ForeColor = System.Drawing.Color.White;
      this.btnTacGia.Location = new System.Drawing.Point(0, 142);
      this.btnTacGia.Name = "btnTacGia";
      this.btnTacGia.Size = new System.Drawing.Size(200, 60);
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
      this.btnNhanVien.Location = new System.Drawing.Point(0, 369);
      this.btnNhanVien.Name = "btnNhanVien";
      this.btnNhanVien.Size = new System.Drawing.Size(200, 60);
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
      this.btnGioiThieu.Location = new System.Drawing.Point(0, 521);
      this.btnGioiThieu.Name = "btnGioiThieu";
      this.btnGioiThieu.Size = new System.Drawing.Size(200, 60);
      this.btnGioiThieu.TabIndex = 1;
      this.btnGioiThieu.Text = "Giới thiệu";
      this.btnGioiThieu.UseVisualStyleBackColor = false;
      this.btnGioiThieu.Click += new System.EventHandler(this.btnGioiThieu_Click);
      this.btnGioiThieu.MouseEnter += new System.EventHandler(this.btnGioiThieu_MouseEnter);
      this.btnGioiThieu.MouseLeave += new System.EventHandler(this.btnGioiThieu_MouseLeave);
      // 
      // btnBaoCao
      // 
      this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
      this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.btnBaoCao.ForeColor = System.Drawing.Color.White;
      this.btnBaoCao.Location = new System.Drawing.Point(0, 444);
      this.btnBaoCao.Name = "btnBaoCao";
      this.btnBaoCao.Size = new System.Drawing.Size(200, 60);
      this.btnBaoCao.TabIndex = 1;
      this.btnBaoCao.Text = "Báo cáo thống kê";
      this.btnBaoCao.UseVisualStyleBackColor = false;
      this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
      this.btnBaoCao.MouseEnter += new System.EventHandler(this.btnBaoCao_MouseEnter);
      this.btnBaoCao.MouseLeave += new System.EventHandler(this.btnBaoCao_MouseLeave);
      // 
      // btnMuonTra
      // 
      this.btnMuonTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
      this.btnMuonTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMuonTra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.btnMuonTra.ForeColor = System.Drawing.Color.White;
      this.btnMuonTra.Location = new System.Drawing.Point(0, 294);
      this.btnMuonTra.Name = "btnMuonTra";
      this.btnMuonTra.Size = new System.Drawing.Size(200, 60);
      this.btnMuonTra.TabIndex = 1;
      this.btnMuonTra.Text = "Mượn trả sách";
      this.btnMuonTra.UseVisualStyleBackColor = false;
      this.btnMuonTra.Click += new System.EventHandler(this.btnMuonTra_Click);
      this.btnMuonTra.MouseEnter += new System.EventHandler(this.btnMuonTra_MouseEnter);
      this.btnMuonTra.MouseLeave += new System.EventHandler(this.btnMuonTra_MouseLeave);
      // 
      // btnDocGia
      // 
      this.btnDocGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
      this.btnDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDocGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.btnDocGia.ForeColor = System.Drawing.Color.White;
      this.btnDocGia.Location = new System.Drawing.Point(0, 218);
      this.btnDocGia.Name = "btnDocGia";
      this.btnDocGia.Size = new System.Drawing.Size(200, 60);
      this.btnDocGia.TabIndex = 1;
      this.btnDocGia.Text = "Độc giả";
      this.btnDocGia.UseVisualStyleBackColor = false;
      this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
      this.btnDocGia.MouseEnter += new System.EventHandler(this.btnDocGia_MouseEnter);
      this.btnDocGia.MouseLeave += new System.EventHandler(this.btnDocGia_MouseLeave);
      // 
      // btndanhmucsach
      // 
      this.btndanhmucsach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
      this.btndanhmucsach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btndanhmucsach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.btndanhmucsach.ForeColor = System.Drawing.Color.White;
      this.btndanhmucsach.Location = new System.Drawing.Point(0, 66);
      this.btndanhmucsach.Name = "btndanhmucsach";
      this.btndanhmucsach.Size = new System.Drawing.Size(200, 60);
      this.btndanhmucsach.TabIndex = 1;
      this.btndanhmucsach.Text = "Danh mục sách";
      this.btndanhmucsach.UseVisualStyleBackColor = false;
      this.btndanhmucsach.Click += new System.EventHandler(this.btndanhmucsach_Click);
      this.btndanhmucsach.MouseEnter += new System.EventHandler(this.btndanhmucsach_MouseEnter);
      this.btndanhmucsach.MouseLeave += new System.EventHandler(this.btndanhmucsach_MouseLeave);
      // 
      // productPanel
      // 
      this.productPanel.BackColor = System.Drawing.Color.WhiteSmoke;
      this.productPanel.Controls.Add(this.pictureBox1);
      this.productPanel.Location = new System.Drawing.Point(197, 0);
      this.productPanel.Name = "productPanel";
      this.productPanel.Size = new System.Drawing.Size(1001, 711);
      this.productPanel.TabIndex = 1;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(0, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(1001, 711);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // FormTrangChu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1199, 712);
      this.Controls.Add(this.productPanel);
      this.Controls.Add(this.panel1);
      this.Name = "FormTrangChu";
      this.Text = "FormTrangChu";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.productPanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnLogout;
    private System.Windows.Forms.Button btnTacGia;
    private System.Windows.Forms.Button btnNhanVien;
    private System.Windows.Forms.Button btnBaoCao;
    private System.Windows.Forms.Button btnMuonTra;
    private System.Windows.Forms.Button btnDocGia;
    private System.Windows.Forms.Button btndanhmucsach;
    private System.Windows.Forms.Button btnGioiThieu;
    private System.Windows.Forms.Panel productPanel;
    private PictureBox pictureBox1;
  }
}
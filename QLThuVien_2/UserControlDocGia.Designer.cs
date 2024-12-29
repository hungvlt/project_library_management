using System.Windows.Forms;

namespace QLThuVien
{
  partial class UserControlDocGia
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lblTimKiemDocGia = new System.Windows.Forms.Label();
      this.dgvQuanLyDocGia = new System.Windows.Forms.DataGridView();
      this.btnXoa = new System.Windows.Forms.Button();
      this.btnSua = new System.Windows.Forms.Button();
      this.btnThem = new System.Windows.Forms.Button();
      this.txtMaDocGia = new System.Windows.Forms.TextBox();
      this.txtSoDienThoai = new System.Windows.Forms.TextBox();
      this.txtTenDocGia = new System.Windows.Forms.TextBox();
      this.lblMaDocGia = new System.Windows.Forms.Label();
      this.lblDiaChi = new System.Windows.Forms.Label();
      this.lblGioiTinh = new System.Windows.Forms.Label();
      this.lblSoDienThoai = new System.Windows.Forms.Label();
      this.lblTenDocGia = new System.Windows.Forms.Label();
      this.lblThongTinDocGia = new System.Windows.Forms.Label();
      this.pnlThongTinDocGia = new System.Windows.Forms.Panel();
      this.btnLamMoi = new System.Windows.Forms.Button();
      this.rdoNu = new System.Windows.Forms.RadioButton();
      this.rdoNam = new System.Windows.Forms.RadioButton();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.txtDiaChi = new System.Windows.Forms.TextBox();
      this.lblEmail = new System.Windows.Forms.Label();
      this.lblQuanLyDocGia = new System.Windows.Forms.Label();
      this.pnlTimKiemDocGia = new System.Windows.Forms.Panel();
      this.txtTimKiemTheoTen = new System.Windows.Forms.TextBox();
      this.lblTongDocGia = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyDocGia)).BeginInit();
      this.pnlThongTinDocGia.SuspendLayout();
      this.pnlTimKiemDocGia.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblTimKiemDocGia
      // 
      this.lblTimKiemDocGia.AutoSize = true;
      this.lblTimKiemDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblTimKiemDocGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.lblTimKiemDocGia.Location = new System.Drawing.Point(0, 0);
      this.lblTimKiemDocGia.Margin = new System.Windows.Forms.Padding(2);
      this.lblTimKiemDocGia.Name = "lblTimKiemDocGia";
      this.lblTimKiemDocGia.Size = new System.Drawing.Size(141, 21);
      this.lblTimKiemDocGia.TabIndex = 0;
      this.lblTimKiemDocGia.Text = "Tìm kiếm độc giả";
      this.lblTimKiemDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dgvQuanLyDocGia
      // 
      this.dgvQuanLyDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvQuanLyDocGia.BackgroundColor = System.Drawing.Color.LightGray;
      this.dgvQuanLyDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgvQuanLyDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvQuanLyDocGia.Location = new System.Drawing.Point(317, 71);
      this.dgvQuanLyDocGia.Margin = new System.Windows.Forms.Padding(2);
      this.dgvQuanLyDocGia.Name = "dgvQuanLyDocGia";
      this.dgvQuanLyDocGia.RowHeadersWidth = 51;
      this.dgvQuanLyDocGia.RowTemplate.Height = 24;
      this.dgvQuanLyDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvQuanLyDocGia.Size = new System.Drawing.Size(832, 618);
      this.dgvQuanLyDocGia.TabIndex = 1;
      this.dgvQuanLyDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyDocGia_CellClick);
      // 
      // btnXoa
      // 
      this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
      this.btnXoa.FlatAppearance.BorderSize = 0;
      this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.btnXoa.Location = new System.Drawing.Point(209, 343);
      this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
      this.btnXoa.Name = "btnXoa";
      this.btnXoa.Size = new System.Drawing.Size(74, 28);
      this.btnXoa.TabIndex = 4;
      this.btnXoa.Text = "Xóa";
      this.btnXoa.UseVisualStyleBackColor = false;
      this.btnXoa.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnSua
      // 
      this.btnSua.BackColor = System.Drawing.Color.LightGoldenrodYellow;
      this.btnSua.FlatAppearance.BorderSize = 0;
      this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.btnSua.Location = new System.Drawing.Point(113, 343);
      this.btnSua.Margin = new System.Windows.Forms.Padding(2);
      this.btnSua.Name = "btnSua";
      this.btnSua.Size = new System.Drawing.Size(81, 28);
      this.btnSua.TabIndex = 4;
      this.btnSua.Text = "Sửa";
      this.btnSua.UseVisualStyleBackColor = false;
      this.btnSua.Click += new System.EventHandler(this.btnEdit_Click);
      // 
      // btnThem
      // 
      this.btnThem.BackColor = System.Drawing.Color.LightGreen;
      this.btnThem.FlatAppearance.BorderSize = 0;
      this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.btnThem.Location = new System.Drawing.Point(21, 343);
      this.btnThem.Margin = new System.Windows.Forms.Padding(2);
      this.btnThem.Name = "btnThem";
      this.btnThem.Size = new System.Drawing.Size(77, 28);
      this.btnThem.TabIndex = 3;
      this.btnThem.Text = "Thêm";
      this.btnThem.UseVisualStyleBackColor = false;
      this.btnThem.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // txtMaDocGia
      // 
      this.txtMaDocGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtMaDocGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtMaDocGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMaDocGia.Location = new System.Drawing.Point(112, 34);
      this.txtMaDocGia.Margin = new System.Windows.Forms.Padding(2);
      this.txtMaDocGia.Name = "txtMaDocGia";
      this.txtMaDocGia.Size = new System.Drawing.Size(171, 25);
      this.txtMaDocGia.TabIndex = 2;
      // 
      // txtSoDienThoai
      // 
      this.txtSoDienThoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtSoDienThoai.Location = new System.Drawing.Point(112, 122);
      this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(2);
      this.txtSoDienThoai.Name = "txtSoDienThoai";
      this.txtSoDienThoai.Size = new System.Drawing.Size(171, 25);
      this.txtSoDienThoai.TabIndex = 2;
      // 
      // txtTenDocGia
      // 
      this.txtTenDocGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtTenDocGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtTenDocGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTenDocGia.Location = new System.Drawing.Point(112, 78);
      this.txtTenDocGia.Margin = new System.Windows.Forms.Padding(2);
      this.txtTenDocGia.Name = "txtTenDocGia";
      this.txtTenDocGia.Size = new System.Drawing.Size(171, 25);
      this.txtTenDocGia.TabIndex = 2;
      // 
      // lblMaDocGia
      // 
      this.lblMaDocGia.AutoSize = true;
      this.lblMaDocGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblMaDocGia.Location = new System.Drawing.Point(9, 36);
      this.lblMaDocGia.Margin = new System.Windows.Forms.Padding(2);
      this.lblMaDocGia.Name = "lblMaDocGia";
      this.lblMaDocGia.Size = new System.Drawing.Size(88, 19);
      this.lblMaDocGia.TabIndex = 1;
      this.lblMaDocGia.Text = "Mã độc giả:";
      // 
      // lblDiaChi
      // 
      this.lblDiaChi.AutoSize = true;
      this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblDiaChi.Location = new System.Drawing.Point(9, 205);
      this.lblDiaChi.Margin = new System.Windows.Forms.Padding(2);
      this.lblDiaChi.Name = "lblDiaChi";
      this.lblDiaChi.Size = new System.Drawing.Size(58, 19);
      this.lblDiaChi.TabIndex = 1;
      this.lblDiaChi.Text = "Địa chỉ:";
      // 
      // lblGioiTinh
      // 
      this.lblGioiTinh.AutoSize = true;
      this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblGioiTinh.Location = new System.Drawing.Point(9, 164);
      this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(2);
      this.lblGioiTinh.Name = "lblGioiTinh";
      this.lblGioiTinh.Size = new System.Drawing.Size(69, 19);
      this.lblGioiTinh.TabIndex = 1;
      this.lblGioiTinh.Text = "Giới tính:";
      // 
      // lblSoDienThoai
      // 
      this.lblSoDienThoai.AutoSize = true;
      this.lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblSoDienThoai.Location = new System.Drawing.Point(9, 124);
      this.lblSoDienThoai.Margin = new System.Windows.Forms.Padding(2);
      this.lblSoDienThoai.Name = "lblSoDienThoai";
      this.lblSoDienThoai.Size = new System.Drawing.Size(101, 19);
      this.lblSoDienThoai.TabIndex = 1;
      this.lblSoDienThoai.Text = "Số điện thoại:";
      // 
      // lblTenDocGia
      // 
      this.lblTenDocGia.AutoSize = true;
      this.lblTenDocGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblTenDocGia.Location = new System.Drawing.Point(9, 80);
      this.lblTenDocGia.Margin = new System.Windows.Forms.Padding(2);
      this.lblTenDocGia.Name = "lblTenDocGia";
      this.lblTenDocGia.Size = new System.Drawing.Size(90, 19);
      this.lblTenDocGia.TabIndex = 1;
      this.lblTenDocGia.Text = "Tên độc giả:";
      // 
      // lblThongTinDocGia
      // 
      this.lblThongTinDocGia.AutoSize = true;
      this.lblThongTinDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblThongTinDocGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.lblThongTinDocGia.Location = new System.Drawing.Point(0, 0);
      this.lblThongTinDocGia.Margin = new System.Windows.Forms.Padding(2);
      this.lblThongTinDocGia.Name = "lblThongTinDocGia";
      this.lblThongTinDocGia.Size = new System.Drawing.Size(144, 21);
      this.lblThongTinDocGia.TabIndex = 0;
      this.lblThongTinDocGia.Text = "Thông tin độc giả";
      // 
      // pnlThongTinDocGia
      // 
      this.pnlThongTinDocGia.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.pnlThongTinDocGia.Controls.Add(this.btnLamMoi);
      this.pnlThongTinDocGia.Controls.Add(this.rdoNu);
      this.pnlThongTinDocGia.Controls.Add(this.rdoNam);
      this.pnlThongTinDocGia.Controls.Add(this.btnXoa);
      this.pnlThongTinDocGia.Controls.Add(this.btnSua);
      this.pnlThongTinDocGia.Controls.Add(this.btnThem);
      this.pnlThongTinDocGia.Controls.Add(this.txtMaDocGia);
      this.pnlThongTinDocGia.Controls.Add(this.txtEmail);
      this.pnlThongTinDocGia.Controls.Add(this.txtDiaChi);
      this.pnlThongTinDocGia.Controls.Add(this.txtSoDienThoai);
      this.pnlThongTinDocGia.Controls.Add(this.txtTenDocGia);
      this.pnlThongTinDocGia.Controls.Add(this.lblEmail);
      this.pnlThongTinDocGia.Controls.Add(this.lblMaDocGia);
      this.pnlThongTinDocGia.Controls.Add(this.lblDiaChi);
      this.pnlThongTinDocGia.Controls.Add(this.lblGioiTinh);
      this.pnlThongTinDocGia.Controls.Add(this.lblSoDienThoai);
      this.pnlThongTinDocGia.Controls.Add(this.lblTenDocGia);
      this.pnlThongTinDocGia.Controls.Add(this.lblThongTinDocGia);
      this.pnlThongTinDocGia.Location = new System.Drawing.Point(6, 71);
      this.pnlThongTinDocGia.Margin = new System.Windows.Forms.Padding(2);
      this.pnlThongTinDocGia.Name = "pnlThongTinDocGia";
      this.pnlThongTinDocGia.Size = new System.Drawing.Size(301, 393);
      this.pnlThongTinDocGia.TabIndex = 8;
      // 
      // btnLamMoi
      // 
      this.btnLamMoi.BackColor = System.Drawing.Color.LightBlue;
      this.btnLamMoi.FlatAppearance.BorderSize = 0;
      this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.btnLamMoi.Location = new System.Drawing.Point(201, 290);
      this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
      this.btnLamMoi.Name = "btnLamMoi";
      this.btnLamMoi.Size = new System.Drawing.Size(82, 28);
      this.btnLamMoi.TabIndex = 6;
      this.btnLamMoi.Text = "Làm mới";
      this.btnLamMoi.UseVisualStyleBackColor = false;
      this.btnLamMoi.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // rdoNu
      // 
      this.rdoNu.AutoSize = true;
      this.rdoNu.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.rdoNu.Location = new System.Drawing.Point(181, 161);
      this.rdoNu.Margin = new System.Windows.Forms.Padding(2);
      this.rdoNu.Name = "rdoNu";
      this.rdoNu.Size = new System.Drawing.Size(49, 23);
      this.rdoNu.TabIndex = 5;
      this.rdoNu.TabStop = true;
      this.rdoNu.Text = " Nữ";
      this.rdoNu.UseVisualStyleBackColor = true;
      // 
      // rdoNam
      // 
      this.rdoNam.AutoSize = true;
      this.rdoNam.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.rdoNam.Location = new System.Drawing.Point(112, 161);
      this.rdoNam.Margin = new System.Windows.Forms.Padding(2);
      this.rdoNam.Name = "rdoNam";
      this.rdoNam.Size = new System.Drawing.Size(56, 23);
      this.rdoNam.TabIndex = 5;
      this.rdoNam.TabStop = true;
      this.rdoNam.Text = "Nam";
      this.rdoNam.UseVisualStyleBackColor = true;
      // 
      // txtEmail
      // 
      this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtEmail.Location = new System.Drawing.Point(112, 248);
      this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(171, 25);
      this.txtEmail.TabIndex = 2;
      // 
      // txtDiaChi
      // 
      this.txtDiaChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDiaChi.Location = new System.Drawing.Point(112, 203);
      this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
      this.txtDiaChi.Name = "txtDiaChi";
      this.txtDiaChi.Size = new System.Drawing.Size(171, 25);
      this.txtDiaChi.TabIndex = 2;
      // 
      // lblEmail
      // 
      this.lblEmail.AutoSize = true;
      this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblEmail.Location = new System.Drawing.Point(8, 250);
      this.lblEmail.Margin = new System.Windows.Forms.Padding(2);
      this.lblEmail.Name = "lblEmail";
      this.lblEmail.Size = new System.Drawing.Size(49, 19);
      this.lblEmail.TabIndex = 1;
      this.lblEmail.Text = "Email:";
      // 
      // lblQuanLyDocGia
      // 
      this.lblQuanLyDocGia.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.lblQuanLyDocGia.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
      this.lblQuanLyDocGia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.lblQuanLyDocGia.Location = new System.Drawing.Point(437, 20);
      this.lblQuanLyDocGia.Margin = new System.Windows.Forms.Padding(2);
      this.lblQuanLyDocGia.Name = "lblQuanLyDocGia";
      this.lblQuanLyDocGia.Size = new System.Drawing.Size(600, 32);
      this.lblQuanLyDocGia.TabIndex = 4;
      this.lblQuanLyDocGia.Text = "QUẢN LÝ ĐỘC GIẢ";
      this.lblQuanLyDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pnlTimKiemDocGia
      // 
      this.pnlTimKiemDocGia.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.pnlTimKiemDocGia.Controls.Add(this.lblTimKiemDocGia);
      this.pnlTimKiemDocGia.Controls.Add(this.txtTimKiemTheoTen);
      this.pnlTimKiemDocGia.Location = new System.Drawing.Point(6, 483);
      this.pnlTimKiemDocGia.Margin = new System.Windows.Forms.Padding(2);
      this.pnlTimKiemDocGia.Name = "pnlTimKiemDocGia";
      this.pnlTimKiemDocGia.Size = new System.Drawing.Size(230, 74);
      this.pnlTimKiemDocGia.TabIndex = 0;
      // 
      // txtTimKiemTheoTen
      // 
      this.txtTimKiemTheoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtTimKiemTheoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtTimKiemTheoTen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTimKiemTheoTen.Location = new System.Drawing.Point(0, 30);
      this.txtTimKiemTheoTen.Margin = new System.Windows.Forms.Padding(2);
      this.txtTimKiemTheoTen.Name = "txtTimKiemTheoTen";
      this.txtTimKiemTheoTen.Size = new System.Drawing.Size(188, 25);
      this.txtTimKiemTheoTen.TabIndex = 1;
      this.txtTimKiemTheoTen.TextChanged += new System.EventHandler(this.txtTimKiemTheoTen_TextChanged);
      // 
      // lblTongDocGia
      // 
      this.lblTongDocGia.BackColor = System.Drawing.Color.Lavender;
      this.lblTongDocGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblTongDocGia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTongDocGia.Location = new System.Drawing.Point(178, 663);
      this.lblTongDocGia.Name = "lblTongDocGia";
      this.lblTongDocGia.Size = new System.Drawing.Size(135, 26);
      this.lblTongDocGia.TabIndex = 10;
      this.lblTongDocGia.Text = "Tổng độc giả: ";
      // 
      // UserControlDocGia
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
      this.Controls.Add(this.lblTongDocGia);
      this.Controls.Add(this.pnlTimKiemDocGia);
      this.Controls.Add(this.dgvQuanLyDocGia);
      this.Controls.Add(this.pnlThongTinDocGia);
      this.Controls.Add(this.lblQuanLyDocGia);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "UserControlDocGia";
      this.Size = new System.Drawing.Size(1166, 704);
      ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyDocGia)).EndInit();
      this.pnlThongTinDocGia.ResumeLayout(false);
      this.pnlThongTinDocGia.PerformLayout();
      this.pnlTimKiemDocGia.ResumeLayout(false);
      this.pnlTimKiemDocGia.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    
    private System.Windows.Forms.Label lblTimKiemDocGia;
    private System.Windows.Forms.DataGridView dgvQuanLyDocGia;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.TextBox txtMaDocGia;
    private System.Windows.Forms.TextBox txtSoDienThoai;
    private System.Windows.Forms.TextBox txtTenDocGia;
    private System.Windows.Forms.Label lblMaDocGia;
    private System.Windows.Forms.Label lblDiaChi;
    private System.Windows.Forms.Label lblGioiTinh;
    private System.Windows.Forms.Label lblSoDienThoai;
    private System.Windows.Forms.Label lblTenDocGia;
    private System.Windows.Forms.Label lblThongTinDocGia;
    private System.Windows.Forms.Panel pnlThongTinDocGia;
    private System.Windows.Forms.TextBox txtDiaChi;
    private System.Windows.Forms.Label lblQuanLyDocGia;
    private System.Windows.Forms.Panel pnlTimKiemDocGia;
    private System.Windows.Forms.RadioButton rdoNu;
    private System.Windows.Forms.RadioButton rdoNam;
    private TextBox txtTimKiemTheoTen;
    private Button btnLamMoi;
    private Label lblTongDocGia;
    private TextBox txtEmail;
    private Label lblEmail;
  }
}
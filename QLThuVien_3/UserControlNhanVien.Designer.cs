﻿namespace QLThuVien_3
{
  partial class UserControlNhanVien
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
      this.btnLamMoi = new System.Windows.Forms.Button();
      this.btnXoa = new System.Windows.Forms.Button();
      this.btnSua = new System.Windows.Forms.Button();
      this.btnThem = new System.Windows.Forms.Button();
      this.txtMaNhanVien = new System.Windows.Forms.TextBox();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.txtDiaChi = new System.Windows.Forms.TextBox();
      this.txtSoDienThoai = new System.Windows.Forms.TextBox();
      this.txtTenNhanVien = new System.Windows.Forms.TextBox();
      this.lblEmail = new System.Windows.Forms.Label();
      this.lblMaNhanVien = new System.Windows.Forms.Label();
      this.lblDiaChi = new System.Windows.Forms.Label();
      this.lblGioiTinh = new System.Windows.Forms.Label();
      this.lblSoDienThoai = new System.Windows.Forms.Label();
      this.lblTongNhanVien = new System.Windows.Forms.Label();
      this.pnlTimKiemNhanVien = new System.Windows.Forms.Panel();
      this.lblTimKiemNhanVien = new System.Windows.Forms.Label();
      this.txtTimKiemTheoTen = new System.Windows.Forms.TextBox();
      this.lblQuanLyNhanVien = new System.Windows.Forms.Label();
      this.lblTenNhanVien = new System.Windows.Forms.Label();
      this.lblThongTinNhanVien = new System.Windows.Forms.Label();
      this.dgvQuanLyNhanVien = new System.Windows.Forms.DataGridView();
      this.pnlThongTinNhanVien = new System.Windows.Forms.Panel();
      this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
      this.cmbQuyen = new System.Windows.Forms.ComboBox();
      this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
      this.txtMatKhau = new System.Windows.Forms.TextBox();
      this.txtTenDangNhap = new System.Windows.Forms.TextBox();
      this.lblMatKhau = new System.Windows.Forms.Label();
      this.lblTenDangNhap = new System.Windows.Forms.Label();
      this.lblQuyen = new System.Windows.Forms.Label();
      this.lblNgaySinh = new System.Windows.Forms.Label();
      this.pnlTimKiemNhanVien.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyNhanVien)).BeginInit();
      this.pnlThongTinNhanVien.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnLamMoi
      // 
      this.btnLamMoi.BackColor = System.Drawing.Color.LightBlue;
      this.btnLamMoi.FlatAppearance.BorderSize = 0;
      this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.btnLamMoi.Location = new System.Drawing.Point(202, 432);
      this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
      this.btnLamMoi.Name = "btnLamMoi";
      this.btnLamMoi.Size = new System.Drawing.Size(81, 31);
      this.btnLamMoi.TabIndex = 6;
      this.btnLamMoi.Text = "Nhập lại";
      this.btnLamMoi.UseVisualStyleBackColor = false;
      this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
      // 
      // btnXoa
      // 
      this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
      this.btnXoa.FlatAppearance.BorderSize = 0;
      this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.btnXoa.Location = new System.Drawing.Point(209, 478);
      this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
      this.btnXoa.Name = "btnXoa";
      this.btnXoa.Size = new System.Drawing.Size(74, 31);
      this.btnXoa.TabIndex = 4;
      this.btnXoa.Text = "Xóa";
      this.btnXoa.UseVisualStyleBackColor = false;
      this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
      // 
      // btnSua
      // 
      this.btnSua.BackColor = System.Drawing.Color.LightGoldenrodYellow;
      this.btnSua.FlatAppearance.BorderSize = 0;
      this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.btnSua.Location = new System.Drawing.Point(113, 478);
      this.btnSua.Margin = new System.Windows.Forms.Padding(2);
      this.btnSua.Name = "btnSua";
      this.btnSua.Size = new System.Drawing.Size(81, 31);
      this.btnSua.TabIndex = 4;
      this.btnSua.Text = "Sửa";
      this.btnSua.UseVisualStyleBackColor = false;
      this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
      // 
      // btnThem
      // 
      this.btnThem.BackColor = System.Drawing.Color.LightGreen;
      this.btnThem.FlatAppearance.BorderSize = 0;
      this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.btnThem.Location = new System.Drawing.Point(21, 478);
      this.btnThem.Margin = new System.Windows.Forms.Padding(2);
      this.btnThem.Name = "btnThem";
      this.btnThem.Size = new System.Drawing.Size(77, 31);
      this.btnThem.TabIndex = 3;
      this.btnThem.Text = "Thêm";
      this.btnThem.UseVisualStyleBackColor = false;
      this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
      // 
      // txtMaNhanVien
      // 
      this.txtMaNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtMaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtMaNhanVien.Enabled = false;
      this.txtMaNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMaNhanVien.Location = new System.Drawing.Point(112, 34);
      this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(2);
      this.txtMaNhanVien.Name = "txtMaNhanVien";
      this.txtMaNhanVien.ReadOnly = true;
      this.txtMaNhanVien.Size = new System.Drawing.Size(56, 25);
      this.txtMaNhanVien.TabIndex = 2;
      // 
      // txtEmail
      // 
      this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtEmail.Location = new System.Drawing.Point(112, 248);
      this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(157, 25);
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
      this.txtDiaChi.Size = new System.Drawing.Size(157, 25);
      this.txtDiaChi.TabIndex = 2;
      // 
      // txtSoDienThoai
      // 
      this.txtSoDienThoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtSoDienThoai.Location = new System.Drawing.Point(112, 122);
      this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(2);
      this.txtSoDienThoai.Name = "txtSoDienThoai";
      this.txtSoDienThoai.Size = new System.Drawing.Size(89, 25);
      this.txtSoDienThoai.TabIndex = 2;
      // 
      // txtTenNhanVien
      // 
      this.txtTenNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtTenNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtTenNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTenNhanVien.Location = new System.Drawing.Point(112, 78);
      this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(2);
      this.txtTenNhanVien.Name = "txtTenNhanVien";
      this.txtTenNhanVien.Size = new System.Drawing.Size(157, 25);
      this.txtTenNhanVien.TabIndex = 2;
      // 
      // lblEmail
      // 
      this.lblEmail.AutoSize = true;
      this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblEmail.Location = new System.Drawing.Point(8, 250);
      this.lblEmail.Margin = new System.Windows.Forms.Padding(2);
      this.lblEmail.Name = "lblEmail";
      this.lblEmail.Size = new System.Drawing.Size(51, 19);
      this.lblEmail.TabIndex = 1;
      this.lblEmail.Text = "Email*";
      // 
      // lblMaNhanVien
      // 
      this.lblMaNhanVien.AutoSize = true;
      this.lblMaNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblMaNhanVien.Location = new System.Drawing.Point(9, 36);
      this.lblMaNhanVien.Margin = new System.Windows.Forms.Padding(2);
      this.lblMaNhanVien.Name = "lblMaNhanVien";
      this.lblMaNhanVien.Size = new System.Drawing.Size(104, 19);
      this.lblMaNhanVien.TabIndex = 1;
      this.lblMaNhanVien.Text = "Mã nhân viên*";
      // 
      // lblDiaChi
      // 
      this.lblDiaChi.AutoSize = true;
      this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblDiaChi.Location = new System.Drawing.Point(9, 205);
      this.lblDiaChi.Margin = new System.Windows.Forms.Padding(2);
      this.lblDiaChi.Name = "lblDiaChi";
      this.lblDiaChi.Size = new System.Drawing.Size(60, 19);
      this.lblDiaChi.TabIndex = 1;
      this.lblDiaChi.Text = "Địa chỉ*";
      // 
      // lblGioiTinh
      // 
      this.lblGioiTinh.AutoSize = true;
      this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblGioiTinh.Location = new System.Drawing.Point(9, 164);
      this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(2);
      this.lblGioiTinh.Name = "lblGioiTinh";
      this.lblGioiTinh.Size = new System.Drawing.Size(71, 19);
      this.lblGioiTinh.TabIndex = 1;
      this.lblGioiTinh.Text = "Giới tính*";
      // 
      // lblSoDienThoai
      // 
      this.lblSoDienThoai.AutoSize = true;
      this.lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblSoDienThoai.Location = new System.Drawing.Point(9, 124);
      this.lblSoDienThoai.Margin = new System.Windows.Forms.Padding(2);
      this.lblSoDienThoai.Name = "lblSoDienThoai";
      this.lblSoDienThoai.Size = new System.Drawing.Size(103, 19);
      this.lblSoDienThoai.TabIndex = 1;
      this.lblSoDienThoai.Text = "Số điện thoại*";
      // 
      // lblTongNhanVien
      // 
      this.lblTongNhanVien.BackColor = System.Drawing.Color.Lavender;
      this.lblTongNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblTongNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
      this.lblTongNhanVien.Location = new System.Drawing.Point(3, 665);
      this.lblTongNhanVien.Name = "lblTongNhanVien";
      this.lblTongNhanVien.Size = new System.Drawing.Size(315, 26);
      this.lblTongNhanVien.TabIndex = 15;
      this.lblTongNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pnlTimKiemNhanVien
      // 
      this.pnlTimKiemNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.pnlTimKiemNhanVien.Controls.Add(this.lblTimKiemNhanVien);
      this.pnlTimKiemNhanVien.Controls.Add(this.txtTimKiemTheoTen);
      this.pnlTimKiemNhanVien.Location = new System.Drawing.Point(12, 597);
      this.pnlTimKiemNhanVien.Margin = new System.Windows.Forms.Padding(2);
      this.pnlTimKiemNhanVien.Name = "pnlTimKiemNhanVien";
      this.pnlTimKiemNhanVien.Size = new System.Drawing.Size(201, 59);
      this.pnlTimKiemNhanVien.TabIndex = 11;
      // 
      // lblTimKiemNhanVien
      // 
      this.lblTimKiemNhanVien.AutoSize = true;
      this.lblTimKiemNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblTimKiemNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.lblTimKiemNhanVien.Location = new System.Drawing.Point(0, 0);
      this.lblTimKiemNhanVien.Margin = new System.Windows.Forms.Padding(2);
      this.lblTimKiemNhanVien.Name = "lblTimKiemNhanVien";
      this.lblTimKiemNhanVien.Size = new System.Drawing.Size(161, 21);
      this.lblTimKiemNhanVien.TabIndex = 0;
      this.lblTimKiemNhanVien.Text = "Tìm kiếm nhân viên";
      this.lblTimKiemNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // txtTimKiemTheoTen
      // 
      this.txtTimKiemTheoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtTimKiemTheoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtTimKiemTheoTen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTimKiemTheoTen.Location = new System.Drawing.Point(0, 30);
      this.txtTimKiemTheoTen.Margin = new System.Windows.Forms.Padding(2);
      this.txtTimKiemTheoTen.Name = "txtTimKiemTheoTen";
      this.txtTimKiemTheoTen.Size = new System.Drawing.Size(184, 25);
      this.txtTimKiemTheoTen.TabIndex = 1;
      this.txtTimKiemTheoTen.Click += new System.EventHandler(this.txtTimKiemTheoTen_Click);
      this.txtTimKiemTheoTen.TextChanged += new System.EventHandler(this.txtTimKiemTheoTen_TextChanged);
      this.txtTimKiemTheoTen.Leave += new System.EventHandler(this.txtTimKiemTheoTen_Leave);
      // 
      // lblQuanLyNhanVien
      // 
      this.lblQuanLyNhanVien.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.lblQuanLyNhanVien.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
      this.lblQuanLyNhanVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.lblQuanLyNhanVien.Location = new System.Drawing.Point(443, 22);
      this.lblQuanLyNhanVien.Margin = new System.Windows.Forms.Padding(2);
      this.lblQuanLyNhanVien.Name = "lblQuanLyNhanVien";
      this.lblQuanLyNhanVien.Size = new System.Drawing.Size(600, 32);
      this.lblQuanLyNhanVien.TabIndex = 13;
      this.lblQuanLyNhanVien.Text = "QUẢN LÝ NHÂN VIÊN";
      this.lblQuanLyNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblTenNhanVien
      // 
      this.lblTenNhanVien.AutoSize = true;
      this.lblTenNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblTenNhanVien.Location = new System.Drawing.Point(9, 80);
      this.lblTenNhanVien.Margin = new System.Windows.Forms.Padding(2);
      this.lblTenNhanVien.Name = "lblTenNhanVien";
      this.lblTenNhanVien.Size = new System.Drawing.Size(106, 19);
      this.lblTenNhanVien.TabIndex = 1;
      this.lblTenNhanVien.Text = "Tên nhân viên*";
      // 
      // lblThongTinNhanVien
      // 
      this.lblThongTinNhanVien.AutoSize = true;
      this.lblThongTinNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblThongTinNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.lblThongTinNhanVien.Location = new System.Drawing.Point(0, 0);
      this.lblThongTinNhanVien.Margin = new System.Windows.Forms.Padding(2);
      this.lblThongTinNhanVien.Name = "lblThongTinNhanVien";
      this.lblThongTinNhanVien.Size = new System.Drawing.Size(164, 21);
      this.lblThongTinNhanVien.TabIndex = 0;
      this.lblThongTinNhanVien.Text = "Thông tin nhân viên";
      // 
      // dgvQuanLyNhanVien
      // 
      this.dgvQuanLyNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvQuanLyNhanVien.BackgroundColor = System.Drawing.Color.LightGray;
      this.dgvQuanLyNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgvQuanLyNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvQuanLyNhanVien.Location = new System.Drawing.Point(323, 73);
      this.dgvQuanLyNhanVien.Margin = new System.Windows.Forms.Padding(2);
      this.dgvQuanLyNhanVien.Name = "dgvQuanLyNhanVien";
      this.dgvQuanLyNhanVien.RowHeadersWidth = 51;
      this.dgvQuanLyNhanVien.RowTemplate.Height = 24;
      this.dgvQuanLyNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvQuanLyNhanVien.Size = new System.Drawing.Size(832, 618);
      this.dgvQuanLyNhanVien.TabIndex = 12;
      this.dgvQuanLyNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyNhanVien_CellClick);
      this.dgvQuanLyNhanVien.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvQuanLyNhanVien_RowPrePaint);
      // 
      // pnlThongTinNhanVien
      // 
      this.pnlThongTinNhanVien.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.pnlThongTinNhanVien.Controls.Add(this.cmbGioiTinh);
      this.pnlThongTinNhanVien.Controls.Add(this.cmbQuyen);
      this.pnlThongTinNhanVien.Controls.Add(this.dtpNgaySinh);
      this.pnlThongTinNhanVien.Controls.Add(this.btnLamMoi);
      this.pnlThongTinNhanVien.Controls.Add(this.btnXoa);
      this.pnlThongTinNhanVien.Controls.Add(this.btnSua);
      this.pnlThongTinNhanVien.Controls.Add(this.btnThem);
      this.pnlThongTinNhanVien.Controls.Add(this.txtMaNhanVien);
      this.pnlThongTinNhanVien.Controls.Add(this.txtMatKhau);
      this.pnlThongTinNhanVien.Controls.Add(this.txtTenDangNhap);
      this.pnlThongTinNhanVien.Controls.Add(this.txtEmail);
      this.pnlThongTinNhanVien.Controls.Add(this.txtDiaChi);
      this.pnlThongTinNhanVien.Controls.Add(this.txtSoDienThoai);
      this.pnlThongTinNhanVien.Controls.Add(this.txtTenNhanVien);
      this.pnlThongTinNhanVien.Controls.Add(this.lblMatKhau);
      this.pnlThongTinNhanVien.Controls.Add(this.lblTenDangNhap);
      this.pnlThongTinNhanVien.Controls.Add(this.lblQuyen);
      this.pnlThongTinNhanVien.Controls.Add(this.lblNgaySinh);
      this.pnlThongTinNhanVien.Controls.Add(this.lblEmail);
      this.pnlThongTinNhanVien.Controls.Add(this.lblMaNhanVien);
      this.pnlThongTinNhanVien.Controls.Add(this.lblDiaChi);
      this.pnlThongTinNhanVien.Controls.Add(this.lblGioiTinh);
      this.pnlThongTinNhanVien.Controls.Add(this.lblSoDienThoai);
      this.pnlThongTinNhanVien.Controls.Add(this.lblTenNhanVien);
      this.pnlThongTinNhanVien.Controls.Add(this.lblThongTinNhanVien);
      this.pnlThongTinNhanVien.Location = new System.Drawing.Point(12, 74);
      this.pnlThongTinNhanVien.Margin = new System.Windows.Forms.Padding(2);
      this.pnlThongTinNhanVien.Name = "pnlThongTinNhanVien";
      this.pnlThongTinNhanVien.Size = new System.Drawing.Size(301, 519);
      this.pnlThongTinNhanVien.TabIndex = 14;
      // 
      // cmbGioiTinh
      // 
      this.cmbGioiTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbGioiTinh.FormattingEnabled = true;
      this.cmbGioiTinh.Location = new System.Drawing.Point(112, 161);
      this.cmbGioiTinh.Name = "cmbGioiTinh";
      this.cmbGioiTinh.Size = new System.Drawing.Size(71, 25);
      this.cmbGioiTinh.TabIndex = 9;
      // 
      // cmbQuyen
      // 
      this.cmbQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.cmbQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbQuyen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbQuyen.FormattingEnabled = true;
      this.cmbQuyen.Location = new System.Drawing.Point(112, 333);
      this.cmbQuyen.Name = "cmbQuyen";
      this.cmbQuyen.Size = new System.Drawing.Size(72, 25);
      this.cmbQuyen.TabIndex = 8;
      // 
      // dtpNgaySinh
      // 
      this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpNgaySinh.Location = new System.Drawing.Point(112, 292);
      this.dtpNgaySinh.Name = "dtpNgaySinh";
      this.dtpNgaySinh.Size = new System.Drawing.Size(89, 25);
      this.dtpNgaySinh.TabIndex = 7;
      // 
      // txtMatKhau
      // 
      this.txtMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMatKhau.Location = new System.Drawing.Point(163, 395);
      this.txtMatKhau.Margin = new System.Windows.Forms.Padding(2);
      this.txtMatKhau.Name = "txtMatKhau";
      this.txtMatKhau.Size = new System.Drawing.Size(106, 25);
      this.txtMatKhau.TabIndex = 2;
      // 
      // txtTenDangNhap
      // 
      this.txtTenDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTenDangNhap.Location = new System.Drawing.Point(12, 395);
      this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(2);
      this.txtTenDangNhap.Name = "txtTenDangNhap";
      this.txtTenDangNhap.Size = new System.Drawing.Size(106, 25);
      this.txtTenDangNhap.TabIndex = 2;
      // 
      // lblMatKhau
      // 
      this.lblMatKhau.AutoSize = true;
      this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblMatKhau.Location = new System.Drawing.Point(159, 372);
      this.lblMatKhau.Margin = new System.Windows.Forms.Padding(2);
      this.lblMatKhau.Name = "lblMatKhau";
      this.lblMatKhau.Size = new System.Drawing.Size(77, 19);
      this.lblMatKhau.TabIndex = 1;
      this.lblMatKhau.Text = "Mật khẩu*";
      // 
      // lblTenDangNhap
      // 
      this.lblTenDangNhap.AutoSize = true;
      this.lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblTenDangNhap.Location = new System.Drawing.Point(9, 372);
      this.lblTenDangNhap.Margin = new System.Windows.Forms.Padding(2);
      this.lblTenDangNhap.Name = "lblTenDangNhap";
      this.lblTenDangNhap.Size = new System.Drawing.Size(113, 19);
      this.lblTenDangNhap.TabIndex = 1;
      this.lblTenDangNhap.Text = "Tên đăng nhập*";
      // 
      // lblQuyen
      // 
      this.lblQuyen.AutoSize = true;
      this.lblQuyen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblQuyen.Location = new System.Drawing.Point(9, 335);
      this.lblQuyen.Margin = new System.Windows.Forms.Padding(2);
      this.lblQuyen.Name = "lblQuyen";
      this.lblQuyen.Size = new System.Drawing.Size(58, 19);
      this.lblQuyen.TabIndex = 1;
      this.lblQuyen.Text = "Quyền*";
      // 
      // lblNgaySinh
      // 
      this.lblNgaySinh.AutoSize = true;
      this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblNgaySinh.Location = new System.Drawing.Point(9, 295);
      this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(2);
      this.lblNgaySinh.Name = "lblNgaySinh";
      this.lblNgaySinh.Size = new System.Drawing.Size(81, 19);
      this.lblNgaySinh.TabIndex = 1;
      this.lblNgaySinh.Text = "Ngày sinh*";
      // 
      // UserControlNhanVien
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Lavender;
      this.Controls.Add(this.lblTongNhanVien);
      this.Controls.Add(this.pnlTimKiemNhanVien);
      this.Controls.Add(this.lblQuanLyNhanVien);
      this.Controls.Add(this.dgvQuanLyNhanVien);
      this.Controls.Add(this.pnlThongTinNhanVien);
      this.Name = "UserControlNhanVien";
      this.Size = new System.Drawing.Size(1166, 704);
      this.Load += new System.EventHandler(this.UserControlNhanVien_Load);
      this.pnlTimKiemNhanVien.ResumeLayout(false);
      this.pnlTimKiemNhanVien.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyNhanVien)).EndInit();
      this.pnlThongTinNhanVien.ResumeLayout(false);
      this.pnlThongTinNhanVien.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.TextBox txtMaNhanVien;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.TextBox txtDiaChi;
    private System.Windows.Forms.TextBox txtSoDienThoai;
    private System.Windows.Forms.TextBox txtTenNhanVien;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.Label lblMaNhanVien;
    private System.Windows.Forms.Label lblDiaChi;
    private System.Windows.Forms.Label lblGioiTinh;
    private System.Windows.Forms.Label lblSoDienThoai;
    private System.Windows.Forms.Label lblTongNhanVien;
    private System.Windows.Forms.Panel pnlTimKiemNhanVien;
    private System.Windows.Forms.Label lblTimKiemNhanVien;
    private System.Windows.Forms.TextBox txtTimKiemTheoTen;
    private System.Windows.Forms.Label lblQuanLyNhanVien;
    private System.Windows.Forms.Label lblTenNhanVien;
    private System.Windows.Forms.Label lblThongTinNhanVien;
    private System.Windows.Forms.DataGridView dgvQuanLyNhanVien;
    private System.Windows.Forms.Panel pnlThongTinNhanVien;
    private System.Windows.Forms.ComboBox cmbQuyen;
    private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    private System.Windows.Forms.Label lblQuyen;
    private System.Windows.Forms.Label lblNgaySinh;
    private System.Windows.Forms.Label lblTenDangNhap;
    private System.Windows.Forms.TextBox txtMatKhau;
    private System.Windows.Forms.TextBox txtTenDangNhap;
    private System.Windows.Forms.Label lblMatKhau;
    private System.Windows.Forms.ComboBox cmbGioiTinh;
  }
}

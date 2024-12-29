using System.Windows.Forms;

namespace QLThuVien_3
{
  partial class UserControlTacGia
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
      this.lblTimKiemTacGia = new System.Windows.Forms.Label();
      this.dgvQuanLyTacGia = new System.Windows.Forms.DataGridView();
      this.btnXoa = new System.Windows.Forms.Button();
      this.btnSua = new System.Windows.Forms.Button();
      this.btnThem = new System.Windows.Forms.Button();
      this.txtMaTacGia = new System.Windows.Forms.TextBox();
      this.txtTenTacGia = new System.Windows.Forms.TextBox();
      this.txtQuocTich = new System.Windows.Forms.TextBox();
      this.lblMaTacGia = new System.Windows.Forms.Label();
      this.lblTenTacGia = new System.Windows.Forms.Label();
      this.lblQuocTich = new System.Windows.Forms.Label();
      this.lblDiaChi = new System.Windows.Forms.Label();
      this.lblThongTinTacGia = new System.Windows.Forms.Label();
      this.pnlThongTinTacGia = new System.Windows.Forms.Panel();
      this.btnLamMoi = new System.Windows.Forms.Button();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.txtSoDienThoai = new System.Windows.Forms.TextBox();
      this.txtDiaChi = new System.Windows.Forms.TextBox();
      this.lblGioiTinh = new System.Windows.Forms.Label();
      this.lblEmail = new System.Windows.Forms.Label();
      this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
      this.lblSoDienThoai = new System.Windows.Forms.Label();
      this.lblNgaySinh = new System.Windows.Forms.Label();
      this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
      this.lblQuanLyTacGia = new System.Windows.Forms.Label();
      this.pnlTimKiemTacGia = new System.Windows.Forms.Panel();
      this.txtTimKiemTheoTen = new System.Windows.Forms.TextBox();
      this.lblTongTacGia = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyTacGia)).BeginInit();
      this.pnlThongTinTacGia.SuspendLayout();
      this.pnlTimKiemTacGia.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblTimKiemTacGia
      // 
      this.lblTimKiemTacGia.AutoSize = true;
      this.lblTimKiemTacGia.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblTimKiemTacGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.lblTimKiemTacGia.Location = new System.Drawing.Point(0, 0);
      this.lblTimKiemTacGia.Margin = new System.Windows.Forms.Padding(4);
      this.lblTimKiemTacGia.Name = "lblTimKiemTacGia";
      this.lblTimKiemTacGia.Size = new System.Drawing.Size(235, 38);
      this.lblTimKiemTacGia.TabIndex = 0;
      this.lblTimKiemTacGia.Text = "Tìm kiếm tác giả";
      this.lblTimKiemTacGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dgvQuanLyTacGia
      // 
      this.dgvQuanLyTacGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvQuanLyTacGia.BackgroundColor = System.Drawing.Color.LightGray;
      this.dgvQuanLyTacGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgvQuanLyTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvQuanLyTacGia.Location = new System.Drawing.Point(581, 131);
      this.dgvQuanLyTacGia.Margin = new System.Windows.Forms.Padding(4);
      this.dgvQuanLyTacGia.Name = "dgvQuanLyTacGia";
      this.dgvQuanLyTacGia.RowHeadersWidth = 51;
      this.dgvQuanLyTacGia.RowTemplate.Height = 24;
      this.dgvQuanLyTacGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvQuanLyTacGia.Size = new System.Drawing.Size(1525, 1141);
      this.dgvQuanLyTacGia.TabIndex = 1;
      this.dgvQuanLyTacGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyTacGia_CellClick);
      this.dgvQuanLyTacGia.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvQuanLyTacGia_RowPrePaint);
      // 
      // btnXoa
      // 
      this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
      this.btnXoa.FlatAppearance.BorderSize = 0;
      this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.btnXoa.Location = new System.Drawing.Point(385, 792);
      this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
      this.btnXoa.Name = "btnXoa";
      this.btnXoa.Size = new System.Drawing.Size(136, 50);
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
      this.btnSua.Location = new System.Drawing.Point(209, 792);
      this.btnSua.Margin = new System.Windows.Forms.Padding(4);
      this.btnSua.Name = "btnSua";
      this.btnSua.Size = new System.Drawing.Size(148, 50);
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
      this.btnThem.Location = new System.Drawing.Point(40, 792);
      this.btnThem.Margin = new System.Windows.Forms.Padding(4);
      this.btnThem.Name = "btnThem";
      this.btnThem.Size = new System.Drawing.Size(141, 50);
      this.btnThem.TabIndex = 3;
      this.btnThem.Text = "Thêm";
      this.btnThem.UseVisualStyleBackColor = false;
      this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
      // 
      // txtMaTacGia
      // 
      this.txtMaTacGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtMaTacGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtMaTacGia.Enabled = false;
      this.txtMaTacGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMaTacGia.Location = new System.Drawing.Point(205, 59);
      this.txtMaTacGia.Margin = new System.Windows.Forms.Padding(4);
      this.txtMaTacGia.Name = "txtMaTacGia";
      this.txtMaTacGia.ReadOnly = true;
      this.txtMaTacGia.Size = new System.Drawing.Size(138, 38);
      this.txtMaTacGia.TabIndex = 2;
      // 
      // txtTenTacGia
      // 
      this.txtTenTacGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtTenTacGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtTenTacGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTenTacGia.Location = new System.Drawing.Point(205, 140);
      this.txtTenTacGia.Margin = new System.Windows.Forms.Padding(4);
      this.txtTenTacGia.Name = "txtTenTacGia";
      this.txtTenTacGia.Size = new System.Drawing.Size(281, 38);
      this.txtTenTacGia.TabIndex = 2;
      // 
      // txtQuocTich
      // 
      this.txtQuocTich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtQuocTich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtQuocTich.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtQuocTich.Location = new System.Drawing.Point(205, 222);
      this.txtQuocTich.Margin = new System.Windows.Forms.Padding(4);
      this.txtQuocTich.Name = "txtQuocTich";
      this.txtQuocTich.Size = new System.Drawing.Size(196, 38);
      this.txtQuocTich.TabIndex = 2;
      // 
      // lblMaTacGia
      // 
      this.lblMaTacGia.AutoSize = true;
      this.lblMaTacGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblMaTacGia.Location = new System.Drawing.Point(13, 63);
      this.lblMaTacGia.Margin = new System.Windows.Forms.Padding(4);
      this.lblMaTacGia.Name = "lblMaTacGia";
      this.lblMaTacGia.Size = new System.Drawing.Size(140, 32);
      this.lblMaTacGia.TabIndex = 1;
      this.lblMaTacGia.Text = "Mã tác giả:";
      // 
      // lblTenTacGia
      // 
      this.lblTenTacGia.AutoSize = true;
      this.lblTenTacGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblTenTacGia.Location = new System.Drawing.Point(13, 144);
      this.lblTenTacGia.Margin = new System.Windows.Forms.Padding(4);
      this.lblTenTacGia.Name = "lblTenTacGia";
      this.lblTenTacGia.Size = new System.Drawing.Size(144, 32);
      this.lblTenTacGia.TabIndex = 1;
      this.lblTenTacGia.Text = "Tên tác giả:";
      // 
      // lblQuocTich
      // 
      this.lblQuocTich.AutoSize = true;
      this.lblQuocTich.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblQuocTich.Location = new System.Drawing.Point(13, 225);
      this.lblQuocTich.Margin = new System.Windows.Forms.Padding(4);
      this.lblQuocTich.Name = "lblQuocTich";
      this.lblQuocTich.Size = new System.Drawing.Size(130, 32);
      this.lblQuocTich.TabIndex = 1;
      this.lblQuocTich.Text = "Quốc tịch:";
      // 
      // lblDiaChi
      // 
      this.lblDiaChi.AutoSize = true;
      this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblDiaChi.Location = new System.Drawing.Point(13, 306);
      this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4);
      this.lblDiaChi.Name = "lblDiaChi";
      this.lblDiaChi.Size = new System.Drawing.Size(99, 32);
      this.lblDiaChi.TabIndex = 1;
      this.lblDiaChi.Text = "Địa chỉ:";
      // 
      // lblThongTinTacGia
      // 
      this.lblThongTinTacGia.AutoSize = true;
      this.lblThongTinTacGia.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblThongTinTacGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.lblThongTinTacGia.Location = new System.Drawing.Point(0, 0);
      this.lblThongTinTacGia.Margin = new System.Windows.Forms.Padding(4);
      this.lblThongTinTacGia.Name = "lblThongTinTacGia";
      this.lblThongTinTacGia.Size = new System.Drawing.Size(240, 38);
      this.lblThongTinTacGia.TabIndex = 0;
      this.lblThongTinTacGia.Text = "Thông tin tác giả";
      // 
      // pnlThongTinTacGia
      // 
      this.pnlThongTinTacGia.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.pnlThongTinTacGia.Controls.Add(this.btnLamMoi);
      this.pnlThongTinTacGia.Controls.Add(this.btnXoa);
      this.pnlThongTinTacGia.Controls.Add(this.btnSua);
      this.pnlThongTinTacGia.Controls.Add(this.btnThem);
      this.pnlThongTinTacGia.Controls.Add(this.txtMaTacGia);
      this.pnlThongTinTacGia.Controls.Add(this.txtEmail);
      this.pnlThongTinTacGia.Controls.Add(this.txtSoDienThoai);
      this.pnlThongTinTacGia.Controls.Add(this.txtDiaChi);
      this.pnlThongTinTacGia.Controls.Add(this.txtTenTacGia);
      this.pnlThongTinTacGia.Controls.Add(this.txtQuocTich);
      this.pnlThongTinTacGia.Controls.Add(this.lblMaTacGia);
      this.pnlThongTinTacGia.Controls.Add(this.lblTenTacGia);
      this.pnlThongTinTacGia.Controls.Add(this.lblQuocTich);
      this.pnlThongTinTacGia.Controls.Add(this.lblDiaChi);
      this.pnlThongTinTacGia.Controls.Add(this.lblGioiTinh);
      this.pnlThongTinTacGia.Controls.Add(this.lblEmail);
      this.pnlThongTinTacGia.Controls.Add(this.cmbGioiTinh);
      this.pnlThongTinTacGia.Controls.Add(this.lblSoDienThoai);
      this.pnlThongTinTacGia.Controls.Add(this.lblNgaySinh);
      this.pnlThongTinTacGia.Controls.Add(this.dtpNgaySinh);
      this.pnlThongTinTacGia.Controls.Add(this.lblThongTinTacGia);
      this.pnlThongTinTacGia.Location = new System.Drawing.Point(11, 131);
      this.pnlThongTinTacGia.Margin = new System.Windows.Forms.Padding(4);
      this.pnlThongTinTacGia.Name = "pnlThongTinTacGia";
      this.pnlThongTinTacGia.Size = new System.Drawing.Size(552, 871);
      this.pnlThongTinTacGia.TabIndex = 8;
      // 
      // btnLamMoi
      // 
      this.btnLamMoi.BackColor = System.Drawing.Color.LightBlue;
      this.btnLamMoi.FlatAppearance.BorderSize = 0;
      this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.btnLamMoi.Location = new System.Drawing.Point(374, 700);
      this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
      this.btnLamMoi.Name = "btnLamMoi";
      this.btnLamMoi.Size = new System.Drawing.Size(147, 50);
      this.btnLamMoi.TabIndex = 6;
      this.btnLamMoi.Text = "Làm mới";
      this.btnLamMoi.UseVisualStyleBackColor = false;
      this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
      // 
      // txtEmail
      // 
      this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtEmail.Location = new System.Drawing.Point(205, 624);
      this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(314, 38);
      this.txtEmail.TabIndex = 2;
      // 
      // txtSoDienThoai
      // 
      this.txtSoDienThoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtSoDienThoai.Location = new System.Drawing.Point(205, 546);
      this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4);
      this.txtSoDienThoai.Name = "txtSoDienThoai";
      this.txtSoDienThoai.Size = new System.Drawing.Size(196, 38);
      this.txtSoDienThoai.TabIndex = 2;
      // 
      // txtDiaChi
      // 
      this.txtDiaChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDiaChi.Location = new System.Drawing.Point(205, 303);
      this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
      this.txtDiaChi.Name = "txtDiaChi";
      this.txtDiaChi.Size = new System.Drawing.Size(281, 38);
      this.txtDiaChi.TabIndex = 2;
      // 
      // lblGioiTinh
      // 
      this.lblGioiTinh.AutoSize = true;
      this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblGioiTinh.Location = new System.Drawing.Point(13, 388);
      this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(4);
      this.lblGioiTinh.Name = "lblGioiTinh";
      this.lblGioiTinh.Size = new System.Drawing.Size(119, 32);
      this.lblGioiTinh.TabIndex = 1;
      this.lblGioiTinh.Text = "Giới tính:";
      // 
      // lblEmail
      // 
      this.lblEmail.AutoSize = true;
      this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblEmail.Location = new System.Drawing.Point(13, 628);
      this.lblEmail.Margin = new System.Windows.Forms.Padding(4);
      this.lblEmail.Name = "lblEmail";
      this.lblEmail.Size = new System.Drawing.Size(83, 32);
      this.lblEmail.TabIndex = 1;
      this.lblEmail.Text = "Email:";
      // 
      // cmbGioiTinh
      // 
      this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
      this.cmbGioiTinh.Location = new System.Drawing.Point(205, 382);
      this.cmbGioiTinh.Margin = new System.Windows.Forms.Padding(4);
      this.cmbGioiTinh.Name = "cmbGioiTinh";
      this.cmbGioiTinh.Size = new System.Drawing.Size(136, 39);
      this.cmbGioiTinh.TabIndex = 5;
      // 
      // lblSoDienThoai
      // 
      this.lblSoDienThoai.AutoSize = true;
      this.lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblSoDienThoai.Location = new System.Drawing.Point(13, 550);
      this.lblSoDienThoai.Margin = new System.Windows.Forms.Padding(4);
      this.lblSoDienThoai.Name = "lblSoDienThoai";
      this.lblSoDienThoai.Size = new System.Drawing.Size(171, 32);
      this.lblSoDienThoai.TabIndex = 1;
      this.lblSoDienThoai.Text = "Số điện thoại:";
      // 
      // lblNgaySinh
      // 
      this.lblNgaySinh.AutoSize = true;
      this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblNgaySinh.Location = new System.Drawing.Point(13, 469);
      this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(4);
      this.lblNgaySinh.Name = "lblNgaySinh";
      this.lblNgaySinh.Size = new System.Drawing.Size(135, 32);
      this.lblNgaySinh.TabIndex = 1;
      this.lblNgaySinh.Text = "Ngày sinh:";
      // 
      // dtpNgaySinh
      // 
      this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpNgaySinh.Location = new System.Drawing.Point(205, 458);
      this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4);
      this.dtpNgaySinh.Name = "dtpNgaySinh";
      this.dtpNgaySinh.Size = new System.Drawing.Size(195, 38);
      this.dtpNgaySinh.TabIndex = 6;
      // 
      // lblQuanLyTacGia
      // 
      this.lblQuanLyTacGia.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.lblQuanLyTacGia.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
      this.lblQuanLyTacGia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.lblQuanLyTacGia.Location = new System.Drawing.Point(801, 37);
      this.lblQuanLyTacGia.Margin = new System.Windows.Forms.Padding(4);
      this.lblQuanLyTacGia.Name = "lblQuanLyTacGia";
      this.lblQuanLyTacGia.Size = new System.Drawing.Size(1100, 59);
      this.lblQuanLyTacGia.TabIndex = 4;
      this.lblQuanLyTacGia.Text = "QUẢN LÝ TÁC GIẢ";
      this.lblQuanLyTacGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pnlTimKiemTacGia
      // 
      this.pnlTimKiemTacGia.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.pnlTimKiemTacGia.Controls.Add(this.lblTimKiemTacGia);
      this.pnlTimKiemTacGia.Controls.Add(this.txtTimKiemTheoTen);
      this.pnlTimKiemTacGia.Location = new System.Drawing.Point(11, 1039);
      this.pnlTimKiemTacGia.Margin = new System.Windows.Forms.Padding(4);
      this.pnlTimKiemTacGia.Name = "pnlTimKiemTacGia";
      this.pnlTimKiemTacGia.Size = new System.Drawing.Size(357, 137);
      this.pnlTimKiemTacGia.TabIndex = 0;
      // 
      // txtTimKiemTheoTen
      // 
      this.txtTimKiemTheoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtTimKiemTheoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtTimKiemTheoTen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTimKiemTheoTen.Location = new System.Drawing.Point(0, 55);
      this.txtTimKiemTheoTen.Margin = new System.Windows.Forms.Padding(4);
      this.txtTimKiemTheoTen.Name = "txtTimKiemTheoTen";
      this.txtTimKiemTheoTen.Size = new System.Drawing.Size(311, 38);
      this.txtTimKiemTheoTen.TabIndex = 1;
      this.txtTimKiemTheoTen.Click += new System.EventHandler(this.txtTimKiemTheoTen_Click);
      this.txtTimKiemTheoTen.TextChanged += new System.EventHandler(this.txtTimKiemTheoTen_TextChanged);
      this.txtTimKiemTheoTen.Leave += new System.EventHandler(this.txtTimKiemTheoTen_Leave);
      // 
      // lblTongTacGia
      // 
      this.lblTongTacGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblTongTacGia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTongTacGia.Location = new System.Drawing.Point(326, 1224);
      this.lblTongTacGia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.lblTongTacGia.Name = "lblTongTacGia";
      this.lblTongTacGia.Size = new System.Drawing.Size(235, 46);
      this.lblTongTacGia.TabIndex = 12;
      this.lblTongTacGia.Text = "Tổng tác giả: ";
      // 
      // UserControlTacGia
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
      this.Controls.Add(this.lblTongTacGia);
      this.Controls.Add(this.pnlTimKiemTacGia);
      this.Controls.Add(this.dgvQuanLyTacGia);
      this.Controls.Add(this.pnlThongTinTacGia);
      this.Controls.Add(this.lblQuanLyTacGia);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "UserControlTacGia";
      this.Size = new System.Drawing.Size(2138, 1300);
      this.Load += new System.EventHandler(this.UserControlTacGia_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyTacGia)).EndInit();
      this.pnlThongTinTacGia.ResumeLayout(false);
      this.pnlThongTinTacGia.PerformLayout();
      this.pnlTimKiemTacGia.ResumeLayout(false);
      this.pnlTimKiemTacGia.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblTimKiemTacGia;
    private System.Windows.Forms.DataGridView dgvQuanLyTacGia;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.TextBox txtMaTacGia;
    private System.Windows.Forms.TextBox txtTenTacGia;
    private System.Windows.Forms.TextBox txtQuocTich;
    private System.Windows.Forms.Label lblMaTacGia;
    private System.Windows.Forms.Label lblTenTacGia;
    private System.Windows.Forms.Label lblQuocTich;
    private System.Windows.Forms.Label lblDiaChi;
    private System.Windows.Forms.Label lblThongTinTacGia;
    private System.Windows.Forms.Panel pnlThongTinTacGia;
    private System.Windows.Forms.TextBox txtDiaChi;
    private System.Windows.Forms.Label lblQuanLyTacGia;
    private System.Windows.Forms.Panel pnlTimKiemTacGia;
    private System.Windows.Forms.TextBox txtTimKiemTheoTen;
    private System.Windows.Forms.Label lblGioiTinh;
    private System.Windows.Forms.ComboBox cmbGioiTinh;
    private System.Windows.Forms.Label lblNgaySinh;
    private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    private System.Windows.Forms.TextBox txtSoDienThoai;
    private System.Windows.Forms.Label lblSoDienThoai;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.Label lblTongTacGia;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label lblEmail;
  }
}
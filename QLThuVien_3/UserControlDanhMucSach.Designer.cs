using System.Drawing;

namespace QLThuVien_3
{
  partial class UserControlDanhMucSach
  {
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.pnlThongTinSach = new System.Windows.Forms.Panel();
      this.dtpNgayXuatBan = new System.Windows.Forms.DateTimePicker();
      this.cmbAuthor = new System.Windows.Forms.ComboBox();
      this.lblThongTinSach = new System.Windows.Forms.Label();
      this.btnTaiAnh = new System.Windows.Forms.Button();
      this.picAnhSach = new System.Windows.Forms.PictureBox();
      this.btnXoa = new System.Windows.Forms.Button();
      this.txtGia = new System.Windows.Forms.TextBox();
      this.lblTenSach = new System.Windows.Forms.Label();
      this.txtTenSach = new System.Windows.Forms.TextBox();
      this.lblGia = new System.Windows.Forms.Label();
      this.txtMaSach = new System.Windows.Forms.TextBox();
      this.lblMaSach = new System.Windows.Forms.Label();
      this.lblTacGia = new System.Windows.Forms.Label();
      this.cmbTheLoai = new System.Windows.Forms.ComboBox();
      this.lblTheLoai = new System.Windows.Forms.Label();
      this.txtMoTa = new System.Windows.Forms.TextBox();
      this.txtNhaXuatBan = new System.Windows.Forms.TextBox();
      this.lblMoTa = new System.Windows.Forms.Label();
      this.lblNhaXuatBan = new System.Windows.Forms.Label();
      this.lblSoLuong = new System.Windows.Forms.Label();
      this.lblNgayXuatBan = new System.Windows.Forms.Label();
      this.numSoLuong = new System.Windows.Forms.NumericUpDown();
      this.btnLamMoi = new System.Windows.Forms.Button();
      this.btnSua = new System.Windows.Forms.Button();
      this.btnThem = new System.Windows.Forms.Button();
      this.lblQuanLySach = new System.Windows.Forms.Label();
      this.lblTongSach = new System.Windows.Forms.Label();
      this.pnlTimKiemSach = new System.Windows.Forms.Panel();
      this.lblTimKiemSach = new System.Windows.Forms.Label();
      this.txtTimKiemTheoTen = new System.Windows.Forms.TextBox();
      this.dgvQuanLySach = new System.Windows.Forms.DataGridView();
      this.lblLocTheoTheLoai = new System.Windows.Forms.Label();
      this.cmbLocTheoTheLoai = new System.Windows.Forms.ComboBox();
      this.cmbLocTheoTacGia = new System.Windows.Forms.ComboBox();
      this.lblLocTheoTacGia = new System.Windows.Forms.Label();
      this.pnlThongTinSach.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picAnhSach)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
      this.pnlTimKiemSach.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLySach)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlThongTinSach
      // 
      this.pnlThongTinSach.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.pnlThongTinSach.Controls.Add(this.dtpNgayXuatBan);
      this.pnlThongTinSach.Controls.Add(this.cmbAuthor);
      this.pnlThongTinSach.Controls.Add(this.lblThongTinSach);
      this.pnlThongTinSach.Controls.Add(this.btnTaiAnh);
      this.pnlThongTinSach.Controls.Add(this.picAnhSach);
      this.pnlThongTinSach.Controls.Add(this.btnXoa);
      this.pnlThongTinSach.Controls.Add(this.txtGia);
      this.pnlThongTinSach.Controls.Add(this.lblTenSach);
      this.pnlThongTinSach.Controls.Add(this.txtTenSach);
      this.pnlThongTinSach.Controls.Add(this.lblGia);
      this.pnlThongTinSach.Controls.Add(this.txtMaSach);
      this.pnlThongTinSach.Controls.Add(this.lblMaSach);
      this.pnlThongTinSach.Controls.Add(this.lblTacGia);
      this.pnlThongTinSach.Controls.Add(this.cmbTheLoai);
      this.pnlThongTinSach.Controls.Add(this.lblTheLoai);
      this.pnlThongTinSach.Controls.Add(this.txtMoTa);
      this.pnlThongTinSach.Controls.Add(this.txtNhaXuatBan);
      this.pnlThongTinSach.Controls.Add(this.lblMoTa);
      this.pnlThongTinSach.Controls.Add(this.lblNhaXuatBan);
      this.pnlThongTinSach.Controls.Add(this.lblSoLuong);
      this.pnlThongTinSach.Controls.Add(this.lblNgayXuatBan);
      this.pnlThongTinSach.Controls.Add(this.numSoLuong);
      this.pnlThongTinSach.Controls.Add(this.btnLamMoi);
      this.pnlThongTinSach.Controls.Add(this.btnSua);
      this.pnlThongTinSach.Controls.Add(this.btnThem);
      this.pnlThongTinSach.Location = new System.Drawing.Point(6, 71);
      this.pnlThongTinSach.Name = "pnlThongTinSach";
      this.pnlThongTinSach.Size = new System.Drawing.Size(301, 429);
      this.pnlThongTinSach.TabIndex = 8;
      // 
      // dtpNgayXuatBan
      // 
      this.dtpNgayXuatBan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpNgayXuatBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpNgayXuatBan.Location = new System.Drawing.Point(136, 237);
      this.dtpNgayXuatBan.Name = "dtpNgayXuatBan";
      this.dtpNgayXuatBan.Size = new System.Drawing.Size(89, 25);
      this.dtpNgayXuatBan.TabIndex = 22;
      // 
      // cmbAuthor
      // 
      this.cmbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbAuthor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbAuthor.FormattingEnabled = true;
      this.cmbAuthor.Location = new System.Drawing.Point(134, 114);
      this.cmbAuthor.Name = "cmbAuthor";
      this.cmbAuthor.Size = new System.Drawing.Size(135, 25);
      this.cmbAuthor.TabIndex = 21;
      // 
      // lblThongTinSach
      // 
      this.lblThongTinSach.AutoSize = true;
      this.lblThongTinSach.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblThongTinSach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblThongTinSach.Location = new System.Drawing.Point(0, 0);
      this.lblThongTinSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblThongTinSach.Name = "lblThongTinSach";
      this.lblThongTinSach.Size = new System.Drawing.Size(122, 21);
      this.lblThongTinSach.TabIndex = 20;
      this.lblThongTinSach.Text = "Thông tin sách";
      // 
      // btnTaiAnh
      // 
      this.btnTaiAnh.BackColor = System.Drawing.Color.LightBlue;
      this.btnTaiAnh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.btnTaiAnh.Location = new System.Drawing.Point(206, 279);
      this.btnTaiAnh.Name = "btnTaiAnh";
      this.btnTaiAnh.Size = new System.Drawing.Size(77, 32);
      this.btnTaiAnh.TabIndex = 7;
      this.btnTaiAnh.Text = "Tải ảnh";
      this.btnTaiAnh.UseVisualStyleBackColor = false;
      this.btnTaiAnh.Click += new System.EventHandler(this.btnTaiAnh_Click);
      // 
      // picAnhSach
      // 
      this.picAnhSach.Location = new System.Drawing.Point(206, 317);
      this.picAnhSach.Name = "picAnhSach";
      this.picAnhSach.Size = new System.Drawing.Size(77, 100);
      this.picAnhSach.TabIndex = 8;
      this.picAnhSach.TabStop = false;
      // 
      // btnXoa
      // 
      this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
      this.btnXoa.FlatAppearance.BorderSize = 0;
      this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.btnXoa.Location = new System.Drawing.Point(142, 387);
      this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
      this.btnXoa.Name = "btnXoa";
      this.btnXoa.Size = new System.Drawing.Size(59, 30);
      this.btnXoa.TabIndex = 8;
      this.btnXoa.Text = "Xóa";
      this.btnXoa.UseVisualStyleBackColor = false;
      this.btnXoa.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // txtGia
      // 
      this.txtGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtGia.Location = new System.Drawing.Point(6, 114);
      this.txtGia.Name = "txtGia";
      this.txtGia.Size = new System.Drawing.Size(79, 25);
      this.txtGia.TabIndex = 6;
      // 
      // lblTenSach
      // 
      this.lblTenSach.AutoSize = true;
      this.lblTenSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblTenSach.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTenSach.Location = new System.Drawing.Point(132, 27);
      this.lblTenSach.Name = "lblTenSach";
      this.lblTenSach.Size = new System.Drawing.Size(71, 19);
      this.lblTenSach.TabIndex = 0;
      this.lblTenSach.Text = "Tên sách*";
      // 
      // txtTenSach
      // 
      this.txtTenSach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTenSach.Location = new System.Drawing.Point(136, 50);
      this.txtTenSach.Name = "txtTenSach";
      this.txtTenSach.Size = new System.Drawing.Size(147, 25);
      this.txtTenSach.TabIndex = 3;
      // 
      // lblGia
      // 
      this.lblGia.AutoSize = true;
      this.lblGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblGia.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblGia.Location = new System.Drawing.Point(4, 91);
      this.lblGia.Name = "lblGia";
      this.lblGia.Size = new System.Drawing.Size(37, 19);
      this.lblGia.TabIndex = 1;
      this.lblGia.Text = "Giá*";
      // 
      // txtMaSach
      // 
      this.txtMaSach.Enabled = false;
      this.txtMaSach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMaSach.Location = new System.Drawing.Point(6, 50);
      this.txtMaSach.Name = "txtMaSach";
      this.txtMaSach.Size = new System.Drawing.Size(35, 25);
      this.txtMaSach.TabIndex = 9;
      // 
      // lblMaSach
      // 
      this.lblMaSach.AutoSize = true;
      this.lblMaSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblMaSach.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblMaSach.Location = new System.Drawing.Point(4, 27);
      this.lblMaSach.Name = "lblMaSach";
      this.lblMaSach.Size = new System.Drawing.Size(69, 19);
      this.lblMaSach.TabIndex = 10;
      this.lblMaSach.Text = "Mã sách*";
      // 
      // lblTacGia
      // 
      this.lblTacGia.AutoSize = true;
      this.lblTacGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblTacGia.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTacGia.Location = new System.Drawing.Point(132, 91);
      this.lblTacGia.Name = "lblTacGia";
      this.lblTacGia.Size = new System.Drawing.Size(62, 19);
      this.lblTacGia.TabIndex = 12;
      this.lblTacGia.Text = "Tác giả*";
      // 
      // cmbTheLoai
      // 
      this.cmbTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbTheLoai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbTheLoai.FormattingEnabled = true;
      this.cmbTheLoai.Location = new System.Drawing.Point(8, 176);
      this.cmbTheLoai.Name = "cmbTheLoai";
      this.cmbTheLoai.Size = new System.Drawing.Size(100, 25);
      this.cmbTheLoai.TabIndex = 13;
      // 
      // lblTheLoai
      // 
      this.lblTheLoai.AutoSize = true;
      this.lblTheLoai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblTheLoai.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTheLoai.Location = new System.Drawing.Point(4, 153);
      this.lblTheLoai.Name = "lblTheLoai";
      this.lblTheLoai.Size = new System.Drawing.Size(68, 19);
      this.lblTheLoai.TabIndex = 14;
      this.lblTheLoai.Text = "Thể loại*";
      // 
      // txtMoTa
      // 
      this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMoTa.Location = new System.Drawing.Point(6, 301);
      this.txtMoTa.Name = "txtMoTa";
      this.txtMoTa.Size = new System.Drawing.Size(149, 25);
      this.txtMoTa.TabIndex = 15;
      // 
      // txtNhaXuatBan
      // 
      this.txtNhaXuatBan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNhaXuatBan.Location = new System.Drawing.Point(136, 176);
      this.txtNhaXuatBan.Name = "txtNhaXuatBan";
      this.txtNhaXuatBan.Size = new System.Drawing.Size(119, 25);
      this.txtNhaXuatBan.TabIndex = 15;
      // 
      // lblMoTa
      // 
      this.lblMoTa.AutoSize = true;
      this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblMoTa.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblMoTa.Location = new System.Drawing.Point(4, 279);
      this.lblMoTa.Name = "lblMoTa";
      this.lblMoTa.Size = new System.Drawing.Size(48, 19);
      this.lblMoTa.TabIndex = 16;
      this.lblMoTa.Text = "Mô tả";
      // 
      // lblNhaXuatBan
      // 
      this.lblNhaXuatBan.AutoSize = true;
      this.lblNhaXuatBan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblNhaXuatBan.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblNhaXuatBan.Location = new System.Drawing.Point(132, 153);
      this.lblNhaXuatBan.Name = "lblNhaXuatBan";
      this.lblNhaXuatBan.Size = new System.Drawing.Size(104, 19);
      this.lblNhaXuatBan.TabIndex = 16;
      this.lblNhaXuatBan.Text = "Nhà xuất bản*";
      // 
      // lblSoLuong
      // 
      this.lblSoLuong.AutoSize = true;
      this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblSoLuong.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblSoLuong.Location = new System.Drawing.Point(4, 215);
      this.lblSoLuong.Name = "lblSoLuong";
      this.lblSoLuong.Size = new System.Drawing.Size(75, 19);
      this.lblSoLuong.TabIndex = 18;
      this.lblSoLuong.Text = "Số lượng*";
      // 
      // lblNgayXuatBan
      // 
      this.lblNgayXuatBan.AutoSize = true;
      this.lblNgayXuatBan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblNgayXuatBan.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblNgayXuatBan.Location = new System.Drawing.Point(132, 215);
      this.lblNgayXuatBan.Name = "lblNgayXuatBan";
      this.lblNgayXuatBan.Size = new System.Drawing.Size(113, 19);
      this.lblNgayXuatBan.TabIndex = 18;
      this.lblNgayXuatBan.Text = "Ngày xuất bản*";
      // 
      // numSoLuong
      // 
      this.numSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numSoLuong.Location = new System.Drawing.Point(6, 237);
      this.numSoLuong.Name = "numSoLuong";
      this.numSoLuong.Size = new System.Drawing.Size(46, 25);
      this.numSoLuong.TabIndex = 19;
      // 
      // btnLamMoi
      // 
      this.btnLamMoi.BackColor = System.Drawing.Color.LightBlue;
      this.btnLamMoi.FlatAppearance.BorderSize = 0;
      this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.btnLamMoi.Location = new System.Drawing.Point(6, 339);
      this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
      this.btnLamMoi.Name = "btnLamMoi";
      this.btnLamMoi.Size = new System.Drawing.Size(83, 30);
      this.btnLamMoi.TabIndex = 10;
      this.btnLamMoi.Text = "Nhập lại";
      this.btnLamMoi.UseVisualStyleBackColor = false;
      this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
      // 
      // btnSua
      // 
      this.btnSua.BackColor = System.Drawing.Color.LightGoldenrodYellow;
      this.btnSua.FlatAppearance.BorderSize = 0;
      this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.btnSua.Location = new System.Drawing.Point(76, 387);
      this.btnSua.Margin = new System.Windows.Forms.Padding(2);
      this.btnSua.Name = "btnSua";
      this.btnSua.Size = new System.Drawing.Size(56, 30);
      this.btnSua.TabIndex = 9;
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
      this.btnThem.Location = new System.Drawing.Point(6, 387);
      this.btnThem.Margin = new System.Windows.Forms.Padding(2);
      this.btnThem.Name = "btnThem";
      this.btnThem.Size = new System.Drawing.Size(60, 30);
      this.btnThem.TabIndex = 7;
      this.btnThem.Text = "Thêm";
      this.btnThem.UseVisualStyleBackColor = false;
      this.btnThem.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // lblQuanLySach
      // 
      this.lblQuanLySach.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.lblQuanLySach.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
      this.lblQuanLySach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.lblQuanLySach.Location = new System.Drawing.Point(437, 20);
      this.lblQuanLySach.Margin = new System.Windows.Forms.Padding(2);
      this.lblQuanLySach.Name = "lblQuanLySach";
      this.lblQuanLySach.Size = new System.Drawing.Size(600, 32);
      this.lblQuanLySach.TabIndex = 5;
      this.lblQuanLySach.Text = "QUẢN LÝ SÁCH";
      this.lblQuanLySach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblTongSach
      // 
      this.lblTongSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblTongSach.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTongSach.Location = new System.Drawing.Point(275, 663);
      this.lblTongSach.Name = "lblTongSach";
      this.lblTongSach.Size = new System.Drawing.Size(32, 26);
      this.lblTongSach.TabIndex = 15;
      this.lblTongSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pnlTimKiemSach
      // 
      this.pnlTimKiemSach.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.pnlTimKiemSach.Controls.Add(this.lblTimKiemSach);
      this.pnlTimKiemSach.Controls.Add(this.txtTimKiemTheoTen);
      this.pnlTimKiemSach.Location = new System.Drawing.Point(6, 590);
      this.pnlTimKiemSach.Margin = new System.Windows.Forms.Padding(2);
      this.pnlTimKiemSach.Name = "pnlTimKiemSach";
      this.pnlTimKiemSach.Size = new System.Drawing.Size(172, 64);
      this.pnlTimKiemSach.TabIndex = 13;
      // 
      // lblTimKiemSach
      // 
      this.lblTimKiemSach.AutoSize = true;
      this.lblTimKiemSach.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblTimKiemSach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.lblTimKiemSach.Location = new System.Drawing.Point(0, 0);
      this.lblTimKiemSach.Margin = new System.Windows.Forms.Padding(2);
      this.lblTimKiemSach.Name = "lblTimKiemSach";
      this.lblTimKiemSach.Size = new System.Drawing.Size(119, 21);
      this.lblTimKiemSach.TabIndex = 0;
      this.lblTimKiemSach.Text = "Tìm kiếm sách";
      this.lblTimKiemSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // txtTimKiemTheoTen
      // 
      this.txtTimKiemTheoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtTimKiemTheoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtTimKiemTheoTen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTimKiemTheoTen.Location = new System.Drawing.Point(0, 30);
      this.txtTimKiemTheoTen.Margin = new System.Windows.Forms.Padding(2);
      this.txtTimKiemTheoTen.Name = "txtTimKiemTheoTen";
      this.txtTimKiemTheoTen.Size = new System.Drawing.Size(159, 25);
      this.txtTimKiemTheoTen.TabIndex = 1;
      this.txtTimKiemTheoTen.Click += new System.EventHandler(this.txtTimKiemTheoTen_Click);
      this.txtTimKiemTheoTen.TextChanged += new System.EventHandler(this.txtTimKiemTheoTen_TextChanged);
      this.txtTimKiemTheoTen.Leave += new System.EventHandler(this.txtTimKiemTheoTen_Leave);
      // 
      // dgvQuanLySach
      // 
      this.dgvQuanLySach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvQuanLySach.BackgroundColor = System.Drawing.Color.LightGray;
      this.dgvQuanLySach.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgvQuanLySach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvQuanLySach.Location = new System.Drawing.Point(321, 71);
      this.dgvQuanLySach.Margin = new System.Windows.Forms.Padding(2);
      this.dgvQuanLySach.Name = "dgvQuanLySach";
      this.dgvQuanLySach.RowHeadersWidth = 51;
      this.dgvQuanLySach.RowTemplate.Height = 24;
      this.dgvQuanLySach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvQuanLySach.Size = new System.Drawing.Size(832, 618);
      this.dgvQuanLySach.TabIndex = 16;
      this.dgvQuanLySach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLySach_CellClick);
      this.dgvQuanLySach.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvQuanLySach_RowPrePaint);
      // 
      // lblLocTheoTheLoai
      // 
      this.lblLocTheoTheLoai.AutoSize = true;
      this.lblLocTheoTheLoai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblLocTheoTheLoai.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLocTheoTheLoai.Location = new System.Drawing.Point(8, 514);
      this.lblLocTheoTheLoai.Name = "lblLocTheoTheLoai";
      this.lblLocTheoTheLoai.Size = new System.Drawing.Size(62, 19);
      this.lblLocTheoTheLoai.TabIndex = 14;
      this.lblLocTheoTheLoai.Text = "Thể loại";
      // 
      // cmbLocTheoTheLoai
      // 
      this.cmbLocTheoTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbLocTheoTheLoai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbLocTheoTheLoai.FormattingEnabled = true;
      this.cmbLocTheoTheLoai.Location = new System.Drawing.Point(12, 537);
      this.cmbLocTheoTheLoai.Name = "cmbLocTheoTheLoai";
      this.cmbLocTheoTheLoai.Size = new System.Drawing.Size(116, 25);
      this.cmbLocTheoTheLoai.TabIndex = 13;
      this.cmbLocTheoTheLoai.SelectedIndexChanged += new System.EventHandler(this.cmbLocTheoTheLoai_SelectedIndexChanged);
      // 
      // cmbLocTheoTacGia
      // 
      this.cmbLocTheoTacGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbLocTheoTacGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbLocTheoTacGia.FormattingEnabled = true;
      this.cmbLocTheoTacGia.Location = new System.Drawing.Point(172, 537);
      this.cmbLocTheoTacGia.Name = "cmbLocTheoTacGia";
      this.cmbLocTheoTacGia.Size = new System.Drawing.Size(135, 25);
      this.cmbLocTheoTacGia.TabIndex = 13;
      this.cmbLocTheoTacGia.SelectedIndexChanged += new System.EventHandler(this.cmbLocTheoTacGia_SelectedIndexChanged);
      // 
      // lblLocTheoTacGia
      // 
      this.lblLocTheoTacGia.AutoSize = true;
      this.lblLocTheoTacGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblLocTheoTacGia.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLocTheoTacGia.Location = new System.Drawing.Point(168, 514);
      this.lblLocTheoTacGia.Name = "lblLocTheoTacGia";
      this.lblLocTheoTacGia.Size = new System.Drawing.Size(56, 19);
      this.lblLocTheoTacGia.TabIndex = 14;
      this.lblLocTheoTacGia.Text = "Tác giả";
      // 
      // UserControlDanhMucSach
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Lavender;
      this.Controls.Add(this.dgvQuanLySach);
      this.Controls.Add(this.lblTongSach);
      this.Controls.Add(this.pnlTimKiemSach);
      this.Controls.Add(this.lblQuanLySach);
      this.Controls.Add(this.pnlThongTinSach);
      this.Controls.Add(this.lblLocTheoTacGia);
      this.Controls.Add(this.cmbLocTheoTacGia);
      this.Controls.Add(this.lblLocTheoTheLoai);
      this.Controls.Add(this.cmbLocTheoTheLoai);
      this.Name = "UserControlDanhMucSach";
      this.Size = new System.Drawing.Size(1166, 704);
      this.Load += new System.EventHandler(this.UserControlDanhMucSach_Load);
      this.pnlThongTinSach.ResumeLayout(false);
      this.pnlThongTinSach.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picAnhSach)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
      this.pnlTimKiemSach.ResumeLayout(false);
      this.pnlTimKiemSach.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLySach)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    private System.Windows.Forms.Panel pnlThongTinSach;
    private System.Windows.Forms.Label lblThongTinSach;
    private System.Windows.Forms.Button btnTaiAnh;
    private System.Windows.Forms.PictureBox picAnhSach;
    private System.Windows.Forms.TextBox txtGia;
    private System.Windows.Forms.Label lblTenSach;
    private System.Windows.Forms.TextBox txtTenSach;
    private System.Windows.Forms.Label lblGia;
    private System.Windows.Forms.TextBox txtMaSach;
    private System.Windows.Forms.Label lblMaSach;
    private System.Windows.Forms.Label lblTacGia;
    private System.Windows.Forms.ComboBox cmbTheLoai;
    private System.Windows.Forms.Label lblTheLoai;
    private System.Windows.Forms.TextBox txtNhaXuatBan;
    private System.Windows.Forms.Label lblNhaXuatBan;
    private System.Windows.Forms.Label lblSoLuong;
    private System.Windows.Forms.Label lblNgayXuatBan;
    private System.Windows.Forms.NumericUpDown numSoLuong;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Label lblQuanLySach;
    private System.Windows.Forms.Label lblTongSach;
    private System.Windows.Forms.Panel pnlTimKiemSach;
    private System.Windows.Forms.Label lblTimKiemSach;
    private System.Windows.Forms.TextBox txtTimKiemTheoTen;
    private System.Windows.Forms.DataGridView dgvQuanLySach;
    private System.Windows.Forms.ComboBox cmbAuthor;
    private System.Windows.Forms.DateTimePicker dtpNgayXuatBan;
    private System.Windows.Forms.TextBox txtMoTa;
    private System.Windows.Forms.Label lblMoTa;
    private System.Windows.Forms.Label lblLocTheoTheLoai;
    private System.Windows.Forms.ComboBox cmbLocTheoTheLoai;
    private System.Windows.Forms.ComboBox cmbLocTheoTacGia;
    private System.Windows.Forms.Label lblLocTheoTacGia;
  }
}
using System.Windows.Forms;

namespace QLThuVien_3
{
  partial class UserControlDocGia
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

    #region Component Designer generated code

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
      this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
      this.btnLamMoi = new System.Windows.Forms.Button();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.txtDiaChi = new System.Windows.Forms.TextBox();
      this.lblEmail = new System.Windows.Forms.Label();
      this.lblQuanLyDocGia = new System.Windows.Forms.Label();
      this.pnlTimKiemDocGia = new System.Windows.Forms.Panel();
      this.txtTimKiemTheoTen = new System.Windows.Forms.TextBox();
      this.lblTongDocGia = new System.Windows.Forms.Label();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lblLocTheoGioiTinh = new System.Windows.Forms.Label();
      this.cmbLocTheoGioiTinh = new System.Windows.Forms.ComboBox();
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
      this.dgvQuanLyDocGia.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvQuanLyDocGia_RowPrePaint);
      // 
      // btnXoa
      // 
      this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
      this.btnXoa.FlatAppearance.BorderSize = 0;
      this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.btnXoa.Location = new System.Drawing.Point(209, 344);
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
      this.btnSua.Location = new System.Drawing.Point(113, 344);
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
      this.btnThem.Location = new System.Drawing.Point(21, 344);
      this.btnThem.Margin = new System.Windows.Forms.Padding(2);
      this.btnThem.Name = "btnThem";
      this.btnThem.Size = new System.Drawing.Size(77, 31);
      this.btnThem.TabIndex = 3;
      this.btnThem.Text = "Thêm";
      this.btnThem.UseVisualStyleBackColor = false;
      this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
      // 
      // txtMaDocGia
      // 
      this.txtMaDocGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtMaDocGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtMaDocGia.Enabled = false;
      this.txtMaDocGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMaDocGia.Location = new System.Drawing.Point(112, 34);
      this.txtMaDocGia.Margin = new System.Windows.Forms.Padding(2);
      this.txtMaDocGia.Name = "txtMaDocGia";
      this.txtMaDocGia.ReadOnly = true;
      this.txtMaDocGia.Size = new System.Drawing.Size(62, 25);
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
      this.txtSoDienThoai.Size = new System.Drawing.Size(97, 25);
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
      this.txtTenDocGia.Size = new System.Drawing.Size(136, 25);
      this.txtTenDocGia.TabIndex = 2;
      // 
      // lblMaDocGia
      // 
      this.lblMaDocGia.AutoSize = true;
      this.lblMaDocGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblMaDocGia.Location = new System.Drawing.Point(9, 36);
      this.lblMaDocGia.Margin = new System.Windows.Forms.Padding(2);
      this.lblMaDocGia.Name = "lblMaDocGia";
      this.lblMaDocGia.Size = new System.Drawing.Size(90, 19);
      this.lblMaDocGia.TabIndex = 1;
      this.lblMaDocGia.Text = "Mã độc giả*";
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
      // lblTenDocGia
      // 
      this.lblTenDocGia.AutoSize = true;
      this.lblTenDocGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblTenDocGia.Location = new System.Drawing.Point(9, 80);
      this.lblTenDocGia.Margin = new System.Windows.Forms.Padding(2);
      this.lblTenDocGia.Name = "lblTenDocGia";
      this.lblTenDocGia.Size = new System.Drawing.Size(92, 19);
      this.lblTenDocGia.TabIndex = 1;
      this.lblTenDocGia.Text = "Tên độc giả*";
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
      this.pnlThongTinDocGia.Controls.Add(this.cmbGioiTinh);
      this.pnlThongTinDocGia.Controls.Add(this.btnLamMoi);
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
      // cmbGioiTinh
      // 
      this.cmbGioiTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbGioiTinh.FormattingEnabled = true;
      this.cmbGioiTinh.Location = new System.Drawing.Point(112, 161);
      this.cmbGioiTinh.Name = "cmbGioiTinh";
      this.cmbGioiTinh.Size = new System.Drawing.Size(71, 25);
      this.cmbGioiTinh.TabIndex = 7;
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
      this.btnLamMoi.Size = new System.Drawing.Size(82, 31);
      this.btnLamMoi.TabIndex = 6;
      this.btnLamMoi.Text = "Nhập lại";
      this.btnLamMoi.UseVisualStyleBackColor = false;
      this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
      // 
      // txtEmail
      // 
      this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtEmail.Location = new System.Drawing.Point(112, 248);
      this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(172, 25);
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
      this.lblEmail.Size = new System.Drawing.Size(51, 19);
      this.lblEmail.TabIndex = 1;
      this.lblEmail.Text = "Email*";
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
      this.pnlTimKiemDocGia.Location = new System.Drawing.Point(6, 519);
      this.pnlTimKiemDocGia.Margin = new System.Windows.Forms.Padding(2);
      this.pnlTimKiemDocGia.Name = "pnlTimKiemDocGia";
      this.pnlTimKiemDocGia.Size = new System.Drawing.Size(194, 68);
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
      this.txtTimKiemTheoTen.Size = new System.Drawing.Size(183, 25);
      this.txtTimKiemTheoTen.TabIndex = 1;
      this.txtTimKiemTheoTen.Click += new System.EventHandler(this.txtTimKiemTheoTen_Click);
      this.txtTimKiemTheoTen.TextChanged += new System.EventHandler(this.txtTimKiemTheoTen_TextChanged);
      this.txtTimKiemTheoTen.Leave += new System.EventHandler(this.txtTimKiemTheoTen_Leave);
      // 
      // lblTongDocGia
      // 
      this.lblTongDocGia.BackColor = System.Drawing.Color.Lavender;
      this.lblTongDocGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblTongDocGia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTongDocGia.Location = new System.Drawing.Point(275, 663);
      this.lblTongDocGia.Name = "lblTongDocGia";
      this.lblTongDocGia.Size = new System.Drawing.Size(32, 26);
      this.lblTongDocGia.TabIndex = 10;
      this.lblTongDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.Width = 175;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.MinimumWidth = 9;
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.Width = 175;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.MinimumWidth = 9;
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.Width = 175;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.MinimumWidth = 9;
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.Width = 175;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.MinimumWidth = 9;
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.Width = 175;
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.MinimumWidth = 9;
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      this.dataGridViewTextBoxColumn6.Width = 175;
      // 
      // lblLocTheoGioiTinh
      // 
      this.lblLocTheoGioiTinh.AutoSize = true;
      this.lblLocTheoGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblLocTheoGioiTinh.Location = new System.Drawing.Point(160, 486);
      this.lblLocTheoGioiTinh.Margin = new System.Windows.Forms.Padding(2);
      this.lblLocTheoGioiTinh.Name = "lblLocTheoGioiTinh";
      this.lblLocTheoGioiTinh.Size = new System.Drawing.Size(65, 19);
      this.lblLocTheoGioiTinh.TabIndex = 1;
      this.lblLocTheoGioiTinh.Text = "Giới tính";
      // 
      // cmbLocTheoGioiTinh
      // 
      this.cmbLocTheoGioiTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.cmbLocTheoGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbLocTheoGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbLocTheoGioiTinh.FormattingEnabled = true;
      this.cmbLocTheoGioiTinh.Location = new System.Drawing.Point(236, 483);
      this.cmbLocTheoGioiTinh.Name = "cmbLocTheoGioiTinh";
      this.cmbLocTheoGioiTinh.Size = new System.Drawing.Size(71, 25);
      this.cmbLocTheoGioiTinh.TabIndex = 7;
      this.cmbLocTheoGioiTinh.SelectedIndexChanged += new System.EventHandler(this.cmbLocTheoGioiTinh_SelectedIndexChanged);
      // 
      // UserControlDocGia
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
      this.Controls.Add(this.cmbLocTheoGioiTinh);
      this.Controls.Add(this.lblTongDocGia);
      this.Controls.Add(this.pnlTimKiemDocGia);
      this.Controls.Add(this.dgvQuanLyDocGia);
      this.Controls.Add(this.pnlThongTinDocGia);
      this.Controls.Add(this.lblQuanLyDocGia);
      this.Controls.Add(this.lblLocTheoGioiTinh);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "UserControlDocGia";
      this.Size = new System.Drawing.Size(1166, 704);
      this.Load += new System.EventHandler(this.UserControlDocGia_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyDocGia)).EndInit();
      this.pnlThongTinDocGia.ResumeLayout(false);
      this.pnlThongTinDocGia.PerformLayout();
      this.pnlTimKiemDocGia.ResumeLayout(false);
      this.pnlTimKiemDocGia.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

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
    private TextBox txtTimKiemTheoTen;
    private Button btnLamMoi;
    private Label lblTongDocGia;
    private TextBox txtEmail;
    private Label lblEmail;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private ComboBox cmbGioiTinh;
    private Label lblLocTheoGioiTinh;
    private ComboBox cmbLocTheoGioiTinh;
  }
}
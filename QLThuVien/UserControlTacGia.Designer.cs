using System.Windows.Forms;

namespace QLThuVien
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
      this.label8 = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnEdit = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.txtMaTacGia = new System.Windows.Forms.TextBox();
      this.txtTenTacGia = new System.Windows.Forms.TextBox();
      this.txtQuocTich = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnClear = new System.Windows.Forms.Button();
      this.txtSoDienThoai = new System.Windows.Forms.TextBox();
      this.txtDiaChi = new System.Windows.Forms.TextBox();
      this.labelGender = new System.Windows.Forms.Label();
      this.cmbGender = new System.Windows.Forms.ComboBox();
      this.lblSoDienThoai = new System.Windows.Forms.Label();
      this.labelDOB = new System.Windows.Forms.Label();
      this.dtpDOB = new System.Windows.Forms.DateTimePicker();
      this.label1 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.txtTimKiemTheoTen = new System.Windows.Forms.TextBox();
      this.lblTongTacGia = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.label8.Location = new System.Drawing.Point(0, 0);
      this.label8.Margin = new System.Windows.Forms.Padding(2);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(136, 21);
      this.label8.TabIndex = 0;
      this.label8.Text = "Tìm kiếm tác giả";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
      this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(317, 71);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 51;
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(534, 570);
      this.dataGridView1.TabIndex = 1;
      this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
      // 
      // btnDelete
      // 
      this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
      this.btnDelete.FlatAppearance.BorderSize = 0;
      this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.btnDelete.Location = new System.Drawing.Point(208, 338);
      this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(74, 28);
      this.btnDelete.TabIndex = 4;
      this.btnDelete.Text = "Xóa";
      this.btnDelete.UseVisualStyleBackColor = false;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnEdit
      // 
      this.btnEdit.BackColor = System.Drawing.Color.LightGoldenrodYellow;
      this.btnEdit.FlatAppearance.BorderSize = 0;
      this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.btnEdit.Location = new System.Drawing.Point(112, 338);
      this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(81, 28);
      this.btnEdit.TabIndex = 4;
      this.btnEdit.Text = "Sửa";
      this.btnEdit.UseVisualStyleBackColor = false;
      this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
      this.btnAdd.FlatAppearance.BorderSize = 0;
      this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.btnAdd.Location = new System.Drawing.Point(20, 338);
      this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(77, 28);
      this.btnAdd.TabIndex = 3;
      this.btnAdd.Text = "Thêm";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // txtMaTacGia
      // 
      this.txtMaTacGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtMaTacGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtMaTacGia.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.txtMaTacGia.Location = new System.Drawing.Point(112, 28);
      this.txtMaTacGia.Margin = new System.Windows.Forms.Padding(2);
      this.txtMaTacGia.Name = "txtMaTacGia";
      this.txtMaTacGia.Size = new System.Drawing.Size(171, 29);
      this.txtMaTacGia.TabIndex = 2;
      // 
      // txtTenTacGia
      // 
      this.txtTenTacGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtTenTacGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtTenTacGia.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.txtTenTacGia.Location = new System.Drawing.Point(112, 72);
      this.txtTenTacGia.Margin = new System.Windows.Forms.Padding(2);
      this.txtTenTacGia.Name = "txtTenTacGia";
      this.txtTenTacGia.Size = new System.Drawing.Size(171, 29);
      this.txtTenTacGia.TabIndex = 2;
      // 
      // txtQuocTich
      // 
      this.txtQuocTich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtQuocTich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtQuocTich.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.txtQuocTich.Location = new System.Drawing.Point(112, 116);
      this.txtQuocTich.Margin = new System.Windows.Forms.Padding(2);
      this.txtQuocTich.Name = "txtQuocTich";
      this.txtQuocTich.Size = new System.Drawing.Size(171, 29);
      this.txtQuocTich.TabIndex = 2;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.label7.Location = new System.Drawing.Point(7, 34);
      this.label7.Margin = new System.Windows.Forms.Padding(2);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(83, 19);
      this.label7.TabIndex = 1;
      this.label7.Text = "Mã tác giả:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.label6.Location = new System.Drawing.Point(7, 78);
      this.label6.Margin = new System.Windows.Forms.Padding(2);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(85, 19);
      this.label6.TabIndex = 1;
      this.label6.Text = "Tên tác giả:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.label5.Location = new System.Drawing.Point(7, 122);
      this.label5.Margin = new System.Windows.Forms.Padding(2);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(76, 19);
      this.label5.TabIndex = 1;
      this.label5.Text = "Quốc tịch:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.label3.Location = new System.Drawing.Point(7, 166);
      this.label3.Margin = new System.Windows.Forms.Padding(2);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(58, 19);
      this.label3.TabIndex = 1;
      this.label3.Text = "Địa chỉ:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(0, 0);
      this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(139, 21);
      this.label4.TabIndex = 7;
      this.label4.Text = "Thông tin tác giả";
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(0, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(100, 23);
      this.label2.TabIndex = 0;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.panel1.Controls.Add(this.btnClear);
      this.panel1.Controls.Add(this.btnDelete);
      this.panel1.Controls.Add(this.btnEdit);
      this.panel1.Controls.Add(this.btnAdd);
      this.panel1.Controls.Add(this.txtMaTacGia);
      this.panel1.Controls.Add(this.txtSoDienThoai);
      this.panel1.Controls.Add(this.txtDiaChi);
      this.panel1.Controls.Add(this.txtTenTacGia);
      this.panel1.Controls.Add(this.txtQuocTich);
      this.panel1.Controls.Add(this.label7);
      this.panel1.Controls.Add(this.label6);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.labelGender);
      this.panel1.Controls.Add(this.cmbGender);
      this.panel1.Controls.Add(this.lblSoDienThoai);
      this.panel1.Controls.Add(this.labelDOB);
      this.panel1.Controls.Add(this.dtpDOB);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Location = new System.Drawing.Point(6, 71);
      this.panel1.Margin = new System.Windows.Forms.Padding(2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(301, 413);
      this.panel1.TabIndex = 8;
      // 
      // btnClear
      // 
      this.btnClear.BackColor = System.Drawing.Color.LightBlue;
      this.btnClear.FlatAppearance.BorderSize = 0;
      this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.btnClear.Location = new System.Drawing.Point(199, 379);
      this.btnClear.Margin = new System.Windows.Forms.Padding(2);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(83, 27);
      this.btnClear.TabIndex = 6;
      this.btnClear.Text = "Làm mới";
      this.btnClear.UseVisualStyleBackColor = false;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // txtSoDienThoai
      // 
      this.txtSoDienThoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.txtSoDienThoai.Location = new System.Drawing.Point(112, 294);
      this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(2);
      this.txtSoDienThoai.Name = "txtSoDienThoai";
      this.txtSoDienThoai.Size = new System.Drawing.Size(171, 29);
      this.txtSoDienThoai.TabIndex = 2;
      // 
      // txtDiaChi
      // 
      this.txtDiaChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.txtDiaChi.Location = new System.Drawing.Point(112, 160);
      this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
      this.txtDiaChi.Name = "txtDiaChi";
      this.txtDiaChi.Size = new System.Drawing.Size(171, 29);
      this.txtDiaChi.TabIndex = 2;
      // 
      // labelGender
      // 
      this.labelGender.AutoSize = true;
      this.labelGender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.labelGender.Location = new System.Drawing.Point(7, 210);
      this.labelGender.Margin = new System.Windows.Forms.Padding(2);
      this.labelGender.Name = "labelGender";
      this.labelGender.Size = new System.Drawing.Size(69, 19);
      this.labelGender.TabIndex = 1;
      this.labelGender.Text = "Giới tính:";
      // 
      // cmbGender
      // 
      this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.cmbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
      this.cmbGender.Location = new System.Drawing.Point(112, 210);
      this.cmbGender.Margin = new System.Windows.Forms.Padding(2);
      this.cmbGender.Name = "cmbGender";
      this.cmbGender.Size = new System.Drawing.Size(172, 29);
      this.cmbGender.TabIndex = 5;
      // 
      // lblSoDienThoai
      // 
      this.lblSoDienThoai.AutoSize = true;
      this.lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.lblSoDienThoai.Location = new System.Drawing.Point(7, 298);
      this.lblSoDienThoai.Margin = new System.Windows.Forms.Padding(2);
      this.lblSoDienThoai.Name = "lblSoDienThoai";
      this.lblSoDienThoai.Size = new System.Drawing.Size(101, 19);
      this.lblSoDienThoai.TabIndex = 1;
      this.lblSoDienThoai.Text = "Số điện thoại:";
      // 
      // labelDOB
      // 
      this.labelDOB.AutoSize = true;
      this.labelDOB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.labelDOB.Location = new System.Drawing.Point(7, 254);
      this.labelDOB.Margin = new System.Windows.Forms.Padding(2);
      this.labelDOB.Name = "labelDOB";
      this.labelDOB.Size = new System.Drawing.Size(79, 19);
      this.labelDOB.TabIndex = 1;
      this.labelDOB.Text = "Ngày sinh:";
      // 
      // dtpDOB
      // 
      this.dtpDOB.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpDOB.Location = new System.Drawing.Point(112, 254);
      this.dtpDOB.Margin = new System.Windows.Forms.Padding(2);
      this.dtpDOB.Name = "dtpDOB";
      this.dtpDOB.Size = new System.Drawing.Size(172, 29);
      this.dtpDOB.TabIndex = 6;
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
      this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label1.Location = new System.Drawing.Point(134, 14);
      this.label1.Margin = new System.Windows.Forms.Padding(2);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(600, 32);
      this.label1.TabIndex = 4;
      this.label1.Text = "QUẢN LÝ TÁC GIẢ";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // panel2
      // 
      this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.panel2.Controls.Add(this.label8);
      this.panel2.Controls.Add(this.txtTimKiemTheoTen);
      this.panel2.Location = new System.Drawing.Point(6, 500);
      this.panel2.Margin = new System.Windows.Forms.Padding(2);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(282, 74);
      this.panel2.TabIndex = 0;
      // 
      // txtTimKiemTheoTen
      // 
      this.txtTimKiemTheoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtTimKiemTheoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtTimKiemTheoTen.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.txtTimKiemTheoTen.Location = new System.Drawing.Point(0, 30);
      this.txtTimKiemTheoTen.Margin = new System.Windows.Forms.Padding(2);
      this.txtTimKiemTheoTen.Name = "txtTimKiemTheoTen";
      this.txtTimKiemTheoTen.Size = new System.Drawing.Size(188, 29);
      this.txtTimKiemTheoTen.TabIndex = 1;
      this.txtTimKiemTheoTen.TextChanged += new System.EventHandler(this.txtTimKiemTheoTen_TextChanged);
      // 
      // lblTongTacGia
      // 
      this.lblTongTacGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblTongTacGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTongTacGia.Location = new System.Drawing.Point(252, 618);
      this.lblTongTacGia.Name = "lblTongTacGia";
      this.lblTongTacGia.Size = new System.Drawing.Size(55, 23);
      this.lblTongTacGia.TabIndex = 12;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.label9.Location = new System.Drawing.Point(186, 619);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(66, 19);
      this.label9.TabIndex = 11;
      this.label9.Text = "Tổng số:";
      // 
      // UserControlTacGia
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
      this.Controls.Add(this.lblTongTacGia);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "UserControlTacGia";
      this.Size = new System.Drawing.Size(866, 659);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.TextBox txtMaTacGia;
    private System.Windows.Forms.TextBox txtTenTacGia;
    private System.Windows.Forms.TextBox txtQuocTich;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txtDiaChi;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox txtTimKiemTheoTen;
    private Label labelGender;
    private ComboBox cmbGender;
    private Label labelDOB;
    private DateTimePicker dtpDOB;
    private TextBox txtSoDienThoai;
    private Label lblSoDienThoai;
    private Button btnClear;
    private Label lblTongTacGia;
    private Label label9;
  }
}
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
      this.label8 = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnEdit = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.txtma = new System.Windows.Forms.TextBox();
      this.txtPhone = new System.Windows.Forms.TextBox();
      this.txthoten = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnClear = new System.Windows.Forms.Button();
      this.radionu = new System.Windows.Forms.RadioButton();
      this.radionam = new System.Windows.Forms.RadioButton();
      this.txtdiachi = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.txtTimKiemTheoTen = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.lblTongDocGia = new System.Windows.Forms.Label();
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
      this.label8.Size = new System.Drawing.Size(141, 21);
      this.label8.TabIndex = 0;
      this.label8.Text = "Tìm kiếm độc giả";
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
      this.btnDelete.Location = new System.Drawing.Point(208, 262);
      this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(74, 31);
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
      this.btnEdit.Location = new System.Drawing.Point(112, 262);
      this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(81, 31);
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
      this.btnAdd.Location = new System.Drawing.Point(20, 262);
      this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(77, 31);
      this.btnAdd.TabIndex = 3;
      this.btnAdd.Text = "Thêm";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // txtma
      // 
      this.txtma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtma.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.txtma.Location = new System.Drawing.Point(112, 34);
      this.txtma.Margin = new System.Windows.Forms.Padding(2);
      this.txtma.Name = "txtma";
      this.txtma.Size = new System.Drawing.Size(171, 29);
      this.txtma.TabIndex = 2;
      // 
      // txtPhone
      // 
      this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.txtPhone.Location = new System.Drawing.Point(112, 122);
      this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Size = new System.Drawing.Size(171, 29);
      this.txtPhone.TabIndex = 2;
      // 
      // txthoten
      // 
      this.txthoten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txthoten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txthoten.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.txthoten.Location = new System.Drawing.Point(112, 78);
      this.txthoten.Margin = new System.Windows.Forms.Padding(2);
      this.txthoten.Name = "txthoten";
      this.txthoten.Size = new System.Drawing.Size(171, 29);
      this.txthoten.TabIndex = 2;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.label7.Location = new System.Drawing.Point(7, 40);
      this.label7.Margin = new System.Windows.Forms.Padding(2);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(88, 19);
      this.label7.TabIndex = 1;
      this.label7.Text = "Mã độc giả:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.label6.Location = new System.Drawing.Point(7, 216);
      this.label6.Margin = new System.Windows.Forms.Padding(2);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(58, 19);
      this.label6.TabIndex = 1;
      this.label6.Text = "Địa chỉ:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.label5.Location = new System.Drawing.Point(7, 172);
      this.label5.Margin = new System.Windows.Forms.Padding(2);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(69, 19);
      this.label5.TabIndex = 1;
      this.label5.Text = "Giới tính:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.label3.Location = new System.Drawing.Point(7, 128);
      this.label3.Margin = new System.Windows.Forms.Padding(2);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(101, 19);
      this.label3.TabIndex = 1;
      this.label3.Text = "Số điện thoại:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.label4.Location = new System.Drawing.Point(7, 84);
      this.label4.Margin = new System.Windows.Forms.Padding(2);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(78, 19);
      this.label4.TabIndex = 1;
      this.label4.Text = "Họ và tên:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.label2.Location = new System.Drawing.Point(0, 0);
      this.label2.Margin = new System.Windows.Forms.Padding(2);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(144, 21);
      this.label2.TabIndex = 0;
      this.label2.Text = "Thông tin độc giả";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.panel1.Controls.Add(this.btnClear);
      this.panel1.Controls.Add(this.radionu);
      this.panel1.Controls.Add(this.radionam);
      this.panel1.Controls.Add(this.btnDelete);
      this.panel1.Controls.Add(this.btnEdit);
      this.panel1.Controls.Add(this.btnAdd);
      this.panel1.Controls.Add(this.txtma);
      this.panel1.Controls.Add(this.txtdiachi);
      this.panel1.Controls.Add(this.txtPhone);
      this.panel1.Controls.Add(this.txthoten);
      this.panel1.Controls.Add(this.label7);
      this.panel1.Controls.Add(this.label6);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Location = new System.Drawing.Point(6, 71);
      this.panel1.Margin = new System.Windows.Forms.Padding(2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(301, 394);
      this.panel1.TabIndex = 8;
      // 
      // btnClear
      // 
      this.btnClear.BackColor = System.Drawing.Color.LightBlue;
      this.btnClear.FlatAppearance.BorderSize = 0;
      this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.btnClear.Location = new System.Drawing.Point(201, 353);
      this.btnClear.Margin = new System.Windows.Forms.Padding(2);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(81, 30);
      this.btnClear.TabIndex = 6;
      this.btnClear.Text = "Làm mới";
      this.btnClear.UseVisualStyleBackColor = false;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // radionu
      // 
      this.radionu.AutoSize = true;
      this.radionu.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.radionu.Location = new System.Drawing.Point(184, 172);
      this.radionu.Margin = new System.Windows.Forms.Padding(2);
      this.radionu.Name = "radionu";
      this.radionu.Size = new System.Drawing.Size(49, 23);
      this.radionu.TabIndex = 5;
      this.radionu.TabStop = true;
      this.radionu.Text = " Nữ";
      this.radionu.UseVisualStyleBackColor = true;
      // 
      // radionam
      // 
      this.radionam.AutoSize = true;
      this.radionam.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.radionam.Location = new System.Drawing.Point(115, 172);
      this.radionam.Margin = new System.Windows.Forms.Padding(2);
      this.radionam.Name = "radionam";
      this.radionam.Size = new System.Drawing.Size(56, 23);
      this.radionam.TabIndex = 5;
      this.radionam.TabStop = true;
      this.radionam.Text = "Nam";
      this.radionam.UseVisualStyleBackColor = true;
      // 
      // txtdiachi
      // 
      this.txtdiachi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
      this.txtdiachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtdiachi.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.txtdiachi.Location = new System.Drawing.Point(112, 211);
      this.txtdiachi.Margin = new System.Windows.Forms.Padding(2);
      this.txtdiachi.Name = "txtdiachi";
      this.txtdiachi.Size = new System.Drawing.Size(171, 29);
      this.txtdiachi.TabIndex = 2;
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
      this.label1.Text = "QUẢN LÝ ĐỘC GIẢ";
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
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.label9.Location = new System.Drawing.Point(186, 619);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(66, 19);
      this.label9.TabIndex = 9;
      this.label9.Text = "Tổng số:";
      // 
      // lblTongDocGia
      // 
      this.lblTongDocGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblTongDocGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTongDocGia.Location = new System.Drawing.Point(252, 618);
      this.lblTongDocGia.Name = "lblTongDocGia";
      this.lblTongDocGia.Size = new System.Drawing.Size(55, 23);
      this.lblTongDocGia.TabIndex = 10;
      // 
      // UserControlDocGia
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
      this.Controls.Add(this.lblTongDocGia);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "UserControlDocGia";
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
    private System.Windows.Forms.TextBox txtma;
    private System.Windows.Forms.TextBox txtPhone;
    private System.Windows.Forms.TextBox txthoten;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txtdiachi;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.RadioButton radionu;
    private System.Windows.Forms.RadioButton radionam;
    private TextBox txtTimKiemTheoTen;
    private Button btnClear;
    private Label label9;
    private Label lblTongDocGia;
  }
}
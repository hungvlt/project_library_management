using System.Drawing;

namespace QLThuVien
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.label9 = new System.Windows.Forms.Label();
      this.btnUpload = new System.Windows.Forms.Button();
      this.PictureBox = new System.Windows.Forms.PictureBox();
      this.txtPrice = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtProductName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtBookID = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.cmbCategory = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtPublisher = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.numYear = new System.Windows.Forms.NumericUpDown();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.numQuantity = new System.Windows.Forms.NumericUpDown();
      this.btnClear = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnEdit = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.label10 = new System.Windows.Forms.Label();
      this.lblTongSach = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.label12 = new System.Windows.Forms.Label();
      this.txtTimKiemTheoTen = new System.Windows.Forms.TextBox();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.cmbAuthor = new System.Windows.Forms.ComboBox();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.panel1.Controls.Add(this.cmbAuthor);
      this.panel1.Controls.Add(this.label9);
      this.panel1.Controls.Add(this.btnUpload);
      this.panel1.Controls.Add(this.PictureBox);
      this.panel1.Controls.Add(this.txtPrice);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.txtProductName);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.txtBookID);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.cmbCategory);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.txtPublisher);
      this.panel1.Controls.Add(this.label6);
      this.panel1.Controls.Add(this.numYear);
      this.panel1.Controls.Add(this.label8);
      this.panel1.Controls.Add(this.label7);
      this.panel1.Controls.Add(this.numQuantity);
      this.panel1.Controls.Add(this.btnClear);
      this.panel1.Controls.Add(this.btnDelete);
      this.panel1.Controls.Add(this.btnEdit);
      this.panel1.Controls.Add(this.btnAdd);
      this.panel1.Location = new System.Drawing.Point(6, 71);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(301, 448);
      this.panel1.TabIndex = 8;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(0, 0);
      this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(122, 21);
      this.label9.TabIndex = 20;
      this.label9.Text = "Thông tin sách";
      // 
      // btnUpload
      // 
      this.btnUpload.BackColor = System.Drawing.Color.LightBlue;
      this.btnUpload.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.btnUpload.Location = new System.Drawing.Point(125, 280);
      this.btnUpload.Name = "btnUpload";
      this.btnUpload.Size = new System.Drawing.Size(84, 32);
      this.btnUpload.TabIndex = 7;
      this.btnUpload.Text = "Tải ảnh";
      this.btnUpload.UseVisualStyleBackColor = false;
      this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
      // 
      // PictureBox
      // 
      this.PictureBox.Location = new System.Drawing.Point(6, 280);
      this.PictureBox.Name = "PictureBox";
      this.PictureBox.Size = new System.Drawing.Size(113, 153);
      this.PictureBox.TabIndex = 8;
      this.PictureBox.TabStop = false;
      // 
      // txtPrice
      // 
      this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.txtPrice.Location = new System.Drawing.Point(6, 114);
      this.txtPrice.Name = "txtPrice";
      this.txtPrice.Size = new System.Drawing.Size(101, 29);
      this.txtPrice.TabIndex = 6;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label1.Location = new System.Drawing.Point(128, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 19);
      this.label1.TabIndex = 0;
      this.label1.Text = "Tên sản phẩm";
      // 
      // txtProductName
      // 
      this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.txtProductName.Location = new System.Drawing.Point(132, 50);
      this.txtProductName.Name = "txtProductName";
      this.txtProductName.Size = new System.Drawing.Size(150, 29);
      this.txtProductName.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label2.Location = new System.Drawing.Point(4, 91);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(99, 19);
      this.label2.TabIndex = 1;
      this.label2.Text = "Giá sản phẩm";
      // 
      // txtBookID
      // 
      this.txtBookID.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.txtBookID.Location = new System.Drawing.Point(6, 50);
      this.txtBookID.Name = "txtBookID";
      this.txtBookID.Size = new System.Drawing.Size(101, 29);
      this.txtBookID.TabIndex = 9;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label3.Location = new System.Drawing.Point(6, 27);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(63, 19);
      this.label3.TabIndex = 10;
      this.label3.Text = "Mã sách";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label4.Location = new System.Drawing.Point(6, 153);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(56, 19);
      this.label4.TabIndex = 12;
      this.label4.Text = "Tác giả";
      // 
      // cmbCategory
      // 
      this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.cmbCategory.FormattingEnabled = true;
      this.cmbCategory.Items.AddRange(new object[] {
            "Khoa học",
            "Văn học",
            "Công nghệ"});
      this.cmbCategory.Location = new System.Drawing.Point(132, 114);
      this.cmbCategory.Name = "cmbCategory";
      this.cmbCategory.Size = new System.Drawing.Size(122, 29);
      this.cmbCategory.TabIndex = 13;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label5.Location = new System.Drawing.Point(128, 91);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(62, 19);
      this.label5.TabIndex = 14;
      this.label5.Text = "Thể loại";
      // 
      // txtPublisher
      // 
      this.txtPublisher.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.txtPublisher.Location = new System.Drawing.Point(132, 176);
      this.txtPublisher.Name = "txtPublisher";
      this.txtPublisher.Size = new System.Drawing.Size(122, 29);
      this.txtPublisher.TabIndex = 15;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label6.Location = new System.Drawing.Point(128, 153);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(98, 19);
      this.label6.TabIndex = 16;
      this.label6.Text = "Nhà xuất bản";
      // 
      // numYear
      // 
      this.numYear.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.numYear.Location = new System.Drawing.Point(6, 239);
      this.numYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
      this.numYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
      this.numYear.Name = "numYear";
      this.numYear.Size = new System.Drawing.Size(101, 29);
      this.numYear.TabIndex = 17;
      this.numYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label8.Location = new System.Drawing.Point(128, 216);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(69, 19);
      this.label8.TabIndex = 18;
      this.label8.Text = "Số lượng";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label7.Location = new System.Drawing.Point(6, 216);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(103, 19);
      this.label7.TabIndex = 18;
      this.label7.Text = "Năm xuất bản";
      // 
      // numQuantity
      // 
      this.numQuantity.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.numQuantity.Location = new System.Drawing.Point(132, 239);
      this.numQuantity.Name = "numQuantity";
      this.numQuantity.Size = new System.Drawing.Size(101, 29);
      this.numQuantity.TabIndex = 19;
      // 
      // btnClear
      // 
      this.btnClear.BackColor = System.Drawing.Color.LightBlue;
      this.btnClear.FlatAppearance.BorderSize = 0;
      this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.btnClear.Location = new System.Drawing.Point(125, 407);
      this.btnClear.Margin = new System.Windows.Forms.Padding(2);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(81, 27);
      this.btnClear.TabIndex = 10;
      this.btnClear.Text = "Làm mới";
      this.btnClear.UseVisualStyleBackColor = false;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
      this.btnDelete.FlatAppearance.BorderSize = 0;
      this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.btnDelete.Location = new System.Drawing.Point(220, 406);
      this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(81, 28);
      this.btnDelete.TabIndex = 8;
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
      this.btnEdit.Location = new System.Drawing.Point(220, 360);
      this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(81, 28);
      this.btnEdit.TabIndex = 9;
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
      this.btnAdd.Location = new System.Drawing.Point(125, 360);
      this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(81, 28);
      this.btnAdd.TabIndex = 7;
      this.btnAdd.Text = "Thêm";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // label10
      // 
      this.label10.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
      this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label10.Location = new System.Drawing.Point(134, 14);
      this.label10.Margin = new System.Windows.Forms.Padding(2);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(600, 32);
      this.label10.TabIndex = 5;
      this.label10.Text = "QUẢN LÝ SÁCH";
      this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblTongSach
      // 
      this.lblTongSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblTongSach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTongSach.Location = new System.Drawing.Point(252, 618);
      this.lblTongSach.Name = "lblTongSach";
      this.lblTongSach.Size = new System.Drawing.Size(55, 23);
      this.lblTongSach.TabIndex = 15;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.label11.Location = new System.Drawing.Point(186, 619);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(66, 19);
      this.label11.TabIndex = 14;
      this.label11.Text = "Tổng số:";
      // 
      // panel2
      // 
      this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.panel2.Controls.Add(this.label12);
      this.panel2.Controls.Add(this.txtTimKiemTheoTen);
      this.panel2.Location = new System.Drawing.Point(6, 533);
      this.panel2.Margin = new System.Windows.Forms.Padding(2);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(282, 74);
      this.panel2.TabIndex = 13;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
      this.label12.Location = new System.Drawing.Point(0, 0);
      this.label12.Margin = new System.Windows.Forms.Padding(2);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(119, 21);
      this.label12.TabIndex = 0;
      this.label12.Text = "Tìm kiếm sách";
      this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
      // dataGridView1
      // 
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
      this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(321, 71);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 51;
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(805, 570);
      this.dataGridView1.TabIndex = 16;
      // 
      // cmbAuthor
      // 
      this.cmbAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbAuthor.FormattingEnabled = true;
      this.cmbAuthor.Location = new System.Drawing.Point(6, 176);
      this.cmbAuthor.Name = "cmbAuthor";
      this.cmbAuthor.Size = new System.Drawing.Size(101, 29);
      this.cmbAuthor.TabIndex = 21;
      // 
      // UserControlDanhMucSach
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Lavender;
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.lblTongSach);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.panel1);
      this.Name = "UserControlDanhMucSach";
      this.Size = new System.Drawing.Size(1138, 659);
      this.Load += new System.EventHandler(this.UserControlDanhMucSach_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Button btnUpload;
    private System.Windows.Forms.PictureBox PictureBox;
    private System.Windows.Forms.TextBox txtPrice;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtProductName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtBookID;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox cmbCategory;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtPublisher;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.NumericUpDown numYear;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.NumericUpDown numQuantity;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label lblTongSach;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.TextBox txtTimKiemTheoTen;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.ComboBox cmbAuthor;
  }
}
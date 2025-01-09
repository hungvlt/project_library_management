using System;
using System.Windows.Forms;

namespace QLThuVien_3
{
  partial class FormDangNhap
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

    private void InitializeComponent()
    {
      this.lblDangNhapQuanLyThuVien = new System.Windows.Forms.Label();
      this.lblTenDangNhap = new System.Windows.Forms.Label();
      this.lblMatKhau = new System.Windows.Forms.Label();
      this.txtUsername = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.btnLogin = new System.Windows.Forms.Button();
      this.chkShowPassword = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // lblDangNhapQuanLyThuVien
      // 
      this.lblDangNhapQuanLyThuVien.AutoSize = true;
      this.lblDangNhapQuanLyThuVien.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
      this.lblDangNhapQuanLyThuVien.ForeColor = System.Drawing.Color.DarkSlateBlue;
      this.lblDangNhapQuanLyThuVien.Location = new System.Drawing.Point(14, 22);
      this.lblDangNhapQuanLyThuVien.Name = "lblDangNhapQuanLyThuVien";
      this.lblDangNhapQuanLyThuVien.Size = new System.Drawing.Size(403, 41);
      this.lblDangNhapQuanLyThuVien.TabIndex = 0;
      this.lblDangNhapQuanLyThuVien.Text = "Đăng nhập Quản lý thư viện";
      // 
      // lblTenDangNhap
      // 
      this.lblTenDangNhap.AutoSize = true;
      this.lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.lblTenDangNhap.Location = new System.Drawing.Point(21, 89);
      this.lblTenDangNhap.Name = "lblTenDangNhap";
      this.lblTenDangNhap.Size = new System.Drawing.Size(120, 21);
      this.lblTenDangNhap.TabIndex = 1;
      this.lblTenDangNhap.Text = "Tên đăng nhập:";
      // 
      // lblMatKhau
      // 
      this.lblMatKhau.AutoSize = true;
      this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
      this.lblMatKhau.Location = new System.Drawing.Point(21, 136);
      this.lblMatKhau.Name = "lblMatKhau";
      this.lblMatKhau.Size = new System.Drawing.Size(81, 21);
      this.lblMatKhau.TabIndex = 1;
      this.lblMatKhau.Text = "Mật khẩu:";
      // 
      // txtUsername
      // 
      this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.txtUsername.Location = new System.Drawing.Point(148, 86);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new System.Drawing.Size(220, 29);
      this.txtUsername.TabIndex = 6;
      // 
      // txtPassword
      // 
      this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.txtPassword.Location = new System.Drawing.Point(148, 134);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Size = new System.Drawing.Size(220, 29);
      this.txtPassword.TabIndex = 5;
      this.txtPassword.UseSystemPasswordChar = true;
      // 
      // btnLogin
      // 
      this.btnLogin.BackColor = System.Drawing.Color.DarkGreen;
      this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
      this.btnLogin.ForeColor = System.Drawing.Color.White;
      this.btnLogin.Location = new System.Drawing.Point(268, 215);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(100, 40);
      this.btnLogin.TabIndex = 3;
      this.btnLogin.Text = "Đăng nhập";
      this.btnLogin.UseVisualStyleBackColor = false;
      this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
      this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
      // 
      // chkShowPassword
      // 
      this.chkShowPassword.AutoSize = true;
      this.chkShowPassword.Location = new System.Drawing.Point(148, 178);
      this.chkShowPassword.Name = "chkShowPassword";
      this.chkShowPassword.Size = new System.Drawing.Size(152, 25);
      this.chkShowPassword.TabIndex = 4;
      this.chkShowPassword.Text = "Hiển thị mật khẩu";
      this.chkShowPassword.UseVisualStyleBackColor = true;
      // 
      // FormDangNhap
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(426, 271);
      this.Controls.Add(this.chkShowPassword);
      this.Controls.Add(this.btnLogin);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.txtUsername);
      this.Controls.Add(this.lblMatKhau);
      this.Controls.Add(this.lblTenDangNhap);
      this.Controls.Add(this.lblDangNhapQuanLyThuVien);
      this.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "FormDangNhap";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ĐĂNG NHẬP";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    private void btnLogin_MouseEnter(object sender, EventArgs e)
    {
      btnLogin.BackColor = System.Drawing.Color.Green;
    }

    private void btnLogin_MouseLeave(object sender, EventArgs e)
    {
      btnLogin.BackColor = System.Drawing.Color.DarkGreen;
    }

    #endregion

    private System.Windows.Forms.Label lblDangNhapQuanLyThuVien;
    private System.Windows.Forms.Label lblTenDangNhap;
    private System.Windows.Forms.Label lblMatKhau;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.CheckBox chkShowPassword;
  }
}


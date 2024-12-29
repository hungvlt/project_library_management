using System;
using System.Windows.Forms;

namespace QLThuVien_2
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtUsername = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.btnLogin = new System.Windows.Forms.Button();
      this.chkShowPassword = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
      this.label1.ForeColor = System.Drawing.Color.DarkBlue;
      this.label1.Location = new System.Drawing.Point(53, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(322, 32);
      this.label1.TabIndex = 0;
      this.label1.Text = "Đăng nhập Quản lý thư viện";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(21, 89);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(111, 21);
      this.label2.TabIndex = 1;
      this.label2.Text = "Tên đăng nhập";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(21, 137);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(75, 21);
      this.label3.TabIndex = 1;
      this.label3.Text = "Mật khẩu";
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
      this.btnLogin.Size = new System.Drawing.Size(100, 31);
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
      this.ClientSize = new System.Drawing.Size(429, 265);
      this.Controls.Add(this.chkShowPassword);
      this.Controls.Add(this.btnLogin);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.txtUsername);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "FormDangNhap";
      this.Text = "Đăng Nhập";
      this.Load += new System.EventHandler(this.FormDangNhap_Load);
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

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.CheckBox chkShowPassword;
  }
}


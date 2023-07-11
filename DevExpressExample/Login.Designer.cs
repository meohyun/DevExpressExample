﻿
namespace DevExpressExample
{
    partial class Login
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IdBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LoginBtn = new DevExpress.XtraEditors.SimpleButton();
            this.UserCreate = new DevExpress.XtraEditors.LabelControl();
            this.FindPassword = new DevExpress.XtraEditors.LabelControl();
            this.WrongTxt = new DevExpress.XtraEditors.LabelControl();
            this.IdLabel = new DevExpress.XtraEditors.LabelControl();
            this.PasswordLabel = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // IdBox
            // 
            this.IdBox.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdBox.Location = new System.Drawing.Point(403, 266);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(491, 40);
            this.IdBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(403, 362);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(491, 40);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(267, 266);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 34);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "아이디 : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(243, 362);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(124, 34);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "비밀번호 : ";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Appearance.Options.UseFont = true;
            this.LoginBtn.Location = new System.Drawing.Point(494, 567);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(190, 60);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "로그인";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // UserCreate
            // 
            this.UserCreate.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCreate.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UserCreate.Appearance.Options.UseFont = true;
            this.UserCreate.Appearance.Options.UseForeColor = true;
            this.UserCreate.Location = new System.Drawing.Point(480, 489);
            this.UserCreate.Name = "UserCreate";
            this.UserCreate.Size = new System.Drawing.Size(64, 24);
            this.UserCreate.TabIndex = 5;
            this.UserCreate.Text = "회원가입";
            this.UserCreate.Click += new System.EventHandler(this.UserCreate_Click);
            // 
            // FindPassword
            // 
            this.FindPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindPassword.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FindPassword.Appearance.Options.UseFont = true;
            this.FindPassword.Appearance.Options.UseForeColor = true;
            this.FindPassword.Location = new System.Drawing.Point(624, 489);
            this.FindPassword.Name = "FindPassword";
            this.FindPassword.Size = new System.Drawing.Size(158, 24);
            this.FindPassword.TabIndex = 6;
            this.FindPassword.Text = "아이디/비밀번호 찾기";
            this.FindPassword.Click += new System.EventHandler(this.FindPassword_Click);
            // 
            // WrongTxt
            // 
            this.WrongTxt.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongTxt.Appearance.ForeColor = System.Drawing.Color.Red;
            this.WrongTxt.Appearance.Options.UseFont = true;
            this.WrongTxt.Appearance.Options.UseForeColor = true;
            this.WrongTxt.Location = new System.Drawing.Point(394, 449);
            this.WrongTxt.Name = "WrongTxt";
            this.WrongTxt.Size = new System.Drawing.Size(0, 33);
            this.WrongTxt.TabIndex = 7;
            // 
            // IdLabel
            // 
            this.IdLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.IdLabel.Appearance.Options.UseFont = true;
            this.IdLabel.Appearance.Options.UseForeColor = true;
            this.IdLabel.Location = new System.Drawing.Point(412, 312);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(0, 28);
            this.IdLabel.TabIndex = 8;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.PasswordLabel.Appearance.Options.UseFont = true;
            this.PasswordLabel.Appearance.Options.UseForeColor = true;
            this.PasswordLabel.Location = new System.Drawing.Point(412, 408);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(0, 28);
            this.PasswordLabel.TabIndex = 9;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 821);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.WrongTxt);
            this.Controls.Add(this.FindPassword);
            this.Controls.Add(this.UserCreate);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.IdBox);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton LoginBtn;
        private DevExpress.XtraEditors.LabelControl UserCreate;
        private DevExpress.XtraEditors.LabelControl FindPassword;
        private DevExpress.XtraEditors.LabelControl WrongTxt;
        private DevExpress.XtraEditors.LabelControl IdLabel;
        private DevExpress.XtraEditors.LabelControl PasswordLabel;
    }
}

namespace DevExpressExample
{
    partial class UserCreate
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.repasswordBox = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.createBtn = new DevExpress.XtraEditors.SimpleButton();
            this.clearBtn = new DevExpress.XtraEditors.SimpleButton();
            this.NameLabel = new DevExpress.XtraEditors.LabelControl();
            this.EmailLabel = new DevExpress.XtraEditors.LabelControl();
            this.IdLabel = new DevExpress.XtraEditors.LabelControl();
            this.PasswordLabel = new DevExpress.XtraEditors.LabelControl();
            this.repasswordLabel = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(208, 130);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(508, 35);
            this.nameBox.TabIndex = 0;
            this.nameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(208, 197);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(508, 35);
            this.emailBox.TabIndex = 1;
            this.emailBox.TextChanged += new System.EventHandler(this.EmailBox_TextChanged);
            // 
            // idBox
            // 
            this.idBox.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.Location = new System.Drawing.Point(208, 263);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(508, 35);
            this.idBox.TabIndex = 2;
            this.idBox.TextChanged += new System.EventHandler(this.IdBox_TextChanged);
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(208, 334);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(508, 35);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.TextChanged += new System.EventHandler(this.PasswordTxt_TextChanged);
            // 
            // repasswordBox
            // 
            this.repasswordBox.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repasswordBox.Location = new System.Drawing.Point(208, 403);
            this.repasswordBox.Name = "repasswordBox";
            this.repasswordBox.Size = new System.Drawing.Size(508, 35);
            this.repasswordBox.TabIndex = 4;
            this.repasswordBox.TextChanged += new System.EventHandler(this.RePasswordTxt_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(136, 130);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 29);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "이름 : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(115, 197);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 29);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "이메일 : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(115, 263);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 29);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "아이디 : ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(94, 337);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(108, 29);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "비밀번호 : ";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(23, 403);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(179, 29);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "비밀번호 재입력 : ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(321, 37);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(112, 40);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "회원가입";
            // 
            // createBtn
            // 
            this.createBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Appearance.Options.UseFont = true;
            this.createBtn.Location = new System.Drawing.Point(154, 489);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(194, 54);
            this.createBtn.TabIndex = 11;
            this.createBtn.Text = "가입하기";
            this.createBtn.Click += new System.EventHandler(this.UserCreateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Appearance.Options.UseFont = true;
            this.clearBtn.Location = new System.Drawing.Point(419, 489);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(194, 54);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "정보 초기화";
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.NameLabel.Appearance.Options.UseFont = true;
            this.NameLabel.Appearance.Options.UseForeColor = true;
            this.NameLabel.Location = new System.Drawing.Point(208, 171);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(0, 24);
            this.NameLabel.TabIndex = 13;
            // 
            // EmailLabel
            // 
            this.EmailLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.EmailLabel.Appearance.Options.UseFont = true;
            this.EmailLabel.Appearance.Options.UseForeColor = true;
            this.EmailLabel.Location = new System.Drawing.Point(208, 238);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(0, 24);
            this.EmailLabel.TabIndex = 14;
            // 
            // IdLabel
            // 
            this.IdLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.IdLabel.Appearance.Options.UseFont = true;
            this.IdLabel.Appearance.Options.UseForeColor = true;
            this.IdLabel.Location = new System.Drawing.Point(208, 304);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(0, 24);
            this.IdLabel.TabIndex = 15;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.PasswordLabel.Appearance.Options.UseFont = true;
            this.PasswordLabel.Appearance.Options.UseForeColor = true;
            this.PasswordLabel.Location = new System.Drawing.Point(208, 375);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(0, 24);
            this.PasswordLabel.TabIndex = 16;
            // 
            // repasswordLabel
            // 
            this.repasswordLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repasswordLabel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.repasswordLabel.Appearance.Options.UseFont = true;
            this.repasswordLabel.Appearance.Options.UseForeColor = true;
            this.repasswordLabel.Location = new System.Drawing.Point(208, 444);
            this.repasswordLabel.Name = "repasswordLabel";
            this.repasswordLabel.Size = new System.Drawing.Size(0, 24);
            this.repasswordLabel.TabIndex = 17;
            // 
            // UserCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 595);
            this.Controls.Add(this.repasswordLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.repasswordBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.nameBox);
            this.Name = "UserCreate";
            this.Text = "UserCreate";
            this.Load += new System.EventHandler(this.UserCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox repasswordBox;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton createBtn;
        private DevExpress.XtraEditors.SimpleButton clearBtn;
        private DevExpress.XtraEditors.LabelControl NameLabel;
        private DevExpress.XtraEditors.LabelControl EmailLabel;
        private DevExpress.XtraEditors.LabelControl IdLabel;
        private DevExpress.XtraEditors.LabelControl PasswordLabel;
        private DevExpress.XtraEditors.LabelControl repasswordLabel;
    }
}
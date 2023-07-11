
namespace DevExpressExample
{
    partial class FindId
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
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.EmailLabel = new DevExpress.XtraEditors.LabelControl();
            this.NameLabel = new DevExpress.XtraEditors.LabelControl();
            this.FindIdBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.IdLabelTxt = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.IdTxtBox = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.NameLabelTxt = new DevExpress.XtraEditors.LabelControl();
            this.FindPasswordBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Location = new System.Drawing.Point(33, 39);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(821, 463);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(821, 463);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "tabNavigationPage1";
            this.tabNavigationPage1.Controls.Add(this.EmailLabel);
            this.tabNavigationPage1.Controls.Add(this.NameLabel);
            this.tabNavigationPage1.Controls.Add(this.FindIdBtn);
            this.tabNavigationPage1.Controls.Add(this.labelControl2);
            this.tabNavigationPage1.Controls.Add(this.labelControl1);
            this.tabNavigationPage1.Controls.Add(this.EmailBox);
            this.tabNavigationPage1.Controls.Add(this.NameBox);
            this.tabNavigationPage1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.PageText = "아이디 찾기";
            this.tabNavigationPage1.Size = new System.Drawing.Size(821, 427);
            // 
            // EmailLabel
            // 
            this.EmailLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.EmailLabel.Appearance.Options.UseFont = true;
            this.EmailLabel.Appearance.Options.UseForeColor = true;
            this.EmailLabel.Location = new System.Drawing.Point(326, 278);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(0, 28);
            this.EmailLabel.TabIndex = 6;
            // 
            // NameLabel
            // 
            this.NameLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.NameLabel.Appearance.Options.UseFont = true;
            this.NameLabel.Appearance.Options.UseForeColor = true;
            this.NameLabel.Location = new System.Drawing.Point(326, 162);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(0, 28);
            this.NameLabel.TabIndex = 5;
            // 
            // FindIdBtn
            // 
            this.FindIdBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindIdBtn.Appearance.Options.UseFont = true;
            this.FindIdBtn.Location = new System.Drawing.Point(372, 336);
            this.FindIdBtn.Name = "FindIdBtn";
            this.FindIdBtn.Size = new System.Drawing.Size(143, 48);
            this.FindIdBtn.TabIndex = 4;
            this.FindIdBtn.Text = "아이디 찾기";
            this.FindIdBtn.Click += new System.EventHandler(this.FindIdBtn_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(149, 238);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 34);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "이메일 : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(173, 112);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 34);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "이름 : ";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(312, 228);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(326, 44);
            this.EmailBox.TabIndex = 1;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(312, 112);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(326, 44);
            this.NameBox.TabIndex = 0;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "tabNavigationPage2";
            this.tabNavigationPage2.Controls.Add(this.IdLabelTxt);
            this.tabNavigationPage2.Controls.Add(this.labelControl8);
            this.tabNavigationPage2.Controls.Add(this.IdTxtBox);
            this.tabNavigationPage2.Controls.Add(this.labelControl3);
            this.tabNavigationPage2.Controls.Add(this.NameLabelTxt);
            this.tabNavigationPage2.Controls.Add(this.FindPasswordBtn);
            this.tabNavigationPage2.Controls.Add(this.labelControl5);
            this.tabNavigationPage2.Controls.Add(this.labelControl6);
            this.tabNavigationPage2.Controls.Add(this.EmailTxtBox);
            this.tabNavigationPage2.Controls.Add(this.NameTxtBox);
            this.tabNavigationPage2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.PageText = "비밀번호 찾기";
            this.tabNavigationPage2.Size = new System.Drawing.Size(821, 427);
            // 
            // IdLabelTxt
            // 
            this.IdLabelTxt.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabelTxt.Appearance.ForeColor = System.Drawing.Color.Red;
            this.IdLabelTxt.Appearance.Options.UseFont = true;
            this.IdLabelTxt.Appearance.Options.UseForeColor = true;
            this.IdLabelTxt.Location = new System.Drawing.Point(327, 144);
            this.IdLabelTxt.Name = "IdLabelTxt";
            this.IdLabelTxt.Size = new System.Drawing.Size(0, 28);
            this.IdLabelTxt.TabIndex = 16;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(188, 96);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(100, 34);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "아이디 : ";
            // 
            // IdTxtBox
            // 
            this.IdTxtBox.Location = new System.Drawing.Point(316, 98);
            this.IdTxtBox.Name = "IdTxtBox";
            this.IdTxtBox.Size = new System.Drawing.Size(326, 40);
            this.IdTxtBox.TabIndex = 14;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(327, 309);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(0, 28);
            this.labelControl3.TabIndex = 13;
            // 
            // NameLabelTxt
            // 
            this.NameLabelTxt.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabelTxt.Appearance.ForeColor = System.Drawing.Color.Red;
            this.NameLabelTxt.Appearance.Options.UseFont = true;
            this.NameLabelTxt.Appearance.Options.UseForeColor = true;
            this.NameLabelTxt.Location = new System.Drawing.Point(327, 224);
            this.NameLabelTxt.Name = "NameLabelTxt";
            this.NameLabelTxt.Size = new System.Drawing.Size(0, 28);
            this.NameLabelTxt.TabIndex = 12;
            // 
            // FindPasswordBtn
            // 
            this.FindPasswordBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindPasswordBtn.Appearance.Options.UseFont = true;
            this.FindPasswordBtn.Location = new System.Drawing.Point(371, 364);
            this.FindPasswordBtn.Name = "FindPasswordBtn";
            this.FindPasswordBtn.Size = new System.Drawing.Size(143, 48);
            this.FindPasswordBtn.TabIndex = 11;
            this.FindPasswordBtn.Text = "비밀번호 찾기";
            this.FindPasswordBtn.Click += new System.EventHandler(this.FindPasswordBtn_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(188, 261);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(100, 34);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "이메일 : ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(212, 178);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(76, 34);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "이름 : ";
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Location = new System.Drawing.Point(316, 263);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(326, 40);
            this.EmailTxtBox.TabIndex = 8;
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(316, 178);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(326, 40);
            this.NameTxtBox.TabIndex = 7;
            // 
            // FindId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 542);
            this.Controls.Add(this.tabPane1);
            this.Name = "FindId";
            this.Text = "FindPassword";
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraEditors.SimpleButton FindIdBtn;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox NameBox;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraEditors.LabelControl EmailLabel;
        private DevExpress.XtraEditors.LabelControl NameLabel;
        private DevExpress.XtraEditors.LabelControl IdLabelTxt;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.TextBox IdTxtBox;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl NameLabelTxt;
        private DevExpress.XtraEditors.SimpleButton FindPasswordBtn;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.TextBox NameTxtBox;
    }
}
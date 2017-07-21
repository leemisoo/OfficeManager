namespace officeManager
{
    partial class officeLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(officeLoginForm));
            this.pictureEditLogin = new DevExpress.XtraEditors.PictureEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.labelControlPassword = new DevExpress.XtraEditors.LabelControl();
            this.labelControlLogin = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.chkAutoLogin = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chkPassSave = new DevExpress.XtraEditors.CheckEdit();
            this.chkIDSave = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutoLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkPassSave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIDSave.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEditLogin
            // 
            this.pictureEditLogin.EditValue = global::officeManager.Properties.Resources.login_logo;
            this.pictureEditLogin.Location = new System.Drawing.Point(20, 20);
            this.pictureEditLogin.Name = "pictureEditLogin";
            this.pictureEditLogin.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditLogin.Size = new System.Drawing.Size(543, 166);
            this.pictureEditLogin.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(345, 214);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(79, 51);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "OK";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelControlPassword
            // 
            this.labelControlPassword.Location = new System.Drawing.Point(173, 245);
            this.labelControlPassword.Name = "labelControlPassword";
            this.labelControlPassword.Size = new System.Drawing.Size(51, 14);
            this.labelControlPassword.TabIndex = 16;
            this.labelControlPassword.Text = "Password";
            // 
            // labelControlLogin
            // 
            this.labelControlLogin.Location = new System.Drawing.Point(173, 220);
            this.labelControlLogin.Name = "labelControlLogin";
            this.labelControlLogin.Size = new System.Drawing.Size(45, 14);
            this.labelControlLogin.TabIndex = 14;
            this.labelControlLogin.Text = "Login ID";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(351, 315);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowMenu = false;
            this.pictureEdit1.Size = new System.Drawing.Size(187, 44);
            this.pictureEdit1.TabIndex = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(54, 333);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(131, 14);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Copyright © 1998-2013";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(234, 214);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 22);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(234, 243);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
            // 
            // chkAutoLogin
            // 
            this.chkAutoLogin.Location = new System.Drawing.Point(172, 5);
            this.chkAutoLogin.Name = "chkAutoLogin";
            this.chkAutoLogin.Properties.Caption = "전체 저장";
            this.chkAutoLogin.Size = new System.Drawing.Size(77, 19);
            this.chkAutoLogin.TabIndex = 4;
            this.chkAutoLogin.CheckedChanged += new System.EventHandler(this.chkAutoLogin_CheckedChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.chkAutoLogin);
            this.panelControl1.Controls.Add(this.chkPassSave);
            this.panelControl1.Controls.Add(this.chkIDSave);
            this.panelControl1.Location = new System.Drawing.Point(172, 273);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(252, 30);
            this.panelControl1.TabIndex = 9;
            // 
            // chkPassSave
            // 
            this.chkPassSave.Location = new System.Drawing.Point(84, 5);
            this.chkPassSave.Name = "chkPassSave";
            this.chkPassSave.Properties.Caption = "암호 저장";
            this.chkPassSave.Size = new System.Drawing.Size(77, 19);
            this.chkPassSave.TabIndex = 3;
            this.chkPassSave.CheckedChanged += new System.EventHandler(this.chkPassSave_CheckedChanged);
            // 
            // chkIDSave
            // 
            this.chkIDSave.Location = new System.Drawing.Point(10, 5);
            this.chkIDSave.Name = "chkIDSave";
            this.chkIDSave.Properties.Caption = "ID 저장";
            this.chkIDSave.Size = new System.Drawing.Size(66, 19);
            this.chkIDSave.TabIndex = 2;
            this.chkIDSave.CheckedChanged += new System.EventHandler(this.chkIDSave_CheckedChanged);
            // 
            // officeLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labelControlPassword);
            this.Controls.Add(this.labelControlLogin);
            this.Controls.Add(this.pictureEditLogin);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "officeLoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "회원관리 프로그램 Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutoLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkPassSave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIDSave.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEditLogin;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.LabelControl labelControlPassword;
        private DevExpress.XtraEditors.LabelControl labelControlLogin;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private DevExpress.XtraEditors.CheckEdit chkAutoLogin;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.CheckEdit chkPassSave;
        private DevExpress.XtraEditors.CheckEdit chkIDSave;
        //private System.Windows.Forms.Timer loginTimer;
    }
}
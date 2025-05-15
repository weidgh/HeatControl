namespace Zyh.DDSApp
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.cmb_LoginName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Pwd = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Close = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_LoginName
            // 
            this.cmb_LoginName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(31)))), ((int)(((byte)(105)))));
            this.cmb_LoginName.ForeColor = System.Drawing.Color.White;
            this.cmb_LoginName.FormattingEnabled = true;
            this.cmb_LoginName.Location = new System.Drawing.Point(136, 138);
            this.cmb_LoginName.Name = "cmb_LoginName";
            this.cmb_LoginName.Size = new System.Drawing.Size(193, 34);
            this.cmb_LoginName.TabIndex = 1;
            this.cmb_LoginName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Common_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(163, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "系统登录";
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(31)))), ((int)(((byte)(105)))));
            this.txt_Pwd.ForeColor = System.Drawing.Color.White;
            this.txt_Pwd.Location = new System.Drawing.Point(136, 179);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.PasswordChar = '*';
            this.txt_Pwd.Size = new System.Drawing.Size(193, 34);
            this.txt_Pwd.TabIndex = 2;
            this.txt_Pwd.Text = "123";
            this.txt_Pwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Common_KeyDown);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(31)))), ((int)(((byte)(105)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(164, 219);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(138, 34);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "登       录";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_Close
            // 
            this.lbl_Close.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Close.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Close.Location = new System.Drawing.Point(391, 9);
            this.lbl_Close.Name = "lbl_Close";
            this.lbl_Close.Size = new System.Drawing.Size(33, 31);
            this.lbl_Close.TabIndex = 4;
            this.lbl_Close.Text = "X";
            this.lbl_Close.Click += new System.EventHandler(this.lbl_Close_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zyh.DDSApp.Properties.Resources.Login;
            this.ClientSize = new System.Drawing.Size(436, 325);
            this.Controls.Add(this.lbl_Close);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Pwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_LoginName);
            this.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登录";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_LoginName;
        private System.Windows.Forms.TextBox txt_Pwd;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Close;
    }
}
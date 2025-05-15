namespace Zyh.DDSApp
{
    partial class FrmParamSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParamSet));
            this.Mainpanel = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.txt_Slot = new System.Windows.Forms.TextBox();
            this.txt_Rack = new System.Windows.Forms.TextBox();
            this.cmb_CPUType = new System.Windows.Forms.ComboBox();
            this.txt_IPAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.lbl_Close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Mainpanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Mainpanel
            // 
            this.Mainpanel.BackColor = System.Drawing.Color.Navy;
            this.Mainpanel.Controls.Add(this.btn_Cancel);
            this.Mainpanel.Controls.Add(this.btn_OK);
            this.Mainpanel.Controls.Add(this.txt_Slot);
            this.Mainpanel.Controls.Add(this.txt_Rack);
            this.Mainpanel.Controls.Add(this.cmb_CPUType);
            this.Mainpanel.Controls.Add(this.txt_IPAddress);
            this.Mainpanel.Controls.Add(this.label6);
            this.Mainpanel.Controls.Add(this.label5);
            this.Mainpanel.Controls.Add(this.label4);
            this.Mainpanel.Controls.Add(this.label3);
            this.Mainpanel.Controls.Add(this.TopPanel);
            this.Mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mainpanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Mainpanel.Location = new System.Drawing.Point(0, 0);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Padding = new System.Windows.Forms.Padding(2);
            this.Mainpanel.Size = new System.Drawing.Size(513, 384);
            this.Mainpanel.TabIndex = 0;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.BackgroundImage = global::Zyh.DDSApp.Properties.Resources.Red;
            this.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_Cancel.Location = new System.Drawing.Point(303, 312);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(110, 47);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "取消设置";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.Transparent;
            this.btn_OK.BackgroundImage = global::Zyh.DDSApp.Properties.Resources.Green;
            this.btn_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_OK.Location = new System.Drawing.Point(99, 312);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(110, 47);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "保存设置";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            this.btn_OK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.btn_OK.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // txt_Slot
            // 
            this.txt_Slot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_Slot.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Slot.Location = new System.Drawing.Point(220, 255);
            this.txt_Slot.Name = "txt_Slot";
            this.txt_Slot.Size = new System.Drawing.Size(183, 34);
            this.txt_Slot.TabIndex = 3;
            // 
            // txt_Rack
            // 
            this.txt_Rack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_Rack.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Rack.Location = new System.Drawing.Point(220, 193);
            this.txt_Rack.Name = "txt_Rack";
            this.txt_Rack.Size = new System.Drawing.Size(183, 34);
            this.txt_Rack.TabIndex = 2;
            // 
            // cmb_CPUType
            // 
            this.cmb_CPUType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_CPUType.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_CPUType.FormattingEnabled = true;
            this.cmb_CPUType.Location = new System.Drawing.Point(220, 132);
            this.cmb_CPUType.Name = "cmb_CPUType";
            this.cmb_CPUType.Size = new System.Drawing.Size(183, 34);
            this.cmb_CPUType.TabIndex = 1;
            // 
            // txt_IPAddress
            // 
            this.txt_IPAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_IPAddress.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_IPAddress.Location = new System.Drawing.Point(220, 79);
            this.txt_IPAddress.Name = "txt_IPAddress";
            this.txt_IPAddress.Size = new System.Drawing.Size(183, 34);
            this.txt_IPAddress.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(87, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "插槽号：";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(87, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "机架号：";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(72, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "CPU类型：";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(87, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "IP地址：";
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.lbl_Close);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(2, 2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(509, 55);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // lbl_Close
            // 
            this.lbl_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Close.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Close.Location = new System.Drawing.Point(466, 10);
            this.lbl_Close.Name = "lbl_Close";
            this.lbl_Close.Size = new System.Drawing.Size(33, 31);
            this.lbl_Close.TabIndex = 2;
            this.lbl_Close.Text = "X";
            this.lbl_Close.Click += new System.EventHandler(this.lbl_Close_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(70, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "参数设置";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zyh.DDSApp.Properties.Resources.Param;
            this.pictureBox1.Location = new System.Drawing.Point(24, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmParamSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(513, 384);
            this.Controls.Add(this.Mainpanel);
            this.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmParamSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "上位机通信设置";
            this.Mainpanel.ResumeLayout(false);
            this.Mainpanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Mainpanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Slot;
        private System.Windows.Forms.TextBox txt_Rack;
        private System.Windows.Forms.ComboBox cmb_CPUType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox txt_IPAddress;
    }
}
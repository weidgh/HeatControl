namespace thinger.HeatingCustomControls
{
    partial class ThingerHCValve
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.plc_Valve = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plc_Valve)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Status);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.plc_Valve);
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Size = new System.Drawing.Size(66, 110);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbl_Status
            // 
            this.lbl_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Status.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Status.ForeColor = System.Drawing.Color.White;
            this.lbl_Status.Location = new System.Drawing.Point(0, 0);
            this.lbl_Status.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(66, 25);
            this.lbl_Status.TabIndex = 0;
            this.lbl_Status.Text = "已关闭";
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plc_Valve
            // 
            this.plc_Valve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.plc_Valve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plc_Valve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plc_Valve.Image = global::thinger.HeatingCustomControls.Properties.Resources.阀门Close;
            this.plc_Valve.Location = new System.Drawing.Point(0, 0);
            this.plc_Valve.Name = "plc_Valve";
            this.plc_Valve.Size = new System.Drawing.Size(66, 84);
            this.plc_Valve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plc_Valve.TabIndex = 0;
            this.plc_Valve.TabStop = false;
            this.plc_Valve.DoubleClick += new System.EventHandler(this.plc_Valve_DoubleClick);
            // 
            // ThingerHCValve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ThingerHCValve";
            this.Size = new System.Drawing.Size(66, 110);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plc_Valve)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.PictureBox plc_Valve;
    }
}

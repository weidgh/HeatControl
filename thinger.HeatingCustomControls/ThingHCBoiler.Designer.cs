namespace thinger.HeatingCustomControls
{
    partial class ThingHCBoiler
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
            this.plc_Boiler = new System.Windows.Forms.PictureBox();
            this.thingerWave1 = new thinger.CommonControlLib.thingerWave();
            this.lacel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.plc_Boiler)).BeginInit();
            this.SuspendLayout();
            // 
            // plc_Boiler
            // 
            this.plc_Boiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plc_Boiler.Image = global::thinger.HeatingCustomControls.Properties.Resources.锅炉Stop;
            this.plc_Boiler.Location = new System.Drawing.Point(0, 0);
            this.plc_Boiler.Name = "plc_Boiler";
            this.plc_Boiler.Size = new System.Drawing.Size(93, 197);
            this.plc_Boiler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.plc_Boiler.TabIndex = 0;
            this.plc_Boiler.TabStop = false;
            // 
            // thingerWave1
            // 
            this.thingerWave1.BackColor = System.Drawing.Color.Blue;
            this.thingerWave1.ConerRadius = 10;
            this.thingerWave1.FillColor = System.Drawing.Color.Transparent;
            this.thingerWave1.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 15F, System.Drawing.FontStyle.Bold);
            this.thingerWave1.ForeColor = System.Drawing.Color.Black;
            this.thingerWave1.IsRadius = true;
            this.thingerWave1.IsRectangle = true;
            this.thingerWave1.IsShowRect = false;
            this.thingerWave1.Location = new System.Drawing.Point(8, 77);
            this.thingerWave1.MaxValue = 100;
            this.thingerWave1.Name = "thingerWave1";
            this.thingerWave1.RectColor = System.Drawing.Color.White;
            this.thingerWave1.RectWidth = 4;
            this.thingerWave1.Size = new System.Drawing.Size(77, 92);
            this.thingerWave1.TabIndex = 2;
            this.thingerWave1.Value = 0;
            this.thingerWave1.ValueColor = System.Drawing.Color.Lime;
            // 
            // lacel1
            // 
            this.lacel1.BackColor = System.Drawing.Color.Cyan;
            this.lacel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lacel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lacel1.ForeColor = System.Drawing.Color.Red;
            this.lacel1.Location = new System.Drawing.Point(8, 38);
            this.lacel1.Name = "lacel1";
            this.lacel1.Size = new System.Drawing.Size(77, 38);
            this.lacel1.TabIndex = 1;
            this.lacel1.Text = "水位计";
            this.lacel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThingHCBoiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.thingerWave1);
            this.Controls.Add(this.lacel1);
            this.Controls.Add(this.plc_Boiler);
            this.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 15F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ThingHCBoiler";
            this.Size = new System.Drawing.Size(93, 197);
            ((System.ComponentModel.ISupportInitialize)(this.plc_Boiler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox plc_Boiler;
        private CommonControlLib.thingerWave thingerWave1;
        private System.Windows.Forms.Label lacel1;
    }
}

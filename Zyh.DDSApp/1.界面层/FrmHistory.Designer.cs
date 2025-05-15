namespace Zyh.DDSApp
{
    partial class FrmHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistory));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.lbl_Close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.btn_Query = new System.Windows.Forms.Button();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.InsertTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PressureIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PressureOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelTank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempBoiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelBoiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PressureBoiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.lbl_Close);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.pictureBox2);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(2, 2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1022, 55);
            this.TopPanel.TabIndex = 18;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // lbl_Close
            // 
            this.lbl_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Close.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Close.Location = new System.Drawing.Point(975, 13);
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
            this.label1.Text = "历史查询";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Zyh.DDSApp.Properties.Resources.device;
            this.pictureBox2.Location = new System.Drawing.Point(24, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(33, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "开始时间：";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(446, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "结束时间：";
            // 
            // dtp_Start
            // 
            this.dtp_Start.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Start.Location = new System.Drawing.Point(166, 91);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(229, 30);
            this.dtp_Start.TabIndex = 20;
            // 
            // dtp_End
            // 
            this.dtp_End.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End.Location = new System.Drawing.Point(588, 91);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(229, 30);
            this.dtp_End.TabIndex = 21;
            // 
            // btn_Query
            // 
            this.btn_Query.BackColor = System.Drawing.Color.Transparent;
            this.btn_Query.BackgroundImage = global::Zyh.DDSApp.Properties.Resources.Green;
            this.btn_Query.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Query.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Query.FlatAppearance.BorderSize = 0;
            this.btn_Query.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Query.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Query.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Query.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 55 Regular", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Query.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_Query.Location = new System.Drawing.Point(876, 80);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(110, 47);
            this.btn_Query.TabIndex = 5;
            this.btn_Query.Text = "查询数据";
            this.btn_Query.UseVisualStyleBackColor = false;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // dgv_Data
            // 
            this.dgv_Data.AllowUserToAddRows = false;
            this.dgv_Data.AllowUserToDeleteRows = false;
            this.dgv_Data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(30)))), ((int)(((byte)(103)))));
            this.dgv_Data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 65 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InsertTime,
            this.PressureIn,
            this.PressureOut,
            this.TempIn,
            this.TempOut,
            this.LevelTank,
            this.TempBoiler,
            this.LevelBoiler,
            this.PressureBoiler});
            this.dgv_Data.EnableHeadersVisualStyles = false;
            this.dgv_Data.Location = new System.Drawing.Point(18, 133);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.ReadOnly = true;
            this.dgv_Data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 65 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Data.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Data.RowHeadersWidth = 45;
            this.dgv_Data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Data.RowTemplate.Height = 35;
            this.dgv_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Data.Size = new System.Drawing.Size(996, 587);
            this.dgv_Data.TabIndex = 22;
            this.dgv_Data.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_Data_RowPostPaint);
            // 
            // InsertTime
            // 
            this.InsertTime.DataPropertyName = "InsertTime";
            this.InsertTime.HeaderText = "时间日期";
            this.InsertTime.Name = "InsertTime";
            this.InsertTime.ReadOnly = true;
            this.InsertTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.InsertTime.Width = 190;
            // 
            // PressureIn
            // 
            this.PressureIn.DataPropertyName = "PressureIn";
            this.PressureIn.HeaderText = "进口压力";
            this.PressureIn.Name = "PressureIn";
            this.PressureIn.ReadOnly = true;
            this.PressureIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PressureIn.Width = 95;
            // 
            // PressureOut
            // 
            this.PressureOut.DataPropertyName = "PressureOut";
            this.PressureOut.HeaderText = "出口压力";
            this.PressureOut.Name = "PressureOut";
            this.PressureOut.ReadOnly = true;
            this.PressureOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PressureOut.Width = 95;
            // 
            // TempIn
            // 
            this.TempIn.DataPropertyName = "TempIn";
            this.TempIn.HeaderText = "进口温度";
            this.TempIn.Name = "TempIn";
            this.TempIn.ReadOnly = true;
            this.TempIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TempIn.Width = 95;
            // 
            // TempOut
            // 
            this.TempOut.DataPropertyName = "TempOut";
            this.TempOut.HeaderText = "出口温度";
            this.TempOut.Name = "TempOut";
            this.TempOut.ReadOnly = true;
            this.TempOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TempOut.Width = 95;
            // 
            // LevelTank
            // 
            this.LevelTank.DataPropertyName = "LevelTank";
            this.LevelTank.HeaderText = "水罐液位";
            this.LevelTank.Name = "LevelTank";
            this.LevelTank.ReadOnly = true;
            this.LevelTank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LevelTank.Width = 95;
            // 
            // TempBoiler
            // 
            this.TempBoiler.DataPropertyName = "TempBoiler";
            this.TempBoiler.HeaderText = "锅炉温度";
            this.TempBoiler.Name = "TempBoiler";
            this.TempBoiler.ReadOnly = true;
            this.TempBoiler.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TempBoiler.Width = 95;
            // 
            // LevelBoiler
            // 
            this.LevelBoiler.DataPropertyName = "LevelBoiler";
            this.LevelBoiler.HeaderText = "锅炉液位";
            this.LevelBoiler.Name = "LevelBoiler";
            this.LevelBoiler.ReadOnly = true;
            this.LevelBoiler.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LevelBoiler.Width = 95;
            // 
            // PressureBoiler
            // 
            this.PressureBoiler.DataPropertyName = "PressureBoiler";
            this.PressureBoiler.HeaderText = "锅炉压力";
            this.PressureBoiler.Name = "PressureBoiler";
            this.PressureBoiler.ReadOnly = true;
            this.PressureBoiler.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PressureBoiler.Width = 95;
            // 
            // FrmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(30)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(1026, 749);
            this.Controls.Add(this.dgv_Data);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.dtp_End);
            this.Controls.Add(this.dtp_Start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("阿里巴巴普惠体 3.0 65 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmHistory";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHistory";
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label lbl_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsertTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PressureIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PressureOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn LevelTank;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempBoiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn LevelBoiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn PressureBoiler;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thinger.HeatingControlProject;

namespace Zyh.DDSApp
{
    public partial class FrmHistory : Form
    {
        public FrmHistory()
        {
            InitializeComponent();

            //初始化时为O
            this.dgv_Data.AutoGenerateColumns = false;

            //显示时间
            this.dgv_Data.Columns[0].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

            //等于当前时间。查询默认当前时间2小时
            this.dtp_Start.Value = DateTime.Now.AddHours(-2.0);
            this.dtp_End.Value = DateTime.Now;
        }

        #region  创建历史查询数据表
        //创建对象
        private SqIDataService sqIService = new SqIDataService();

        private void btn_Query_Click(object sender, EventArgs e)
        {
            TimeSpan timeSpan = this.dtp_End.Value - this.dtp_Start.Value;

            if (timeSpan.TotalSeconds < 0) 
            {
                MessageBox.Show("开始时间不能大于结束时间！", "数据查询");
                return;
            }
            try
            {
                //查询时间得到数据表
                DataTable dataTable = sqIService.GetActualDataByTime(this.dtp_Start.Value, this.dtp_End.Value);

                if (dataTable.Rows.Count > 0)
                {
                    this.dgv_Data.DataSource = null;
                    this.dgv_Data.DataSource = dataTable;
                }

                else 
                {
                    MessageBox.Show("此时间段未查询到数据", "数据查询");
                }
            }

            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "数据查询");
            }            
        }

        #endregion

        #region 自动产生行号
        private void dgv_Data_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewHelper.DgvRowPostPaint(this.dgv_Data, e);
        }

        #endregion

        #region  历史查询 数据表格 关闭
        private void lbl_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 无边框拖动 

        private Point mPoint;
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        #endregion
    }
}

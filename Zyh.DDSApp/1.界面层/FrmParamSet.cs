using S7.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zyh.DDSApp
{
    public partial class FrmParamSet : Form
    {
        public FrmParamSet(Plclnfo plclnfo,string path)
        {
            InitializeComponent();

            this.Plclnfo = plclnfo;
            this.path = path;

            this.cmb_CPUType.DataSource = Enum.GetNames(typeof(CpuType));

            if (this.Plclnfo != null ) 
            {
                this.txt_IPAddress.Text = this.Plclnfo.IPAddress;
                this.cmb_CPUType.Text = this.Plclnfo.CpuType.ToString();
                this.txt_Rack.Text = this.Plclnfo.Rack.ToString();
                this.txt_Slot.Text = this.Plclnfo.Slot.ToString();

            
            }
        }

        /// <summary>
        /// 文件路径
        /// </summary>
        private string path;

        /// <summary>
        /// PLC信息对象
        /// </summary>
        private Plclnfo Plclnfo;


        /// <summary>
        /// PLC信息服务对象
        /// </summary>
        private PlclnfoService infoService = new PlclnfoService();

        /// <summary>
        /// 写入保存设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (this.Plclnfo == null) 
            {
               this.Plclnfo = new Plclnfo();
            }

            this.Plclnfo.IPAddress = this.txt_IPAddress.Text;
            this.Plclnfo.CpuType = (CpuType)Enum.Parse(typeof(CpuType),
            this.cmb_CPUType.Text, true);
            this.Plclnfo.Rack = Convert.ToInt16(this.txt_Rack.Text.Trim());
            this.Plclnfo.Slot = Convert.ToInt16(this.txt_Slot.Text.Trim());

            bool result = infoService.SePlcInfoToPath(this.Plclnfo, this.path);

            if (result) 
            {
             this.DialogResult  = DialogResult.OK;
                MessageBox.Show("PLC参数写入成功", "参数写入");
            }
            else
            {
                MessageBox.Show("PLC参数写入失败", "参数写入");
            }
        }

        /// <summary>
        /// 取消参数设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbl_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

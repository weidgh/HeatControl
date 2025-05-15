using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thinger.HeatingCustomControls
{
    public partial class ThingerHCValve : UserControl
    {
        public ThingerHCValve()
        {
            InitializeComponent();
        }

        private bool isOpen = false;

        [Category("自定义属性")]
        [Description("获取和设置锅炉的状态")]
        public bool IsOpen 
        {
            get {return isOpen; }
            set 
            {
                if (isOpen != value)
                {

                    isOpen = value;

                    if (isOpen) 
                    {
                        this.lbl_Status.Text = "已打开";
                        this.plc_Valve.Image = Properties.Resources.阀门Open;
                    }
                    else
                    {
                        this.lbl_Status.Text = "已关闭";
                        this.plc_Valve.Image = Properties.Resources.阀门Close;
                    }
                }                
            }
        }

        [Category("自定义属性")]
        [Description("双击阀门触发")]
        public event Action<bool> ValveControl;//系统声明委托

        private void plc_Valve_DoubleClick(object sender, EventArgs e)
        {
            if (ValveControl != null) 
            {
                ValveControl(isOpen);
            }
        }
    }
}

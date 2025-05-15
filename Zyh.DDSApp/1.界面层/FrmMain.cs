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
using thinger.CommonControlLib;
using static System.Windows.Forms.AxHost;


namespace Zyh.DDSApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            this.readTimer.Interval = 100;
            this.readTimer.Tick += Readtimer_Tick;
        }

        /// <summary>
        /// 启动时禁止手动启动泵按钮
        /// </summary>
        /// <param name="isEnadble"></param>
        public void EnableBtn(bool isEnadble) 
        {
            this.toggle_SsJk.Enabled = isEnadble;
            this.toggle_AddPump.Enabled = isEnadble;
            this.toggle_Airpump.Enabled = isEnadble;
            this.toggle_Circlepump.Enabled = isEnadble;
            this.toggle_Feedpump.Enabled = isEnadble;
            this.pump_OutState.Enabled = isEnadble;
        }

        #region PLC信息
        /// <summary>
        /// PLC信息
        /// </summary>
        private Plclnfo Plclnfo = new Plclnfo();

        /// <summary>
        /// PLC信息服务对象
        /// </summary>
        private PlclnfoService infoService = new PlclnfoService();

        /// <summary>
        /// PLC数据服务对象
        /// </summary>
        private PlcDataService dataService = new PlcDataService();

        /// <summary>
        /// SQL 数据存储服务对象
        /// </summary>
        private SqIDataService sqlService = new SqIDataService();

        /// <summary>
        /// PLC路径
        /// </summary>
        private string path = Application.StartupPath + "//PLClnfo.ini";

        /// <summary>
        /// 定时器
        /// </summary>
        private Timer readTimer = new Timer();

        /// <summary>
        /// 读取PLC信息配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                this.Plclnfo = infoService.GetPlcInfoByPath(path);
                this.btn_SystemStop.Enabled = false;
                this.btn_SystemStart.Enabled = false;
                this.nuTWarn.Enabled = false;
                this.nuTWarn1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PLC信息加载失败：" + ex.Message, "读取配置");
            }
        }

        /// <summary>
        /// 参数设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ParamSet_Click(object sender, EventArgs e)
        {
            FrmParamSet frmParamSet = new FrmParamSet(this.Plclnfo, this.path);
            frmParamSet.ShowDialog();
            this.btn_SystemStart.Enabled = true;
            this.timer2.Start();
        }
        #endregion

        #region 定时器更新UI
        /// <summary>
        /// 上次存储时间
        /// </summary>
        private DateTime lastTime = DateTime.Now;

        /// <summary>
        /// 定时器更新UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Readtimer_Tick(object sender, EventArgs e)
        {
            try
            {
                PlcData plcData = dataService.GetPLCData();
                UpdateUI(plcData);


                //SQL数据定时存储
                int timeSpan = DateTime.Now.Second - lastTime.Second;

                if (timeSpan == 1 || timeSpan == -59) 
                {
                    sqlService.AddPLCData(plcData);
                }
                //每次记录一次存储一次
                lastTime = DateTime.Now;
            }

            catch (Exception ex)
            {
                this.readTimer.Enabled = false;
                MessageBox.Show(ex.Message, "读取中断");
            }
        }

        #endregion

        #region  UI更新
        /// <summary>
        /// 更新UI
        /// </summary>
        /// <param name="data"></param>
        private void UpdateUI(PlcData data)
        {
            #region  更新状态
            
            //更新状态
            this.pump_FeedState.IsRun = data.FeedPumpState;
            this.Gd1.PipeLineActive = data.FeedPumpState;
            this.Gd2.PipeLineActive = data.FeedPumpState;
            this.Gd3.PipeLineActive = data.FeedPumpState;

            this.pump_AddState.IsRun = data.AddPumpState;
            this.Gd4.PipeLineActive = data.AddPumpState;

            this.pump_CirleState.IsRun = data.AirPumpState;
            this.Gd5.PipeLineActive = data.AirPumpState;

            this.pump_AirState.PumpState = data.CirclePumpState ? 1 : 0;
            this.Gd6.PipeLineActive = data.CirclePumpState ;
            this.Gd7.PipeLineActive = data.CirclePumpState ;
            this.Gd8.PipeLineActive = data.CirclePumpState ;
            this.Gd9.PipeLineActive = data.CirclePumpState ;
            this.Gd10.PipeLineActive = data.CirclePumpState ;
            this.Gd13.PipeLineActive = data.CirclePumpState ;

            this.pump_OutState.IsOpen = data.OutValveState;
            this.Gd11.PipeLineActive = data.OutValveState ;
            this.Gd12.PipeLineActive = data.OutValveState ;

            this.led_SystemState.LedState = data.SystemState ? 1 : 0;

            //更新Label标签
            this.lbl_Templn.Text = data.TempIn.ToString("F1");
            this.lbl_TempOut.Text = data.TempOut.ToString("f1");
            this.lbl_PressureBoiler.Text = data.PressureBoiler.ToString("f1");

            this.lbl_Pressureln.Text = data.PressureIn.ToString("f1") + "Bar";
            this.lbl_Templn2.Text = data.TempIn.ToString("f1") + "℃";
            this.lbl_TempOut2.Text = data.TempOut.ToString("f1") + "℃";
            this.lbl_PressureOut.Text = data.PressureOut.ToString("f1") + "Bar";
            this.lbl_LevelTank.Text = data.LevelTank.ToString("f1") + "%";
            this.lbl_TempBoiler.Text = data.TempBoiler.ToString("f1") + "℃";
            this.lbl_LevelBoiler.Text = data.LevelBoiler.ToString("f1") + "%";
            this.lbl_PressureBoiler2.Text = data.PressureBoiler.ToString("f1") + "Bar";
            this.lbl_Ldyl.Text = data.Ldyl.ToString("f1") + "Bar";
            //更新仪表盘
            this.meter_Pressureln.Value = data.PressureIn;
            this.meter_Templn.Value = data.TempIn;
            this.meter_TempOut.Value = data.TempOut;
            this.meter_PressureOut.Value = data.PressureOut;
            this.meter_LevelTank.Value = data.LevelTank;
            this.meter_TempBoiler.Value = data.TempBoiler;
            this.meter_LevelBoiler.Value = data.LevelBoiler;
            this.meter_PressureBoiler.Value = data.PressureBoiler;
            

            //更新液位
            this.wave_LevelTank.Value = (int)data.LevelTank;
            this.ct_boilerr1.Value = (int)data.LevelBoiler;

            //储水罐液位报警
            if (wave_LevelTank.Value > this.nuTWarn.Value)
            {
                //如果当前值大于报警设定值，则报警为红色颜色
                LED_1.IsWarning = true;
                this.wave_LevelTank.BackColor = Color.Red;
            }
            else 
            {
                //如果当前值小于报警设定值，则回归正常颜色
                LED_1.IsWarning = false;
                this.wave_LevelTank.BackColor = Color.Blue;
            }
            //锅炉液位报警
            if (this.ct_boilerr1.Value > this.nuTWarn1.Value)
            {
                LED_2.IsWarning = true;
                this.toggle_Feedpump.Checked = false;
                this.ct_boilerr1.BackColor = Color.Red;
            }
            else
            {
                LED_2.IsWarning = false;
                this.ct_boilerr1.BackColor = Color.Blue;
            }

            #endregion
        }

        #endregion        

        #region 控制泵启停
        /// <summary>
        /// 出水阀控制
        /// </summary>
        /// <param name="value"></param>
        private void pump_OutState_ValveControl(bool value)
        {
            //提醒 提示   
            string tips = (value ? "关闭" : "打开") + "出水阀门";
            DialogResult dialogResult = MessageBox.Show("是否确定要打开" + tips,tips);


            //if判断，出水阀门是否打开成功，成功就OK
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    //取反/！value属性当前状态
                    dataService.OutValveControl(!value);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("出水阀控制失败：" + ex.Message, "出水阀控制");
                }
            }
        }
       
        /// <summary>
        /// 进水泵控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toggle_Feedpump_CheckedChanged(object sender, EventArgs e)
        {
            //先拿到控件对象
            thingerToggleAdvance toggle = sender as thingerToggleAdvance;

            try
            {
                //然后调用对象，通过值再传控制对象toggle。没有异常，启动OK。
                dataService.FeedpumpControl(toggle.Checked);
            }
            catch (Exception ex)
            {
                toggle.CheckedChanged -= toggle_Feedpump_CheckedChanged;
                toggle.Checked = !toggle.Checked;
                toggle.CheckedChanged += toggle_Feedpump_CheckedChanged;

                MessageBox.Show("进水泵控制失败：" + ex.Message, "进水泵控制");
            }
        }


        /// <summary>
        /// 加水泵控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toggle_AddPump_CheckedChanged(object sender, EventArgs e)
        {
            //先拿到控件对象
            thingerToggleAdvance toggle = sender as thingerToggleAdvance;

            try
            {
                //然后调用对象，通过值再传控制对象toggle。没有异常，启动OK。
                dataService.AddPumpControl(toggle.Checked);
            }
            catch (Exception ex)
            {
                toggle.CheckedChanged -= toggle_AddPump_CheckedChanged;
                toggle.Checked = !toggle.Checked;
                toggle.CheckedChanged += toggle_AddPump_CheckedChanged;

                MessageBox.Show("加水泵控制失败：" + ex.Message, "加水泵控制");
            }
        }


        /// <summary>
        /// 循环泵控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toggle_Airpump_CheckedChanged(object sender, EventArgs e)
        {
            //先拿到控件对象
            thingerToggleAdvance toggle = sender as thingerToggleAdvance;

            try
            {
                //然后调用对象，通过值再传控制对象toggle。没有异常，启动OK。
                dataService.CirclepumpControl(toggle.Checked);
            }
            catch (Exception ex)
            {
                toggle.CheckedChanged -= toggle_Airpump_CheckedChanged;
                toggle.Checked = !toggle.Checked;
                toggle.CheckedChanged += toggle_Airpump_CheckedChanged;

                MessageBox.Show("循环泵控制失败：" + ex.Message, "循环泵控制");
            }
        }

        /// <summary>
        /// 燃气泵
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toggle_Circlepump_CheckedChanged(object sender, EventArgs e)
        {
            //先拿到控件对象
            thingerToggleAdvance toggle = sender as thingerToggleAdvance;

            try
            {
                //然后调用对象，通过值再传控制对象toggle。没有异常，启动OK。
                dataService.AirpumpControl(toggle.Checked);
            }
            catch (Exception ex)
            {
                toggle.CheckedChanged -= toggle_Circlepump_CheckedChanged;
                toggle.Checked = !toggle.Checked;
                toggle.CheckedChanged += toggle_Circlepump_CheckedChanged;

                MessageBox.Show("燃气泵控制失败：" + ex.Message, "燃气泵控制");
            }
        }

        /// <summary>
        /// 实时监控启动信号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toggle_SsJk_CheckedChanged(object sender, EventArgs e)
        {
            //先拿到控件对象
            thingerToggleAdvance toggle = sender as thingerToggleAdvance;

            try
            {
                //然后调用对象，通过值再传控制对象toggle。没有异常，启动OK。
                dataService.SsJkControl(toggle.Checked);
            }
            catch (Exception ex)
            {
                toggle.CheckedChanged -= toggle_SsJk_CheckedChanged;
                toggle.Checked = !toggle.Checked;
                toggle.CheckedChanged += toggle_SsJk_CheckedChanged;

                MessageBox.Show("燃气泵控制失败：" + ex.Message, "燃气泵控制");
            }
        }

        #endregion

        #region 历史查询。弹窗出历史数据查询表
        /// <summary>
        /// 历史查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_History_Click(object sender, EventArgs e)
        {
            new FrmHistory().Show();
        }

        #endregion

        #region  用户管理弹窗   
        /// <summary>
        /// 用户管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_UserManage_Click(object sender, EventArgs e)
        {
            //不是管理员不能打开
            if (Program.CurrentAdmin.RoleName != RoleName.管理员.ToString())
            {
                MessageBox.Show("用户权限不足! 请检查", "用户管理");
                return;
            }

            new FrmUserManage().Show();
        }
        #endregion

        #region  关闭系统
        /// <summary>
        /// 关闭系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region  退出系统弹窗 
        /// <summary>
        /// 退出系统弹窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = new FrmMsgBoxWithAck("是否确认退出系统？", "退出系统").ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                //停止定时器
                this.readTimer.Enabled = false;

                //断开PLC连接
                dataService.DisConnect();
                this.btn_SystemStart.Enabled = true;
                this.btn_SystemStop.Enabled = false;
                this.led_LED.Value = false;
                this.led_PLCState.LedState = 0;

                //将所有的值恢复默认值
                UpdateUI(new PlcData());
            }
            else
            {
                e.Cancel = true;
            }
        }

        #endregion

        #region  启动连接PLC
        /// <summary>
        /// 连接PLC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SystemStart_Click(object sender, EventArgs e)
        {
            try
            {
                //连接PLC
                dataService.Connnect(this.Plclnfo);
                //开启定时器
                this.readTimer.Enabled = true;
                this.nuTWarn.Enabled = true;
                this.nuTWarn1.Enabled = true;

                //禁止使用按钮
                EnableBtn(true);
                this.btn_SystemStart.Enabled = false;
                this.btn_SystemStop.Enabled = true;
                this.led_LED.Value = true;
                this.led_PLCState.LedState = 1;

            }

            catch (Exception ex)
            {
                MessageBox.Show("系统启动失败：" + ex.Message, "系统启动");
            }
        }

        #endregion

        #region   断开PLC通信      
        /// <summary>
        /// 断开PLC通信
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SystemStop_Click(object sender, EventArgs e)
        {
            //恢复初始状态
            this.toggle_SsJk.Checked = false;
            this.toggle_AddPump.Checked = false;
            this.toggle_Airpump.Checked = false;
            this.toggle_Circlepump.Checked = false;
            this.toggle_Feedpump.Checked = false;
            this.pump_AddState.IsRun = false;
            this.pump_FeedState.IsRun = false;
            this.pump_CirleState.IsRun = false;
            this.pump_AirState.PumpState = 0;
            
            //停止定时器
            this.readTimer.Enabled = false;
            //断开PLC连接
            dataService.DisConnect();
            //禁止使用按钮
            EnableBtn(false);            
            this.btn_SystemStart.Enabled = true;
            this.btn_SystemStop.Enabled = false;
            this.led_LED.Value = false;
            this.led_PLCState.LedState = 0;
            this.nuTWarn.Enabled = false;
            this.nuTWarn1.Enabled = false;

            //将所有的值恢复默认值
            UpdateUI(new PlcData());
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

        /// <summary>
        /// 更新UI日期时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.lbl_CurrentTime.Text = DateTime.Now.ToString("yyyy-MM-dd-ddd " +
                "HH:mm:ss:");
        }
    }
}
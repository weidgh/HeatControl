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

namespace Zyh.DDSApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.Load += FrmLogin_Load;
        }

        /// <summary>
        /// 创建一个用户服务对象
        /// </summary>
        private SysAdminService adminService = new SysAdminService();

        /// <summary>
        /// 登录提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            List<SysAdmin> sysAdmins = adminService.QuerySysAdmins();

            if (sysAdmins.Count > 0)
            {
                foreach (var item in sysAdmins)
                {
                    this.cmb_LoginName.Items.Add(item.LoginName);
                }
                this.cmb_LoginName.SelectedIndex = 0;
            }
            else 
            {
                MessageBox.Show("没有可以使用的登录用户，请联系管理员！", "登录提示");
            }
        }

        #region  创建服务对象
       
        private void btn_Login_Click(object sender, EventArgs e)
        {
            //验证数据
            if (this.cmb_LoginName.Text.Trim().Length == 0) 
            {
                MessageBox.Show("请选择登录用户！", "登录提示");
                return;
            }
            if (this.txt_Pwd.Text.Trim().Length == 0) 
            {
                MessageBox.Show("请输入用户密码！", "登录提示");
                return;
            }

            //封装对象
            SysAdmin objAdmin = new SysAdmin()
            {
                LoginName = this.cmb_LoginName.Text.Trim(),
                LoginPwd = this.txt_Pwd.Text.Trim()
            };

            //用户查询
            objAdmin = adminService.AdminLogin(objAdmin);

            //判断结构
            if (objAdmin == null) 
            {
                MessageBox.Show("用户名和密码不正确！", "登录提示");
                return;
            }
            else 
            { 
                this.DialogResult = DialogResult.OK;
                //存储
                Program.CurrentAdmin = objAdmin;
            }
        }

        /// <summary>
        /// 调用按钮事件，快速输入密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Common_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
             this.btn_Login_Click(null, null);
            }
        }

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

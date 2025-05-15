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
    public partial class FrmUserManage : Form
    {
        public FrmUserManage()
        {
            InitializeComponent();

            this.dgv_User.AutoGenerateColumns = false;

            this.Load += FrmUserManage_Load;
        }

        #region  建立全局变量
        //建立用户列表，全局变量 
        private List<SysAdmin> sysAdmins = new List<SysAdmin>();

        //调用方法
        private SysAdminService adminService = new SysAdminService();   


        private void FrmUserManage_Load(object sender, EventArgs e)
        {
            //先绑定
            this.cmb_RoleName.Items.AddRange(Enum.GetNames(typeof(RoleName)));
            //默认显示用户名和用户密码
            this.cmb_RoleName.SelectedIndex = 0;
            //自动刷新
            RefreshUserList();

            //自动显示当前用户名称
            if (sysAdmins.Count >0)
            {
                UpdateUserlnfo(sysAdmins.First());
            }

        }

        private void RefreshUserList() 
        {
            sysAdmins = adminService.QuerySysAdmins();
            this.dgv_User.DataSource = null;
            this.dgv_User.DataSource = sysAdmins;
        }

        #endregion

        #region  添加用户
        private void btn_Add_Click(object sender, EventArgs e)
        {

            //非空判断
            if (this.txt_LoginName.Text.Length == 0) 
            {
                MessageBox.Show("用户名称不能为空", "添加用户");
                return;
            }
            if (this.txt_LoginPwd.Text.Length == 0)
            {
                MessageBox.Show("用户密码不能为空", "添加用户");
                return;
            }

            //判断是否存在
            if (sysAdmins.Where(c => c.LoginName == this.txt_LoginName.Text.Trim()).ToList().Count > 0)
            {
                MessageBox.Show("该用户已经存在！", "添加用户");
                return;
            }

            //封装对象
            SysAdmin sysAdmin = new SysAdmin()
            {
                LoginName = this.txt_LoginName.Text.Trim(),
                LoginPwd = this.txt_LoginPwd.Text.Trim(),
                RoleName = this.cmb_RoleName.Text
            };

            //添加用户
            if (adminService.AddSysAdmin(sysAdmin) == 1 )
            {
                //刷新
                RefreshUserList();
            }

            else
            {
                MessageBox.Show("添加用户失败！", "添加用户");
            }           
        }

        #endregion

        #region  修改用户
        //修改用户
        private void Modify_Click(object sender, EventArgs e)
        {

            //非空判断
            if (this.txt_LoginName.Text.Length == 0)
            {
                MessageBox.Show("用户名称不能为空", "修改用户");
                return;
            }
            if (this.txt_LoginPwd.Text.Length == 0)
            {
                MessageBox.Show("用户密码不能为空", "修改用户");
                return;
            }

            //判断是否修改用户名
            if (sysAdmins[this.dgv_User.SelectedRows[0].Index].LoginName != this.txt_LoginName.Text)
            {
                if (sysAdmins.Where(c => c.LoginName == this.txt_LoginName.Text.Trim()).ToList().Count > 0)
                {
                    MessageBox.Show("该用户已经存在！", "修改用户");
                    return;
                }
            }

            ///封装对象
            SysAdmin sysAdmin = new SysAdmin()
            {
                LoginId = sysAdmins[this.dgv_User.SelectedRows[0].Index].LoginId,
                LoginName = this.txt_LoginName.Text.Trim(),
                LoginPwd = this.txt_LoginPwd.Text.Trim(),
                RoleName = this.cmb_RoleName.Text
            };

            //修改用户
            if (adminService.ModifySysAdmin(sysAdmin) == 1)
            {
                //刷新
                RefreshUserList();
            }

            else
            {
                MessageBox.Show("修改用户失败！", "修改用户");
            }
        }

        #endregion

        #region  删除用户
        //删除用户
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int loginld = sysAdmins[this.dgv_User.SelectedRows[0].Index].LoginId;

            if (adminService.DeleteSysAdmin(loginld) == 1)
            {
                //刷新
                RefreshUserList();
            }
            else
            {
                MessageBox.Show("删除用户失败！", "删除用户");
            }
        }


        #endregion

        #region  更新状态
        //自动更新
        private void dgv_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UpdateUserlnfo(sysAdmins[e.RowIndex]);
            }
        }

        //封装方法
        private void UpdateUserlnfo(SysAdmin sysAdmin) 
        {
            if (sysAdmin != null)
            {
                //拿到数据
                this.txt_LoginName.Text = sysAdmin.LoginName;
                this.txt_LoginPwd.Text = sysAdmin.LoginPwd;
                this.cmb_RoleName.Text = sysAdmin.RoleName;
            }
        }

        #endregion

        #region 序列号显示
        private void dgv_User_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewHelper.DgvRowPostPaint(this.dgv_User, e);
        }

        #endregion

        #region   退出数据表  
        private void label1_Click(object sender, EventArgs e)
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

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thinger.HeatingControlProject;

namespace Zyh.DDSApp
{

    /// <summary>
    /// 用户管理服务类
    /// </summary>
    public class SysAdminService
    {

        #region  用户管理
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="admin">包含账号和密码的用户对象</param>
        /// <returns>包含所有的参数对象</returns>
        public SysAdmin AdminLogin(SysAdmin admin) 
        {
            //封装SQL语句
            string sql = "select LoginId,RoleName from SysAdmin where LoginName=@LoginName and LoginPwd= @LoginPwd";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@LoginName",admin.LoginName),
                new SqlParameter("@LoginPwd",admin.LoginPwd),
            };

            //提交查询
            SqlDataReader reader = SqlHelper.ExecuteReader(sql, param);

            //判断是否成功，如果成功就封装对象,赋值
            if (reader.Read())
            {
                admin.LoginId = Convert.ToInt32(reader["LoginId"]);
                admin.RoleName = reader["RoleName"].ToString();
            }
            else 
            {
              //如果都有值的情况下，再赋值空
              admin = null;
            }
            reader.Close();//关闭SQL  data
            return admin;//最后再返回给adminLogin，形成封装子循环
        }



        /// <summary>
        /// 创建获取所有的名字
        /// </summary>
        /// <returns></returns>
        public List<SysAdmin> QuerySysAdmins() 
        {
            //获取
            string sql = "Select LoginId,LoginName,LoginPwd,RoleName from SysAdmin";

            SqlDataReader reader = SqlHelper.ExecuteReader(sql);

            //创建集合
            List<SysAdmin> sysAdmins = new List<SysAdmin>();

            //使用外循环
            while (reader.Read()) 
            {
                //对象初始化值
                sysAdmins.Add(new SysAdmin()
                {
                    LoginId = Convert.ToInt32(reader["LoginId"]),
                    LoginName = reader["LoginName"].ToString(),
                    LoginPwd = reader["LoginPwd"].ToString(),
                    RoleName = reader["RoleName"].ToString(),
                 });
             }
            reader.Close();//关闭SQL  data
            return sysAdmins;
        }

        #endregion

        #region  添加用户
        public int AddSysAdmin(SysAdmin sysAdmin)
        
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Insert into SysAdmin(LoginName,LoginPwd,RoleName)");
            stringBuilder.Append(" values(@LoginName,@LoginPwd,@RoleName)");
            
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@LoginName",sysAdmin.LoginName),
                new SqlParameter("@LoginPwd",sysAdmin.LoginPwd),
                new SqlParameter("@RoleName",sysAdmin.RoleName),
            };
            return SqlHelper.ExecuteNonQuery(stringBuilder.ToString(), sqlParameters);
        }

        #endregion

        #region  修改用户
        public int ModifySysAdmin(SysAdmin sysAdmin)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Update SysAdmin set LoginName=@LoginName,LoginPwd=@LoginPwd,");
            stringBuilder.Append("RoleName=@RoleName where LoginId=@LoginId");

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@LoginId",sysAdmin.LoginId),
                new SqlParameter("@LoginName",sysAdmin.LoginName),
                new SqlParameter("@LoginPwd",sysAdmin.LoginPwd),
                new SqlParameter("@RoleName",sysAdmin.RoleName),
            };
            return SqlHelper.ExecuteNonQuery(stringBuilder.ToString(), sqlParameters);
        }
        #endregion

        #region  删除用户
        public int DeleteSysAdmin(int loginld) 
        {
            string sql = "Delete from SysAdmin where LoginId=@LoginId";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@LoginId",loginld),
               
            };
            return SqlHelper.ExecuteNonQuery(sql, sqlParameters);
        }

        #endregion
    }
}
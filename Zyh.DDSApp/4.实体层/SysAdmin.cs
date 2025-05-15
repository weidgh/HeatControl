using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zyh.DDSApp
{

    /// <summary>
    /// 用户实体类
    /// </summary>
    public class SysAdmin
    {
        /// <summary>
        /// 登录账号
        /// </summary>
        public int LoginId { get; set; }

        /// <summary>
        /// 管理员名称
        /// </summary>
        public string LoginName { get; set; }

        /// <summary>
        /// 登录密码
        /// </summary>
        public string LoginPwd { get; set;}

        /// <summary>
        /// 
        /// </summary>
        public string RoleName { get; set; }
    }
}

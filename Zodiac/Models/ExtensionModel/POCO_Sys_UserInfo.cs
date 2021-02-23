using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.PocoModel
{
    public partial class POCO_Sys_UserInfo
    {
        /// <summary>
        /// 部门名称
        /// </summary>
        public string depName { get; set; }

        /// <summary>
        /// 用户所关联的所有角色的编号 以,为分隔符连接起来
        /// </summary>
        public string roleIds { get; set; }
        /// <summary>
        /// 用户所关联的所有特权的编号 以,为分隔符连接起来
        /// </summary>
        public string vipIds { get; set; }
    }
}

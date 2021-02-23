using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.PocoModel
{
    public partial class POCO_Sys_Role
    {
        /// <summary>
        /// 部门名称
        /// </summary>
        public string depName { get; set; }

        /// <summary>
        /// 角色所关联的所有权限的编号 以,为分隔符连接起来
        /// </summary>
        public string perIds { get; set; }
    }
}

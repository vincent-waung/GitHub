using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.PocoModel;
namespace Models
{
    public class EITreeGrid_Permission:POCO_Sys_Permission
    {
        /*上级菜单权限编号*/
        public int _parentId { get; set; }
        /*
         * 节点的状态同tree
         */
        public string state { get; set; }
        /* 
         * 是否选择
         */
        public bool Checked { get; set; }
        /**
         * 节点对应的图标
         * */
        public string iconCls { get; set; }
        /// <summary>
        /// 上级菜单权限名称
        /// </summary>
        public string pPerName { get; set; }
        /// <summary>
        /// 是否拥有权限
        /// </summary>
        public bool IsHPer { get; set; }
    }
}

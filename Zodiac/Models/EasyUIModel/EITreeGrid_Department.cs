using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.PocoModel;
namespace Models
{
    /*
     组织结构表的EasyUITreeGrid模型实体
     */
    public class EITreeGrid_Department : POCO_Sys_Department
    {
        /*上级部门编号*/
        public int _parentId { get; set; }
        /*
         * 节点的状态同tree
         */
        public string state { get; set; }
       /* 
        * 是否选择ss
        */
        public bool Checked { get; set; }
          /**
           * 节点对应的图标
           * */
        public string iconCls { get; set; }
        /// <summary>
        /// 上级部门名称
        /// </summary>
        public string pDepName { get; set; }
    }
}

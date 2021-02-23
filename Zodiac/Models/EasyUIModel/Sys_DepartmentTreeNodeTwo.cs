using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Sys_DepartmentTreeNodeTwo
    {
        public int id { get; set; }
        public string text { get; set; }
        public string state { get; set; }
        public bool Checked { get; set; }
        public object attributes { get; set; }
        public string iconCls { get; set; }
        public string depRemark { get; set; }
        public string depAddTime { get; set; }
        public string progress { get; set; }
        public int _parentId { get; set; }     
    }
}

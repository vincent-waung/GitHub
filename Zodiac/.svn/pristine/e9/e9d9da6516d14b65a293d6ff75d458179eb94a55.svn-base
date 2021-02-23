using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.PocoModel;
namespace Models
{
   public class EITree_Department:POCO_Sys_Department
    {
        //id：绑定节点的标识值。
        public int id { get; set; }
        //text：显示的节点文本。
        public string text { get; set; }
        //iconCls：显示的节点图标CSS类ID。
        public string iconCls { get; set; }
        //checked：该节点是否被选中。
        public bool Checked { get; set; }
        //state：节点状态，'open' 或 'closed'。
        public string state { get; set; }
        //attributes：绑定该节点的自定义属性。
        public object attributes { get; set; }
        //子结点集合
        public List<EITree_Department> children { get; set; }
        //target: 目标DOM对象。

    }
}

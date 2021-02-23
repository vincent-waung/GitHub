using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 对应EasyUI的树型结点
    /// id：节点ID，对加载远程数据很重要。
    //text：显示节点文本。
    //state：节点状态，'open' 或 'closed'，默认：'open'。在设置为'closed'的时     //候，当前节点的子节点将会从远程服务器加载他们。
    //checked：表示该节点是否被选中。
    //attributes: 被添加到节点的自定义属性。
    //children: 一个节点数组声明了若干节点。
    /// </summary>
    public class TreeNode
    {
        public int id { get; set; }
        public string text { get; set; }
        public string state { get; set; }
        public string iconCls { get; set; }
        public bool Checked { get; set; }
        public object attributes { get; set; }
        public List<TreeNode> children { get; set; }
    }
}

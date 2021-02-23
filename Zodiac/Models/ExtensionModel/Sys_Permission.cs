using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class Sys_Permission
    {
        #region 把权限菜单转换化easyui的treenode
        private TreeNode TransformTreeNode()
        {
            TreeNode treeNode = new TreeNode()
            {
                id = this.pid,
                text = this.pName,
                iconCls= this.pIco,
                //this.pState == true ? "open" : "closed",
                state ="open",
                Checked = false,
                attributes = new {url= this.GenerateUrl()},
                children = new List<TreeNode>()
            };
            return treeNode;
        }

        #region 组建结点对应的路由
        public string GenerateUrl()
        {
            return FormatUrl(this.pAreaName)
                + FormatUrl(this.pControllerName)
                + FormatUrl(this.pActionName);
        }

        public string FormatUrl(string name)
        {
            return string.IsNullOrEmpty(name) ? "" : "/" + name;
        }
        #endregion
        #endregion

        #region 把权限菜单数据转换成符合easyui的带有递归关系的集合
        public static List<TreeNode> ConvertTreeNodes(List<Sys_Permission> listPers)
        {
            List<TreeNode> listTreeNodes = new List<TreeNode>();
            LoadTreeNode(listPers, listTreeNodes, 1);
            return listTreeNodes;
        }

        private static void LoadTreeNode(List<Sys_Permission> listPers, List<TreeNode> listTreeNodes, int pid)
        {
            foreach (Sys_Permission per in listPers)
            {
                if (per.pParent == pid)
                {
                    TreeNode node = per.TransformTreeNode();
                    listTreeNodes.Add(node);

                    LoadTreeNode(listPers, node.children, node.id);
                }
            }
        }
        #endregion
    }
}

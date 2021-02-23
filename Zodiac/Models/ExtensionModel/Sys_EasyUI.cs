using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class Sys_EasyUI
    {
        #region 把权限转换成树型结点
        public TreeNode ToNode()
        {
            TreeNode node = new TreeNode()
            {
                id = this.pid,
                text = this.pName,
                state =this.pRemark,
                Checked = false,
                attributes = new { url = this.GetUrl() },
                children = new List<TreeNode>()
            };
            return node;
        } 
        #endregion

        #region 将当前权限的区域名+控制器名
        /// <summary>
        /// 将 当前权限的 区域名+控制器名
        /// </summary>
        /// <returns></returns>
        protected string GetUrl()
        {
            return GetUrlPart(this.pAreaName)
                + GetUrlPart(this.pControllerName)
                + GetUrlPart(this.pActionName);
        }

        protected string GetUrlPart(string urlPart)
        {
            return string.IsNullOrEmpty(urlPart) ? "" : "/" + urlPart;
        }
        #endregion

        #region 将权限集合转成树节点集合
        /// <summary>
        /// 将 权限集合 转成 树节点集合
        /// </summary>
        /// <param name="listPer"></param>
        /// <returns></returns>
        public static List<TreeNode> ToTreeNodes(List<Sys_EasyUI> listPer)
        {
            List<TreeNode> listNodes = new List<TreeNode>();
            //生成 树节点时，根据 pid=0的根节点 来生成
            LoadTreeNode(listPer, listNodes, 0);
            return listNodes;
        }

        public static void LoadTreeNode(List<Sys_EasyUI> listPer, List<TreeNode> listNodes, int pid)
        {
            foreach (var permission in listPer)
            {
                if (permission.pParent == pid)
                {
                    //将 权限转成 树节点
                    TreeNode node = permission.ToNode();
                    listNodes.Add(node);
                    LoadTreeNode(listPer, node.children, node.id);
                }
            }
        }
        #endregion
       
    }
}

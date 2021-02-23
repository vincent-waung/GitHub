using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class Sys_Department
    {
        #region 把权限转换成树型结点
        public Sys_DepartmentTreeNode ToNode()
        {
            Sys_DepartmentTreeNode node = new Sys_DepartmentTreeNode()
            {
                id = this.depId,
                text = this.depName,
                state = "open",
                Checked = false,
                iconCls = "icon-ok",
                depRemark = this.depRemark,
                depAddTime = this.depAddTime.ToShortDateString(),
                children = new List<Sys_DepartmentTreeNode>()               
            };
            return node;
        }
        #endregion


        #region 把权限转换成树型结点
        public EITree_Department ToEasyUINode()
        {
            EITree_Department node = new EITree_Department()
            {
                id = this.depId,
                text = this.depName,
                state = "open",
                Checked = false,
                iconCls = depIconCls,              
                children = new List<EITree_Department>()
            };
            return node;
        }
        #endregion
        #region 将权限集合转成树节点集合
        /// <summary>
        /// 将 权限集合 转成 树节点集合
        /// </summary>
        /// <param name="listPer"></param>
        /// <returns></returns>
        public static List<Sys_DepartmentTreeNode> ToTreeNodes(List<Sys_Department> listPer)
        {
            List<Sys_DepartmentTreeNode> listNodes = new List<Sys_DepartmentTreeNode>();
            //生成 树节点时，根据 pid=0的根节点 来生成
            LoadTreeNode(listPer, listNodes, 0);
            return listNodes;
        }

        public static List<EITree_Department> ToEayUITreeNodes(List<Sys_Department> listPer)
        {
            List<EITree_Department> listNodes = new List<EITree_Department>();
            //生成 树节点时，根据 pid=0的根节点 来生成
            LoadEasyUITreeNode(listPer, listNodes, 0);
            return listNodes;
        }
        public static void LoadEasyUITreeNode(List<Sys_Department> listDepts, List<EITree_Department> listNodes, int pid)
        {
            foreach (var dept in listDepts)
            {
                if (dept.depPid == pid)
                {
                    //将 部门转成 树节点
                    EITree_Department node = dept.ToEasyUINode();
                    listNodes.Add(node);
                    LoadEasyUITreeNode(listDepts, node.children, node.id);
                }
            }
        }

        public static void LoadTreeNode(List<Sys_Department> listPer, List<Sys_DepartmentTreeNode> listNodes, int pid)
        {
            foreach (var permission in listPer)
            {
                if (permission.depPid == pid)
                {
                    //将 权限转成 树节点
                    Sys_DepartmentTreeNode node = permission.ToNode();
                    listNodes.Add(node);
                    LoadTreeNode(listPer, node.children, node.id);
                }
            }
        }


     

        /// <summary>
        /// 将 权限集合 转成 树节点集合
        /// </summary>
        /// <param name="listPer"></param>
        /// <returns></returns>
        public static List<Sys_DepartmentTreeNodeTwo> ToTreeGird(List<Sys_Department> listPer)
        {
            List<Sys_DepartmentTreeNodeTwo> listNodes = new List<Sys_DepartmentTreeNodeTwo>();
            //生成 树节点时，根据 pid=0的根节点 来生成
            int i = 5;
            foreach (Sys_Department d in listPer)
            {
             
                Sys_DepartmentTreeNodeTwo dt = new Sys_DepartmentTreeNodeTwo
                {
                    _parentId = d.depPid,
                    id = d.depId,
                    text = d.depName,
                    state = "open",
                    Checked = false,
                    iconCls = "icon-add",
                    depRemark = d.depRemark,
                    progress =(30+i).ToString(),
                    depAddTime = d.depAddTime.ToShortDateString()
                };

                i += 5;
                listNodes.Add(dt);

            }
            return listNodes;
        }
        #endregion
     
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;
using System.Web.Mvc;
using Common;
using System.Linq.Expressions;
using Models.PocoModel;
using MvcZodiac.Report;
using Models.ReportModel;
namespace MvcZodiac.Areas.Models
{
    /// <summary>
    /// 封装与Service层交互的方法，同时响应控制器
    /// </summary>
    public partial class Model_Sys_UserInfo
    {    
        #region 实现登录功能
        public static AjaxMsgModel LoginIn(string strLoginName
            , string strLoginPwd, string strYzm)
        {
            if (!strYzm.Equals(oc.CurrentUserVcode))
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "验证码不正确！请重新输入！"
                };
            }
            //根据登录名得到用户信息
          var users =  oc.BllSession.ISys_UserInfoBLL.Entities.Where(u => u.uLoginName == strLoginName).Select(u => new
            {
                u.uId,
                u.uLoginName,
                u.uPwd,
                u.Sys_Department.depName
            }).ToList();

          if (users.Count > 0)
          {
              var cUsr = users.First();
              if (cUsr != null && cUsr.uPwd == SecurityHelper.Md5EncryptToString(strLoginPwd))
              {
                  //如果用户名称密码都正确那么就把用户信息放入Session中
                  oc.CurrentUser = new Sys_UserInfo
                  {
                      uId= cUsr.uId,
                      uLoginName = cUsr.uLoginName,
                      uPwd = cUsr.uPwd,
                      Sys_Department = new Sys_Department{ depName = cUsr.depName }
                     
                  };
                  /**
                   * 保存当前用户的权限信息
                   * */
                  oc.UserPermission = Model_Sys_Permission.GetUserPermission(cUsr.uId);
                  /**
                   * 如果你在登录界面选择请记住我
                   * 将用户ID加密成字符串存入Cookie
                   * */                 
                  //创建Cookie保存登录用户信息
                  oc.CurrentLoginName = oc.CurrentUser.uLoginName;
                   

                  //返回登录成功的信息，并跳转到管理端首页
                  return new AjaxMsgModel
                  {
                      Statu = AjaxStatu.ok,
                      Msg = "登录成功",
                      Data = null,
                      BackUrl = "/Admin_Areas/AdminIndex/Index"
                  };
              }
              else
              {
                  //返回登录失败的信息
                  return new AjaxMsgModel
                  {
                      Statu = AjaxStatu.err,
                      Msg = "密码不正确！",
                      Data = null
                  };
              }
          }
          else
          {
              return new AjaxMsgModel
              {
                  Statu = AjaxStatu.err,
                  Msg = "用户名不存在！",
                  Data = null
              };
          }

        }
        #endregion


        #region 实现登录功能,不带验证码
        public static AjaxMsgModel LoginIn(string strLoginName
            , string strLoginPwd )
        {
            //if (!strYzm.Equals(oc.CurrentUserVcode))
            //{
            //    return new AjaxMsgModel
            //    {
            //        Statu = AjaxStatu.err,
            //        Msg = "验证码不正确！请重新输入！"
            //    };
            //}
            //根据登录名得到用户信息
            var users = oc.BllSession.ISys_UserInfoBLL.Entities.Where(u => u.uLoginName == strLoginName).Select(u => new
            {
                u.uId,
                u.uLoginName,
                u.uPwd,
                u.Sys_Department.depName
            }).ToList();

            if (users.Count > 0)
            {
                var cUsr = users.First();
                if (cUsr != null && cUsr.uPwd == SecurityHelper.Md5EncryptToString(strLoginPwd))
                {
                    //如果用户名称密码都正确那么就把用户信息放入Session中
                    oc.CurrentUser = new Sys_UserInfo
                    {
                        uId = cUsr.uId,
                        uLoginName = cUsr.uLoginName,
                        uPwd = cUsr.uPwd,
                        Sys_Department = new Sys_Department { depName = cUsr.depName }

                    };
                    /**
                     * 保存当前用户的权限信息
                     * */
                    oc.UserPermission = Model_Sys_Permission.GetUserPermission(cUsr.uId);
                    /**
                     * 如果你在登录界面选择请记住我
                     * 将用户ID加密成字符串存入Cookie
                     * */
                    //创建Cookie保存登录用户信息
                    oc.CurrentLoginName = oc.CurrentUser.uLoginName;

 
                    var loginusers = oc.BllSession.ISys_UserInfoBLL.Entities.Where(u => u.uLoginName == strLoginName).FirstOrDefault().ToPOCO();
                   
                    
                    ///将vendor name 保存至cookie
                    oc.CurrentVendorName = loginusers.uRemark;
 

                    //返回登录成功的信息，并跳转到管理端首页
                    return new AjaxMsgModel
                    {
                        Statu = AjaxStatu.ok,
                        Msg = "登录成功",
                        Data = null,
                        BackUrl = "/Admin_Areas/AdminIndex/Index"
                    };
                }
                else
                {
                    //返回登录失败的信息
                    return new AjaxMsgModel
                    {
                        Statu = AjaxStatu.err,
                        Msg = "密码不正确！",
                        Data = null
                    };
                }
            }
            else
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "用户名不存在！",
                    Data = null
                };
            }

        }
        #endregion

        #region 生成验证码
        /// <summary>
        /// 生成验证码
        /// </summary>
        /// <returns></returns>
        public static byte[] GenerateValidateCode()
        {
            //实例化验证码类
            ValidateCode validateCode = new ValidateCode();
            //生成验证码指定的长度
            string code = validateCode.CreateValidateCode(5);
            //将验证码赋值给Session变量
            oc.CurrentUserVcode = code;
            //创建验证码的图片
            byte[] bytes = validateCode.CreateValidateGraphic(code);
            return bytes;
        }
       #endregion

        #region 根据用户名检索用户信息,并提供分页查询
        /// <summary>
        /// 根据用户名检索用户信息,并提供分页查询
        /// </summary>
        /// <param name="q">检索的模糊条件</param>
        /// <param name="page">当前页码</param>
        /// <param name="rows">每页显示的行数</param>
        /// <param name="psc">排序的字段及排序的方向</param>
        /// <returns>查询的结果集DataGrid</returns>
        public static dynamic GetUsersByLoginName( int page, int rows,string q=null,
             string sort =null,string order = null ,bool isComobo =false)
        {
            dynamic users =null;
            int total =0;
            if (isComobo)
            {
                if (q == null || q.ToString().Equals(""))
                {
                    users = oc.BllSession.ISys_UserInfoBLL.Entities.Where(u => u.uIsDel == false).Select(u => new
                    {
                        u.uId,
                        u.uLoginName
                    }).ToList();
                }
                else
                {
                    users = oc.BllSession.ISys_UserInfoBLL.Entities.Where(u => u.uIsDel == false && u.uLoginName.Contains(q)).Select(u => new
                    {
                        u.uId,
                        u.uLoginName
                    }).ToList();
                }
                return users;             
            }
           
            PropertySortCondition<Sys_UserInfo> psc = null;
            if (sort == null && order == null)
            {
                psc = new PropertySortCondition<Sys_UserInfo>(u=>u.uLoginName);
            }
            else
            {
                psc = new PropertySortCondition<Sys_UserInfo>(sort, order.Equals("asc") ? ListSortDirection.Ascending : ListSortDirection.Descending);
            }
            if (q == null || q.ToString().Trim().Equals(""))
            {
                //得到所有的用户信息
                 users = oc.BllSession.ISys_UserInfoBLL.Entities.Where(u => u.uIsDel == false, page, rows, out total, psc)
                    .Select(u => new
                    {
                        u.uId,
                        u.uLoginName,
                        u.uGender,
                        u.Sys_Department.depName
                    }).ToList();
            }
            else
            {
                users = oc.BllSession.ISys_UserInfoBLL.Entities.Where(u => u.uIsDel == false&&u.uLoginName.Contains(q), page, rows, out total, psc)
                       .Select(u => new
                       {
                           u.uId,
                           u.uLoginName,
                           u.uGender,
                           u.Sys_Department.depName
                       }).ToList();
            }
            return new DataGrid
            {
                total = total,
                rows = users,
                footer = null
            };
        }
        #endregion

        #region 判断当前用户是否登录
        /// <summary>
        /// 判断当前用户是否登录
        /// </summary>
        /// <returns>false 没有登录反之登录</returns>
        public static bool IsLogin()
        {
            if (oc.CurrentUser == null)
            {
                if (oc.CurrentLoginName != "")
                {
                  /*根据登录名得到用户信息*/
                    var cUsr = oc.BllSession.ISys_UserInfoBLL.Entities.Where(u => u.uLoginName == oc.CurrentLoginName).Select(u => new
                     {
                       u.uLoginName,
                       u.uPwd,
                       u.Sys_Department.depName
                     }).ToList().First();

                    /*把用户信息再次放入Session*/
                    oc.CurrentUser = new Sys_UserInfo
                    {
                        uLoginName = cUsr.uLoginName,
                        uPwd = cUsr.uPwd,
                        Sys_Department = new Sys_Department { depName = cUsr.depName }

                    };
                    return true;

                }
                return false;
            }

            return true;
        }
        #endregion

        #region 根据筛选条件查询用户信息+IQueryable<Sys_UserInfo>
        private static IQueryable<Sys_UserInfo> GetUserInfoForIQueryable(out int total,int page, int rows,
            DateTime operDateStart, DateTime operDateEnd, int depId = -1, string uLoginName = "", string sort = null, string order = null)
        { 
            total = 0;
            PropertySortCondition<Sys_UserInfo> psc = null;
            if (sort == null)
            {
                psc = new PropertySortCondition<Sys_UserInfo>(u=>u.uLoginName);
            }
            else
            {
                psc = new PropertySortCondition<Sys_UserInfo>(sort, order.Equals("asc") ? ListSortDirection.Ascending : ListSortDirection.Descending);
            }
            Expression<Func<Sys_UserInfo, bool>> predicate = null;
            if (depId == -1)
            {
                predicate = u => u.uLoginName.Contains(uLoginName) &&
                u.uAddTime >= operDateStart && u.uAddTime <= operDateEnd;
            }
            else {
                predicate = u => u.uLoginName.Contains(uLoginName) && u.uDepId == depId &&
                  u.uAddTime >= operDateStart && u.uAddTime <= operDateEnd;
            }
            var users = oc.BllSession.ISys_UserInfoBLL.Entities.Where(predicate, page, rows, out total, psc);
        
             return users;
        }
        #endregion

        #region 根据筛选条件查询用户信息+ List<POCO_Sys_UserInfo>
        public static List<POCO_Sys_UserInfo> GetUserInfoForIQueryable( 
            DateTime operDateStart, DateTime operDateEnd, int depId = -1, string uLoginName = "")
        {         
            
            Expression<Func<Sys_UserInfo, bool>> predicate = null;
            if (depId == -1)
            {
                predicate = u => u.uLoginName.Contains(uLoginName) &&
                u.uAddTime >= operDateStart && u.uAddTime <= operDateEnd;
            }
            else
            {
                predicate = u => u.uLoginName.Contains(uLoginName) && u.uDepId == depId &&
                  u.uAddTime >= operDateStart && u.uAddTime <= operDateEnd;
            }
             List<POCO_Sys_UserInfo> usrList = oc.BllSession.ISys_UserInfoBLL.Entities.Where(predicate).Select(u => new POCO_Sys_UserInfo {
             uId = u.uId,
             uDepId = u.Sys_Department.depId,
             depName = u.Sys_Department.depName,
             uAddTime = u.uAddTime,
             uGender = u.uGender,
             uIsDel = u.uIsDel,
             uLoginName = u.uLoginName,
             uPost = u.uPost,
             uPwd = u.uPwd,
             uRemark = u.uRemark            
            }).ToList();

           return usrList;
        }
        #endregion

        #region 根据筛选条件查询用户信息
        /// <summary>
        /// 根据筛选条件查询用户信息
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="rows">每页条数</param>
        /// <param name="operDateStart">起始日期</param>
        /// <param name="operDateEnd">截止日期</param>
        /// <param name="depId">所属部门</param>
        /// <param name="uLoginName">登录名</param>
        /// <param name="sort">排序字段</param>
        /// <param name="order">排序方向</param>
        /// <returns>根据指定条件返回用户信息</returns>
        public static dynamic GetUserInfoByCondition(int page, int rows,
            DateTime operDateStart, DateTime operDateEnd, int depId = -1, string uLoginName = "", string sort = null, string order = null)
        {
            int total = 0;
            var users = GetUserInfoForIQueryable(out total, page, rows, operDateStart, operDateEnd, depId,
                uLoginName, sort, order);

          var userList =  users.Select(u => new
            {
                u.uId,
                u.Sys_Department.depId,
                u.Sys_Department.depName,
                u.uAddTime,
                u.uDepId,
                u.uGender,
                u.uIsDel,
                u.uLoginName,
                u.uPost,
                u.uPwd,
                u.uRemark,
                u.uImgUrl
            }).ToList();

            return new DataGrid
            {
                total = total,
                rows = userList,
                footer = null
            };
        }
        #endregion

        #region 根据筛选条件查询用户信息并关联角色信息
        /// <summary>
        /// 根据筛选条件查询用户信息
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="rows">每页条数</param>
        /// <param name="operDateStart">起始日期</param>
        /// <param name="operDateEnd">截止日期</param>
        /// <param name="depId">所属部门</param>
        /// <param name="uLoginName">登录名</param>
        /// <param name="sort">排序字段</param>
        /// <param name="order">排序方向</param>
        /// <returns>根据指定条件返回用户信息</returns>
        public static dynamic GetUserInfoByConditionJoinRoleIds(int page, int rows,
            DateTime operDateStart, DateTime operDateEnd, int depId = -1, string uLoginName = "", string sort = null, string order = null)
        {
            int total = 0;
            var users = GetUserInfoForIQueryable(out total, page, rows, operDateStart, operDateEnd, depId,
                uLoginName, sort, order);

           var userList =  users.Select(u => new 
            {
                u.uId,
                u.Sys_Department.depId,
                u.Sys_Department.depName,
                u.uAddTime,
                u.uDepId,
                u.uGender,
                u.uIsDel,
                u.uLoginName,
                u.uPost,
                u.uPwd,
                u.uRemark
            }).ToList();

            List<POCO_Sys_UserInfo> pocoUsers = new List<POCO_Sys_UserInfo>();

            foreach (var usr in userList)
            {
                List<int> listRoles = oc.BllSession.ISys_UserRoleBLL.Entities.Where(ur => ur.urUId == usr.uId
                    && ur.urIsDel == false).Select(ur => ur.urRId).ToList();
                string rIds = string.Empty;
                if (listRoles.Count > 0)
                {
                    listRoles.ForEach(r =>
                    {
                        rIds += r.ToString() + ",";
                    });
                    rIds = rIds.Substring(0, rIds.Length - 1);
                }

                POCO_Sys_UserInfo psu = new POCO_Sys_UserInfo
                {
                    uId = usr.uId,
                    uDepId = usr.depId,
                    depName = usr.depName,
                    uAddTime = usr.uAddTime,
                    uGender = usr.uGender,
                    uIsDel = usr.uIsDel,
                    uLoginName = usr.uLoginName,
                    uPost = usr.uPost,
                    uPwd = usr.uPwd,
                    uRemark = usr.uRemark,
                    roleIds = rIds
                };
                pocoUsers.Add(psu);
            }

            return new DataGrid
            {
                total = total,
                rows = pocoUsers,
                footer = null
            };
        }
        #endregion

        #region 根据筛选条件查询用户信息并关联特权信息
        /// <summary>
        /// 根据筛选条件查询用户信息并关联特权信息
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="rows">每页条数</param>
        /// <param name="operDateStart">起始日期</param>
        /// <param name="operDateEnd">截止日期</param>
        /// <param name="depId">所属部门</param>
        /// <param name="uLoginName">登录名</param>
        /// <param name="sort">排序字段</param>
        /// <param name="order">排序方向</param>
        /// <returns>根据指定条件返回用户信息</returns>
        public static dynamic GetUserInfoByConditionJoinVipIds(int page, int rows,
            DateTime operDateStart, DateTime operDateEnd, int depId = -1, string uLoginName = "", string sort = null, string order = null)
        {
            int total = 0;
            var users = GetUserInfoForIQueryable(out total, page, rows, operDateStart, operDateEnd, depId,
                uLoginName, sort, order);

            var userList = users.Select(u => new
            {
                u.uId,
                u.Sys_Department.depId,
                u.Sys_Department.depName,
                u.uAddTime,
                u.uDepId,
                u.uGender,
                u.uIsDel,
                u.uLoginName,
                u.uPost,
                u.uPwd,
                u.uRemark
            }).ToList();

            List<POCO_Sys_UserInfo> pocoUsers = new List<POCO_Sys_UserInfo>();

            foreach (var usr in userList)
            {
                List<int> listVips = oc.BllSession.ISys_UserVipPermissionBLL.Entities.Where(ur => ur.vipUserId == usr.uId
                    && ur.vipIsDel == false).Select(ur => ur.vipPermission).ToList();
                string vIds = string.Empty;
                if (listVips.Count > 0)
                {
                    listVips.ForEach(v =>
                    {
                        vIds += v.ToString() + ",";
                    });
                    vIds = vIds.Substring(0, vIds.Length - 1);
                }

                POCO_Sys_UserInfo psu = new POCO_Sys_UserInfo
                {
                    uId = usr.uId,
                    uDepId = usr.depId,
                    depName = usr.depName,
                    uAddTime = usr.uAddTime,
                    uGender = usr.uGender,
                    uIsDel = usr.uIsDel,
                    uLoginName = usr.uLoginName,
                    uPost = usr.uPost,
                    uPwd = usr.uPwd,
                    uRemark = usr.uRemark,
                    vipIds = vIds
                };
                pocoUsers.Add(psu);
            }

            return new DataGrid
            {
                total = total,
                rows = pocoUsers,
                footer = null
            };
        }
        #endregion

        #region 新增用户
        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="User">用户</param>
        /// <returns>AjaxMsgModel实体对象</returns>
        public static AjaxMsgModel AddUserInfo(Sys_UserInfo UserInfo)
        {
            int iret = oc.BllSession.ISys_UserInfoBLL.Add(UserInfo);

            if (iret > 0)
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.ok,
                    Msg = "用户新增成功！",
                    Data = null,
                    BackUrl = null
                };
            }
            else
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "用户新增失败！",
                    Data = null,
                    BackUrl = null
                };
            }
        }
        #endregion

        #region 修改用户
        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="UserInfo">用户</param>
        /// <returns>AjaxMsgModel实体对象</returns>
        public static AjaxMsgModel EditUserInfo(Sys_UserInfo UserInfo)
        {
            Expression<Func<Sys_UserInfo, object>>[] ignoreProperties =
                new Expression<Func<Sys_UserInfo, object>>[] {
                   p=>p.uPwd, p => p.Sys_Department, p => p.Sys_UserRole, p => p.Sys_UserVipPermission };

            int iret = oc.BllSession.ISys_UserInfoBLL.Modify(UserInfo, ignoreProperties);

            if (iret > 0)
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.ok,
                    Msg = "用户修改成功！",
                    Data = null,
                    BackUrl = null
                };
            }
            else
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "用户修改失败！",
                    Data = null,
                    BackUrl = null
                };
            }
        }
        #endregion

        #region 删除用户
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="uId">要删除的用户编号</param>
        /// <returns>AjaxMsgModel实体对象</returns>
        public static AjaxMsgModel DelUserInfo(int uId)
        {
            int uCount = oc.BllSession.ISys_UserRoleBLL.Entities.Count(u => u.urUId == uId);
            if (uCount > 0)
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "此用户已分配角色，不允许直接删除！",
                    Data = null,
                    BackUrl = null
                };
            }

            int rCount = oc.BllSession.ISys_UserVipPermissionBLL.Entities.Count(u => u.vipUserId == uId);
            if (rCount > 0)
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "此用户已关联特权，不允许直接删除！",
                    Data = null,
                    BackUrl = null
                };
            }

            int iret = oc.BllSession.ISys_UserInfoBLL.DelBy(p => p.uId == uId);
            if (iret > 0)
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.ok,
                    Msg = "用户删除成功！",
                    Data = null,
                    BackUrl = null
                };
            }
            else
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "用户删除失败！",
                    Data = null,
                    BackUrl = null
                };
            }

        }
        #endregion

        #region 修改用户密码
        /// <summary>
        /// 修改用户密码
        /// </summary>
        /// <param name="UserInfo">用户</param>
        /// <returns>AjaxMsgModel实体对象</returns>
        public static AjaxMsgModel EditUserPwd(Sys_UserInfo UserInfo, string cypwd)
        {

            Sys_UserInfo modifyUser = oc.BllSession.ISys_UserInfoBLL.Entities.Where(u => u.uId == UserInfo.uId).FirstOrDefault();

            //if (!SecurityHelper.DeEncrypt(modifyUser.uPwd).Equals(cypwd))
            if (modifyUser.uPwd != SecurityHelper.Md5EncryptToString(cypwd))
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.ok,
                    Msg = "原密码不正确！不允许修改！",
                    Data = null,
                    BackUrl = null
                };
            }
           

            UserInfo.uDepId = modifyUser.uDepId;
            UserInfo.uGender = modifyUser.uGender;
            UserInfo.uIsDel = modifyUser.uIsDel;
            UserInfo.uLoginName = modifyUser.uLoginName;
            UserInfo.uPost = modifyUser.uPost;
            UserInfo.uRemark = modifyUser.uRemark;
            UserInfo.uAddTime = DateTime.Now;


            Expression<Func<Sys_UserInfo, object>>[] ignoreProperties =
                new Expression<Func<Sys_UserInfo, object>>[] {
                   p => p.Sys_Department, p => p.Sys_UserRole, p => p.Sys_UserVipPermission 
                };

            int iret = oc.BllSession.ISys_UserInfoBLL.Modify(UserInfo, ignoreProperties);

            if (iret > 0)
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.ok,
                    Msg = "用户密码修改成功！",
                    Data = null,
                    BackUrl = null
                };
            }
            else
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "用户密码修改失败！",
                    Data = null,
                    BackUrl = null
                };
            }
        }
        #endregion


        #region 统计每个部门的人数
        /// <summary>
        /// 统计每个部门的人数
        /// </summary>
        /// <returns></returns>
        public static List<YW_DepartPerson> GetUserCountByDepName()
        {
            return oc.BllSession.ISys_UserInfoBLL.GetUserCountByDepName();
        }
        #endregion

        #region 统计男女人数比例
        /// <summary>
        /// 统计男女人数比例
        /// </summary>
        /// <returns></returns>
        public static dynamic GetPerCountByGender()
        {
            return oc.BllSession.ISys_UserInfoBLL.Entities.GroupBy(u => u.uGender).Select(u => new
            {
                Name = u.Key ? "男" : "女",
                Count = u.Count()
            }).ToList();
        }
        #endregion

        #region 用户基本信息统计报表
        public static List<R_Sys_UserInfo> GetUserInfoForReport()
        {
            List<R_Sys_UserInfo> rUsers = oc.BllSession.ISys_UserInfoBLL.Entities.Select(u => new R_Sys_UserInfo
            {
                uId = u.uId,
                depName = u.Sys_Department.depName,
                uAddTime = u.uAddTime,
                uGender = u.uGender ? "男" : "女",
                uIsDel = u.uIsDel ? "禁用" : "启用",
                uLoginName = u.uLoginName,
                uPost = u.uPost,
                uRemark = u.uRemark

            }).ToList();

            return rUsers;
        }
        #endregion
    }
}
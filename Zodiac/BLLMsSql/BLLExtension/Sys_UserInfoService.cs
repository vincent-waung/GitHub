using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Models;
using Common;
namespace BLLMsSql
{
    public partial class Sys_UserInfoService:ISys_UserInfoBLL
    {
        #region  登录
        /// <summary>
        /// 根据用户名和密码实现登录
        /// </summary>
        /// <param name="uLoginName">登录名</param>
        /// <param name="uPwd">密码</param>
        /// <returns>用户对象</returns>
        public Sys_UserInfo Login(string uLoginName, string uPwd)
        {
            List<Sys_UserInfo> users = this.GetListBy(u => u.uLoginName == uLoginName);
            if (users.Count > 0)
            {
                Sys_UserInfo usr = users.Select(u => u.ToPOCO()).First();
                if (usr != null && usr.uPwd == DataHelper.Md5(uPwd))
                {
                    return usr;
                }
            }
         return null;
        }
        #endregion

        #region 统计每个部门的人数
        /// <summary>
        /// 统计每个部门的人数
        /// </summary>
        /// <returns></returns>
        public List<YW_DepartPerson> GetUserCountByDepName()
        {
            return DbSession.ISys_UserInfoDAL.GetUserCountByDepName();
        }
        #endregion
    }
}

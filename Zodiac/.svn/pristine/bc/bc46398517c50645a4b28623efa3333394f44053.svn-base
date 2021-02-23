using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace IBLL
{
    public partial interface ISys_UserInfoBLL
    {
        #region  登录
        /// <summary>
        /// 根据用户名和密码实现登录
        /// </summary>
        /// <param name="uLoginName">登录名</param>
        /// <param name="uPwd">密码</param>
        /// <returns>用户对象</returns>
        Sys_UserInfo Login(string uLoginName,string uPwd);
        #endregion

        #region 统计每个部门的人数
        /// <summary>
        /// 统计每个部门的人数
        /// </summary>
        /// <returns></returns>
        List<YW_DepartPerson> GetUserCountByDepName();
        #endregion
    }
}

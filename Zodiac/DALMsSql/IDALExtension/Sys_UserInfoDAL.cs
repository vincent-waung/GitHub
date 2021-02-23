using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DALMsSql
{
   public partial class Sys_UserInfoDAL
    {
       #region 统计每个部门的人数
       /// <summary>
        /// 统计每个部门的人数
       /// </summary>
       /// <returns></returns>
       public  List<YW_DepartPerson> GetUserCountByDepName()
       {
           return db.Set<Sys_UserInfo>().Join(db.Set<Sys_Department>(), u => u.uDepId, d => d.depId, (u, d) => new 
           {
               depName = d.depName,
               uid = u.uId

           }).GroupBy(ud => ud.depName).Select(ud => new YW_DepartPerson
           {
               Name = ud.Key,
               Count = ud.Count()

           }).ToList();
       }
       #endregion
    }
}

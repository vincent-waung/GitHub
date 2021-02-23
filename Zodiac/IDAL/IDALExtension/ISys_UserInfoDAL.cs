using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public partial interface ISys_UserInfoDAL
    {
        #region 统计每个部门的人数
        /// <summary>
        /// 统计每个部门的人数
        /// </summary>
        /// <returns></returns>
        List<YW_DepartPerson> GetUserCountByDepName();
        #endregion
    }
}

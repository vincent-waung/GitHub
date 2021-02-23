using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public partial interface ISys_UserVipPermissionDAL
    {
        int SetUserVips(List<Sys_UserVipPermission> uvs, int uId = 0);
    }
}

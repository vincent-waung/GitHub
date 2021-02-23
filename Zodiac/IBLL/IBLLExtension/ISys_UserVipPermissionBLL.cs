using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
   public partial interface ISys_UserVipPermissionBLL
    {
       int SetUserVips(List<Sys_UserVipPermission> uvs, int uId = 0);
    }
}

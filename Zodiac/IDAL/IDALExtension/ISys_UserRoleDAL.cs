using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
   public partial interface ISys_UserRoleDAL
    {
       int SetUserRoles(List<Sys_UserRole> urs,int uId =0);
    }
}

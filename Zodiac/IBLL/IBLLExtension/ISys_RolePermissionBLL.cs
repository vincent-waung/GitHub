using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
   public partial interface ISys_RolePermissionBLL
    {
       int SetRolePers(List<Sys_RolePermission> rps ,int rId =0);
    }
}

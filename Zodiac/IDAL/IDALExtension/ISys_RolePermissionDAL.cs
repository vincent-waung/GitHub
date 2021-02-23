using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public partial interface ISys_RolePermissionDAL
    {
        int SetRolePers(List<Sys_RolePermission> rps, int rId = 0);
    }
}

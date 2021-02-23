using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLMsSql
{
    public partial class Sys_UserRoleService 
    {
        public int SetUserRoles(List<Sys_UserRole> urs,int uId =0)
        {
            return DbSession.ISys_UserRoleDAL.SetUserRoles(urs, uId);
               
        }
    }
}

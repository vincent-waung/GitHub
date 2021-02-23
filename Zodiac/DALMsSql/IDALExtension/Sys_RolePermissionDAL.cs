using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALMsSql
{
    public partial class Sys_RolePermissionDAL
    {
        #region 设置用户对应的角色
        public int SetRolePers(List<Sys_RolePermission> rps, int rId = 0)
        {
            int iret = -1;

            Logger("向表" + typeof(Sys_RolePermission).Name + "设置角色",
                () =>
                {

                    List<Sys_RolePermission> listDels = db.Set<Sys_RolePermission>().Where(v => v.rpRId == rId).ToList();
                    listDels.ForEach(d =>
                    {
                        db.Set<Sys_RolePermission>().Attach(d);
                        db.Set<Sys_RolePermission>().Remove(d);
                    });

                    if (rps.Count > 0)
                    {
                        DbSet<Sys_RolePermission> dst = db.Set<Sys_RolePermission>();
                        foreach (Sys_RolePermission model in rps)
                        {
                            dst.Add(model);
                        }
                    }

                    iret = db.SaveChanges();

                });
       
            return iret;

        }
        #endregion
    }
}

using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALMsSql
{
    public partial class Sys_UserVipPermissionDAL
    {
        #region 设置用户对应的特权
        public int SetUserVips(List<Sys_UserVipPermission> uvs, int uId = 0)
        {
            int iret = -1;
            Logger("向表" + typeof(Sys_UserVipPermission).Name + "设置角色",
                () =>
                {
                    //可以新建一个新的数据上下文，操作完成后释放

                    //using (DbContext db = new ZodiacEntities())
                    //{

                    List<Sys_UserVipPermission> listDels = db.Set<Sys_UserVipPermission>().Where(v => v.vipUserId == uId).ToList();
                    listDels.ForEach(d =>
                    {
                        db.Set<Sys_UserVipPermission>().Attach(d);
                        db.Set<Sys_UserVipPermission>().Remove(d);
                    });

                    if (uvs.Count > 0)
                    {
                        DbSet<Sys_UserVipPermission> dst = db.Set<Sys_UserVipPermission>();
                        foreach (Sys_UserVipPermission model in uvs)
                        {
                            dst.Add(model);
                        }

                    }

                    iret = db.SaveChanges();
                    //}

                });

            return iret;

        }
        #endregion
    }
}

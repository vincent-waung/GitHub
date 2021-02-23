using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DALMsSql
{
   public partial class Sys_UserRoleDAL
   {
       #region 设置用户对应的角色
       public int SetUserRoles(List<Sys_UserRole> urs,int uId =0)
       {
           int iret = -1;
           Logger("向表" + typeof(Sys_UserRole).Name + "设置角色",
               () =>
               {
                  //可以新建一个新的数据上下文，操作完成后释放

                   //using (DbContext db = new ZodiacEntities())
                   //{

                       List<Sys_UserRole> listDels = db.Set<Sys_UserRole>().Where(v => v.urUId == uId).ToList();
                       listDels.ForEach(d =>
                       {
                           db.Set<Sys_UserRole>().Attach(d);
                           db.Set<Sys_UserRole>().Remove(d);
                       });

                       if (urs.Count > 0)
                       {
                           DbSet<Sys_UserRole> dst = db.Set<Sys_UserRole>();
                           foreach (Sys_UserRole model in urs)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using System.Data.Entity;
using System.Runtime.Remoting.Messaging;
using Models;
namespace DALMsSql
{
    /// <summary>
    /// 通过线程对数据上下文进行一个优化
    /// </summary>
   public class DBContextFactory: IDBContextFactory
    {
       public DbContext GetDbContext()
       {
           DbContext dbContext = CallContext.GetData(typeof(DBContextFactory).Name) as DbContext;
           if (dbContext == null)
           {
               dbContext = new OnlineBookingEntities();
               CallContext.SetData(typeof(DBContextFactory).Name,dbContext);
              
               
              
           }

           return dbContext;
       }

       public void DeleteDbContext()
       {
           CallContext.FreeNamedDataSlot(typeof(DBContextFactory).Name);
       }
    }
}

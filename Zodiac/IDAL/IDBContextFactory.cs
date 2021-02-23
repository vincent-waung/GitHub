using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace IDAL
{
    public interface IDBContextFactory
    {
        /// <summary>
        /// 获取EF上下文
        /// </summary>
        /// <returns></returns>
        DbContext GetDbContext();
        void DeleteDbContext();
    }
}

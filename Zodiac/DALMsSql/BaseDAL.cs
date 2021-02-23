using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Models;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Data.Entity.Infrastructure;
using System.Reflection;
using log4net;
using Common.Log;
using Common;
namespace DALMsSql
{
    public class BaseDAL<T>:BaseLog<T>,IBaseDAL<T> where T:class,new()
    {
        //EF上下文
        protected  DbContext db = new DBContextFactory().GetDbContext();
  

        #region 0.数据源
       public IQueryable<T> Entities
        {
            get
            {
               return db.Set<T>().AsNoTracking();
            }
        }
        #endregion


        #region 1.新增
        public int Add(T model)
        {
            int iret = -1;
            Logger("向表" + typeof(T).Name + "增加数据",
                () =>
                {
                    db.Configuration.ValidateOnSaveEnabled = false;
                    DbSet<T> dst = db.Set<T>();
                    dst.Add(model);
                    iret = db.SaveChanges();
                    db.Configuration.ValidateOnSaveEnabled = true;
                });
            return iret;              

        }
        #endregion

        #region 2.根据id删除
        public int Del(T model)
        {
            int iret = -1;
            Logger("根据ID删除" + typeof(T).Name + "中的数据", () =>
            {
                db.Set<T>().Attach(model);
                db.Set<T>().Remove(model);
                iret = db.SaveChanges();
            });           
            return iret;
        }
        #endregion

        #region 3.根据条件删除
        public int DelBy(Expression<Func<T, bool>> delWhere)
        {
             int iret = -1;
             Logger("根据条件删除" + typeof(T).Name + "中的数据", () =>
             {
                 List<T> listDels = db.Set<T>().Where(delWhere).ToList();
                 listDels.ForEach(d =>
                 {
                     db.Set<T>().Attach(d);
                     db.Set<T>().Remove(d);
                 });
                 iret = db.SaveChanges();

             });
             return iret;
        }
        #endregion

        #region 4.x扩展修改方法（把不须要修改的列用LAMBDA数组表示出来）
        /// <summary>
        /// 4.x扩展修改方法（把不须要修改的列用LAMBDA数组表示出来）
        /// </summary>
        /// <param name="model">要修改的实体对象</param>
        /// <param name="ignoreProperties">不须要修改的相关字段</param>
        /// <returns>受影响的行数</returns>
        public int Modify(T model, params Expression<Func<T, object>>[] ignoreProperties)
        {
            int iret = -1;
            Logger("修改" + typeof(T).Name + "中的数据", () =>
            {
                using (DbContext dbs =  new OnlineBookingEntities())
                {
                   dbs.Set<T>().Attach(model);

                    DbEntityEntry entry = dbs.Entry<T>(model);
                    entry.State = System.Data.EntityState.Unchanged;

                    Type t = typeof(T);
                    List<PropertyInfo> proInfos = t.GetProperties(BindingFlags.Instance | BindingFlags.Public).ToList();

                    Dictionary<string, PropertyInfo> dicPros = new Dictionary<string, PropertyInfo>();
                    proInfos.ForEach(
                        p => dicPros.Add(p.Name, p)
                        );

                    if (ignoreProperties != null)
                    {
                        foreach (var ignorePropertyExpression in ignoreProperties)
                        {
                            //根据表达式得到对应的字段信息
                            var ignorePropertyName = new PropertyExpressionParser<T>(ignorePropertyExpression).Name;
                            dicPros.Remove(ignorePropertyName);
                        }
                    }

                    foreach (string proName in dicPros.Keys)
                    {
                        entry.Property(proName).IsModified = true;
                    }
                    iret = dbs.SaveChanges();
                }
            });
            return iret;
        }
        #endregion

        #region 4.x扩展修改方法（把不须要修改的列用LAMBDA数组表示出来）
        /// <summary>
        /// 4.x扩展修改方法（把不须要修改的列用LAMBDA数组表示出来）
        /// </summary>
        /// <param name="model">要修改的实体对象</param>
        /// <param name="ignoreProperties">不须要修改的相关字段</param>
        /// <returns>受影响的行数</returns>
        public int Modifys(List<T> model, params Expression<Func<T, object>>[] ignoreProperties)
        {
            int iret = -1;
            Logger("修改" + typeof(T).Name + "中的数据", () =>
            {

                using (DbContext dbs = new DBContextFactory().GetDbContext())
                {
                    foreach (T item in model)
                    {
                        //dbs.Set<T>().Attach(item);
                        DbEntityEntry entry = dbs.Entry<T>(item);
                        if (dbs.Entry<T>(item).State == System.Data.EntityState.Unchanged || dbs.Entry<T>(item).State == System.Data.EntityState.Unchanged)
                        {
                            entry.State = System.Data.EntityState.Modified;
                        }
                        else
                        {
                            entry.State = System.Data.EntityState.Unchanged;
                        }

                        Type t = typeof(T);
                        List<PropertyInfo> proInfos = t.GetProperties(BindingFlags.Instance | BindingFlags.Public).ToList();

                        Dictionary<string, PropertyInfo> dicPros = new Dictionary<string, PropertyInfo>();
                        proInfos.ForEach(
                            p => dicPros.Add(p.Name, p)
                            );

                        if (ignoreProperties != null)
                        {
                            foreach (var ignorePropertyExpression in ignoreProperties)
                            {
                                //根据表达式得到对应的字段信息
                                var ignorePropertyName = new PropertyExpressionParser<T>(ignorePropertyExpression).Name;
                                dicPros.Remove(ignorePropertyName);
                            }
                        }

                        foreach (string proName in dicPros.Keys)
                        {
                            entry.Property(proName).IsModified = true;
                        }
                        iret = dbs.SaveChanges();
                    }
                }
                new DBContextFactory().DeleteDbContext();
            });
            return iret;
        }
        #endregion


        #region 4.修改
        public int Modify(T model, params string[] proNames)
        {
             int iret = -1;
             Logger("修改" + typeof(T).Name + "中的数据", () =>
             {
                 
                 DbEntityEntry entry = db.Entry<T>(model);
                 entry.State = System.Data.EntityState.Unchanged;
                 foreach (string proName in proNames)
                 {
                     entry.Property(proName).IsModified = true;
                 }
                 iret = db.SaveChanges();
             });
             return iret;
        }
        #endregion

        #region 5.批量修改
        public int ModifyBy(T model, Expression<Func<T, bool>> whereLambda, params string[] proNames)
        {
             int iret = -1;
             Logger("批量修改" + typeof(T).Name + "中的数据", () =>
             {

                 List<T> listModifes = db.Set<T>().Where(whereLambda).ToList();

                 Type t = typeof(T);
                 List<PropertyInfo> proInfos = t.GetProperties(BindingFlags.Instance | BindingFlags.Public).ToList();

                 Dictionary<string, PropertyInfo> dicPros = new Dictionary<string, PropertyInfo>();

                 proInfos.ForEach(p =>
                 {
                     if (proNames.Contains(p.Name))
                     {
                         dicPros.Add(p.Name, p);
                     }
                 });

                 foreach (string proName in proNames)
                 {
                     if (dicPros.ContainsKey(proName))
                     {
                         PropertyInfo proInfo = dicPros[proName];
                         object newValue = proInfo.GetValue(model, null);
                         foreach (T m in listModifes)
                         {
                             proInfo.SetValue(m, newValue, null);
                         }
                     }
                 }

                 iret = db.SaveChanges();
             });

             return iret;
        }
        #endregion

        #region 5.x批量修改
        public int ModifyBy(T model, Expression<Func<T, bool>> whereLambda, params Expression<Func<T,object>>[] proNames)
        {
            int iret = -1;
            Logger("批量修改" + typeof(T).Name + "中的数据", () =>
            {

                List<T> listModifes = db.Set<T>().Where(whereLambda).ToList();

                Type t = typeof(T);
                List<PropertyInfo> proInfos = t.GetProperties(BindingFlags.Instance | BindingFlags.Public).ToList();

                Dictionary<string, PropertyInfo> dicPros = new Dictionary<string, PropertyInfo>();

                if (proNames != null)
                {
                    foreach (var myProperyExp in proNames)
                    {
                        var my_ProName = new PropertyExpressionParser<T>(myProperyExp).Name;

                        proInfos.ForEach(p =>
                        {
                            if (p.Name.Equals(my_ProName))
                            {
                                dicPros.Add(p.Name, p);
                            }
                        });

                        if (dicPros.ContainsKey(my_ProName))
                        {
                            PropertyInfo proInfo = dicPros[my_ProName];
                            object newValue = proInfo.GetValue(model, null);
                            foreach (T m in listModifes) 
                            {
                                proInfo.SetValue(m, newValue, null);
                            }
                        }
                    }
                }

                iret = db.SaveChanges();
            });

            return iret;
        }
        #endregion

        #region 6.根据条件查询
        public List<T> GetListBy(Expression<Func<T, bool>> whereLambda)
        {

            List<T> list = null;
            Logger("根据条件查询" + typeof(T).Name + "中的数据", () =>
            {
                list = db.Set<T>().AsNoTracking().Where(whereLambda).ToList();
            });
            return list;
        }
        #endregion

        #region 7.根据条件排序和查询
        /// <summary>
        /// 根据条件排序和查询
        /// </summary>
        /// <typeparam name="Tkey">排序字段类型</typeparam>
        /// <param name="whereLambda">查询条件</param>
        /// <param name="orderLambda">排序条件</param>
        /// <returns></returns>
        public List<T> GetListBy<Tkey>(Expression<Func<T, bool>> whereLambda, Expression<Func<T, Tkey>> orderLambda)
        {
            
            List<T> list = null;
            Logger("根据条件排序查询" + typeof(T).Name + "中的数据", () =>
            {
                list = db.Set<T>().AsNoTracking().Where(whereLambda).OrderBy(orderLambda).ToList();
            });

            return list;

        }
        #endregion

        #region 8.分页查询
        /// <summary>
        /// 根据条件排序和查询
        /// </summary>
        /// <typeparam name="Tkey">排序字段类型</typeparam>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页容量</param>
        /// <param name="whereLambda">查询条件</param>
        /// <param name="orderLambda">排序条件</param>
        /// <returns></returns>
        public List<T> GetPageList<Tkey>(int pageIndex, int pageSize, Expression<Func<T, bool>> whereLambda, Expression<Func<T, Tkey>> orderLambda)
        {

            List<T> list = null;
            Logger("根据条件分页查询" + typeof(T).Name + "中的数据", () =>
            {
                list = db.Set<T>().AsNoTracking().Where(whereLambda).OrderBy(orderLambda)
                    .Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            }
            );

            return list;
        }
        #endregion

        #region 9.分页查询输出总行数
        /// <summary>
        /// 根据条件排序和查询
        /// </summary>
        /// <typeparam name="Tkey">排序字段类型</typeparam>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页容量</param>
        /// <param name="whereLambda">查询条件</param>
        /// <param name="orderLambda">排序条件</param>
        /// <returns></returns>
        public List<T> GetPageList<Tkey>(int pageIndex, int pageSize, ref int rowCount, Expression<Func<T, bool>> whereLambda, Expression<Func<T, Tkey>> orderLambda, bool isAsc = true)
        {

            int count = 0;
            List<T> list = null;
            Logger("根据条件分页查询并输出总行数" + typeof(T).Name + "中的数据", () =>
            {

                count = db.Set<T>().Where(whereLambda).Count();
                if (isAsc)
                {
                    var iQueryList = db.Set<T>().AsNoTracking().Where(whereLambda).OrderBy(orderLambda)
                       .Skip((pageIndex - 1) * pageSize).Take(pageSize);

                    list = iQueryList.ToList();
                }
                else
                {
                    var iQueryList = db.Set<T>().AsNoTracking().Where(whereLambda).OrderByDescending(orderLambda)
                     .Skip((pageIndex - 1) * pageSize).Take(pageSize);
                    list = iQueryList.ToList();
                }
            });
            rowCount = count;
            return list;
        }


        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using IDAL;
using System.Linq.Expressions;
using DI;
namespace BLLMsSql
{
    public abstract class BaseBLL<T>:IBaseBLL<T> where T:class,new()
    {
        //EF上下文
        //不能直接实例化，否则仓储层与服务层之间会产生紧耦合
       // protected IBaseDAL<T> idal = new DALMsSql.BaseDAL<T>();
        protected IBaseDAL<T> idal;

        public abstract void SetiDal();

        public BaseBLL()
        {
            SetiDal();
        }

        //初始化创建对象
        private IDBSession iDbSession;

        public IDBSession DbSession
        {
            get
            {
                if (iDbSession == null)
                {
                    IDBSessionFactory dbSessionFactory = SpringHelper.GetObject<IDBSessionFactory>("DBSessionFactory");
                    iDbSession = dbSessionFactory.GetDbSession();
                }

                return iDbSession; 
            }        
             
        }
        #region 0.数据源
       public IQueryable<T> Entities
        {
            get
            {
                return idal.Entities;
            }

        }
        #endregion

        #region 1.新增
        public int Add(T model)
        {
           return idal.Add(model);
        }
        #endregion

        #region 2.根据id删除
        public int Del(T model)
        {
            return idal.Del(model);
        }
        #endregion

        #region 3.根据条件删除
        public int DelBy(Expression<Func<T, bool>> delWhere)
        {
            return idal.DelBy(delWhere);
        }
        #endregion

        #region 4.修改
        public int Modify(T model, params string[] proNames)
        {
            return idal.Modify(model, proNames);
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
            return idal.Modify(model, ignoreProperties);
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
            return idal.Modifys(model, ignoreProperties);
        }
        #endregion

        #region 5.批量修改
        public int ModifyBy(T model, Expression<Func<T, bool>> whereLambda, params string[] proNames)
        {
            return idal.ModifyBy(model, whereLambda, proNames);
        }
        #endregion

        #region 5.x批量修改
        public int ModifyBy(T model, Expression<Func<T, bool>> whereLambda, params Expression<Func<T, object>>[] proNames)
        {
            return idal.ModifyBy(model, whereLambda, proNames);
        }
        #endregion

        #region 6.根据条件查询
        public List<T> GetListBy(Expression<Func<T, bool>> whereLambda)
        {
            return idal.GetListBy(whereLambda);
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
            return idal.GetListBy(whereLambda, orderLambda);
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

            return idal.GetPageList(pageIndex, pageSize, whereLambda, orderLambda);
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

            return idal.GetPageList(pageIndex, pageSize, ref rowCount, whereLambda, orderLambda,isAsc);

        }
        #endregion
    }
}

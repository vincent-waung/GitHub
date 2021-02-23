using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
namespace IDAL
{
    /// <summary>
    /// 数据层的父接口
    /// T:要操作的实体(表)
    /// </summary>
    public interface IBaseDAL<T>
    {
        #region 0.数据源
        IQueryable<T> Entities
        {
            get;
        }
        #endregion

        #region 1.新增
        int Add(T model);
        #endregion

        #region 2.根据id删除
        int Del(T model);
        #endregion

        #region 3.根据条件删除
        int DelBy(Expression<Func<T, bool>> delWhere);
        #endregion

        #region 4.修改
        int Modify(T model, params string[] proNames);
        #endregion

        #region 4.x扩展修改方法（把不须要修改的列用LAMBDA数组表示出来）
        /// <summary>
        /// 4.x扩展修改方法（把不须要修改的列用LAMBDA数组表示出来）
        /// </summary>
        /// <param name="model">要修改的实体对象</param>
        /// <param name="ignoreProperties">不须要修改的相关字段</param>
        /// <returns>受影响的行数</returns>
        int Modify(T model, params Expression<Func<T, object>>[] ignoreProperties);
        #endregion


        #region 4.x扩展修改方法（把不须要修改的列用LAMBDA数组表示出来）
        /// <summary>
        /// 4.x扩展修改方法（把不须要修改的列用LAMBDA数组表示出来）
        /// </summary>
        /// <param name="model">要修改的实体对象</param>
        /// <param name="ignoreProperties">不须要修改的相关字段</param>
        /// <returns>受影响的行数</returns>
        int Modifys(List<T> model, params Expression<Func<T, object>>[] ignoreProperties);
        #endregion

        #region 5.批量修改
        int ModifyBy(T model, Expression<Func<T, bool>> whereLambda, params string[] proNames);
        #endregion

        #region 5.x批量修改
        int ModifyBy(T model, Expression<Func<T, bool>> whereLambda, params Expression<Func<T, object>>[] proNames);
        #endregion

        #region 6.根据条件查询
      

        List<T> GetListBy(Expression<Func<T, bool>> whereLambda);
        #endregion

        #region 7.根据条件排序和查询
        /// <summary>
        /// 根据条件排序和查询
        /// </summary>
        /// <typeparam name="Tkey">排序字段类型</typeparam>
        /// <param name="whereLambda">查询条件</param>
        /// <param name="orderLambda">排序条件</param>
        /// <returns></returns>
        List<T> GetListBy<Tkey>(Expression<Func<T, bool>> whereLambda,Expression<Func<T,Tkey>> orderLambda);
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
        List<T> GetPageList<Tkey>(int pageIndex,int pageSize, Expression<Func<T, bool>> whereLambda, Expression<Func<T, Tkey>> orderLambda);
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
        List<T> GetPageList<Tkey>(int pageIndex, int pageSize,ref int rowCount, Expression<Func<T, bool>> whereLambda, Expression<Func<T, Tkey>> orderLambda,bool isAsc = true);
        #endregion
    }
}

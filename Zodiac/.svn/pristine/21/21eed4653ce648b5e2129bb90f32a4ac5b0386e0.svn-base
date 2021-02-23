using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Common.Log;
using log4net;

namespace Common
{
    /// <summary>
    /// 存放查询的扩展方法
    /// </summary>
   public static class CollectionsExtensions
   {
       #region Log4net日志处理
       static ILog log = null;

       static void Logger(string function, Action tryHandle, Action<Exception> catchHandle = null,
         Action finallyHandle = null)
       {
           LogHelper.Logger(log, function, ErrorHandle.Throw, tryHandle, catchHandle, finallyHandle);

       } 
       #endregion

       #region IEnumerable的扩展

       #region 将集合展开分别转换成字符串，再以指定的分隔符衔接，拼成一个字符串返回
       /// <summary>
       /// 将集合展开分别转换成字符串，再以指定的分隔符衔接，拼成一个字符串返回
       /// </summary>
       /// <typeparam name="T">动态类型</typeparam>
       /// <param name="collection">要处理的集合</param>
       /// <param name="separator">分隔符</param>
       /// <returns>拼接后的字符串</returns>
       public static string ExpandAndToString<T>(this IEnumerable<T> collection, string separator)
       {
           List<T> source = collection as List<T> ?? collection.ToList();
           if (source.IsEmpty())
           {
               return null;
           }
           string result = source.Cast<object>().Aggregate<object, string>(null, (curent, o) => curent + string.Format("{0}{1}", o, separator));

           return result.Substring(0, result.Length - separator.Length);

       } 
       #endregion

       #region 集合是否为空
       /// <summary>
       /// 集合是否为空
       /// </summary>
       /// <typeparam name="T">动态类型</typeparam>
       /// <param name="collection">要处理的集合</param>
       /// <returns>为空返回True，不为空返回False</returns>
       public static bool IsEmpty<T>(this IEnumerable<T> collection)
       {
           return !collection.Any();
       } 
       #endregion

       #region IEnumerable<T>根据第三方条件是否为真决定是否执行指定条件的查询
       /// <summary>
       /// 根据第三方条件是否为真决定是否执行指定条件的查询
       /// </summary>
       /// <typeparam name="T">动态类型</typeparam>
       /// <param name="source">要查询的数据源</param>
       /// <param name="predicate">查询条件</param>
       /// <param name="condition">第三方条件</param>
       /// <returns>查询的结果</returns>
       public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> source, Func<T, bool> predicate, bool condition)
       {
           return condition ? source.Where(predicate) : source;
       }

       #region 根据指定的条件返回集合中不重复的元素
       /// <summary>
       /// 根据指定的条件返回集合中不重复的元素
       /// </summary>
       /// <typeparam name="T">动态类型</typeparam>
       /// <typeparam name="TKey">动态筛选条件类型</typeparam>
       /// <param name="source">要操作的数据源</param>
       /// <param name="keySelector">重复数据筛选条件</param>
       /// <returns>不重复元素的集合</returns>
       public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> source, Func<T, TKey> keySelector)
       {
           //取集合分组后的每组中的第一条数据，组成新的集合
           return source.GroupBy(keySelector).Select(group => group.First());
       } 
       #endregion
       #endregion
       #endregion

       #region IQueryable扩展

        #region IQueryable<T>根据第三方条件是否为真决定是否执行指定条件的查询
       /// <summary>
       /// 根据第三方条件是否为真决定是否执行指定条件的查询
       /// </summary>
       /// <typeparam name="T">动态类型</typeparam>
       /// <param name="source">要查询的数据源</param>
       /// <param name="predicate">查询条件</param>
       /// <param name="condition">第三方条件</param>
       /// <returns>查询的结果</returns>
       public static IQueryable<T> WhereIf<T>(this IQueryable<T> source, Expression<Func<T, bool>> predicate, bool condition)
       {
           PublicHelper.CheckArgument(predicate, "predicate");
           return condition ? source.Where(predicate) : source;
       } 
       #endregion

        #region 把Queryable<T>集合按指定属性与排序方式进行排序
       /// <summary>
        /// 把Queryable<T>集合按指定属性与排序方式进行排序
        /// </summary>
        /// <typeparam name="T">动态类型</typeparam>
        /// <param name="source">要排序的数据集</param>
        /// <param name="propertyName">排序的属性名称</param>
        /// <param name="listSortDirection">排序的方向</param>
        /// <returns>排序后的结果集</returns>
        public static IOrderedQueryable<T> OrderBy<T>(this IQueryable<T> source,
            string propertyName, ListSortDirection listSortDirection = ListSortDirection.Ascending)
        {
            PublicHelper.CheckArgument(propertyName, "propertyName");
            return QueryableHelper<T>.OrderBy(source, propertyName, listSortDirection);
        } 
        #endregion

        #region 把Queryable<T>集合按指定属性与排序方式进行排序
        /// <summary>
        /// 把Queryable<T>集合按指定属性与排序方式进行排序
        /// </summary>
        /// <typeparam name="T">动态类型</typeparam>
        /// <param name="source">要排序的数据集</param>
        /// <param name="propertyName">排序的属性名称</param>
        /// <param name="listSortDirection">排序的方向</param>
        /// <returns>排序后的结果集</returns>
        public static IOrderedQueryable<T> OrderBy<T>(this IQueryable<T> source,
            PropertySortCondition<T> sortCondition)
        {
            PublicHelper.CheckArgument(sortCondition, "sortCondition");
            return source.OrderBy(sortCondition.PropertyName, sortCondition.ListSortDirection);
        }
        #endregion

        #region 把IOrderedQueryable<T>集合按指定属性与排序方式进行排序
        /// <summary>
        /// 把IOrderedQueryable<T>集合按指定属性与排序方式进行排序
        /// </summary>
        /// <typeparam name="T">动态类型</typeparam>
        /// <param name="source">要排序的数据集</param>
        /// <param name="propertyName">排序的属性名称</param>
        /// <param name="listSortDirection">排序的方向</param>
        /// <returns>排序后的结果集</returns>
        public static IOrderedQueryable<T> ThenBy<T>(this IOrderedQueryable<T> source,
            string propertyName, ListSortDirection listSortDirection = ListSortDirection.Ascending)
        {
           
            return QueryableHelper<T>.ThenBy(source, propertyName, listSortDirection);
        }
        #endregion

        #region 把IOrderedQueryable<T>集合按指定属性与排序方式进行排序
        /// <summary>
        /// 把IOrderedQueryable<T>集合按指定属性与排序方式进行排序
        /// </summary>
        /// <typeparam name="T">动态类型</typeparam>
        /// <param name="source">要排序的数据集</param>
        /// <param name="propertyName">排序的属性名称</param>
        /// <param name="listSortDirection">排序的方向</param>
        /// <returns>排序后的结果集</returns>
        public static IOrderedQueryable<T> ThenBy<T>(this IOrderedQueryable<T> source,
            PropertySortCondition<T> sortCondition)
        {
            IOrderedQueryable<T> result = null;
            log = LogManager.GetLogger(string.Format("DAL_{0}", typeof(T).Name));

            Logger("根据条件分页查询并输出总行数" + typeof(T).Name + "中的数据", () =>
            {
                result = QueryableHelper<T>.ThenBy(source, sortCondition.PropertyName, sortCondition.ListSortDirection);
            });
            return result;
        }
        #endregion

        #region IQueryable<T>分页查询
        /// <summary>
        /// 把Queryable<T>集合按指定属性与排序方式进行排序后
        /// 再按指定的条件提前指定页码指定条目的数据
        /// </summary>
        /// <typeparam name="T">动态类型</typeparam>
        /// <param name="source">Queryable<T>数据源</param>
        /// <param name="predicate">检索条件</param>
        /// <param name="pageIndex">指定页码</param>
        /// <param name="pageSize">提定每页的条目数</param>
        /// <param name="total">总页数</param>
        /// <param name="sorConditions">排序的条件</param>
        /// <returns>子集</returns>
        public static IQueryable<T> Where<T>(this IQueryable<T> source, Expression<Func<T, bool>> predicate
            , int pageIndex, int pageSize, out int total, params PropertySortCondition<T>[] sorConditions) where T : class,new()
        {

            IQueryable<T> result = null;
            log = LogManager.GetLogger(string.Format("DAL_{0}", typeof(T).Name));
            int totalRow = 0;

            Logger("根据条件分页查询并输出总行数" + typeof(T).Name + "中的数据", () =>
            {

                if (PublicHelper.CheckArgument(source, "source")
                 && PublicHelper.CheckArgument(predicate, "predicate")
                 && PublicHelper.CheckArgument(pageIndex, "pageIndex")
                 && PublicHelper.CheckArgument(pageSize, "pageSize")
                 )
                {
                    //判断是不是首个排序条件
                    int count = 0;
                    //得到满足查询条件的总记录数
                    totalRow = source.Count(predicate);
                    //对数据源进行排序
                    IOrderedQueryable<T> orderSource = null;
                    foreach (PropertySortCondition<T> sorCondition in sorConditions)
                    {
                        orderSource = count == 0
                            ? source.OrderBy(sorCondition.PropertyName, sorCondition.ListSortDirection)
                            : orderSource.ThenBy(sorCondition.PropertyName, sorCondition.ListSortDirection);
                        count++;
                    }

                    source = orderSource;
                    result = source != null
                        ? source.Where(predicate).Skip((pageIndex - 1) * pageSize).Take(pageSize)
                        : Enumerable.Empty<T>().AsQueryable();
                }
            });
            total = totalRow;
            return result;
        }
        #endregion



        #endregion
   }
}

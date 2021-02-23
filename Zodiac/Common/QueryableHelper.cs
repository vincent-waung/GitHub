using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Collections.Concurrent;
namespace Common
{
     public  class QueryableHelper<T>
    {
         //做一个缓存，保存转换后的结果，方便下次直接使用
         private static readonly ConcurrentDictionary<string, LambdaExpression> Cache
             = new ConcurrentDictionary<string, LambdaExpression>();
         /// <summary>
         /// 对某个数据源按照某列，某个方向进行排序
         /// </summary>
         /// <param name="source">IQueryable要排序的数据源</param>
         /// <param name="propertyName">排序字段</param>
         /// <param name="listSortDirection">排序的方向</param>
         /// <returns>排序后的结果</returns>
         public static IOrderedQueryable<T> OrderBy(IQueryable<T> source,string propertyName
             ,ListSortDirection listSortDirection)
         {
            dynamic keySelector = GetLambdaExpression(propertyName);
            return listSortDirection == ListSortDirection.Ascending
                ? Queryable.OrderBy(source, keySelector)
                : Queryable.OrderByDescending(source, keySelector);
         }

         /// <summary>
         /// 对某个数排序后据源再按照某列，某个方向进行排序
         /// </summary>
         /// <param name="source">IOrderedQueryable要排序的数据源</param>
         /// <param name="propertyName">排序字段</param>
         /// <param name="listSortDirection">排序的方向</param>
         /// <returns>排序后的结果</returns>
         public static IOrderedQueryable<T> ThenBy(IOrderedQueryable<T> source, string propertyName
             , ListSortDirection listSortDirection)
         {
             dynamic keySelector = GetLambdaExpression(propertyName);
             return listSortDirection == ListSortDirection.Ascending
                 ? Queryable.OrderBy(source, keySelector)
                 : Queryable.OrderByDescending(source, keySelector);
         }
         /// <summary>
         /// 把属性转换成Lambda表达式
         /// </summary>
         /// <param name="propertyName"></param>
         /// <returns></returns>
         private static LambdaExpression GetLambdaExpression(string propertyName)
         {
             ParameterExpression param = Expression.Parameter(typeof(T));
             MemberExpression body = Expression.Property(param, propertyName);
             LambdaExpression keySelector = Expression.Lambda(body, param);

             return keySelector;
         }
    }
}

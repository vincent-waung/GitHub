using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 属性排序条件
    /// </summary>
   public class PropertySortCondition<T>
    {
        /// <summary>
        /// 构造一个属性名称的升序排序的排序条件
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="listSortDirection"></param>
       public PropertySortCondition(string propertyName):this(propertyName,ListSortDirection.Ascending)
       {
       }

       /// <summary>
       /// 构造一个属性名称和排序方式的排序条件
       /// </summary>
       /// <param name="propertyName"></param>
       /// <param name="listSortDirection"></param>

       public PropertySortCondition(string propertyName, ListSortDirection listSortDirection)
       {
           PropertyName = propertyName;
           ListSortDirection = listSortDirection;
       }


       public PropertySortCondition(Expression<Func<T, object>> ignoreProperty, ListSortDirection listSortDirection = ListSortDirection.Ascending)
       {
           PropertyName = new PropertyExpressionParser<T>(ignoreProperty).Name; ;
           ListSortDirection = listSortDirection;
       }
       /// <summary>
       /// 获取或设置 排序属性名称
       /// </summary>
        public string PropertyName { get; set; }

       /// <summary>
       /// 获取或设置排序方向
       /// </summary>
        public ListSortDirection ListSortDirection { get; set; }
    }
}

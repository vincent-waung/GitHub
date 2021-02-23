using Common;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MvcZodiac.Areas.Models
{
    public partial class Model_Sys_Log
    {
        #region 根据筛选条件查询日志信息+IQueryable<Sys_UserInfo>
        private static IQueryable<Sys_Log> GetLogInfoForIQueryable(out int total, int page, int rows,
            DateTime operDateStart, DateTime operDateEnd, string Logger = "", string sort = null, string order = null)
        {
            total = 0;
            PropertySortCondition<Sys_Log> psc = null;
            if (sort == null)
            {
                psc = new PropertySortCondition<Sys_Log>(u => u.Date,ListSortDirection.Descending);
            }
            else
            {
                psc = new PropertySortCondition<Sys_Log>(sort, order.Equals("asc") ? ListSortDirection.Ascending : ListSortDirection.Descending);
            }
            Expression<Func<Sys_Log, bool>> predicate = null;

            predicate = u => u.Logger.Contains(Logger) && 
                u.Date >= operDateStart && u.Date <= operDateEnd;
            //lambda写法
            //var logs = oc.BllSession.ISys_LogBLL.Entities.Where(predicate, page, rows, out total, psc);
            //linq的写法
            //var fLogs = (from log in oc.BllSession.ISys_LogBLL.Entities
            //             where log.Logger.Contains(Logger) &&
            //     log.Date >= operDateStart && log.Date <= operDateEnd
            //             orderby log.Date descending
            //             select log).Skip((page - 1) * rows).Take(rows);
            var fLogs = (from log in oc.BllSession.ISys_LogBLL.Entities                     
                         orderby log.Date descending
                         select log).Skip((page - 1) * rows).Take(rows);
            fLogs = fLogs.Where(predicate);
            return fLogs;
            
        }
        #endregion

        #region 根据筛选条件查询日志信息
        /// <summary>
        /// 根据筛选条件查询日志信息
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="rows">每页条数</param>
        /// <param name="operDateStart">起始日期</param>
        /// <param name="operDateEnd">截止日期</param>
        /// <param name="depId">所属部门</param>
        /// <param name="uLoginName">登录名</param>
        /// <param name="sort">排序字段</param>
        /// <param name="order">排序方向</param>
        /// <returns>根据指定条件返回日志信息</returns>
        public static dynamic GetLogInfoByCondition(int page, int rows,
            DateTime operDateStart, DateTime operDateEnd, string Logger = "", string sort = null, string order = null)
        {
            int total = 0;
            var logs = GetLogInfoForIQueryable(out total, page, rows, operDateStart, operDateEnd, 
                Logger, sort, order);

            var logsList = logs.ToList();

            return new DataGrid
            {
                total = total,
                rows = logsList,
                footer = null
            };
        }
        #endregion
    }
}
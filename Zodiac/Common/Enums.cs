using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /*HTTP请求的方式*/
    public enum HttpMethod
    {
        Get = 1,
        Post = 2,
        HEAD = 3
    }
    public enum ErrorHandle
    { 
        Throw,
        Continue
    }
    public enum AjaxStatu
    { 
        ok=1,
        err=2,
        none=3,
        nologin=4,
        noperm=5
    }
    // 指定排序操作的方向。
    public enum ListSortDirection
    {
        // 摘要: 
        //     按升序排序。
        Ascending = 0,
        //
        // 摘要: 
        //     按降序排序。
        Descending = 1,
    }
}

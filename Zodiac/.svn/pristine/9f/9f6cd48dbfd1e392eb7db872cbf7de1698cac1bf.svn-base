using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Reflection;

public static class Extensions
{
    /// <summary>
    /// 把DataRow直接转换成对应的实体对象Model
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="dr"></param>
    /// <returns></returns>
    public static T ToModel<T>(this DataRow dr)//我们给DataRow新增了一个扩展方法
    {
        T t = Activator.CreateInstance<T>();
        // 获得此模型的公共属性  
        string tempName = "";
        PropertyInfo[] propertys = t.GetType().GetProperties();
        foreach (PropertyInfo pi in propertys)
        {
            tempName = pi.Name;  // 检查DataTable是否包含此列
            if (dr.Table.Columns.Contains(tempName))
            {
                // 判断此属性是否有Setter      
                if (!pi.CanWrite)
                {
                    continue;
                }
                object value = dr[tempName];
                if (value != DBNull.Value)
                {
                    pi.SetValue(t, value, null);
                }
            }
        }
        return t;
    }
}
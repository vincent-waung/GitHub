using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
   public static class ObjectExtensions
   {

        #region 把对象类型转化为指定的类型，转化失败时返回类型的默认值
       /// <summary>
        /// 把对象类型转化为指定的类型，转化失败时返回类型的默认值
        /// </summary>
        /// <typeparam name="T">动态类型</typeparam>
        /// <param name="value">要转化的原对象</param>
        /// <param name="defaultValue">转化失败时返回类型的默认值</param>
        /// <returns>转化后指定类型对象，转化失败时返回类型的默认值</returns>
        public static T CastTo<T>(this object value)
        {
            object result;
            Type type = typeof(T);
            try
            {
             if(type.IsEnum)
             {
                 result = Enum.Parse(type, value.ToString());
             }
             else if (type == typeof(Guid))
             {
                 result = Guid.Parse(value.ToString());
             }
             else
             {
                 result = Convert.ChangeType(value, type);
             }

            }
            catch
            {
                result = default(T);
            }

            return (T)result;
        }
        #endregion

        #region 把对象类型转化为指定的类型，转化失败时返回指定的默认值
        /// <summary>
        /// 把对象类型转化为指定的类型，转化失败时返回指定的默认值
        /// </summary>
        /// <typeparam name="T">动态类型</typeparam>
        /// <param name="value">要转化的原对象</param>
        /// <param name="defaultValue">转化失败时指定的默认值</param>
        /// <returns>转化后指定类型对象，转化失败时返回指定的默认值</returns>
        public static T CastTo<T>(this object value, T defaultValue)
        {
            object result;
            Type type = typeof(T);
            try
            {
                result = type.IsEnum ? Enum.Parse(type, value.ToString()) : Convert.ChangeType(value, type);
            }
            catch
            {
                return defaultValue;
            }

            return (T)result;
        } 
        #endregion
    }
}

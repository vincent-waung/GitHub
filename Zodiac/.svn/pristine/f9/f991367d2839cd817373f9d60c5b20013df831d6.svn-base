using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel;
namespace Common
{
   public static class TypeExtensions
    {

        #region 判断指定的类型是否为数值类型
        /// <summary>
        /// 判断指定的类型是否为数值类型
        /// </summary>
        /// <param name="type">要检查的类型</param>
        /// <returns>是否是数值类型</returns>
        public static bool IsNumeric(this Type type)
        {
            return type == typeof(Byte)
                || type == typeof(Int16)
                || type == typeof(Int32)
                || type == typeof(Int64)
                || type == typeof(SByte)
                || type == typeof(UInt16)
                || type == typeof(UInt32)
                || type == typeof(UInt64)
                || type == typeof(Decimal)
                || type == typeof(Double)
                || type == typeof(Single);

        } 
        #endregion

        #region 获取成员元数据的Description特性描述信息
        /// <summary>
        /// 获取成员元数据的Description特性描述信息
        /// </summary>
        /// <param name="memberInfo">成员元数据对象</param>
        /// <param name="inherit">是否从继承中查找</param>
        /// <returns>存在返回描述信息，否则返回为空</returns>
        public static string GetDescription(this ICustomAttributeProvider memberInfo, bool inherit =false)
        {
            DescriptionAttribute desc = memberInfo.GetAttribute<DescriptionAttribute>(inherit);
            return desc == null ? "无描述信息" : desc.Description;
        } 
        #endregion

        #region 检查指定类型成员中是否存在指定的Attributes特性
        /// <summary>
        /// 检查指定类型成员中是否存在指定的Attributes特性
        /// </summary>
        /// <typeparam name="T">要检查的Attributes特性类</typeparam>
        /// <param name="memberInfo">要检查的类型成员</param>
        /// <param name="inherit">是否从继承中查找</param>
        /// <returns>是否存在</returns>
        public static bool AttributeExists<T>(this ICustomAttributeProvider memberInfo, bool inherit) where T : Attribute
        {
            return memberInfo.IsDefined(typeof(T), inherit);
            //return memberInfo.GetCustomAttributes(typeof(T), inherit).Any(m => (m as T) != null);
        } 
        #endregion

        #region 从类型成员获取指定的Attribute特性
       /// <summary>
        /// 得到memberInfo对象上的T特性集合中第一个
       /// </summary>
        /// <typeparam name="T">Attribute特性类型</typeparam>
        /// <param name="memberInfo">实现了ICustomAttributeProvider接口的类实例</param>
       /// <param name="inherit">是否从继承中查找</param>
       /// <returns>存在返回第一个，不存在返回null</returns>
        public static T GetAttribute<T>(this ICustomAttributeProvider memberInfo, bool inherit) where T : Attribute
        {
            return memberInfo.GetCustomAttributes(typeof(T), inherit).SingleOrDefault() as T;
        }
        #endregion

        #region 从类型成员获取指定的Attribute特性
        /// <summary>
        /// 得到memberInfo对象上的T特性集合
        /// </summary>
        /// <typeparam name="T[]">Attribute特性类型集合</typeparam>
        /// <param name="memberInfo">实现了ICustomAttributeProvider接口的类实例</param>
        /// <param name="inherit">是否从继承中查找</param>
        /// <returns>存在返回第一个，不存在返回null</returns>
        public static T[] GetAttributes<T>(this ICustomAttributeProvider memberInfo, bool inherit) where T : Attribute
        {
            return memberInfo.GetCustomAttributes(typeof(T), inherit).Cast<T>().ToArray();
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Context;
using Spring.Context.Support;
namespace DI
{
  public class SpringHelper
  {
      #region Spring.NET容器上下文
      private static IApplicationContext SpringContext
      {
          get
          {
              return ContextRegistry.GetContext();
          }
      }
      #endregion

      #region 使用Spring操作配置文件并转化为对象
      public static T GetObject<T>(string objName) where T : class
      {
          T o = (T)SpringContext.GetObject(objName);
          return o;
      }
      #endregion
  }
}

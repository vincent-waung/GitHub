using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using log4net;
namespace Common.Log
{
  public  class LogHelper
  {
      #region 全局设置
      public static void InitLog4net()
      {
          Assembly assembly = Assembly.GetExecutingAssembly();
          var xml = assembly.GetManifestResourceStream("Common.Log.Log4net.config");
          log4net.Config.XmlConfigurator.Configure(xml);
      }
      #endregion
      
      #region 利用Action委托封装LOG4NET对方法的处理方法
      /// <summary>
      ///利用Action委托封装LOG4NET对方法的处理方法
      /// </summary>
      /// <param name="log">日志对象</param>
      /// <param name="function">方法名</param>
      /// <param name="errorHandle">异常处理方法</param>
      /// <param name="tryHandle">调试/运行代码</param>
      /// <param name="catchHandle">异常处理方式</param>
      /// <param name="finallyHandle">最终处理方式</param>
      public static void Logger(ILog log, string function, ErrorHandle errorHandle, Action tryHandle, Action<Exception> catchHandle = null,
          Action finallyHandle = null)
      {
          try
          {
              log.Debug(function);
              tryHandle();
          }
          catch (Exception ex)
          {
              log.Error(function + "失败", ex);
              if (catchHandle != null)
              {
                  catchHandle(ex);
              }
              if (errorHandle == ErrorHandle.Throw)
              {
                  throw ex;
              }
          }
          finally
          {
              if (finallyHandle != null)
              {
                  finallyHandle();
              }
          }
      } 
      #endregion

      #region 单独封装处理日志的方式
      private static ILog myLog = LogManager.GetLogger("CustomerErrorProcess");

      /// <summary>
      /// 记录日志信息
      /// </summary>
      /// <param name="msg"></param>
      public static void Info(string msg)
      {
          myLog.Info(msg);
      }
      /// <summary>
      /// 记录错误信息
      /// </summary>
      /// <param name="msg"></param>
      public static void Error(string msg)
      {
          myLog.Error(msg);
      }
      /// <summary>
      /// 记录错误信息及异常对象
      /// </summary>
      /// <param name="msg"></param>
      /// <param name="ex"></param>
      public static void Error(string msg, Exception ex)
      {
          myLog.Error(msg, ex);
      }
      #endregion
  }
}

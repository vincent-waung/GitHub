using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Log
{
    public class BaseLog<T> where T:new()
    {
      protected static ILog log = LogManager.GetLogger(string.Format("DAL_{0}", typeof(T).Name));

      protected static void Logger(string function, Action tryHandle, Action<Exception> catchHandle = null,
        Action finallyHandle = null)
      {
          LogHelper.Logger(log, function, ErrorHandle.Throw, tryHandle, catchHandle, finallyHandle);
      
      }
    }
}

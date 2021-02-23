using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common.Log;
namespace MvcZodiac
{
   public class MyFrameworkConfig
    {
       public static void Register()
       {
           LogHelper.InitLog4net(); 
       }
      
    }
}
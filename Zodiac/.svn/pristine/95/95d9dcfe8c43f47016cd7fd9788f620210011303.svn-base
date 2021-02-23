using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;
using IBLL;
namespace BLLMsSql
{
   public class BLLSessionFactory:IBLLSessionFactory
    {
       public IBLLSession GetBLLSesson()
       {
           IBLLSession bllSession = CallContext.GetData(typeof(BLLSessionFactory).Name) as BLLSession;

           if (bllSession == null)
           {
               bllSession = new BLLSession();
               CallContext.SetData(typeof(BLLSessionFactory).Name, bllSession);
           }

           return bllSession;
       }
    }
}

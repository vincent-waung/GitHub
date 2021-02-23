using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Web.Script.Serialization;
using System.Web.Security;
namespace Common
{
   public class DataHelper
   {
       #region  把对象转换成JSON格式
       //js序列化器
       static JavaScriptSerializer jss = new JavaScriptSerializer();
       /// <summary>
       /// 把对象转换成JSON格式
       /// </summary>
       /// <param name="obj">对象</param>
       /// <returns>json格式数据</returns>
       public static string ObjToJson(object obj)
       {

           return jss.Serialize(obj);
       }
       #endregion

       #region 把一个字符串进行MD5加密
       public static string Md5(string str)
       {
           return FormsAuthentication.HashPasswordForStoringInConfigFile(str, FormsAuthPasswordFormat.MD5.ToString());
       }
       #endregion


       ///<summary>  
       /// 将Json序列化的时间由/Date(1294499956278+0800)转为字符串 
       /// </summary>
       public static string ConvertJsonDateToDateString(Match m)
       {
           string result = string.Empty;
           DateTime dt = new DateTime(1970, 1, 1);
           dt = dt.AddMilliseconds(long.Parse(m.Groups[1].Value));
           dt = dt.ToLocalTime();
           result = dt.ToString("yyyy-MM-dd HH:mm:ss");
           return result;
       }

       public static string JsonSerializer<T>(T t)
       {
           DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
           MemoryStream ms = new MemoryStream();
           ser.WriteObject(ms, t);
           string jsonString = Encoding.UTF8.GetString(ms.ToArray());
           ms.Close();

           //替换Json的Date字符串
           string p = @"\\/Date\((\d+)\+\d+\)\\/";
           MatchEvaluator matchEvaluator = new MatchEvaluator(ConvertJsonDateToDateString);
           Regex reg = new Regex(p);
           jsonString = reg.Replace(jsonString, matchEvaluator);

           //string jsonString = JsonConvert.SerializeObject(t);

           return jsonString;
       }

       /// <summary>
       /// JSON反序列化
       /// </summary>
       public static T JsonDeserialize<T>(string jsonString)
       {
           //将"yyyy-MM-dd HH:mm:ss"格式的字符串转为"\/Date(1294499956278+0800)\/"格式  
           string p = @"\d{2}/\d{2}/\d{4}";
           System.Text.RegularExpressions.MatchEvaluator matchEvaluator = new System.Text.RegularExpressions.MatchEvaluator(ConvertDateStringToJsonDate);
           System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(p);
           jsonString = reg.Replace(jsonString, matchEvaluator);
           jsonString = jsonString.Replace("\n", "\\n");
           jsonString = jsonString.Replace("\r", "\\r");

           DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
           MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
           T obj = (T)ser.ReadObject(ms);
           return obj;

           //JsonSerializer serializer = new JsonSerializer();
           //StringReader sr = new StringReader(jsonString);
           //object o = serializer.Deserialize(new JsonTextReader(sr), typeof(T));
           //T t = (T)o;
           //return t;
       }




       /// <summary>
       /// 将时间字符串转为Json时间 
       /// </summary>  
       private static string ConvertDateStringToJsonDate(Match m)
       {
           string result = string.Empty;
           DateTime dt = DateTime.Parse(m.Groups[0].Value);
           dt = dt.ToUniversalTime();
           TimeSpan ts = dt - DateTime.Parse("1970-01-01");
           result = string.Format("\\/Date({0}+0800)\\/", ts.TotalMilliseconds);
           return result;
       }


   }
}

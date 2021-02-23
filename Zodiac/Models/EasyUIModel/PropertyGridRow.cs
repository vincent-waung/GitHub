using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   /// <summary>
   /// 属性表格的实体模型
   /// </summary>
   public class PropertyGridRow
    {
        public string name { get; set; }

        public string value { get; set; }

        public string group { get; set; }

        public string editor { get; set; }
    }
}

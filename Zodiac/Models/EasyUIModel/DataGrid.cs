using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// easyuidatagrid模型
    /// </summary>
   public class DataGrid
    {
        public int total { get; set; }
        public object rows { get; set; }
        public object footer { get; set; }

    }
}

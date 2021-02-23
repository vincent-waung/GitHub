using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class FinalLoadingPlan
    {
        public DateTime Arrive_WHS_Date { get; set; }

        public DateTime Arrived_Terminal { get; set; }

        public DateTime Leave_factory_time { get; set; }


        public string Transport_mode { get; set; }

        public bool POD { get; set; }
    }
}

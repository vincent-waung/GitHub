using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ReportModel
{
    public class R_LoadPlan_Overall
    {

        public string Mfr_Name1 { get; set; }
        public string FOB_Customer_Name { get; set; }
        public int TotalNoofPOitem { get; set; }
        public int? TotalQty{ get; set; }
        public int ConfirmedPO { get; set; }
        public decimal? ConfirmedCBM { get; set; }
        public string Completed { get; set; }

        public int? ConfirmedQty { get; set; }

        public decimal? Total_CBM { get; set; }
        public int NoConfirmeItem { get; set; }
        public int? NoConfirmedQty { get; set; }
        public decimal? NoConfirmedCBM { get; set; }
    }
}

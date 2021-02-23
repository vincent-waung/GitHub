using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ReportModel
{
    public class R_Polist_Dashboard
    {

        public string Management { get; set; }
        public string SepItem { get; set; }
        public string OctItem { get; set; }
        public string NovItem { get; set; }
        public string PoItem { get; set; }
        public string percentage { get; set; }
        public string POpercentage { get; set; }
        public decimal? CBM { get; set; }
        public string CBMpercentage { get; set; }



        public List<R_LoadPlan_DailyReport> AbnormalloadplanList { get; set; }
        public List<R_LoadPlan_DailyReport> ShippedloadplanList { get; set; }
        public List<R_LoadPlan_DailyReport> OntrackloadplanList { get; set; }

        public List<R_LoadPlan_DailyReport> NobookingAbnormalloadplanList { get; set; }

        public List<R_LoadPlan_DailyReport> NOActualAbnormalloadplanList { get; set; }

        public List<R_LoadPlan_DailyReport> NOCertificateAbnormalloadplanList { get; set; }

        public List<R_LoadPlan_DailyReport> NoSoDateAbnormalloadplanList { get; set; }

        public List<R_LoadPlan_DailyReport> VarianceAbnormalloadplanList { get; set; }

        public List<R_LoadPlan_Overall> OverallloadplanList { get; set; }

        public List<R_LoadPlan_Overall> NextloadplanList { get; set; }

        public decimal? SepCBM { get; set; }

        public decimal? OctCBM { get; set; }

        public decimal? NovCBM { get; set; }

        public List<R_LoadPlan_Overall> uploadplanList { get; set; }
    }
}

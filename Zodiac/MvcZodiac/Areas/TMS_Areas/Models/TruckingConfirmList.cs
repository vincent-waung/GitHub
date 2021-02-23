using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcZodiac.Areas.TMS_Areas.Models
{
    public class TruckingConfirmList
    {

        public int plid { get; set; }
        public string VendorCode { get; set; }
        public string so_no { get; set; }
        public string Customer_PO { get; set; }
        public Nullable<System.DateTime> pick_date { get; set; }
        public Nullable<int> pcs { get; set; }
        public string Material { get; set; }
        public string Item { get; set; }
        public string hfe { get; set; }
        public string Line { get; set; }
        public Nullable<int> Ctn { get; set; }
        public Nullable<int> availablectn { get; set; }
        public Nullable<decimal> availableweight { get; set; }
        public Nullable<decimal> availableCBM { get; set; }
        public Nullable<int> Booking_Ctn { get; set; }
        public Nullable<decimal> GrossWeight { get; set; }
        public Nullable<decimal> CBM { get; set; }
        public string delivery_type { get; set; }
        public string remarks { get; set; }
        public string pick_address { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class bookingHead
    {
        public int hId { get; set; }
        public string so_no { get; set; }
        public string Shipper { get; set; }
        public string Consignee { get; set; }
        public string Notifyparty { get; set; }
        public string AlsoNotify { get; set; }
        public string ContSize { get; set; }
        public string UnloadingPort { get; set; }
        public string LoadingPort { get; set; }
        public string DestinationPort { get; set; }
        public Nullable<System.DateTime> OpenDate { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }
        public Nullable<System.DateTime> InputDate { get; set; }
        public string @operator { get; set; }
        public string TelNo { get; set; }
        public Nullable<decimal> TotGrossWeight { get; set; }
        public Nullable<int> TotPcs { get; set; }
        public Nullable<int> TotCtn { get; set; }
        public Nullable<decimal> TotCBM { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }
        public Nullable<System.DateTime> precastInHouseDate { get; set; }
        public string account { get; set; }
        public string inputOperator { get; set; }
        public string cancelOperator { get; set; }
        public string vessel { get; set; }
        public string voyage { get; set; }
        public string BLNO { get; set; }
        public Nullable<System.DateTime> ETD { get; set; }
        public Nullable<System.DateTime> SI_cut_off { get; set; }
        public Nullable<System.DateTime> CY_closing_date { get; set; }
        public string Client_Operator { get; set; }
        public string cutomer_name { get; set; }
        public Nullable<System.DateTime> first_date { get; set; }
        public Nullable<System.DateTime> cancel_date { get; set; }
        public Nullable<System.DateTime> confirm_date { get; set; }
        public string clpno { get; set; }
        public string client { get; set; }
        public string service_type { get; set; }
        public Nullable<bool> printed { get; set; }
        public string shipping_mark { get; set; }
        public string Shipper2 { get; set; }
        public string Consignee2 { get; set; }
        public string Notifyparty2 { get; set; }
    }
}

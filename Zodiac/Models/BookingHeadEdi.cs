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
    
    public partial class BookingHeadEdi
    {
        public string so_no { get; set; }
        public Nullable<System.DateTime> input_time { get; set; }
        public string shipper_ref { get; set; }
        public string vessel { get; set; }
        public string voyage { get; set; }
        public string POD { get; set; }
        public string dest_code { get; set; }
        public string dest { get; set; }
        public string consg_code { get; set; }
        public Nullable<int> totqty { get; set; }
        public Nullable<decimal> totweight { get; set; }
        public Nullable<decimal> totcbm { get; set; }
        public Nullable<decimal> totpcs { get; set; }
        public Nullable<decimal> rec_totqty { get; set; }
        public Nullable<decimal> rec_totweight { get; set; }
        public Nullable<decimal> rec_totcbm { get; set; }
        public Nullable<decimal> rec_totpcs { get; set; }
        public Nullable<System.DateTime> rec_date { get; set; }
        public Nullable<bool> EDI_Status { get; set; }
        public string EDIFile_In { get; set; }
        public string EDIFile_Out { get; set; }
        public string EDI_Account { get; set; }
        public Nullable<System.DateTime> XFactory_Date { get; set; }
        public Nullable<System.DateTime> NLT { get; set; }
        public string Ship_To_Name { get; set; }
        public string vendor { get; set; }
    }
}

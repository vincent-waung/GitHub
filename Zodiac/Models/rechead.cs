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
    
    public partial class rechead
    {
        public string so_no { get; set; }
        public decimal seq_no { get; set; }
        public string client { get; set; }
        public string vendor { get; set; }
        public int totctns { get; set; }
        public string account { get; set; }
        public string vess_voy { get; set; }
        public Nullable<decimal> totcbm { get; set; }
        public bool Rec_Status { get; set; }
        public bool linked { get; set; }
        public Nullable<System.DateTime> fsd { get; set; }
        public Nullable<System.DateTime> lsd { get; set; }
        public Nullable<bool> EDI_Status { get; set; }
        public Nullable<decimal> totwei { get; set; }
        public Nullable<bool> Ispartial { get; set; }
        public string SkMark { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models.PocoModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class POCO_collectlist
    {
        public string customer { get; set; }
        public string consg_code { get; set; }
        public System.DateTime collectdate { get; set; }
        public Nullable<decimal> rec_qty { get; set; }
        public Nullable<decimal> rec_cbm { get; set; }
        public Nullable<decimal> load_qty { get; set; }
        public Nullable<decimal> load_cbm { get; set; }
        public Nullable<decimal> qtybal { get; set; }
        public Nullable<decimal> cbmbal { get; set; }
    }
}

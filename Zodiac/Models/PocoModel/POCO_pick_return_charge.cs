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
    
    public partial class POCO_pick_return_charge
    {
        public int id { get; set; }
        public string pick_address { get; set; }
        public string return_address { get; set; }
        public string cont_size { get; set; }
        public Nullable<int> chargeID { get; set; }
        public Nullable<decimal> charge { get; set; }
        public string remark { get; set; }
    }
}

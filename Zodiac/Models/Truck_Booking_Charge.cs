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
    
    public partial class Truck_Booking_Charge
    {
        public string Booking_Number { get; set; }
        public string Seq { get; set; }
        public string ChargeName { get; set; }
        public Nullable<decimal> Charge { get; set; }
        public string Currency { get; set; }
        public Nullable<bool> Confirmed { get; set; }
        public string Remark { get; set; }
        public Nullable<bool> Upload { get; set; }
    }
}

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
    
    public partial class Loading
    {
        public int ID { get; set; }
        public string OrderNo { get; set; }
        public Nullable<System.DateTime> OperateDate { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string Employer { get; set; }
        public string Account { get; set; }
        public Nullable<int> Ctn { get; set; }
        public Nullable<int> Paires { get; set; }
        public Nullable<decimal> CBM { get; set; }
        public string VehicleType { get; set; }
        public string VehicleNumber { get; set; }
        public string Warehouse { get; set; }
    }
}

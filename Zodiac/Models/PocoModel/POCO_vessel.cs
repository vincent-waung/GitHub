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
    
    public partial class POCO_vessel
    {
        public string vessel1 { get; set; }
        public string voyage { get; set; }
        public string carry_no { get; set; }
        public string agent { get; set; }
        public string vessel_no { get; set; }
        public Nullable<System.DateTime> close_date { get; set; }
        public Nullable<System.DateTime> close_time { get; set; }
        public Nullable<System.DateTime> sail_date { get; set; }
        public string dest_port { get; set; }
        public Nullable<System.DateTime> ETD { get; set; }
        public Nullable<System.DateTime> ETA { get; set; }
        public string load_no { get; set; }
    }
}

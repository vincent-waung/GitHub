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
    
    public partial class Sys_RolePermission
    {
        public int rpId { get; set; }
        public int rpRId { get; set; }
        public int rpPId { get; set; }
        public bool rpIsDel { get; set; }
        public System.DateTime rpAddTime { get; set; }
    
        public virtual Sys_Permission Sys_Permission { get; set; }
        public virtual Sys_Role Sys_Role { get; set; }
    }
}

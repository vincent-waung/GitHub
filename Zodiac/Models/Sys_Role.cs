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
    
    public partial class Sys_Role
    {
        public Sys_Role()
        {
            this.Sys_RolePermission = new HashSet<Sys_RolePermission>();
            this.Sys_UserRole = new HashSet<Sys_UserRole>();
        }
    
        public int rId { get; set; }
        public int rDepId { get; set; }
        public string rName { get; set; }
        public string rRemark { get; set; }
        public bool rIsShow { get; set; }
        public bool rIsDel { get; set; }
        public System.DateTime rAddTime { get; set; }
    
        public virtual Sys_Department Sys_Department { get; set; }
        public virtual ICollection<Sys_RolePermission> Sys_RolePermission { get; set; }
        public virtual ICollection<Sys_UserRole> Sys_UserRole { get; set; }
    }
}
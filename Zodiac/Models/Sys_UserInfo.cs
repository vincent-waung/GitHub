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
    
    public partial class Sys_UserInfo
    {
        public Sys_UserInfo()
        {
            this.Sys_UserRole = new HashSet<Sys_UserRole>();
            this.Sys_UserVipPermission = new HashSet<Sys_UserVipPermission>();
        }
    
        public int uId { get; set; }
        public int uDepId { get; set; }
        public string uLoginName { get; set; }
        public string uPwd { get; set; }
        public bool uGender { get; set; }
        public string uPost { get; set; }
        public string uRemark { get; set; }
        public bool uIsDel { get; set; }
        public string uImgUrl { get; set; }
        public System.DateTime uAddTime { get; set; }
        public string uVendor_Code { get; set; }
        public string uTruck_Company_Code { get; set; }
    
        public virtual Sys_Department Sys_Department { get; set; }
        public virtual ICollection<Sys_UserRole> Sys_UserRole { get; set; }
        public virtual ICollection<Sys_UserVipPermission> Sys_UserVipPermission { get; set; }
    }
}
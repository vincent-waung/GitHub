//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Models
{
	public partial class Sys_UserRole
	{
		public Sys_UserRole ToPOCO(bool isPOCO = true){
			return new Sys_UserRole(){
				urId = this.urId,
				urUId = this.urUId,
				urRId = this.urRId,
				urIsDel = this.urIsDel,
				urAddtime = this.urAddtime,
			};
		}
	}
}
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
	public partial class ypmfuser
	{
		public ypmfuser ToPOCO(bool isPOCO = true){
			return new ypmfuser(){
				user_name = this.user_name,
				EmployeeID = this.EmployeeID,
				passcode = this.passcode,
				layer = this.layer,
				recloa = this.recloa,
				del = this.del,
				dec = this.dec,
				acc = this.acc,
				adminname = this.adminname,
				guest = this.guest,
				email = this.email,
			};
		}
	}
}

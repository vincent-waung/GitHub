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
	public partial class pick_return_charge
	{
		public pick_return_charge ToPOCO(bool isPOCO = true){
			return new pick_return_charge(){
				id = this.id,
				pick_address = this.pick_address,
				return_address = this.return_address,
				cont_size = this.cont_size,
				chargeID = this.chargeID,
				charge = this.charge,
				remark = this.remark,
			};
		}
	}
}

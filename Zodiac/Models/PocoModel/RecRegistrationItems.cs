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
	public partial class RecRegistrationItems
	{
		public RecRegistrationItems ToPOCO(bool isPOCO = true){
			return new RecRegistrationItems(){
				RegDID = this.RegDID,
				In_No = this.In_No,
				ItemSeq = this.ItemSeq,
				So_No = this.So_No,
				Amount = this.Amount,
				Client = this.Client,
				Prod_Des = this.Prod_Des,
				Inspection = this.Inspection,
				Remark = this.Remark,
			};
		}
	}
}

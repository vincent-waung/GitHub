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
	public partial class cus_hchg
	{
		public cus_hchg ToPOCO(bool isPOCO = true){
			return new cus_hchg(){
				client = this.client,
				start_wgt = this.start_wgt,
				end_wgt = this.end_wgt,
				chrg_amt = this.chrg_amt,
			};
		}
	}
}

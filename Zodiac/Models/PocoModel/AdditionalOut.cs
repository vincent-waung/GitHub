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
	public partial class AdditionalOut
	{
		public AdditionalOut ToPOCO(bool isPOCO = true){
			return new AdditionalOut(){
				id = this.id,
				operatedate = this.operatedate,
				so_no = this.so_no,
				recline = this.recline,
				po = this.po,
				skn = this.skn,
				sku = this.sku,
				ctns = this.ctns,
				pcs = this.pcs,
				cbm = this.cbm,
				account = this.account,
				Remark = this.Remark,
			};
		}
	}
}
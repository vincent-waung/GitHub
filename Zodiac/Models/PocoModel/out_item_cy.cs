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
	public partial class out_item_cy
	{
		public out_item_cy ToPOCO(bool isPOCO = true){
			return new out_item_cy(){
				ID = this.ID,
				aID = this.aID,
				so_no = this.so_no,
				order_no = this.order_no,
				po = this.po,
				stock_no = this.stock_no,
				pattern_no = this.pattern_no,
				pattern_name = this.pattern_name,
				rec_date = this.rec_date,
				destination = this.destination,
				pairage = this.pairage,
				ctn = this.ctn,
				cbm = this.cbm,
				weight = this.weight,
				supplier = this.supplier,
				commodity = this.commodity,
				packing = this.packing,
				htsus_no = this.htsus_no,
				line_no = this.line_no,
				Material_Group_Desc = this.Material_Group_Desc,
				ECV_Status = this.ECV_Status,
				Cases_Units_Status = this.Cases_Units_Status,
			};
		}
	}
}

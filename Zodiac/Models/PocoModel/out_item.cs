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
	public partial class out_item
	{
		public out_item ToPOCO(bool isPOCO = true){
			return new out_item(){
				clpno = this.clpno,
				oseq = this.oseq,
				consg_code = this.consg_code,
				so_no = this.so_no,
				seq = this.seq,
				LinkSeq = this.LinkSeq,
				g_no = this.g_no,
				stk = this.stk,
				po = this.po,
				sku = this.sku,
				pre_entry = this.pre_entry,
				in_no = this.in_no,
				case_no = this.case_no,
				style_no = this.style_no,
				item_no = this.item_no,
				patterno = this.patterno,
				pattern_name = this.pattern_name,
				sample_no = this.sample_no,
				cat_code = this.cat_code,
				descr = this.descr,
				pallet = this.pallet,
				qty = this.qty,
				ctns = this.ctns,
				pcs = this.pcs,
				unit = this.unit,
				unitwei = this.unitwei,
				weight = this.weight,
				length = this.length,
				width = this.width,
				height = this.height,
				cbm = this.cbm,
				Location = this.Location,
				remark = this.remark,
				la_no = this.la_no,
				plan_date = this.plan_date,
				beloaded = this.beloaded,
				remark1 = this.remark1,
				size = this.size,
				NewSeq = this.NewSeq,
				ScanQty = this.ScanQty,
				ScanFlag = this.ScanFlag,
				Act_Weight = this.Act_Weight,
			};
		}
	}
}
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
	public partial class in_head
	{
		public in_head ToPOCO(bool isPOCO = true){
			return new in_head(){
				so_no = this.so_no,
				client = this.client,
				consg_code = this.consg_code,
				load_port = this.load_port,
				dest = this.dest,
				dest_port = this.dest_port,
				division = this.division,
				bill_no = this.bill_no,
				cont_no = this.cont_no,
				frmctry = this.frmctry,
				etd = this.etd,
				eta = this.eta,
				nst = this.nst,
				nlt = this.nlt,
				factory = this.factory,
				vendor = this.vendor,
				vessel = this.vessel,
				voyage = this.voyage,
				seal_no = this.seal_no,
				btotal = this.btotal,
				completed = this.completed,
				cust = this.cust,
				commodity = this.commodity,
				ieflag = this.ieflag,
				repacked = this.repacked,
				remark1 = this.remark1,
				remark2 = this.remark2,
				remark = this.remark,
				LinkToIn = this.LinkToIn,
				socbm = this.socbm,
				poType = this.poType,
				cfsso = this.cfsso,
				whs = this.whs,
				//operator = this.operator,
				inputstarttime = this.inputstarttime,
				inputendtime = this.inputendtime,
				Ecv_Status = this.Ecv_Status,
				Fin_Type = this.Fin_Type,
			};
		}
	}
}
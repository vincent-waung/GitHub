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
	public partial class Truck_Invoice_Info
	{
		public Truck_Invoice_Info ToPOCO(bool isPOCO = true){
			return new Truck_Invoice_Info(){
				invoice_no = this.invoice_no,
				so = this.so,
				sales_order = this.sales_order,
				line = this.line,
				ship_mode = this.ship_mode,
				BL = this.BL,
			};
		}
	}
}

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
	public partial class Truck_Booking_Reg
	{
		public Truck_Booking_Reg ToPOCO(bool isPOCO = true){
			return new Truck_Booking_Reg(){
				ID = this.ID,
				SO_NO = this.SO_NO,
				Rec_BookingDate = this.Rec_BookingDate,
				FirstDate = this.FirstDate,
				EndDate = this.EndDate,
				VendorCode = this.VendorCode,
			};
		}
	}
}
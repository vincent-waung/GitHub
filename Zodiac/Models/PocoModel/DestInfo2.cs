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
	public partial class DestInfo2
	{
		public DestInfo2 ToPOCO(bool isPOCO = true){
			return new DestInfo2(){
				DestID = this.DestID,
				DestName = this.DestName,
				ChineseName = this.ChineseName,
				Country = this.Country,
				DestCode = this.DestCode,
				CountryCode = this.CountryCode,
			};
		}
	}
}

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
	public partial class Curr_Rate
	{
		public Curr_Rate ToPOCO(bool isPOCO = true){
			return new Curr_Rate(){
				CID = this.CID,
				curr_code = this.curr_code,
				curr_symb = this.curr_symb,
				Rate = this.Rate,
				curr_name = this.curr_name,
			};
		}
	}
}

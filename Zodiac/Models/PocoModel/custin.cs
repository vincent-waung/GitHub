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
	public partial class custin
	{
		public custin ToPOCO(bool isPOCO = true){
			return new custin(){
				in_no = this.in_no,
				decl_mode = this.decl_mode,
				factory = this.factory,
				decldate = this.decldate,
				arr_time = this.arr_time,
				ingate_time = this.ingate_time,
				dev_time = this.dev_time,
				compl_time = this.compl_time,
				remark = this.remark,
				duty = this.duty,
			};
		}
	}
}
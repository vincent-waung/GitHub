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
	public partial class sysdiagrams
	{
		public sysdiagrams ToPOCO(bool isPOCO = true){
			return new sysdiagrams(){
				name = this.name,
				principal_id = this.principal_id,
				diagram_id = this.diagram_id,
				version = this.version,
				definition = this.definition,
			};
		}
	}
}

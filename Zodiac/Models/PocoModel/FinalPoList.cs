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
	public partial class FinalPoList
	{
		public FinalPoList ToPOCO(bool isPOCO = true){
			return new FinalPoList(){
				ID = this.ID,
				Brand = this.Brand,
				Carton_Depth_W = this.Carton_Depth_W,
				Carton_GrossWeight = this.Carton_GrossWeight,
				Carton_Height = this.Carton_Height,
				Carton_NetWeight = this.Carton_NetWeight,
				Carton_PCS = this.Carton_PCS,
				Carton_Width_L = this.Carton_Width_L,
				Comments = this.Comments,
				Deliv_Date = this.Deliv_Date,
				Delivery_Number = this.Delivery_Number,
				Item = this.Item,
				ItemNO = this.ItemNO,
				Material = this.Material,
				Matl_Group = this.Matl_Group,
				Mfr_Country = this.Mfr_Country,
				Mfr_Name1 = this.Mfr_Name1,
				PO_quantity = this.PO_quantity,
				Purch_Doc = this.Purch_Doc,
				Sales_Material = this.Sales_Material,
				SalesOrd_STO = this.SalesOrd_STO,
				Ship_To_Country = this.Ship_To_Country,
				ShipTo_Name = this.ShipTo_Name,
				Short_text = this.Short_text,
				Total_Carton = this.Total_Carton,
				Total_GrossWeight = this.Total_GrossWeight,
				Total_Volume = this.Total_Volume,
				Vendor_Name = this.Vendor_Name,
				FOB_Cancel_Date = this.FOB_Cancel_Date,
				FOB_Carton_Volume = this.FOB_Carton_Volume,
				FOB_Customer_Description = this.FOB_Customer_Description,
				FOB_Customer_Material_Number = this.FOB_Customer_Material_Number,
				FOB_Customer_Name = this.FOB_Customer_Name,
				FOB_Customer_PO = this.FOB_Customer_PO,
				FOB_First_Date = this.FOB_First_Date,
				FOB_LOG = this.FOB_LOG,
				FOB_MainBatt = this.FOB_MainBatt,
				FOB_MainBattQty = this.FOB_MainBattQty,
				FOB_OverallCredStat = this.FOB_OverallCredStat,
				FOB_Proforma_Invoice = this.FOB_Proforma_Invoice,
				FOB_Receiving_Point = this.FOB_Receiving_Point,
				FOB_Total_NetWeight = this.FOB_Total_NetWeight,
				FOB_Booking_Date = this.FOB_Booking_Date,
				FOB_Ship_MODE = this.FOB_Ship_MODE,
				DOM_Delivery_Quantity = this.DOM_Delivery_Quantity,
				DOM_Domestic_Dest = this.DOM_Domestic_Dest,
				DOM_Finaloadingport = this.DOM_Finaloadingport,
				DOM_Inbound = this.DOM_Inbound,
				DOM_Invoice = this.DOM_Invoice,
				DOM_Mfr_City = this.DOM_Mfr_City,
				DOM_Qty_Delivered = this.DOM_Qty_Delivered,
				DOM_Route = this.DOM_Route,
				DOM_Shipment_Number = this.DOM_Shipment_Number,
				DOM_Sloc = this.DOM_Sloc,
				DOM_StatDelD = this.DOM_StatDelD,
				DOM_STO_Delivery_Date = this.DOM_STO_Delivery_Date,
				DOM_STO_MA_Date = this.DOM_STO_MA_Date,
				DOM_To_Be_Del = this.DOM_To_Be_Del,
				DOM_Vendor = this.DOM_Vendor,
				PO_List_Type = this.PO_List_Type,
				Import_Date = this.Import_Date,
				Vendor_User = this.Vendor_User,
				Vendor_Latest_Update = this.Vendor_Latest_Update,
			};
		}
	}
}

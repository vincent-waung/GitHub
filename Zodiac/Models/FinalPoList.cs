//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FinalPoList
    {
        public FinalPoList()
        {
            this.FinalVendorInput = new HashSet<FinalVendorInput>();
        }
    
        public int ID { get; set; }
        public string Brand { get; set; }
        public Nullable<decimal> Carton_Depth_W { get; set; }
        public Nullable<decimal> Carton_GrossWeight { get; set; }
        public Nullable<decimal> Carton_Height { get; set; }
        public Nullable<decimal> Carton_NetWeight { get; set; }
        public Nullable<int> Carton_PCS { get; set; }
        public Nullable<decimal> Carton_Width_L { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> Deliv_Date { get; set; }
        public string Delivery_Number { get; set; }
        public string Item { get; set; }
        public string ItemNO { get; set; }
        public string Material { get; set; }
        public string Matl_Group { get; set; }
        public string Mfr_Country { get; set; }
        public string Mfr_Name1 { get; set; }
        public Nullable<int> PO_quantity { get; set; }
        public string Purch_Doc { get; set; }
        public string Sales_Material { get; set; }
        public string SalesOrd_STO { get; set; }
        public string Ship_To_Country { get; set; }
        public string ShipTo_Name { get; set; }
        public string Short_text { get; set; }
        public Nullable<int> Total_Carton { get; set; }
        public Nullable<decimal> Total_GrossWeight { get; set; }
        public Nullable<decimal> Total_Volume { get; set; }
        public string Vendor_Name { get; set; }
        public Nullable<System.DateTime> FOB_Cancel_Date { get; set; }
        public Nullable<decimal> FOB_Carton_Volume { get; set; }
        public string FOB_Customer_Description { get; set; }
        public string FOB_Customer_Material_Number { get; set; }
        public string FOB_Customer_Name { get; set; }
        public string FOB_Customer_PO { get; set; }
        public Nullable<System.DateTime> FOB_First_Date { get; set; }
        public string FOB_LOG { get; set; }
        public string FOB_MainBatt { get; set; }
        public Nullable<int> FOB_MainBattQty { get; set; }
        public string FOB_OverallCredStat { get; set; }
        public string FOB_Proforma_Invoice { get; set; }
        public string FOB_Receiving_Point { get; set; }
        public Nullable<decimal> FOB_Total_NetWeight { get; set; }
        public Nullable<System.DateTime> FOB_Booking_Date { get; set; }
        public string FOB_Ship_MODE { get; set; }
        public Nullable<int> DOM_Delivery_Quantity { get; set; }
        public string DOM_Domestic_Dest { get; set; }
        public string DOM_Finaloadingport { get; set; }
        public string DOM_Inbound { get; set; }
        public string DOM_Invoice { get; set; }
        public string DOM_Mfr_City { get; set; }
        public Nullable<int> DOM_Qty_Delivered { get; set; }
        public string DOM_Route { get; set; }
        public string DOM_Shipment_Number { get; set; }
        public string DOM_Sloc { get; set; }
        public Nullable<System.DateTime> DOM_StatDelD { get; set; }
        public Nullable<System.DateTime> DOM_STO_Delivery_Date { get; set; }
        public Nullable<System.DateTime> DOM_STO_MA_Date { get; set; }
        public Nullable<int> DOM_To_Be_Del { get; set; }
        public string DOM_Vendor { get; set; }
        public string PO_List_Type { get; set; }
        public Nullable<System.DateTime> Import_Date { get; set; }
        public string Vendor_User { get; set; }
        public Nullable<System.DateTime> Vendor_Latest_Update { get; set; }
    
        public virtual ICollection<FinalVendorInput> FinalVendorInput { get; set; }
    }
}

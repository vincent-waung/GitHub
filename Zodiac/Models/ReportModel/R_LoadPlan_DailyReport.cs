using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ReportModel
{
   public class R_LoadPlan_DailyReport
    {
       public string Remark { get; set; }

       public string Status { get; set; }
        public string Purch_Doc { get; set; }
        public string Item { get; set; }
        public string PO_Line { get; set; }
        public string Created_By { get; set; }
        public string Matl_Group { get; set; }
        public string Matl_Group_Sales { get; set; }

        public string Mohth { get; set; }
        public string Weekly { get; set; }

        public string CustomerType { get; set; }



        public string Material { get; set; }
        public string ShipMode { get; set; }
        public string Brand { get; set; }
        public string Short_text { get; set; }
        public Nullable<int> PO_quantity { get; set; }
        public Nullable<int> Total_Carton { get; set; }
        public string Matrix { get; set; }
        public Nullable<System.DateTime> Deliv_Date { get; set; }
        //public DateTime FOB_First_Date { get; set; }
        public string Slip_Sheet { get; set; }
        public string Packing_Status { get; set; }
        public Nullable<System.DateTime> Inspection_End_Date { get; set; }
        public string Inspection_Result { get; set; }
        public string Booking_No { get; set; }
        public Nullable<System.DateTime> Loading_Date { get; set; }
        public Nullable<System.DateTime> Closing_Date { get; set; }
        public Nullable<System.DateTime> ETD { get; set; }
   public string Shipment_Status { get; set; }
   public string FOB_Local_Charges_Settlement { get; set; }
   public Nullable<System.DateTime> FCR_Bill_Return_Date { get; set; }
   public Nullable<System.DateTime> Certificate_Application_Date { get; set; }
   public Nullable<System.DateTime> Certificate_Return_TO_SMDate { get; set; }
   public Nullable<int> Qty_Delivered { get; set; }
   public string To_be_del { get; set; }
   public string Sales_Material { get; set; }
   public string FOB_Customer_PO { get; set; }
   public string SalesOrd_STO { get; set; }

   public string ItemNO { get; set; }    
   public string DOM_Domestic_Dest { get; set; }
   public string FOB_Customer_Name { get; set; }
   public string Actual_GI_Date { get; set; }
   public string DOM_Route { get; set; }
   public string Ship_To_Country { get; set; }
   public string ShipTo_Name { get; set; }
   public string Delivery_Number { get; set; }
   public string OTD_Reason_Code { get; set; }
   public string FOB_Carton_Volume { get; set; }
   public string FOB_Customer_Description { get; set; }
   public string FOB_Customer_Material_Number { get; set; }
   public string FOB_LOG { get; set; }
   public string FOB_MainBatt { get; set; }
   public string FOB_MainBattQty { get; set; }
   public string FOB_OverallCredStat { get; set; }
   public string FOB_Proforma_Invoice { get; set; }
   public string FOB_Receiving_Point { get; set; }
   public string FOB_Total_NetWeight { get; set; }

       

   public string DOM_Delivery_Quantity { get; set; }
   public string DOM_Inbound { get; set; }
   public string DOM_Invoice { get; set; }
   public string DOM_Mfr_City { get; set; }
   public string DOM_Qty_Delivered { get; set; }
   public string DOM_Shipment_Number { get; set; }
   public string DOM_Sloc { get; set; }
   public Nullable<System.DateTime> DOM_StatDelD { get; set; }
   public Nullable<System.DateTime> DOM_STO_Delivery_Date { get; set; }
   public Nullable<System.DateTime> DOM_STO_MA_Date { get; set; }
   public string DOM_To_Be_Del { get; set; }
   public string DOM_Vendor { get; set; }
   public string DOM_Finaloadingport { get; set; }


   public string Carton_Depth_W { get; set; }
   public string Carton_GrossWeight { get; set; }
   public string Carton_Height { get; set; }
   public string Carton_NetWeight { get; set; }
   public string Carton_PCS { get; set; }
   public string Carton_Width_L { get; set; }
   public string Comments { get; set; }
   public string Mfr_Name1 { get; set; }
   public string Total_GrossWeight { get; set; }
   public decimal? Total_Volume { get; set; }
   public string Mfr_Country { get; set; }
   public string Vendor_Name { get; set; }




   public string Dischaging_Port { get; set; }
   public string Vessel { get; set; }
   public string Voyage { get; set; }
   public string Loading_Port { get; set; }
   public Nullable<System.DateTime> SI_Cut_Time { get; set; }
   public Nullable<System.DateTime> CY_Closing_Date { get; set; }
   public Nullable<System.DateTime> Booking_Date { get; set; }
   public Nullable<System.DateTime> ETA { get; set; }
   public Nullable<System.DateTime> Arrive_WHS_Date { get; set; }
   public Nullable<System.DateTime> Arrive_terminal_Date { get; set; }
   public Nullable<decimal> Delivery_CBM { get; set; }
   public Nullable<int> Carton_delivered { get; set; }
   public string Container_NO { get; set; }
   public string Seal_NO { get; set; }
   public string Vehicle_Type { get; set; }



  


       


   public string Delay_Details { get; set; }
   public Nullable<System.DateTime> FOB_First_Date { get; set; }
   public Nullable<System.DateTime> FOB_Cancel_Date { get; set; }



















































   public string Forward_Name { get; set; }
   public string TruckingNo { get; set; }

   public Nullable<System.DateTime> SO_Release_Date { get; set; }
   public Nullable<int> CTN { get; set; }
   public decimal? CBM { get; set; }
   public int? Qty { get; set; }
   public int Tid { get; set; }
   public Nullable<System.DateTime> Trucking_Arrive_WHS_Date { get; set; }
   public Nullable<System.DateTime> Trucking_Arrive_terminal_Date { get; set; }
   public string Qiy { get; set; }

   public Nullable<System.DateTime> OpenDate { get; set; }

   public string PO_List_Type { get; set; }

   public string Courier_tracking_no { get; set; }







    //-----------------------



   public int? Quantiryvariance { get; set; }

   public int? Cartonvariance { get; set; }

   public decimal? Cbmvariance { get; set; }







    }
}

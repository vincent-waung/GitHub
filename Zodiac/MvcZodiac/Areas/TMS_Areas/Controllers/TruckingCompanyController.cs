﻿using MvcZodiac.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Models;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Data;
using System.IO;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using System.Windows.Forms;

namespace MvcZodiac.Areas.TMS_Areas.Controllers
{
    public class TruckingCompanyController : BaseController
    {
        OnlineBookingEntities db = new OnlineBookingEntities();
        private List<Models.FGshipmentvehicledispatchsummaryInfo> DataInfo = new List<Models.FGshipmentvehicledispatchsummaryInfo>();

        //
        // GET: /TMS_Areas/TruckingCompany/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TruckingConfirmIndex()
        {
            List<Models.TruckingConfirmList> ls = new List<Models.TruckingConfirmList>();
            Session["TruckingConfirm"] = ls;
            return View();
        }

        public ActionResult TruckingOrderMngIndex()
        {
            return View();
        }
        public ActionResult TruckingOrderSearchIndex()
        {
            return View();
        }

        public ActionResult TrkBookingResult(string id)
        {
            TempData["TrkBookingResultBno"] = id;
            return View();
        }
        public ActionResult GetTrkBookingResultList()
        {
            string Booking_Number=TempData["TrkBookingResultBno"].ToString();
            var bookhead = oc.BllSession.ITruck_Booking_HeadBLL.GetListBy(cc => cc.Booking_Number== Booking_Number).ToList();

            List<object> ls = new List<object>();
            try
            {
                for (int i = 0; i < bookhead.Count; i++)
                {

                    Truck_Booking_Head v = new Truck_Booking_Head();

                    v.Booking_Number = bookhead[i].Booking_Number;
                    v.Intype = bookhead[i].Intype;
                    v.Transport_Type = bookhead[i].Transport_Type;
                    v.Delivery_Type = bookhead[i].Delivery_Type;
                    v.Pick_address = bookhead[i].Loading_address;
                    v.Vdr_Pickup_date = bookhead[i].Vdr_Pickup_date;
                    if (bookhead[i].Account == null)
                    {
                        v.Pick_address = bookhead[i].Pick_address;
                        v.Vdr_Pickup_date = bookhead[i].Rq_Arrive_Whs_time;
                    }
                    v.CBM = bookhead[i].CBM;
                    v.GrossWeight = bookhead[i].GrossWeight;
                    v.CTN = bookhead[i].CTN;
                    v.Vehicletype = bookhead[i].Vehicletype;
                    v.VendorCode = bookhead[i].VendorCode;
                    v.VendorName = bookhead[i].VendorName;
                    v.Fongguan_Address = bookhead[i].Fongguan_Address;
                    v.Return_address = bookhead[i].Return_address;
                    v.CancelDate = bookhead[i].CancelDate;
                    v.Driver_Name = bookhead[i].Driver_Name;
                    v.Driver_TelNo = bookhead[i].Driver_TelNo;
                    v.Vehicle_number = bookhead[i].Vehicle_number;
                    v.CustomsNo = bookhead[i].CustomsNo;
                    v.Cont_NO = bookhead[i].Cont_NO;
                    v.Seal_NO = bookhead[i].Seal_NO;
                    v.Frame_Type = bookhead[i].Frame_Type;
                    v.FrameWeight = bookhead[i].FrameWeight;
                    v.HeadStockWeight = bookhead[i].HeadStockWeight;
                    v.ContainerWeight = bookhead[i].ContainerWeight;
                    v.Customs_Password = bookhead[i].Customs_Password;
                    v.Electronic_Lock = bookhead[i].Electronic_Lock;
                    v.TongGuanCard = bookhead[i].TongGuanCard;
                    v.Release_Pass = bookhead[i].Release_Pass;
                    ls.Add(new { book = v });
                }
            }
            catch (Exception ex)
            {
                return View();
            }

            return new ContentResult
            {
                Content = new JavaScriptSerializer { MaxJsonLength = Int32.MaxValue }.Serialize(ls),
                ContentType = "application/json"

            };
       
        }

        public ActionResult TruckingReportIndex()
        {
           
            return View();
        }
        public ActionResult TruckingConfirmEdit(string id)
        {
        
            TempData["ConfirmEditBno"] = id;
            List<Models.TruckingConfirmList> ls = new List<Models.TruckingConfirmList>();
            var data = (from u in db.Truck_Booking_Detail where u.Booking_Number == id select u).ToList();
            var datahead = (from u in db.Truck_Booking_Head where u.Booking_Number == id select u).ToList();
            for (int i = 0; i < data.Count; i++)
            {
                Models.TruckingConfirmList v = new Models.TruckingConfirmList();
                v.plid = Convert.ToInt32(data[i].plid);
                v.so_no = data[i].SO_No;
                v.Customer_PO = data[i].Customer_PO;
                v.Material = data[i].Material;
                v.Item = data[i].Item;
                v.Line = data[i].Line;
                v.pick_date = datahead[0].Vdr_Pickup_date;
                v.pcs = data[i].Pcs;
                v.Ctn = data[i].Ctn;
                v.CBM = data[i].CBM;
                v.GrossWeight= data[i].GrossWeight;
                v.remarks = data[i].remark;
                v.hfe = data[i].hfe;
                ls.Add(v);

            }
            Session["TruckingConfirmEdit"] = ls;
            return View();
        }
        public ActionResult TruckingOrderDetails()
        {
            string id = Request.QueryString["id"].Trim();
            TempData["BookingNo"] = id;
            return View();
        }
        public ActionResult GetOrderHead()
        {
            string Booking_Number = TempData["BookingNo"].ToString();


                var bookhead = db.Truck_Booking_Head.Find(Booking_Number);
                    Truck_Booking_Head v = new Truck_Booking_Head();

                    v.Booking_Number = bookhead.Booking_Number;
                    v.Intype = bookhead.Intype;
                    v.Transport_Type = bookhead.Transport_Type;
                    v.Delivery_Type = bookhead.Delivery_Type;
                    v.Pick_address = bookhead.Loading_address;
                    v.Vdr_Pickup_date = bookhead.Vdr_Pickup_date;

                    v.CBM = bookhead.CBM;
                    v.GrossWeight = bookhead.GrossWeight;
                    v.CTN = bookhead.CTN;
                    v.Vehicletype = bookhead.Vehicletype;
                    v.VendorCode = bookhead.VendorCode;
                    v.VendorName = bookhead.VendorName;
                    v.Fongguan_Address = bookhead.Fongguan_Address;
                    v.Return_address = bookhead.Return_address;
                    v.CancelDate = bookhead.CancelDate;
                    v.Driver_Name = bookhead.Driver_Name;
                    v.Driver_TelNo = bookhead.Driver_TelNo;
                    v.Vehicle_number = bookhead.Vehicle_number;
                    v.CustomsNo = bookhead.CustomsNo;
                    v.Cont_NO = bookhead.Cont_NO;
                    v.Seal_NO = bookhead.Seal_NO;
                    v.Frame_Type = bookhead.Frame_Type;
                    v.FrameWeight = bookhead.FrameWeight;
                    v.HeadStockWeight = bookhead.HeadStockWeight;
                    v.ContainerWeight = bookhead.ContainerWeight;
                    v.Customs_Password = bookhead.Customs_Password;
                    v.Electronic_Lock = bookhead.Electronic_Lock;
                    v.TongGuanCard = bookhead.TongGuanCard;
                    v.Release_Pass = bookhead.Release_Pass;
            
                
  
            TempData["BookingNo"] = Booking_Number;
            return Content(new JavaScriptSerializer().Serialize(v));

        }
        public ActionResult GetOrderDetails()
        {
            string Booking_Number = TempData["BookingNo"].ToString();

            var bookdetail = oc.BllSession.ITruck_Booking_DetailBLL.GetListBy(cc => cc.Booking_Number == Booking_Number).ToList();

            List<object> ls = new List<object>();
            try
            {
                for (int i = 0; i < bookdetail.Count; i++)
                {

                    Truck_Booking_Detail v = new Truck_Booking_Detail();

                    v.Booking_Number = bookdetail[i].Booking_Number;
                    v.SO_No = bookdetail[i].SO_No;
                    v.CBM = bookdetail[i].CBM;
                    v.Ctn = bookdetail[i].Ctn;
                    v.GrossWeight = bookdetail[i].GrossWeight;
                 
                    ls.Add(new { book = v });
                }
            }
            catch (Exception ex)
            {
                return View();
            }
            TempData["BookingNo"] = Booking_Number;
            return new ContentResult
            {
                Content = new JavaScriptSerializer { MaxJsonLength = Int32.MaxValue }.Serialize(ls),
                ContentType = "application/json"

            };

        }
        public ActionResult GetBookedHeadList(DateTime data1, DateTime data2)
        {
          
           string Truck_Company = oc.CurrentVendorName;
            //string Truck_Company=Request.Cookies[Vendor_Name_Cookie].Values["VendorName"]
            var bookhead = oc.BllSession.ITruck_Booking_HeadBLL.GetListBy(cc => cc.Truck_Company == Truck_Company&&cc.CancelDate==null&&((cc.Vdr_Pickup_date>= data1 && cc.Vdr_Pickup_date< data2) ||(cc.Rq_Arrive_Whs_time >= data1 && cc.Rq_Arrive_Whs_time < data2))).ToList();

            List<object> ls = new List<object>();
            try
            {
                for (int i = 0; i < bookhead.Count; i++)
                {

                    Truck_Booking_Head v = new Truck_Booking_Head();

                    v.Booking_Number = bookhead[i].Booking_Number;
                    v.Intype = bookhead[i].Intype;
                    v.Transport_Type = bookhead[i].Transport_Type;
                    v.Delivery_Type = bookhead[i].Delivery_Type;
                    v.Pick_address = bookhead[i].Loading_address;
                    v.Vdr_Pickup_date = bookhead[i].Vdr_Pickup_date;
                    if (bookhead[i].Account == null)
                    {
                        v.Pick_address = bookhead[i].Pick_address;
                        v.Vdr_Pickup_date = bookhead[i].Rq_Arrive_Whs_time;
                    }
                    v.CBM = bookhead[i].CBM;
                    v.GrossWeight = bookhead[i].GrossWeight;
                    v.CTN = bookhead[i].CTN;
                    v.Vehicletype = bookhead[i].Vehicletype;
                    v.VendorCode = bookhead[i].VendorCode;
                    v.VendorName = bookhead[i].VendorName;
                    v.Fongguan_Address = bookhead[i].Fongguan_Address;
                    v.Return_address = bookhead[i].Return_address;
                    v.CancelDate = bookhead[i].CancelDate;
                    v.Driver_Name = bookhead[i].Driver_Name;
                    v.Driver_TelNo = bookhead[i].Driver_TelNo;
                    v.Vehicle_number = bookhead[i].Vehicle_number;
                    v.CustomsNo = bookhead[i].CustomsNo;
                    v.Cont_NO = bookhead[i].Cont_NO;
                    v.Seal_NO = bookhead[i].Seal_NO;
                    v.Frame_Type = bookhead[i].Frame_Type;
                    v.FrameWeight = bookhead[i].FrameWeight;
                    v.HeadStockWeight = bookhead[i].HeadStockWeight;
                    v.ContainerWeight = bookhead[i].ContainerWeight;
                    v.Customs_Password = bookhead[i].Customs_Password;
                    v.Electronic_Lock = bookhead[i].Electronic_Lock;
                    v.TongGuanCard = bookhead[i].TongGuanCard;
                    v.Release_Pass = bookhead[i].Release_Pass;
                    ls.Add(new { book = v });
                }
            }
            catch (Exception ex)
            {
                return View();
            }

            return new ContentResult
            {
                Content = new JavaScriptSerializer { MaxJsonLength = Int32.MaxValue }.Serialize(ls),
                ContentType = "application/json"

            };
        }
  
        public ActionResult GetPackingList(string data1, string data2, string so)
        {
            List<Truck_PackingList> data =new List<Truck_PackingList>();
            string Truck_Company = oc.CurrentVendorName;
           // var data = (from u in db.Truck_PackingList where u.truck_company == Truck_Company && u.so_no.Contains(so) select u).ToList();
            if (data1.ToString() != "" && data2.ToString() != "")
            {
                DateTime date1 = Convert.ToDateTime(data1);
                DateTime date2 = Convert.ToDateTime(data2);
                data = (from u in db.Truck_PackingList where u.truck_company == Truck_Company && u.pick_date >= date1 && u.pick_date < date2 select u).ToList();

            }
            if (so.ToString() != "")
            {
                data = (from u in db.Truck_PackingList where u.truck_company == Truck_Company && u.so_no.Contains(so) select u).ToList();
            }

            List<object> ls = new List<object>();
            try
            {
                for (int i = 0; i < data.Count; i++)
                {
                    int plid = data[i].plid;
                    var databookingdetail= (from u in db.Truck_Booking_Detail where u.plid == plid select u).ToList();
                    var sumctn = databookingdetail.Sum(aa => aa.Ctn);
                    if (sumctn == null)
                    {
                        sumctn = 0;
                    }
                    if (data[i].ctns - sumctn <= 0)
                    {
                        continue;
                    }
                    Models.TruckingConfirmList  v = new Models.TruckingConfirmList();

                    v.plid = data[i].plid;
                    v.VendorCode = data[i].vendor_code;
                    v.so_no = data[i].so_no;
                    v.Customer_PO = data[i].cpo;
                    v.pick_date = data[i].pick_date;
                    v.pcs = data[i].pcs;
                    v.Material = data[i].material_groupNo;
                    v.Item = data[i].item;
                    v.Line = data[i].line;
                    v.Ctn = data[i].ctns;
                    v.availablectn = data[i].ctns - sumctn;
                    v.availableweight = (data[i].ctns - sumctn)* data[i].total_grossweight/ data[i].ctns;
                    v.availableCBM = (data[i].ctns - sumctn) * data[i].total_cbm / data[i].ctns;
                    v.Booking_Ctn = v.availablectn;
                    v.GrossWeight = data[i].total_grossweight;
                    v.CBM = data[i].total_cbm; ;
                    v.delivery_type = data[i].delivery_type;
                    v.remarks = data[i].remarks;
                    v.pick_address = data[i].pick_address ;
                    v.hfe = data[i].hfe;
                    ls.Add(v);
                }
            }
            catch (Exception ex)
            {
                return View();
            }

            return new ContentResult
            {
                Content = new JavaScriptSerializer { MaxJsonLength = Int32.MaxValue }.Serialize(ls),
                ContentType = "application/json"

            };
        }
        public ActionResult GetBookedHeadSave(string booking)
        {

            try
            {

                string errorinfo = "";
                Truck_Booking_Head truckbooking = JsonConvert.DeserializeObject<Truck_Booking_Head>(booking);
                string Booking_Number = truckbooking.Booking_Number;
                Regex reg = new Regex(@"^(?:[1-9][0-9]*|0)(?:\.[0-9]+)?$");
                Match ma = reg.Match(truckbooking.FrameWeight.ToString());
                if (!ma.Success)
                {
                    errorinfo += ":Please enter a numeric type greater than 0 for Frame Weight";
                }
                Match ma1 = reg.Match(truckbooking.ContainerWeight.ToString());
                if (!ma1.Success)
                {
                    errorinfo += ":Please enter a numeric type greater than 0 for Container Weight";
                }
                Match ma2 = reg.Match(truckbooking.HeadStockWeight.ToString());
                if (!ma2.Success)
                {
                    errorinfo += ":Please enter a numeric type greater than 0 for Head Weight";
                }
                if (truckbooking.Cont_NO.ToString().Length >= 15)
                {
                    errorinfo += ":Container No cannot exceed 15 characters";
                }
                if (truckbooking.Seal_NO.ToString().Length >= 15)
                {
                    errorinfo += ":Seal Number cannot exceed 15 characters";
                }
                if (truckbooking.Driver_Name.ToString().Length >= 50)
                {
                    errorinfo += ":Driver cannot exceed 50 characters";
                }
                if (truckbooking.Driver_TelNo.ToString().Length >= 50)
                {
                    errorinfo += ":Telephone cannot exceed 50 characters";
                }
                if (errorinfo.Trim().Length > 0)
                {
                    return Json(new { err = errorinfo, msg = "1" }, "text/x-json");
                }
                var data = db.Truck_Booking_Head.Find(Booking_Number);
                db.Truck_Booking_Head.Attach(data);
                var entry = db.Entry(data);
                data.Vehicle_number = truckbooking.Vehicle_number;
                data.Driver_Name = truckbooking.Driver_Name;
                data.Driver_TelNo = truckbooking.Driver_TelNo;
                data.CustomsNo = truckbooking.CustomsNo;
                data.Cont_NO = truckbooking.Cont_NO;
                data.Seal_NO = truckbooking.Seal_NO;
                data.Frame_Type = truckbooking.Frame_Type;
                data.FrameWeight = truckbooking.FrameWeight;
                data.HeadStockWeight = truckbooking.HeadStockWeight;
                data.ContainerWeight = truckbooking.ContainerWeight;
                data.Customs_Password = truckbooking.Customs_Password;
                data.Electronic_Lock = truckbooking.Electronic_Lock;
                data.TongGuanCard = truckbooking.TongGuanCard;
                data.Release_Pass = truckbooking.Release_Pass;
                entry.Property(e => e.Vehicle_number).IsModified = true;
                entry.Property(e => e.Driver_Name).IsModified = true;
                entry.Property(e => e.Driver_TelNo).IsModified = true;
                entry.Property(e => e.CustomsNo).IsModified = true;
                entry.Property(e => e.Cont_NO).IsModified = true;
                entry.Property(e => e.Seal_NO).IsModified = true;
                entry.Property(e => e.Frame_Type).IsModified = true;
                entry.Property(e => e.FrameWeight).IsModified = true;
                entry.Property(e => e.HeadStockWeight).IsModified = true;
                entry.Property(e => e.ContainerWeight).IsModified = true;
                entry.Property(e => e.Customs_Password).IsModified = true;
                entry.Property(e => e.TongGuanCard).IsModified = true;
                entry.Property(e => e.Release_Pass).IsModified = true;
                entry.Property(e => e.Electronic_Lock).IsModified = true;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Json(new { err = ex.Message, msg = "1" }, "text/x-json");
            }

            return Json(new { err = "", msg = "0" }, "text/x-json");
        }
        public ActionResult TruckingMaintenance()
        {
            string id = Request.QueryString["id"].Trim();
            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn("Id");
            dc.AutoIncrement = true;
            dc.AutoIncrementSeed = 1;
            dc.AutoIncrementStep = 1;
            dt.Columns.Add(dc);
            dt.Columns.Add(@"ChargeName", System.Type.GetType("System.String"));
            dt.Columns.Add(@"Charge", System.Type.GetType("System.String"));
            Session["ChargeInfo"] = dt;
            Session["BookingNo"] = id;

            return View();
        }
        public ActionResult GetTruckingCharge()
        {
            //var bookhead = oc.BllSession.ITruck_Booking_HeadBLL.GetListBy(cc => cc.Truck_Company == Truck_Company).ToList();
            List<object> ls = new List<object>();
            try
            {
               var dtlist = (from u in db.ChargeName select u.name).Distinct().ToList();
                //var dtlist = oc.BllSession.ITruck_ChargeNameBLL.GetListBy(cc =>cc.ChargeName=="Data Binding Fee").ToList();

                for (int i = 0; i < dtlist.Count; i++)
                {
                    ChargeName v = new ChargeName();
                    v.name = dtlist[i].Trim();
                    ls.Add(v);
                }
            }
            catch (Exception EX)
            {
                return View();
            }
            return Content(new JavaScriptSerializer().Serialize(ls));

        }
        public ActionResult GetTruckingChargeList()
        {
            DataTable dt = Session["ChargeInfo"] as DataTable;
            string Booking_Number = Session["BookingNo"].ToString();
            var data = (from u in db.Truck_Booking_Charge where u.Booking_Number == Booking_Number select u).ToList();
            List<object> ls = new List<object>();
            for (int i = 0; i < data.Count(); i++)
            {

 
                DataRow row = dt.NewRow();
                row["ChargeName"] = data[i].ChargeName;
                row["Charge"] = data[i].Charge;

                dt.Rows.Add(row);
                Truck_Booking_Charge charge = new Truck_Booking_Charge();
                charge.Seq = Convert.ToInt32(dt.Rows[i]["Id"]).ToString();
                charge.Charge = data[i].Charge;
                charge.ChargeName = data[i].ChargeName;
                ls.Add(charge);
            }

            return Content(new JavaScriptSerializer().Serialize(ls));
        }
        public ActionResult AddTruckingCharge(string Fees,string Cost)
        {
            if (Session["ChargeInfo"] == null)
            {
                return Json(new { err = "", msg = "1" }, "text/x-json");
            }
            DataTable dt = Session["ChargeInfo"] as DataTable;
            DataRow row = dt.NewRow();
            row["ChargeName"] = Fees;
            row["Charge"] = Cost;

            dt.Rows.Add(row);
            List<object> ls = new List<object>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                Truck_Booking_Charge charge = new Truck_Booking_Charge();
                charge.Seq = Convert.ToInt32(dt.Rows[i]["Id"]).ToString();
                charge.Charge =Convert.ToDecimal(dt.Rows[i]["Charge"]);
                charge.ChargeName = dt.Rows[i]["ChargeName"].ToString();

                ls.Add(charge);
            }

            return Content(new JavaScriptSerializer().Serialize(ls));
        }
        public ActionResult DelTruckingCharge(string id)
        {
            DataTable dt = Session["ChargeInfo"] as DataTable;
            DataRow[] dr = dt.Select("Id='" + id + "'");
            dt.Rows.Remove(dr[0]);
            List<object> ls = new List<object>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                Truck_Booking_Charge charge = new Truck_Booking_Charge();
                charge.Seq = Convert.ToInt32(dt.Rows[i]["Id"]).ToString();
                charge.Charge = Convert.ToDecimal(dt.Rows[i]["Charge"]);
                charge.ChargeName = dt.Rows[i]["ChargeName"].ToString();

                ls.Add(charge);
            }

            return Content(new JavaScriptSerializer().Serialize(ls));
        }
        public ActionResult SaveTruckingCharge()
        {


            DataTable dt = Session["ChargeInfo"] as DataTable;
            string Booking_Number = Session["BookingNo"].ToString();
            try
            {
                var data = (from u in db.Truck_Booking_Charge where u.Booking_Number == Booking_Number select u).ToList();
                for (int i = 0; i < data.Count; i++)
                {
                    db.Truck_Booking_Charge.Remove(data[i]);

                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Truck_Booking_Charge charge = new Truck_Booking_Charge();
                    charge.Booking_Number = Booking_Number;
                    charge.Seq = Convert.ToInt32(dt.Rows[i]["Id"]).ToString();
                    charge.Charge = Convert.ToDecimal(dt.Rows[i]["Charge"]);
                    charge.ChargeName = dt.Rows[i]["ChargeName"].ToString();
                    db.Truck_Booking_Charge.Add(charge);
                }

                db.SaveChanges();

            }
            catch (Exception ex)
            {
                return Json(new { err = ex.Message, msg = "1" }, "text/x-json");

            }
            dt.Rows.Clear();
            return Json(new { err = "", msg = "0" }, "text/x-json");

        }
        public ActionResult SaveTruckingTime(string ArrivalTime, string DepartureTime)
        {


            string Booking_Number = Session["BookingNo"].ToString();
            try
            {
                string errorinfo = "";
                if (ArrivalTime.ToString()==""|| DepartureTime.ToString() == "")
                {
                    errorinfo = "Arrival time and departure time should not be empty";
                }

                if (errorinfo.Trim().Length > 0)
                {
                    return Json(new { err = errorinfo, msg = "1" }, "text/x-json");
                }
                var data = db.Truck_Booking_Head.Find(Booking_Number);
                db.Truck_Booking_Head.Attach(data);
                var entry = db.Entry(data);
                data.Arrive_factory_time =Convert.ToDateTime(ArrivalTime);
                data.Leave_factory_time = Convert.ToDateTime(DepartureTime);
                entry.Property(e => e.Arrive_factory_time).IsModified = true;
                entry.Property(e => e.Leave_factory_time).IsModified = true;
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                return Json(new { err = ex.Message, msg = "1" }, "text/x-json");

            }
            return Json(new { err = "", msg = "0" }, "text/x-json");
        }
        public ActionResult SaveTruckingTime2(string Arrive_factory_time, string Arrive_Whs_time, string Leave_factory_time, string Leave_customs_time, string Terminal_Time, string Start_Unloading_time, string Leave_Terminal_time)
        {


            string Booking_Number = Session["BookingNo2"].ToString();
            try
            {
                //string errorinfo = "";
                //if (ArrivalTime.ToString() == "" || DepartureTime.ToString() == "")
                //{
                //    errorinfo = "Arrival time and departure time should not be empty";
                //}

                //if (errorinfo.Trim().Length > 0)
                //{
                //    return Json(new { err = errorinfo, msg = "1" }, "text/x-json");
                //}
                var data = db.Truck_Booking_Head.Find(Booking_Number);
                db.Truck_Booking_Head.Attach(data);
                var entry = db.Entry(data);
                data.Arrive_factory_time = Convert.ToDateTime(Arrive_factory_time);
                data.Leave_factory_time = Convert.ToDateTime(Arrive_Whs_time);
                data.Arrive_factory_time = Convert.ToDateTime(Leave_factory_time);
                data.Leave_factory_time = Convert.ToDateTime(Leave_customs_time);
                data.Arrive_factory_time = Convert.ToDateTime(Terminal_Time);
                data.Leave_factory_time = Convert.ToDateTime(Start_Unloading_time);
                data.Arrive_factory_time = Convert.ToDateTime(Leave_Terminal_time);
                entry.Property(e => e.Arrive_factory_time).IsModified = true;
                entry.Property(e => e.Arrive_Whs_time).IsModified = true;
                entry.Property(e => e.Leave_factory_time).IsModified = true;
                entry.Property(e => e.Leave_customs_time).IsModified = true;
                entry.Property(e => e.Terminal_Time).IsModified = true;
                entry.Property(e => e.Start_Unloading_time).IsModified = true;
                entry.Property(e => e.Leave_Terminal_time).IsModified = true;
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                return Json(new { err = ex.Message, msg = "1" }, "text/x-json");

            }
            return Json(new { err = "", msg = "0" }, "text/x-json");
        }
        public ActionResult GetBookedHeadListByParams(string data1, string data2,string Booking_Number)
        {

            string Truck_Company = oc.CurrentVendorName;

            List<Truck_Booking_Head> bookhead = new List<Truck_Booking_Head>();
          
            //string Truck_Company=Request.Cookies[Vendor_Name_Cookie].Values["VendorName"]
            
            if (data1.ToString() != "" && data2.ToString() != "")
            {
                DateTime date1 = Convert.ToDateTime(data1);
                DateTime date2 = Convert.ToDateTime(data2);
                bookhead = oc.BllSession.ITruck_Booking_HeadBLL.GetListBy(cc => cc.Truck_Company == Truck_Company && cc.CancelDate == null && ((cc.Vdr_Pickup_date >= date1 && cc.Vdr_Pickup_date < date2) || (cc.Rq_Arrive_Whs_time >= date1 && cc.Rq_Arrive_Whs_time < date2))).ToList();

            }
            if (Booking_Number.ToString() != "")
            {
                bookhead = oc.BllSession.ITruck_Booking_HeadBLL.GetListBy(cc => cc.Truck_Company == Truck_Company && cc.CancelDate == null && cc.Booking_Number.Contains(Booking_Number)).ToList();
            }

            List<object> ls = new List<object>();
            try
            {
                for (int i = 0; i < bookhead.Count; i++)
                {
                    //标记能否被取消
                    string flag = "0";
                    string bno = bookhead[i].Booking_Number;
                    var bookdetail = oc.BllSession.ITruck_Booking_DetailBLL.GetListBy(cc => cc.Booking_Number== bno).ToList();
                    if (bookdetail.Count > 0)
                    {
                        flag = "1";
                    }

                    Truck_Booking_Head v = new Truck_Booking_Head();

                    v.Booking_Number = bookhead[i].Booking_Number;
                    v.Intype = bookhead[i].Intype;
                    v.Transport_Type = bookhead[i].Transport_Type;
                    v.Delivery_Type = bookhead[i].Delivery_Type;
                    v.Pick_address = bookhead[i].Loading_address;
                    v.Vdr_Pickup_date = bookhead[i].Vdr_Pickup_date;
                    if (bookhead[i].Account == null)
                    {
                        v.Pick_address = bookhead[i].Pick_address;
                        v.Vdr_Pickup_date = bookhead[i].Rq_Arrive_Whs_time;
                    }
                    v.CBM = bookhead[i].CBM;
                    v.GrossWeight = bookhead[i].GrossWeight;
                    v.CTN = bookhead[i].CTN;
                    v.Vehicletype = bookhead[i].Vehicletype;
                    v.VendorCode = bookhead[i].VendorCode;
                    v.VendorName = bookhead[i].VendorName;
                    v.Fongguan_Address = bookhead[i].Fongguan_Address;
                    v.Return_address = bookhead[i].Return_address;
                    v.CancelDate = bookhead[i].CancelDate;
                    v.Driver_Name = bookhead[i].Driver_Name;
                    v.Driver_TelNo = bookhead[i].Driver_TelNo;
                    v.Vehicle_number = bookhead[i].Vehicle_number;
                    v.CustomsNo = bookhead[i].CustomsNo;
                    v.Cont_NO = bookhead[i].Cont_NO;
                    v.Seal_NO = bookhead[i].Seal_NO;
                    v.Frame_Type = bookhead[i].Frame_Type;
                    v.FrameWeight = bookhead[i].FrameWeight;
                    v.HeadStockWeight = bookhead[i].HeadStockWeight;
                    v.ContainerWeight = bookhead[i].ContainerWeight;
                    v.Customs_Password = bookhead[i].Customs_Password;
                    v.Electronic_Lock = bookhead[i].Electronic_Lock;
                    v.TongGuanCard = bookhead[i].TongGuanCard;
                    v.Release_Pass = bookhead[i].Release_Pass;
                    v.CancelDate = bookhead[i].CancelDate;
                    v.Remark2 = flag;
                    ls.Add(new { book = v });
                }
            }
            catch (Exception ex)
            {
                return View();
            }

            return new ContentResult
            {
                Content = new JavaScriptSerializer { MaxJsonLength = Int32.MaxValue }.Serialize(ls),
                ContentType = "application/json"

            };
        }
        public ActionResult TruckingCancel()
        {

            string id = Request.QueryString["id"].Trim();
            TempData["BookingNo"] = id;
            return View();

        }
        public ActionResult TruckCancelBooking()
        {
            try
            {
                string Booking_Number = TempData["BookingNo"].ToString();
                string Reason = Request.QueryString["Reason"].Trim();

                var bookhead = db.Truck_Booking_Head.Find(Booking_Number);
                db.Truck_Booking_Head.Attach(bookhead);
                var entry = db.Entry(bookhead);
                bookhead.Truck_CancelReason = Reason;
                bookhead.CancelDate = DateTime.Now;
                bookhead.Cancelperson = oc.CurrentUser.uLoginName;
                entry.Property(e => e.Truck_CancelReason).IsModified = true;
                entry.Property(e => e.CancelDate).IsModified = true;
                entry.Property(e => e.Cancelperson).IsModified = true;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Json(new { err = ex.Message, msg = "1" }, "text/x-json");

            }

            return Json(new { err = "", msg = "0" }, "text/x-json");
        }
        public ActionResult TruckingMaintenance2()
        {
            string id = Request.QueryString["id"].Trim();
            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn("Id");
            dc.AutoIncrement = true;
            dc.AutoIncrementSeed = 1;
            dc.AutoIncrementStep = 1;
            dt.Columns.Add(dc);
            dt.Columns.Add(@"ChargeName", System.Type.GetType("System.String"));
            dt.Columns.Add(@"Charge", System.Type.GetType("System.String"));
            dt.Columns.Add(@"Currency", System.Type.GetType("System.String"));
            dt.Columns.Add(@"Confirmed", System.Type.GetType("System.String"));
            dt.Columns.Add(@"Upload", System.Type.GetType("System.String"));
            Session["ChargeInfo2"] = dt;
            Session["BookingNo2"] = id;
            ViewData["Booking_Number"] = id;
            Session["Uploadflag"] = "N";
            return View();
        }
        public ActionResult GetTruckingChargeList2()
        {
            DataTable dt = Session["ChargeInfo2"] as DataTable;
            string Booking_Number = Session["BookingNo2"].ToString();
            var data = (from u in db.Truck_Booking_Charge where u.Booking_Number == Booking_Number select u).ToList();
            List<object> ls = new List<object>();
            for (int i = 0; i < data.Count(); i++)
            {

                bool Confirmed = Convert.ToBoolean(data[i].Confirmed);
                bool Upload = Convert.ToBoolean(data[i].Upload);
                string flagC = "";
                string flagU = "";
                if (Confirmed)
                {
                    flagC = "Y";
                }
                else
                {
                    flagC = "N";
                }
                if (Upload)
                {
                    flagU = "Y";
                }
                else
                {
                    flagU = "N";
                }
                DataRow row = dt.NewRow();
                row["ChargeName"] = data[i].ChargeName;
                row["Charge"] = data[i].Charge;

                row["Currency"] = data[i].Currency;
                row["Confirmed"] = flagC;
                row["Upload"] = flagU;
                dt.Rows.Add(row);
                Truck_Booking_Charge charge = new Truck_Booking_Charge();
                charge.Seq = Convert.ToInt32(dt.Rows[i]["Id"]).ToString();
                charge.Charge = data[i].Charge;
                charge.ChargeName = data[i].ChargeName;
                charge.Currency = data[i].Currency;
                charge.Booking_Number = flagC;
                charge.Remark = flagU;
                ls.Add(charge);
            }

            return Content(new JavaScriptSerializer().Serialize(ls));
        }
        public ActionResult GetTruckingTimeList()
        {

            string Booking_Number = Session["BookingNo"].ToString();
            //var data = (from u in db.Truck_Booking_Head where u.Booking_Number == Booking_Number select u).ToList();
            var data = db.Truck_Booking_Head.Find(Booking_Number);
            List<object> ls = new List<object>();

            Truck_Booking_Head v = new Truck_Booking_Head();
            v.Arrive_factory_time = data.Arrive_factory_time;
            v.Leave_factory_time = data.Leave_factory_time;
           
            ls.Add(v);
            return Content(new JavaScriptSerializer().Serialize(ls));
        }
        public ActionResult GetTruckingTimeList2()
        {

            string Booking_Number = Session["BookingNo2"].ToString();
            //var data = (from u in db.Truck_Booking_Head where u.Booking_Number == Booking_Number select u).ToList();
            var data = db.Truck_Booking_Head.Find(Booking_Number);
            List<object> ls = new List<object>();

            Truck_Booking_Head v = new Truck_Booking_Head();
            v.Arrive_factory_time = data.Arrive_factory_time;
            v.Leave_factory_time = data.Leave_factory_time;
            v.Arrive_Whs_time = data.Arrive_Whs_time;
            v.Leave_customs_time = data.Leave_customs_time;
            v.Terminal_Time = data.Terminal_Time;
            v.Start_Unloading_time = data.Start_Unloading_time;
            v.Leave_Terminal_time = data.Leave_Terminal_time;
            ls.Add(v);
            return Content(new JavaScriptSerializer().Serialize(ls));
        }
        public ActionResult AddTruckingCharge2(string Fees, string Cost,string Currency)
        {
            if (Session["ChargeInfo2"] == null)
            {
                return Json(new { err = "", msg = "1" }, "text/x-json");
            }
            DataTable dt = Session["ChargeInfo2"] as DataTable;
            string Uploadflag = Session["Uploadflag"].ToString();
            if (Fees == "AMS submission fee")
            {
                if (Uploadflag == "N")
                {
                    return Json(new { err = "", msg = "0" }, "text/x-json");
                }
            }
            DataRow row = dt.NewRow();
            row["ChargeName"] = Fees;
            row["Charge"] = Cost;
            row["Currency"] = Currency;
            row["Confirmed"] = "N";
            row["Upload"] = "N";
  
            dt.Rows.Add(row);
            List<object> ls = new List<object>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                Truck_Booking_Charge charge = new Truck_Booking_Charge();
                charge.Seq = Convert.ToInt32(dt.Rows[i]["Id"]).ToString();
                charge.Charge = Convert.ToDecimal(dt.Rows[i]["Charge"]);
                charge.ChargeName = dt.Rows[i]["ChargeName"].ToString();
                charge.Currency = dt.Rows[i]["Currency"].ToString();
                ls.Add(charge);
            }

            return Content(new JavaScriptSerializer().Serialize(ls));
        }
        public ActionResult GetTruckingChargeSessionList2()
        {
            DataTable dt = Session["ChargeInfo2"] as DataTable;
            List<object> ls = new List<object>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                bool Confirmed = Convert.ToBoolean(dt.Rows[i]["Confirmed"]);
                bool Upload = Convert.ToBoolean(dt.Rows[i]["Upload"]);
                string flagC = "";
                string flagU = "";
                if (Confirmed)
                {
                    flagC = "Y";
                }
                else
                {
                    flagC = "N";
                }
                if (Upload)
                {
                    flagU = "Y";
                }
                else
                {
                    flagU = "N";
                }
  
                Truck_Booking_Charge charge = new Truck_Booking_Charge();
                charge.Seq = Convert.ToInt32(dt.Rows[i]["Id"]).ToString();
                charge.Charge =Convert.ToDecimal(dt.Rows[i]["Charge"]);
                charge.ChargeName = dt.Rows[i]["ChargeName"].ToString();
                charge.Currency = dt.Rows[i]["Currency"].ToString();
                charge.Booking_Number = flagC;
                charge.Remark = flagU;
                ls.Add(charge);
            }

            return Content(new JavaScriptSerializer().Serialize(ls));
        }
        public ActionResult UploadFile()
        {
            string Booking_Number = TempData["BookingNo2"].ToString();


            var bookhead = db.Truck_Booking_Head.Find(Booking_Number);

            string strYear = Convert.ToDateTime(bookhead.Vdr_Pickup_date).Year.ToString();
            string strMonth = Convert.ToDateTime(bookhead.Vdr_Pickup_date).Month.ToString();

            string path = @"D:\TMCharge/" + strYear + "/" + strMonth;

            HttpPostedFileBase file = Request.Files["image"];

            bool files = false;
            int index = file.FileName.LastIndexOf(".");
            string strFilePath = file.FileName.Trim();
            string lastName = file.FileName.Substring(index, file.FileName.Length - index).ToLower();//文件后缀
            String[] restrictExtension = { ".pdf" };
            //判断文件类型是否符合
            for (int i = 0; i < restrictExtension.Length; i++)
            {
                if (lastName == restrictExtension[i])
                {
                    files = true;
                }
            }
            if (files == true)
            {

                file.SaveAs(path + Booking_Number + lastName);

                Session["Uploadflag"] = "Y";
                return Json(new { err = "", msg = "1" }, "text/x-json");

            }
            else
            {
       
                return Json(new { err = "", msg = "2" }, "text/x-json");
            }


        }
        public ActionResult DelTruckingCharge2(string id)
        {
            DataTable dt = Session["ChargeInfo2"] as DataTable;
            DataRow[] dr = dt.Select("Id='" + id + "'");
            dt.Rows.Remove(dr[0]);
            List<object> ls = new List<object>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                Truck_Booking_Charge charge = new Truck_Booking_Charge();
                charge.Seq = Convert.ToInt32(dt.Rows[i]["Id"]).ToString();
                charge.Charge = Convert.ToDecimal(dt.Rows[i]["Charge"]);
                charge.ChargeName = dt.Rows[i]["ChargeName"].ToString();
                charge.Currency = dt.Rows[i]["Currency"].ToString();
                charge.Booking_Number = dt.Rows[i]["Confirmed"].ToString();
                charge.Remark = dt.Rows[i]["Upload"].ToString();
                ls.Add(charge);
            }

            return Content(new JavaScriptSerializer().Serialize(ls));
        }
        public ActionResult SaveTruckingCharge2()
        {


            DataTable dt = Session["ChargeInfo2"] as DataTable;
            string Booking_Number = Session["BookingNo2"].ToString();
            try
            {
                var data = (from u in db.Truck_Booking_Charge where u.Booking_Number == Booking_Number select u).ToList();
                for (int i = 0; i < data.Count; i++)
                {
                    db.Truck_Booking_Charge.Remove(data[i]);

                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    bool Confirmed = true;
                    bool Upload = true;
                    if (dt.Rows[i]["Confirmed"].ToString() == "" || dt.Rows[i]["Confirmed"].ToString() == "N")
                    {
                        Confirmed = false;
                    }
                    if (dt.Rows[i]["Upload"].ToString() == "" || dt.Rows[i]["Upload"].ToString() == "N")
                    {
                        Upload = false;
                    }

                    Truck_Booking_Charge charge = new Truck_Booking_Charge();
                    charge.Booking_Number = Booking_Number;
                    charge.Seq = i.ToString();
                    charge.Charge = Convert.ToDecimal(dt.Rows[i]["Charge"]);
                    charge.ChargeName = dt.Rows[i]["ChargeName"].ToString();
                    charge.Currency = dt.Rows[i]["Currency"].ToString();
                    charge.Confirmed = Confirmed;
                    charge.Upload = Upload;
                    db.Truck_Booking_Charge.Add(charge);
                }

                db.SaveChanges();

            }
            catch (Exception ex)
            {
                return Json(new { err = ex.Message, msg = "1" }, "text/x-json");

            }
            dt.Rows.Clear();
            return Json(new { err = "", msg = "0" }, "text/x-json");

        }
        public ActionResult DownloadTruckingCharge()
        {
            string Booking_Number = TempData["BookingNo2"].ToString();


            var bookhead = db.Truck_Booking_Head.Find(Booking_Number);

            string strYear = Convert.ToDateTime(bookhead.Vdr_Pickup_date).Year.ToString();
            string strMonth = Convert.ToDateTime(bookhead.Vdr_Pickup_date).Month.ToString();

            string path = @"D:\TMCharge/" + strYear + "/" + strMonth;
            FileStream fs = new FileStream(path + "/" + Booking_Number + ".pdf", FileMode.Open);
            return File(fs, "application /pdf", Booking_Number + ".pdf");
        }
        public ActionResult GetFGsummary(DateTime data1, DateTime data2)
        {

            string sql = string.Format(@"SELECT  CAST('' AS VARCHAR(50)) Operator,
                                               so_no,
                                               CAST('' AS VARCHAR(50)) ContType,
                                               SUM(ctns) Ctn,
                                               SUM(total_cbm) Cbm,
                                               CAST('' AS VARCHAR(100)) ContNo,
                                               CAST('' AS VARCHAR(100)) SailNo,
                                               CAST('' AS VARCHAR(50)) CarNo,
                                               CAST('' AS VARCHAR(50)) Phone,
                                               CAST('1980-1-1' AS DATETIME) ArriveTime,
                                               CAST('1980-1-1' AS DATETIME) LeaveTime,
                                               CAST('1980-1-1' AS DATETIME) ActLeaveTime,
                                               CAST('' AS VARCHAR(50)) ContState,
                                               CAST('' AS VARCHAR(50)) LoadingGate,
                                               CAST('' AS VARCHAR(50)) TranWay,
                                               CAST('' AS VARCHAR(200)) Remark,
                                               CAST('' AS VARCHAR(50)) Client
                                        INTO #TEMP
                                        FROM dbo.Truck_PackingList
                                        WHERE pick_date >= '{0}' AND pick_date<'{1}' AND cancel_date IS NULL
                                        GROUP BY so_no;

                                        --更新司机信息
                                        UPDATE a 
                                        SET a.CarNo=c.Vehicle_number,
                                        a.ContNo=c.Cont_NO,
                                        a.SailNo=c.Seal_NO,
                                        a.Phone=c.Driver_TelNo,
                                        a.Remark=c.Remark,
                                        a.ActLeaveTime=c.Leave_factory_time,
                                        a.ArriveTime=c.Arrive_factory_time
                                        FROM #TEMP a
                                        INNER JOIN dbo.Truck_Booking_Detail b ON b.SO_No = a.so_no
                                        INNER JOIN dbo.Truck_Booking_Head c ON c.Booking_Number = b.Booking_Number

                                        SELECT     Operator,
                                                   so_no,
                                                   ContType,
                                                   ISNULL(Ctn,0) Ctn,
                                                   ISNULL(Cbm,0) Cbm,
                                                   ISNULL(ContNo,'') ContNo,
                                                   ISNULL(SailNo,'') SailNo,
                                                   CarNo,
                                                   Phone,
                                                   ArriveTime,
                                                   LeaveTime,
                                                   ActLeaveTime,
                                                   ContState,
                                                   LoadingGate,
                                                   TranWay,
	                                               Remark,
	                                               Client
                                            FROM #TEMP;

                                        DROP TABLE #TEMP", data1, data2);
            DataTable dt = Common.DbHelperSQL.QueryTable(sql);
            DateTime NimD = Convert.ToDateTime("1980-1-1");
            List<Models.FGshipmentvehicledispatchsummaryInfo> ls = new List<Models.FGshipmentvehicledispatchsummaryInfo>();
            try
            {
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    DataRow dr = dt.Rows[x];
                    Models.FGshipmentvehicledispatchsummaryInfo i = new Models.FGshipmentvehicledispatchsummaryInfo();
                    i.Seq = x + 1;
                    i.Operator = dr["Operator"].ToString();
                    string so = dr["so_no"].ToString().Trim();
                    if (so.Contains("-"))
                    {
                        i.BookingNo = so.Split('-')[0];
                        i.InvoiceNo = so.Split('-')[1];
                    }
                    else
                    {
                        i.BookingNo = so;
                    }
                    i.ContState = dr["ContType"].ToString();
                    i.Ctn = Convert.ToInt32(dr["Ctn"]);
                    i.Cbm = Convert.ToDecimal(dr["Cbm"]);
                    i.ContNo_SailNo = dr["ContNo"].ToString().Trim() + "/" + dr["SailNo"].ToString().Trim();
                    if (dr["ContNo"].ToString().Trim() == "" || dr["SailNo"].ToString().Trim() == "")
                    {
                        i.ContNo_SailNo = i.ContNo_SailNo.Replace("/", "");
                    }
                    i.CarNo = dr["CarNo"].ToString();
                    i.Phone = dr["Phone"].ToString();
                    if (dr["ArriveTime"].ToString() == "")
                    {
                        dr["ArriveTime"] = NimD.ToShortDateString();
                    }
                    i.ArriveTime = Convert.ToDateTime(dr["ArriveTime"]) == NimD ? "" : Convert.ToDateTime(dr["ArriveTime"]).ToString("HH:mm");
                    i.LeaveTime = Convert.ToDateTime(dr["LeaveTime"]) == NimD ? "" : Convert.ToDateTime(dr["LeaveTime"]).ToString("HH:mm");
                    if (dr["ActLeaveTime"].ToString() == "")
                    {
                        dr["ActLeaveTime"] = NimD.ToShortDateString();
                    }
                    i.ActLeaveTime = Convert.ToDateTime(dr["ActLeaveTime"]) == NimD ? "" : Convert.ToDateTime(dr["ActLeaveTime"]).ToString("HH:mm");
                    i.ContState = dr["ContState"].ToString();
                    i.LoadingGate = dr["LoadingGate"].ToString();
                    i.TranWay = dr["TranWay"].ToString();
                    i.Remark = dr["Remark"].ToString();
                    i.Client = dr["Client"].ToString();
                    ls.Add(i);
                }

                TempData["FGlist"] = ls;
                TempData["data1"] = data1;
                TempData["data2"] = data2;
            }
            catch (Exception ex)
            {
                return View();
            }

            return new ContentResult
            {
                Content = new JavaScriptSerializer { MaxJsonLength = Int32.MaxValue }.Serialize(ls),
                ContentType = "application/json"

            };
        }
        public ActionResult ExportFGsummary()
        {
                string TempPath = Server.MapPath("~/Report/TemplateForFinishProduct.xlsx");
                FileStream file1 = new FileStream(TempPath, FileMode.Open, FileAccess.Read);
                XSSFWorkbook wb = new XSSFWorkbook(file1);
                NPOI.SS.UserModel.ISheet sh = wb.GetSheetAt(0);

            try
            {
                // ISheet sh = wb.GetSheetAt(0);
                DataInfo = TempData["FGlist"] as List<Models.FGshipmentvehicledispatchsummaryInfo>;
                DateTime date1 =Convert.ToDateTime(TempData["data1"]);
                DateTime date2 = Convert.ToDateTime(TempData["data2"]);
                //表头处理
                string A1 = "";
                if (date1.ToShortDateString() == date2.ToShortDateString())
                {
                    A1 = string.Format("GFTU成品出货车辆调度总表 {0}", date1.ToString("dd/MM/yyyy"));
                }
                else
                {
                    A1 = string.Format("GFTU成品出货车辆调度总表 {0}-{1}", date1.ToString("dd/MM/yyyy"), date2.ToString("dd/MM/yyyy"));
                }
                sh.GetRow(0).GetCell(0).SetCellValue(A1);
                //创建行
                CreateRow(sh, DataInfo.Count + 1, wb);

                //插入数据
                InsertExcel(sh);

                //修改单元格格式
                UpdateStyle(wb, sh, DataInfo.Count);

                //修改CBM列和wei列的显示方式
                SetCBM(wb, sh);
            }
            catch (Exception ex)

            { 
            
            }
            string filename = "FinishProduct.xlsx";
            var ms = new NpoiMemoryStream();
            ms.AllowClose = false;
            wb.Write(ms);
            ms.Flush();
            ms.Seek(0, SeekOrigin.Begin);
            ms.AllowClose = true;
            return File(ms, "application/vnd.ms-excel", filename);
        }
        public ActionResult AddTruckingConfirm(string booking)
        {   
            if (Session["TruckingConfirm"] == null)
            {
                return Json(new { msg = "1" }, "text/x-json");
            }

            List<Models.TruckingConfirmList> ls = Session["TruckingConfirm"] as List<Models.TruckingConfirmList>;
            List<Models.TruckingConfirmList> truckingConfirm = JsonConvert.DeserializeObject<List<Models.TruckingConfirmList>>(booking);
            for (int i= 0; i < truckingConfirm.Count;i++)
            {
                ls.Add(truckingConfirm[i]);
            }
            decimal totweight =Convert.ToDecimal(ls.Sum(g => g.GrossWeight));
            decimal totcbm = Convert.ToDecimal(ls.Sum(g => g.CBM));
            int cbmvehtype = 0;
            int weightvehtype = 0;
            int vehtype = 0;
            string vehvalue = "";

            if (totcbm > 0 && totcbm <= 50)
            {
                cbmvehtype = 11;
            }

            if (totcbm > 0 && totcbm <= 35)
            {
                cbmvehtype = 10;
            }

            if (totcbm > 0 && totcbm <= 26)
            {
                cbmvehtype = 8;
            }

            if (totcbm > 0 && totcbm <= 23)
            {
                cbmvehtype = 5;
            }

            if (totcbm > 0 && totcbm <= 17)
            {
                cbmvehtype = 3;
            }

            if (totcbm > 0 && totcbm <= 12)
            {
                cbmvehtype = 2;
            }

            if (totcbm > 0 && totcbm <= 6)
            {
                cbmvehtype = 1;
            }


            if (totweight > 0 && totweight <= 9200)
            {
                weightvehtype = 10;
            }


            if (totweight > 0 && totweight <= 8250)
            {
                weightvehtype = 11;
            }

            if (totweight > 0 && totweight <= 6500)
            {
                weightvehtype = 8;
            }

            if (totweight > 0 && totweight <= 4500)
            {
                weightvehtype = 5;
            }

            if (totweight > 0 && totweight <= 3000)
            {
                weightvehtype = 3;
            }

            if (totweight > 0 && totweight <= 2000)
            {
                weightvehtype = 2;
            }

            if (totweight > 0 && totweight <= 900)
            {
                weightvehtype = 1;
            }



            if (weightvehtype > cbmvehtype)
            {
                vehtype = weightvehtype;
            }
            else
            {
                vehtype = cbmvehtype;
            }


            if (vehtype == 1)
            {
                vehvalue = "1.25T";
            }
            if (vehtype == 2)
            {
                vehvalue = "2.5T";
            }

            if (vehtype == 3)
            {
                vehvalue = "3.5T";
            }

            if (vehtype == 5)
            {
                vehvalue = "5T";

            }
            if (vehtype == 8)
            {
                vehvalue = "8T";
            }

            if (vehtype == 10)
            {
                vehvalue = "10T";
            }

            if (vehtype == 11)
            {
                vehvalue = "10T(spec.)";
            }

            return Json(new { cbm =ls.Sum(g=>g.CBM), ctn = ls.Sum(g => g.Booking_Ctn), weight = ls.Sum(g => g.GrossWeight), vehvalue= vehvalue, msg = "0" }, "text/x-json");
        }
        public ActionResult AddTruckingConfirmEdit(string booking)
        {
            if (Session["TruckingConfirmEdit"] == null)
            {
                return Json(new { msg = "1" }, "text/x-json");
            }

            List<Models.TruckingConfirmList> ls = Session["TruckingConfirmEdit"] as List<Models.TruckingConfirmList>;
            List<Models.TruckingConfirmList> truckingConfirm = JsonConvert.DeserializeObject<List<Models.TruckingConfirmList>>(booking);
            for (int i = 0; i < truckingConfirm.Count; i++)
            {
                ls.Add(truckingConfirm[i]);
            }
            decimal totweight = Convert.ToDecimal(ls.Sum(g => g.GrossWeight));
            decimal totcbm = Convert.ToDecimal(ls.Sum(g => g.CBM));
            int cbmvehtype = 0;
            int weightvehtype = 0;
            int vehtype = 0;
            string vehvalue = "";

            if (totcbm > 0 && totcbm <= 50)
            {
                cbmvehtype = 11;
            }

            if (totcbm > 0 && totcbm <= 35)
            {
                cbmvehtype = 10;
            }

            if (totcbm > 0 && totcbm <= 26)
            {
                cbmvehtype = 8;
            }

            if (totcbm > 0 && totcbm <= 23)
            {
                cbmvehtype = 5;
            }

            if (totcbm > 0 && totcbm <= 17)
            {
                cbmvehtype = 3;
            }

            if (totcbm > 0 && totcbm <= 12)
            {
                cbmvehtype = 2;
            }

            if (totcbm > 0 && totcbm <= 6)
            {
                cbmvehtype = 1;
            }


            if (totweight > 0 && totweight <= 9200)
            {
                weightvehtype = 10;
            }


            if (totweight > 0 && totweight <= 8250)
            {
                weightvehtype = 11;
            }

            if (totweight > 0 && totweight <= 6500)
            {
                weightvehtype = 8;
            }

            if (totweight > 0 && totweight <= 4500)
            {
                weightvehtype = 5;
            }

            if (totweight > 0 && totweight <= 3000)
            {
                weightvehtype = 3;
            }

            if (totweight > 0 && totweight <= 2000)
            {
                weightvehtype = 2;
            }

            if (totweight > 0 && totweight <= 900)
            {
                weightvehtype = 1;
            }



            if (weightvehtype > cbmvehtype)
            {
                vehtype = weightvehtype;
            }
            else
            {
                vehtype = cbmvehtype;
            }


            if (vehtype == 1)
            {
                vehvalue = "1.25T";
            }
            if (vehtype == 2)
            {
                vehvalue = "2.5T";
            }

            if (vehtype == 3)
            {
                vehvalue = "3.5T";
            }

            if (vehtype == 5)
            {
                vehvalue = "5T";

            }
            if (vehtype == 8)
            {
                vehvalue = "8T";
            }

            if (vehtype == 10)
            {
                vehvalue = "10T";
            }

            if (vehtype == 11)
            {
                vehvalue = "10T(spec.)";
            }

            return Json(new { cbm = ls.Sum(g => g.CBM), ctn = ls.Sum(g => g.Booking_Ctn), weight = ls.Sum(g => g.GrossWeight), vehvalue = vehvalue, msg = "0" }, "text/x-json");

        }
        public ActionResult GetConfirmList()
        {
            List<Models.TruckingConfirmList> ls = Session["TruckingConfirm"] as List<Models.TruckingConfirmList>;
           

            return Content(new JavaScriptSerializer().Serialize(ls));
        }
        public ActionResult GetConfirmEditList()
        {
            List<Models.TruckingConfirmList> ls = Session["TruckingConfirmEdit"] as List<Models.TruckingConfirmList>;


            return Content(new JavaScriptSerializer().Serialize(ls));
        }
        public ActionResult GetConfirmEditHead()
        {
            string Booking_Number = TempData["ConfirmEditBno"].ToString();


            var bookhead = db.Truck_Booking_Head.Find(Booking_Number);
            Truck_Booking_Head v = new Truck_Booking_Head();

            v.Booking_Number = bookhead.Booking_Number;
            v.Intype = bookhead.Intype;
            v.Transport_Type = bookhead.Transport_Type;
            v.Delivery_Type = bookhead.Delivery_Type;
            v.Pick_address = bookhead.Loading_address;
            v.Vdr_Pickup_date = bookhead.Vdr_Pickup_date;

            v.CBM = bookhead.CBM;
            v.GrossWeight = bookhead.GrossWeight;
            v.CTN = bookhead.CTN;
            v.Vehicletype = bookhead.Vehicletype;
            v.VendorCode = bookhead.VendorCode;
            v.VendorName = bookhead.VendorName;
            v.Fongguan_Address = bookhead.Fongguan_Address;
            v.Return_address = bookhead.Return_address;
            v.CancelDate = bookhead.CancelDate;
            v.Driver_Name = bookhead.Driver_Name;
            v.Driver_TelNo = bookhead.Driver_TelNo;
            v.Vehicle_number = bookhead.Vehicle_number;
            v.CustomsNo = bookhead.CustomsNo;
            v.Cont_NO = bookhead.Cont_NO;
            v.Seal_NO = bookhead.Seal_NO;
            v.Frame_Type = bookhead.Frame_Type;
            v.FrameWeight = bookhead.FrameWeight;
            v.HeadStockWeight = bookhead.HeadStockWeight;
            v.ContainerWeight = bookhead.ContainerWeight;
            v.Customs_Password = bookhead.Customs_Password;
            v.Electronic_Lock = bookhead.Electronic_Lock;
            v.TongGuanCard = bookhead.TongGuanCard;
            v.Release_Pass = bookhead.Release_Pass;
            v.Remark = bookhead.Remark;



            TempData["ConfirmEditBno"] = Booking_Number;
            return Content(new JavaScriptSerializer().Serialize(v));
        }
        public ActionResult SaveTruckingConfirm(string Vehicle_type, string Vehicle_number, string Driver_name, string Driver_telno, string Cont_no, string Seal_no, string Remark)
        {


            List<Models.TruckingConfirmList> ls = Session["TruckingConfirm"] as List<Models.TruckingConfirmList>;
            string Booking_Number = GetBookingNumber();
            try
            {
                int plid = ls[0].plid;
                var datapk = db.Truck_PackingList.Find(plid);
             
                string vendor_code = datapk.vendor_code;
                string Vendorname = (from u in db.Truck_Vendor where u.Vendor_Code == vendor_code select u).ToList()[0].Vendor_Name.ToString();
                Truck_Booking_Head head = new Truck_Booking_Head();
                head.Booking_Number = Booking_Number;
                head.Delivery_Type = datapk.delivery_type;
                head.Vdr_Pickup_date = datapk.pick_date;
                head.Return_address = datapk.delivery_address;
                head.VendorCode = datapk.vendor_code;
                head.VendorName = Vendorname;
                head.Pick_address = datapk.pick_address;
                head.Vehicletype = Vehicle_type;
                head.Intype ="";
                head.Fongguan_Address = "";
                head.CTN =ls.Sum(a=>a.Ctn);
                head.CBM = ls.Sum(a => a.CBM);
                head.GrossWeight = ls.Sum(a => a.GrossWeight);
                head.Create_Person =oc.CurrentUser.uLoginName;
                head.Truck_Company = oc.CurrentVendorName;
                head.Driver_Name = Driver_name;
                head.Vehicle_number = Vehicle_number;
                head.Cont_NO = Cont_no;
                head.Seal_NO = Seal_no;
                head.Driver_TelNo = Driver_telno;
                head.Remark = Remark;
                db.Truck_Booking_Head.Add(head);
                for (int i = 0; i < ls.Count; i++)
                {
                    Truck_Booking_Detail detail = new Truck_Booking_Detail();
                    detail.Booking_Number = Booking_Number;
                    detail.plid = ls[i].plid;
                    detail.Seq= (i + 1).ToString().PadLeft(3, '0').Trim();
                    detail.CBM = ls[i].CBM;
                    detail.Ctn=ls[i].Booking_Ctn;
                    detail.SO_No =ls[i].so_no;
                    detail.GrossWeight = ls[i].GrossWeight;
                    detail.Customer_PO = ls[i].Customer_PO;
                    detail.Line = ls[i].Line;
                    detail.Material = ls[i].Material;
                    detail.Item = ls[i].Item;
                    detail.remark = ls[i].remarks;
                    detail.hfe = ls[i].hfe;
                    db.Truck_Booking_Detail.Add(detail);
                }

                db.SaveChanges();

            }
            catch (Exception ex)
            {
                return Json(new { err = ex.Message, msg = "1" }, "text/x-json");

            }
            ls.Clear();
            return Json(new { err = Booking_Number, msg = "0" }, "text/x-json");
            //return Redirect("../TMS_Areas/TruckingCompany/TrkBookingResult");
        }
        public ActionResult SaveTruckingConfirmEdit(string Vehicle_type, string Vehicle_number, string Driver_name, string Driver_telno, string Cont_no, string Seal_no, string Remark)
        {

            string Booking_Number = TempData["ConfirmEditBno"].ToString();
            List <Models.TruckingConfirmList> ls = Session["TruckingConfirmEdit"] as List<Models.TruckingConfirmList>;
            try
            {
                int plid = ls[0].plid;
                var datahead = (from u in db.Truck_Booking_Head where u.Booking_Number == Booking_Number select u).ToList();
                db.Truck_Booking_Head.Attach(datahead[0]);
                var entry = db.Entry(datahead[0]);
                datahead[0].Vehicletype = Vehicle_type;
                datahead[0].Driver_Name = Driver_name;
                datahead[0].Vehicle_number = Vehicle_number;
                datahead[0].Cont_NO = Cont_no;
                datahead[0].Seal_NO = Seal_no;
                datahead[0].Driver_TelNo = Driver_telno;
                datahead[0].Remark = Remark;
                datahead[0].CTN = ls.Sum(a => a.Ctn);
                datahead[0].CBM = ls.Sum(a => a.CBM);
                datahead[0].GrossWeight = ls.Sum(a => a.GrossWeight);
                entry.Property(e => e.Vehicletype).IsModified = true;
                entry.Property(e => e.Driver_Name).IsModified = true;
                entry.Property(e => e.Vehicle_number).IsModified = true;
                entry.Property(e => e.Cont_NO).IsModified = true;
                entry.Property(e => e.Seal_NO).IsModified = true;
                entry.Property(e => e.Driver_TelNo).IsModified = true;
                entry.Property(e => e.Remark).IsModified = true;
                entry.Property(e => e.CTN).IsModified = true;
                entry.Property(e => e.CBM).IsModified = true;
                entry.Property(e => e.GrossWeight).IsModified = true;
                var datadetail = (from u in db.Truck_Booking_Detail where u.Booking_Number == Booking_Number select u).ToList();
                for (int i = 0; i < datadetail.Count; i++)
                {
                    db.Truck_Booking_Detail.Remove(datadetail[i]);

                }
                for (int i = 0; i < ls.Count; i++)
                {
                    Truck_Booking_Detail detail = new Truck_Booking_Detail();
                    detail.Booking_Number = Booking_Number;
                    detail.plid = ls[i].plid;
                    detail.Seq = (i + 1).ToString().PadLeft(3, '0').Trim();
                    detail.CBM = ls[i].CBM;
                    detail.Ctn = ls[i].Booking_Ctn;
                    detail.SO_No = ls[i].so_no;
                    detail.GrossWeight = ls[i].GrossWeight;
                    detail.Customer_PO = ls[i].Customer_PO;
                    detail.Line = ls[i].Line;
                    detail.Material = ls[i].Material;
                    detail.Item = ls[i].Item;
                    detail.remark = ls[i].remarks;
                    detail.hfe = ls[i].hfe;
                    db.Truck_Booking_Detail.Add(detail);
                }

                db.SaveChanges();

            }
            catch (Exception ex)
            {
                return Json(new { err = ex.Message, msg = "1" }, "text/x-json");

            }
            ls.Clear();
            return Json(new { err = Booking_Number, msg = "0" }, "text/x-json");
        }
        public ActionResult DelGetConfirmListById(string id)
        {
            int plid = Convert.ToInt32(id);
            List<Models.TruckingConfirmList> ls = Session["TruckingConfirm"] as List<Models.TruckingConfirmList>;
            var data = ls.Where(aa => aa.plid == plid).ToList();
            if (data.Count > 0)
            {
                ls.Remove(data[0]);
            }
            return Json(new { cbm = ls.Sum(g => g.CBM), ctn = ls.Sum(g => g.Booking_Ctn), weight = ls.Sum(g => g.GrossWeight), msg = "0" }, "text/x-json");

        }
        public ActionResult DelGetConfirmEditListById(string id)
        {
            int plid = Convert.ToInt32(id);
            List<Models.TruckingConfirmList> ls = Session["TruckingConfirmEdit"] as List<Models.TruckingConfirmList>;
            var data = ls.Where(aa => aa.plid == plid).ToList();
            if (data.Count > 0)
            {
                ls.Remove(data[0]);
            }
            return Json(new { cbm = ls.Sum(g => g.CBM), ctn = ls.Sum(g => g.Booking_Ctn), weight = ls.Sum(g => g.GrossWeight), msg = "0" }, "text/x-json");

            //return Content(new JavaScriptSerializer().Serialize(ls));
        }
        public ActionResult CheckDownloadTruckingConfrim(string id)
        {
            int plid = Convert.ToInt32(id);
            var data = db.Truck_PackingList.Find(plid);
            if (data == null)
            {
                return Json(new { err = "", msg = "1" }, "text/x-json");
            }
            string strYear = Convert.ToDateTime(data.pick_date).Year.ToString();
            string strMonth = Convert.ToDateTime(data.pick_date).Month.ToString();
            string fileName = data.so_no.Trim();
            string path = @"D:\TMSOFile/" + strYear + "/" + strMonth;
            if (!System.IO.File.Exists(path + "/" + fileName + ".pdf"))
            {
                return Json(new { err = "", msg = "1" }, "text/x-json");
            }
            return Json(new { err = "", msg = "0" }, "text/x-json");

        }
        public ActionResult DownloadTruckingConfrim(string id)
        {
            int plid = Convert.ToInt32(id);
            var data = db.Truck_PackingList.Find(plid);

            string strYear = Convert.ToDateTime(data.pick_date).Year.ToString();
            string strMonth = Convert.ToDateTime(data.pick_date).Month.ToString();
            string fileName = data.so_no.Trim();
            string path = @"D:\TMSOFile/" + strYear + "/" + strMonth;
            FileStream fs = new FileStream(path + "/" + fileName + ".pdf", FileMode.Open);
            return File(fs, "application /pdf", fileName + ".pdf");
        }
        public ActionResult GetNull()
        {
           // return RedirectToAction("TrkBookingResult", "TruckingCompany",new { area= "TMS_Areas" });
            return Redirect("/TMS_Areas/TruckingCompany/TrkBookingResult");
        }
        public void CreateRow(ISheet sh, int rowCount, XSSFWorkbook wb)
        {
            int startIndex = 2;
            for (int x = 0; x < rowCount; x++)
            {
                if (sh.GetRow(x + startIndex) == null)
                {
                    sh.CreateRow(x + startIndex);
                }
                for (int y = 0; y < 19; y++)
                {
                    if (sh.GetRow(x + startIndex).GetCell(y) == null)
                    {
                        sh.GetRow(x + startIndex).CreateCell(y);
                    }
                }
            }
        }

        public void InsertExcel(ISheet sh)
        {
            int startIndex = 2;
            DataInfo.ForEach(a =>
            {
                sh.GetRow(startIndex).CreateCell(0).SetCellValue(a.Seq);
                sh.GetRow(startIndex).CreateCell(1).SetCellValue(a.Operator);
                sh.GetRow(startIndex).CreateCell(2).SetCellValue(a.BookingNo);
                sh.GetRow(startIndex).CreateCell(3).SetCellValue(a.InvoiceNo);
                sh.GetRow(startIndex).CreateCell(4).SetCellValue(a.ContType);
                sh.GetRow(startIndex).CreateCell(5).SetCellValue(a.Ctn);
                sh.GetRow(startIndex).CreateCell(6).SetCellValue((double)a.Cbm);
                sh.GetRow(startIndex).CreateCell(7).SetCellValue(a.ContNo_SailNo);
                sh.GetRow(startIndex).CreateCell(8).SetCellValue(a.CarNo);
                sh.GetRow(startIndex).CreateCell(9).SetCellValue(a.Phone);
                sh.GetRow(startIndex).CreateCell(10).SetCellValue(a.ArriveTime);
                sh.GetRow(startIndex).CreateCell(11).SetCellValue(a.LeaveTime);
                sh.GetRow(startIndex).CreateCell(12).SetCellValue(a.ActArriveTime);
                sh.GetRow(startIndex).CreateCell(13).SetCellValue(a.ContState);
                sh.GetRow(startIndex).CreateCell(14).SetCellValue(a.ContState);
                sh.GetRow(startIndex).CreateCell(15).SetCellValue(a.LoadingGate);
                sh.GetRow(startIndex).CreateCell(16).SetCellValue(a.TranWay);
                sh.GetRow(startIndex).CreateCell(17).SetCellValue(a.Remark);
                sh.GetRow(startIndex).CreateCell(18).SetCellValue(a.Client);
                startIndex++;
            });
        }

        public void SetCBM(XSSFWorkbook wb, ISheet sh)
        {
            IDataFormat f = wb.CreateDataFormat();
            int start = 2;
            ICellStyle style = wb.CreateCellStyle();
            style.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            style.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
            style.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            style.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            IFont font = wb.CreateFont();
            font.FontName = "Times New Roman";
            font.FontHeight = 12;
            style.SetFont(font);
            style.DataFormat = f.GetFormat("0.000");
            DataInfo.ForEach(a =>
            {
                //sh.GetRow(start).GetCell(3).CellStyle.DataFormat = f.GetFormat("0.000");
                sh.GetRow(start).GetCell(3).CellStyle = style;
                start++;
            });
        }

        public void UpdateStyle(XSSFWorkbook wb, ISheet sh, int rowCount)
        {
            IDataFormat f = wb.CreateDataFormat();
            ICellStyle style = wb.CreateCellStyle();
            style.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            style.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
            style.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            style.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            IFont font = wb.CreateFont();
            font.FontName = "Times New Roman";
            font.FontHeight = 12;
            style.SetFont(font);
            for (int x = 0; x < rowCount; x++)
            {
                for (int y = 0; y < 19; y++)
                {
                    sh.GetRow(x + 2).GetCell(y).CellStyle = style;
                }
            }
        }

        private string GetBookingNumber()
        {
            string strBookingNumber;
            DateTime date = DateTime.Now;
            string sysYear = date.Year.ToString();
            string sysMonth = date.Month.ToString().PadLeft(2, '0');
            DataSet dsResult =GetMaxBookingNumber();
            DataSet dsResult2 = GetMaxBookingNumber2();
            if (dsResult2.Tables[0].Rows[0][0] == System.DBNull.Value)
            {

                string nowYear = dsResult.Tables[0].Rows[0]["bookingnumber"].ToString().Substring(2, 4);
                string nowMonth = dsResult.Tables[0].Rows[0]["bookingnumber"].ToString().Substring(6, 2).PadLeft(2, '0'); ;
                string nowSeq = dsResult.Tables[0].Rows[0]["bookingnumber"].ToString().Substring(8);

                if (sysYear == nowYear && sysMonth == nowMonth)
                {
                    strBookingNumber = "TK" + sysYear.Trim() + sysMonth.Trim() + (Convert.ToInt32(nowSeq) + 1).ToString().PadLeft(4, '0').Trim();
                }
                else
                {
                    strBookingNumber = "TK" + sysYear.Trim() + sysMonth.Trim() + "0001";
                }
            }
            else
            {
                string nowYear = dsResult2.Tables[0].Rows[0]["bookingnumber"].ToString().Substring(2, 4);
                string nowMonth = dsResult2.Tables[0].Rows[0]["bookingnumber"].ToString().Substring(6, 2).PadLeft(2, '0'); ;
                string nowSeq = dsResult2.Tables[0].Rows[0]["bookingnumber"].ToString().Substring(8);

                if (sysYear == nowYear && sysMonth == nowMonth)
                {
                    strBookingNumber = "TK" + sysYear.Trim() + sysMonth.Trim() + (Convert.ToInt32(nowSeq) + 1).ToString().PadLeft(4, '0').Trim();
                }
                else
                {
                    strBookingNumber = "TK" + sysYear.Trim() + sysMonth.Trim() + "0001";
                }
            }

   
            return strBookingNumber;
        }


        public DataSet GetMaxBookingNumber()
        {
            const string sql = "Select  MAX(Booking_number) as bookingnumber from Truck_Booking_Head    with (XLOCK,TABLOCKX) where LEN(rtrim(Booking_Number)) =11  ";
            return Common.DbHelperSQL.Query(sql);
        }


        public DataSet GetMaxBookingNumber2()
        {
            const string sql = "Select  MAX(Booking_number) as bookingnumber from Truck_Booking_Head    with (XLOCK,TABLOCKX) where LEN(rtrim(Booking_Number)) =12  ";
            return Common.DbHelperSQL.Query(sql);
        }
    }
}

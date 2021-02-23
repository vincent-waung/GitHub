using Common;
using Microsoft.Reporting.WebForms;
using Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MvcZodiac.AspWeb
{
    public partial class TruckReportViewer : System.Web.UI.Page
    {
        OnlineBookingEntities db = new OnlineBookingEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string BookingNumber =Request.QueryString["id"].ToString().Trim();

     
                var dtbookhead = (from u1 in db.Truck_Booking_Head.Where(a => a.Booking_Number == BookingNumber) select u1).ToList();
                var dtSo = (from u1 in db.Truck_Booking_Detail.Where(a => a.Booking_Number == BookingNumber) select u1).ToList();
                string VendorCode = dtbookhead[0].VendorCode.Trim();
                var dtVendorInfo = (from u1 in db.Truck_Vendor.Where(a => a.Vendor_Code == VendorCode) select u1).ToList();

                #region LeadSail 托运单


                string contactPerson = dtVendorInfo[0].Contact_Person.ToString().Trim();
                string contactTel = dtVendorInfo[0].Contact_TelNo.ToString().Trim();

               
                //foreach (DataRow drSo in dtSo.Rows)
                //{
                //    if (strSo_Number == "")
                //    {

                //        strSo_Number = drSo["SO_No"].ToString().Trim();
                //    }
                //    else
                //    {
                //        strSo_Number = strSo_Number + "," + drSo["SO_No"].ToString().Trim();
                //    }
                //}

                try
                {

                    this.ReportViewer1.LocalReport.ReportPath = @"Report\rptTruckWorkSheet.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Clear();




                    BarcodeHelper _Code39 = new BarcodeHelper();
                    _Code39.Height = 120; //高度
                    _Code39.Magnify = 2;  //放大倍数
                                          // _Code39.ViewFont = new Font("宋体", 20);  // 设置字体

                    Bitmap bitMap = _Code39.GetCodeImage(BookingNumber, BarcodeHelper.Code39Model.Code39Normal, true);  // 根据传入的参数，生成对应的“位图”；


                    byte[] imgBytes = bmpToBytes(bitMap);//（此为上述方法，bmp为实现绘制好的Bitmap对象或通过别的方式转化为来的Bitmap对象）
                    string strB64 = Convert.ToBase64String(imgBytes);

                    this.ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dtbookhead));
                    this.ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", dtSo));
                    List<ReportParameter> paramList = new List<ReportParameter>();

                    paramList.Add(new ReportParameter("contactPerson", contactPerson, false));
                    paramList.Add(new ReportParameter("contactTel", contactTel, false));
                    paramList.Add(new ReportParameter("parBooking_Number", strB64, false));
                    paramList.Add(new ReportParameter("Client", dtVendorInfo[0].Client.ToString(), false));

                  this.ReportViewer1.LocalReport.SetParameters(paramList);
                }
                catch (Exception ex)
                { }
                #endregion
                this.ReportViewer1.LocalReport.Refresh();
            }
        }
        private byte[] bmpToBytes(Bitmap bitmap)
        {
            MemoryStream ms = null;
            try
            {
                ms = new MemoryStream();

                bitmap.Save(ms, ImageFormat.Bmp);
                byte[] byteImage = new Byte[ms.Length];
                byteImage = ms.ToArray();
                return byteImage;
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            finally
            {
                ms.Close();
            }
        }
    }
}
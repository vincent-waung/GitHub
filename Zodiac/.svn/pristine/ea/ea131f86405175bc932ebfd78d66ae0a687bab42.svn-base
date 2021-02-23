using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
using Models;
using MvcZodiac.Areas;
using System.ComponentModel;
using Common.Log;
using System.IO;
//using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Text;
namespace MvcZodiac.Controllers
{
    /**
     *  父类控制器 
     *
     */
    public class BaseController : Controller
    {
        #region UI层与Service之间操作的上下文
        protected OperContext oc = OperContext.CurrentContext;
        #endregion

        #region 把ajax返回值封装成json格式返回
        /// <summary>
        /// 把ajax返回值封装成json格式返回
        /// </summary>
        /// <param name="statu">Ajax 状态</param>
        /// <param name="msg">Ajax 信息</param>
        /// <param name="data">Ajax 数据</param>
        /// <param name="backurl">调用后的链接</param>
        /// <returns>json格式的Ajax数据</returns>
        public ActionResult PackagingAjaxmsg(AjaxStatu statu, string msg
            , object data = null, string backurl = "")
        {
            AjaxMsgModel amm = new AjaxMsgModel
            {
                BackUrl = backurl,
                Data = data,
                Msg = msg,
                Statu = statu
            };
         
            JsonResult ajaxRes = new JsonResult();
            ajaxRes.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            ajaxRes.Data = amm;         
            return ajaxRes;
        }
        #endregion

        #region 把ajax返回值封装成json格式返回
        /// <summary>
        /// 把ajax返回值封装成json格式返回
        /// </summary>
        /// <param name="statu">Ajax 状态</param>
        /// <param name="msg">Ajax 信息</param>
        /// <param name="data">Ajax 数据</param>
        /// <param name="backurl">调用后的链接</param>
        /// <returns>json格式的Ajax数据</returns>
        public ActionResult PackagingAjaxmsg(AjaxMsgModel amm)
        {          

            JsonResult ajaxRes = new JsonResult();
            ajaxRes.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            ajaxRes.Data = amm;
            return ajaxRes;

           
        }
        #endregion

        #region 重定向方法(ajax和link)
        /// <summary>
        /// 重定向方法(ajax和link)
        /// </summary>
        /// <param name="url">重定向的url</param>
        /// <param name="action">产生重定向的action方法</param>
        /// <returns>JSONRESULT REDIRECTRESULT</returns>
        public ActionResult Redirect(string url, ActionDescriptor action,AjaxStatu ajaxStatu= AjaxStatu.noperm)
        {
            //如果是Ajax请求没有权限，那么就返回Json消息
            if (action.IsDefined(typeof(Common.Attributes.AjaxRequestAttribute), false)
                || action.ControllerDescriptor.IsDefined(typeof(Common.Attributes.AjaxRequestAttribute), false))
            {
                if (ajaxStatu == AjaxStatu.nologin)
                {
                    return PackagingAjaxmsg(AjaxStatu.nologin, "您还没有登录或登录已超时，请重新登录！", null, url);
                }
                else
                {

                    string strAction = action.GetDescription();
                    string strController = action.ControllerDescriptor.GetDescription();
                    string msg = string.Format("您没有<br/>【{0}】<br/>的权限！请联系管理员！",strAction);
                    return PackagingAjaxmsg(AjaxStatu.noperm, msg, null, null);
                }
              
            }
            else//如果是超链接或表单
            {
                return new RedirectResult(url);
            }
        
        }
        #endregion

        #region 向Action加异常处理
        /// <summary>
        /// 验证控制器的Action方法
        /// </summary>
        /// <param name="controller">控件器</param>
        /// <param name="onAction">Action方法</param>
        protected void SaveToAction(Controller controller, Action onAction)
        {
            if (controller.ModelState.IsValid)
            {
                try
                {
                    onAction.Invoke();
                    controller.ViewBag.SuccessMsg = "操作成功！";
                }
                catch (Exception ex)
                {
                    LogHelper.Error(ex.Message, ex);
                    controller.ViewBag.ErrorMsg = "操作失败！" + ex.Message;
                }
            }
            else {
                controller.ViewBag.ErrorMsg = "数据验证失败！" ;
            }
        }
        #endregion

        #region 打印用户信息统计报表

        private int m_currentPageIndex;
        private IList<Stream> m_streams;


        // Routine to provide to the report renderer, in order to
        //    save an image for each page of the report.
        private Stream CreateStream(string name,
          string fileNameExtension, Encoding encoding,
          string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }
        // Export the given report as an EMF (Enhanced Metafile) file.
//        protected void Export(LocalReport report)
//        {
//            string deviceInfo =
//              @"<DeviceInfo>
//                <OutputFormat>EMF</OutputFormat>
//                <PageWidth>8.5in</PageWidth>
//                <PageHeight>11in</PageHeight>
//                <MarginTop>0.25in</MarginTop>
//                <MarginLeft>0.25in</MarginLeft>
//                <MarginRight>0.25in</MarginRight>
//                <MarginBottom>0.25in</MarginBottom>
//            </DeviceInfo>";
//            Warning[] warnings;
//            m_streams = new List<Stream>();
//            report.Render("Image", deviceInfo, CreateStream,
//               out warnings);
//            foreach (Stream stream in m_streams)
//                stream.Position = 0;
//        }
        // Handler for PrintPageEvents
        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            if (m_currentPageIndex < m_streams.Count)
            {
                Metafile pageImage = new
                   Metafile(m_streams[m_currentPageIndex]);

                // Adjust rectangular area with printer margins.
                Rectangle adjustedRect = new Rectangle(
                    ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                    ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                    ev.PageBounds.Width,
                    ev.PageBounds.Height);

                // Draw a white background for the report
                ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

                // Draw the report content
                ev.Graphics.DrawImage(pageImage, adjustedRect);

                // Prepare for the next page. Make sure we haven't hit the end.
                m_currentPageIndex++;
                ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
            }
        }

        protected void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();

            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);

                m_currentPageIndex = 0;
                //跳出打印对话框，提供打印参数可视化设置，如选择哪个打印机打印此文档等
                PrintDialog pd = new PrintDialog();
                pd.Document = printDoc;
                if (DialogResult.OK == pd.ShowDialog()) //如果确认，将会覆盖所有的打印参数设置
                {
                    //页面设置对话框（可以不使用，其实PrintDialog对话框已提供页面设置）
                    PageSetupDialog psd = new PageSetupDialog();
                    psd.Document = printDoc;
                    if (DialogResult.OK == psd.ShowDialog())
                    {
                        //打印预览
                        PrintPreviewDialog ppd = new PrintPreviewDialog();
                        ppd.Document = printDoc;
                        if (DialogResult.OK == ppd.ShowDialog())
                            printDoc.Print();          //打印
                    }
                }

            }
        }
        // Create a local report for Report.rdlc, load the data,
        //    export the report to an .emf file, and print it.
       

        protected void StreamDispose()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }


        #endregion
    }
}

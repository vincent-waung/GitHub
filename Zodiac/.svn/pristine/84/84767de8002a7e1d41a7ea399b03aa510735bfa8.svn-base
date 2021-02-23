using Common;
using Common.Attributes;
using Models;
using MvcZodiac.Areas.Models;
using MvcZodiac.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using OfficeOpenXml;
using Models.PocoModel;
using OfficeOpenXml.Style;
using System.Drawing;
using OfficeOpenXml.Drawing.Chart;
using OfficeOpenXml.Drawing;
using ThoughtWorks.QRCode.Codec;
//using Microsoft.Reporting.WinForms;
using MvcZodiac.Report;
using System.Text;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Models.ReportModel;
namespace MvcZodiac.Areas.Admin_Areas.Controllers
{
    public class Sys_UserInfoController : BaseController
    {
        //
        // GET: /Admin_Areas/Sys_UserInfo/
        #region 用户管理首页
        [Skip]
        [HttpGet]
        [Description("用户管理首页")]
        public ActionResult UserInfoIndex()
        {
            return View();
        } 
        #endregion

        #region 用户信息编辑页面
        [AjaxRequest]
        [HttpGet]
        [Description("用户信息编辑页面")]
        public ActionResult ShowUserInfoEditView()
        {
            return View();
        }
        #endregion


        #region 查看用户二维码信息
        [Skip]
        [AjaxRequest]
        [HttpGet]
        [Description("查看用户二维码信息")]
        public ActionResult ShowTdcView(int uId)
        {
            ViewBag.uId = uId;
            return View();
        }
        #endregion

        #region 根据条件查询用户信息
        [AjaxRequest]
        [HttpPost]
        [Description("根据条件查询用户信息")]
        public ActionResult GetUserInfoByCondition()
        {
          
            int page = 1;
            int rows = 5;
            if (Request.Form["rows"] != null && Request.Form["page"] != null)
            {
                page = int.Parse(Request.Form["page"]);
                rows = int.Parse(Request.Form["rows"]);
            }
            string sort = null;
            string order = null;
            if (Request.Form["sort"] != null && Request.Form["order"] != null)
            {
                sort = Request.Form["sort"];
                order = Request.Form["order"];
            }
            string uLoginName = "";
            if (Request.Form["uLoginName"] != null)
            {
                uLoginName = Request.Form["uLoginName"];
            }
            DateTime operDateStart = DateTime.Now.AddYears(-100);
            if (Request.Form["operDateStart"] != null && !Request.Form["operDateStart"].Equals(""))
            {
                operDateStart = DateTime.Parse(Request.Form["operDateStart"]);

            }
            DateTime operDateEnd = DateTime.Now;
            if (Request.Form["operDateEnd"] != null && !Request.Form["operDateEnd"].Equals(""))
            {
                operDateEnd = DateTime.Parse(Request.Form["operDateEnd"]);

            }
            int depId = -1;
            if (Request.Form["depId"] != null && !Request.Form["depId"].Equals(""))
            {
                depId = int.Parse(Request.Form["depId"]);
            }

            dynamic dgUserInfo = Model_Sys_UserInfo.GetUserInfoByCondition(page, rows, operDateStart
                , operDateEnd,depId, uLoginName, sort, order);
            return Content(DataHelper.ObjToJson(dgUserInfo));
        }
        #endregion

        #region 根据条件查询用户信息并关联角色编号
        [AjaxRequest]
        [HttpPost]
        [Description("根据条件查询用户信息")]
        public ActionResult GetUserInfoByConditionJoinRoleIds()
        {
            int page = 1;
            int rows = 5;
            if (Request.Form["rows"] != null && Request.Form["page"] != null)
            {
                page = int.Parse(Request.Form["page"]);
                rows = int.Parse(Request.Form["rows"]);
            }
            string sort = null;
            string order = null;
            if (Request.Form["sort"] != null && Request.Form["order"] != null)
            {
                sort = Request.Form["sort"];
                order = Request.Form["order"];
            }
            string uLoginName = "";
            if (Request.Form["uLoginName"] != null)
            {
                uLoginName = Request.Form["uLoginName"];
            }
            DateTime operDateStart = DateTime.Now.AddYears(-100);
            if (Request.Form["operDateStart"] != null && !Request.Form["operDateStart"].Equals(""))
            {
                operDateStart = DateTime.Parse(Request.Form["operDateStart"]);

            }
            DateTime operDateEnd = DateTime.Now;
            if (Request.Form["operDateEnd"] != null && !Request.Form["operDateEnd"].Equals(""))
            {
                operDateEnd = DateTime.Parse(Request.Form["operDateEnd"]);

            }
            int depId = -1;
            if (Request.Form["depId"] != null && !Request.Form["depId"].Equals(""))
            {
                depId = int.Parse(Request.Form["depId"]);
            }

            dynamic dgUserInfo = Model_Sys_UserInfo.GetUserInfoByConditionJoinRoleIds(page, rows, operDateStart
                , operDateEnd, depId, uLoginName, sort, order);
            return Content(DataHelper.ObjToJson(dgUserInfo));
        }
        #endregion

        #region 根据条件查询用户信息并关联特权编号
        [AjaxRequest]
        [HttpPost]
        [Description("根据条件查询用户信息并关联特权编号")]
        public ActionResult GetUserInfoByConditionJoinVipIds()
        {
            int page = 1;
            int rows = 5;
            if (Request.Form["rows"] != null && Request.Form["page"] != null)
            {
                page = int.Parse(Request.Form["page"]);
                rows = int.Parse(Request.Form["rows"]);
            }
            string sort = null;
            string order = null;
            if (Request.Form["sort"] != null && Request.Form["order"] != null)
            {
                sort = Request.Form["sort"];
                order = Request.Form["order"];
            }
            string uLoginName = "";
            if (Request.Form["uLoginName"] != null)
            {
                uLoginName = Request.Form["uLoginName"];
            }
            DateTime operDateStart = DateTime.Now.AddYears(-100);
            if (Request.Form["operDateStart"] != null && !Request.Form["operDateStart"].Equals(""))
            {
                operDateStart = DateTime.Parse(Request.Form["operDateStart"]);

            }
            DateTime operDateEnd = DateTime.Now;
            if (Request.Form["operDateEnd"] != null && !Request.Form["operDateEnd"].Equals(""))
            {
                operDateEnd = DateTime.Parse(Request.Form["operDateEnd"]);

            }
            int depId = -1;
            if (Request.Form["depId"] != null && !Request.Form["depId"].Equals(""))
            {
                depId = int.Parse(Request.Form["depId"]);
            }

            dynamic dgUserInfo = Model_Sys_UserInfo.GetUserInfoByConditionJoinVipIds(page, rows, operDateStart
                , operDateEnd, depId, uLoginName, sort, order);
            return Content(DataHelper.ObjToJson(dgUserInfo));
        }
        #endregion

        #region 新增用户
        [AjaxRequest]
        [HttpPost]
        [Description("新增用户")]
        public ActionResult AddUser()
        {
            string uLoginName = string.Empty;
            if (Request.Form["uLoginName"] != null)
            {
                uLoginName = Request.Form["uLoginName"];
            }
            int uDepId = 0;
            if (Request.Form["uDepId"] != null)
            {
                uDepId = int.Parse(Request.Form["uDepId"]);
            }

            string uPost = string.Empty;
            if (Request.Form["uPost"] != null)
            {
                uPost = Request.Form["uPost"];
            }

            string uRemark = string.Empty;
            if (Request.Form["uRemark"] != null)
            {
                uRemark = Request.Form["uRemark"];
            }
            string uImgUrl = string.Empty;
            if (Request.Form["uImgUrl"] != null)
            {
                uImgUrl = Request.Form["uImgUrl"];
            }

            bool uGender = true;
            if (Request.Form["uGender"] != null && !Request.Form["uGender"].Equals(""))
            {
                uGender = bool.Parse(Request.Form["uGender"]);
            }
            bool uIsDel = false;
            if (Request.Form["uIsDel"] != null && !Request.Form["uIsDel"].Equals(""))
            {
                uIsDel = bool.Parse(Request.Form["uIsDel"]);
            }

            string uPwd = SecurityHelper.Md5EncryptToString("1234");

            Sys_UserInfo user = new Sys_UserInfo
            {
                uAddTime = DateTime.Now,
                uDepId = uDepId,
                uGender = uGender,
                uIsDel = uIsDel,
                uLoginName = uLoginName,
                uPost = uPost,
                uRemark = uRemark,
                uPwd = uPwd,
                uImgUrl = uImgUrl
            };
            AjaxMsgModel amm = Model_Sys_UserInfo.AddUserInfo(user);
            return PackagingAjaxmsg(amm);
        }
        #endregion

        #region 修改用户
        [AjaxRequest]
        [HttpPost]
        [Description("修改用户")]
        public ActionResult EditUser()
        {
            
              string uLoginName = string.Empty;
            if (Request.Form["uLoginName"] != null)
            {
                uLoginName = Request.Form["uLoginName"];
            }
            int uDepId = 0;
            if (Request.Form["uDepId"] != null)
            {
                uDepId = int.Parse(Request.Form["uDepId"]);
            }

            string uPost = string.Empty;
            if (Request.Form["uPost"] != null)
            {
                uPost = Request.Form["uPost"];
            }

            string uRemark = string.Empty;
            if (Request.Form["uRemark"] != null)
            {
                uRemark = Request.Form["uRemark"];
            }

            bool uGender = true;
            if (Request.Form["uGender"] != null && !Request.Form["uGender"].Equals(""))
            {
                uGender = bool.Parse(Request.Form["uGender"]);
            }
            bool uIsDel = false;
            if (Request.Form["uIsDel"] != null && !Request.Form["uIsDel"].Equals(""))
            {
                uIsDel = bool.Parse(Request.Form["uIsDel"]);
            }

            string uImgUrl = string.Empty;
            if (Request.Form["uImgUrl"] != null)
            {
                uImgUrl = Request.Form["uImgUrl"];
            }

            int uId = 0;
            if (Request.Form["uId"] != null)
            {
                uId = int.Parse(Request.Form["uId"]);
            }

            Sys_UserInfo user = new Sys_UserInfo
            {
                uAddTime = DateTime.Now,
                uDepId = uDepId,
                uGender = uGender,
                uIsDel = uIsDel,
                uLoginName = uLoginName,
                uPost = uPost,
                uRemark = uRemark,
                uId = uId,
                uImgUrl=uImgUrl
              
            };
            AjaxMsgModel amm = Model_Sys_UserInfo.EditUserInfo(user);
            return PackagingAjaxmsg(amm);

        
        }
        #endregion

        #region 删除用户
        [AjaxRequest]
        [HttpPost]
        [Description("删除用户")]
        public ActionResult DelUser()
        {
            int uId = 0;
            if (Request.Form["uId"] != null)
            {
                uId = int.Parse(Request.Form["uId"]);
            }
            AjaxMsgModel amm = Model_Sys_UserInfo.DelUserInfo(uId);
            return PackagingAjaxmsg(amm);
        }
        #endregion

        #region 修改密码
        [AjaxRequest]
        [HttpPost]
        [Description("修改密码")]
        public ActionResult EditUserPwd()
        {
             string cxpwd = string.Empty;
            if (Request.Form["cxpwd"] != null)
            {
                cxpwd = Request.Form["cxpwd"];
            }
            cxpwd = SecurityHelper.Md5EncryptToString(cxpwd);
            string cypwd = string.Empty;
            if (Request.Form["cypwd"] != null)
            {
                cypwd = Request.Form["cypwd"];
            }

            int uId = 0;
            if (Request.Form["uId"] != null)
            {
                uId = int.Parse(Request.Form["uId"]);
            }

            Sys_UserInfo user = new Sys_UserInfo
            {
                uId =uId,
                uPwd = cxpwd
            };
            AjaxMsgModel amm = Model_Sys_UserInfo.EditUserPwd(user, cypwd);
            return PackagingAjaxmsg(amm);
        }
        #endregion

        #region 导出用户信息
        [Skip]
        public ActionResult ExportExcel()
        {
            string pathFileName = string.Empty;
            ExportUserExcel(out pathFileName);         
            return PackagingAjaxmsg(new AjaxMsgModel { BackUrl = null, Data = null, Msg = "导出成功！", Statu = AjaxStatu.ok });
        }

        [Skip]
        public FileResult DownLoadFileExcel()
        {
            string pathFileName = string.Empty;
            ExportUserExcel(out pathFileName);
            string fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx";
            return File(pathFileName, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }

        private void ExportUserExcel(out string pathFileName)
        {
            //创建存放Excel的文件夹
            string path = Server.MapPath("~/Upload/");
            string fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx";
            pathFileName = path + fileName;
            FileInfo newFile = new FileInfo(pathFileName);
            if (newFile.Exists)
            {
                newFile.Delete();
                newFile = new FileInfo(pathFileName);
            }

            string uLoginName = "";
            if (Request.Form["uLoginName"] != null)
            {
                uLoginName = Request.Form["uLoginName"];
            }
            DateTime operDateStart = DateTime.Now.AddYears(-100);
            if (Request.Form["operDateStart"] != null && !Request.Form["operDateStart"].Equals(""))
            {
                operDateStart = DateTime.Parse(Request.Form["operDateStart"]);

            }
            DateTime operDateEnd = DateTime.Now;
            if (Request.Form["operDateEnd"] != null && !Request.Form["operDateEnd"].Equals(""))
            {
                operDateEnd = DateTime.Parse(Request.Form["operDateEnd"]);

            }
            int depId = -1;
            if (Request.Form["depId"] != null && !Request.Form["depId"].Equals(""))
            {
                depId = int.Parse(Request.Form["depId"]);
            }
            //得到符合条件的用户信息
            List<POCO_Sys_UserInfo> pocoUsers = Model_Sys_UserInfo.GetUserInfoForIQueryable(operDateStart, operDateEnd, depId, uLoginName);
            //创建工作簿和工作表
            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                ExcelWorksheet workSheet = package.Workbook.Worksheets.Add("usrInfo");
                /*添加表头*/
                workSheet.InsertRow(1, 1);
                using (var range = workSheet.Cells[1, 1, 1, 8])
                {
                    range.Merge = true;
                    range.Style.Font.SetFromFont(new Font("Britannic Bold", 18, FontStyle.Italic));
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(184, 204, 228));
                    range.Style.Font.Color.SetColor(Color.Black);
                    range.Value = "用户基本信息";
                }
                /*设置标题*/
                workSheet.Cells[2, 1].Value = "用户编号";
                workSheet.Cells[2, 2].Value = "用户名称";
                workSheet.Cells[2, 3].Value = "所属部门";
                workSheet.Cells[2, 4].Value = "性    别";
                workSheet.Cells[2, 5].Value = "是否禁用";
                workSheet.Cells[2, 6].Value = "联系电话";
                workSheet.Cells[2, 7].Value = "操作日期";
                workSheet.Cells[2, 8].Value = "说    明";
                using (var range = workSheet.Cells[2, 1, 2, 8])
                {
                    range.Style.Font.Bold = true;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(Color.DarkBlue);
                    range.Style.Font.Color.SetColor(Color.White);
                    range.AutoFilter = true;
                }
                /*设置单元格内容*/
                int row = 3;
                foreach (POCO_Sys_UserInfo pUser in pocoUsers)
                {
                    workSheet.Cells[row, 1].Value = pUser.uId;
                    workSheet.Cells[row, 2].Value = pUser.uLoginName;
                    workSheet.Cells[row, 3].Value = pUser.depName;
                    workSheet.Cells[row, 4].Value = pUser.uGender ? "男" : "女";
                    workSheet.Cells[row, 5].Value = pUser.uIsDel ? "禁用" : "启用";
                    workSheet.Cells[row, 6].Value = pUser.uPost;
                    workSheet.Cells[row, 7].Value = pUser.uAddTime;
                    workSheet.Cells[row, 8].Value = pUser.uRemark;
                    workSheet.Cells[row, 7].Style.Numberformat.Format = "yyyy-MM-dd HH:mm:ss";
                    workSheet.Cells[row, 6].Style.Numberformat.Format = "@";
                    row++;
                }
                /*添加表尾*/
                using (var range = workSheet.Cells[pocoUsers.Count + 3, 1, pocoUsers.Count + 3, 8])
                {
                    range.Merge = true;
                    range.Style.Font.SetFromFont(new Font("Britannic Bold", 18, FontStyle.Italic));
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(184, 204, 228));
                    range.Style.Font.Color.SetColor(Color.Black);
                    range.Value = "总人数:" + pocoUsers.Count + "人";
                }
                /*设置整个Excel样式*/
                workSheet.Cells[workSheet.Dimension.Address].AutoFitColumns();
                workSheet.Cells[workSheet.Dimension.Address].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                workSheet.Cells[workSheet.Dimension.Address].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                workSheet.Cells[workSheet.Dimension.Address].Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;


                package.Save();
            }
        }
        #endregion

        #region 统计每个部门的人数
        [Skip]
        public ActionResult GetUserCountByDepName()
        {
            List<YW_DepartPerson> dgUsrCount = Model_Sys_UserInfo.GetUserCountByDepName();
            return Content(DataHelper.ObjToJson(dgUsrCount));
        }
        #endregion

        #region 统计每种性别对应的人数
        [Skip]
        public ActionResult GetPerCountByGender()
        {
             dynamic dgUsrCount = Model_Sys_UserInfo.GetPerCountByGender();
            return Content(DataHelper.ObjToJson(dgUsrCount));
        }
        #endregion

        #region 导出每个部门人数
        [Skip]
        public FileResult ExportDepUserExcel()
        {
            //创建存放Excel的文件夹
            string path = Server.MapPath("~/Upload/");
            string fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx";
            string pathFileName = path + fileName;
            FileInfo newFile = new FileInfo(pathFileName);
            if (newFile.Exists)
            {
                newFile.Delete();
                newFile = new FileInfo(pathFileName);
            }
            //得到每个部门的人数
            List<YW_DepartPerson> dgUsrCount = Model_Sys_UserInfo.GetUserCountByDepName();
            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("deptInfo");
                //允许单元格内容换行
                worksheet.Cells.Style.WrapText = true;
                //不显示网格线
                worksheet.View.ShowGridLines = false;

                worksheet.InsertRow(1, 1);
                worksheet.Cells[1, 1].Value = "部门名称";
                worksheet.Cells[1, 2].Value = "部门人数";

                int row = 2;
                foreach (YW_DepartPerson dp in dgUsrCount)
                {
                    worksheet.Cells[row, 1].Value = dp.Name;
                    worksheet.Cells[row, 2].Value = dp.Count;
                    row++;
                }
                using (ExcelRange range = worksheet.Cells[1, 1, dgUsrCount.Count + 1, 2])
                {
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    range.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                }
                using (ExcelRange range = worksheet.Cells[1, 1, 1, 2])
                {
                    range.Style.Font.Bold = true;
                    range.Style.Font.Color.SetColor(Color.White);
                    range.Style.Font.Name = "微软雅黑";
                    range.Style.Font.Size = 12;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(128, 128, 128));
                }
                worksheet.Cells.Style.ShrinkToFit = true;
                //生成图表
                ExcelChart chart = worksheet.Drawings.AddChart("chart", eChartType.ColumnClustered);

                ExcelChartSerie serie = chart.Series.Add(worksheet.Cells[2, 2, dgUsrCount.Count + 1, 2], worksheet.Cells[2, 1, dgUsrCount.Count + 1, 1]);
                serie.HeaderAddress = worksheet.Cells[1, 2];

                chart.SetPosition(150, 10);
                chart.SetSize(500, 300);
                chart.Title.Text = "部门人数";
                chart.Title.Font.Color = Color.FromArgb(89, 89, 89);
                chart.Title.Font.Size = 15;
                chart.Title.Font.Bold = true;
                chart.Style = eChartStyle.Style15;
                chart.Legend.Border.LineStyle = eLineStyle.Solid;
                chart.Legend.Border.Fill.Color = Color.FromArgb(217, 217, 217);

                package.Save();
            }
            return File(pathFileName, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }
        #endregion

        #region 上传用户头像到服务器
        [Skip]
        public ActionResult Upload(int uid)
        {
            if (Request.Files.Count == 0)
            {
                return PackagingAjaxmsg(new AjaxMsgModel { BackUrl = null, Data = null, Msg = "未找到要上传的图片", Statu = AjaxStatu.err });
            }
            else
            { 
               //得到上传的图片
                var file = Request.Files[0];
                //要保存的文件路径
                var path = Path.Combine(Server.MapPath(Request.ApplicationPath), "Upload", "userHead");
                //要保存的文件名称
                string fileName = string.Format("{0}_{1}_{2}{3}", oc.CurrentUser.uId, Path.GetFileNameWithoutExtension(file.FileName)
                    , DateTime.Now.ToString("yyyyMMddHHmmss"), Path.GetExtension(file.FileName));
                //保存文件到指定的目录
                file.SaveAs(Path.Combine(path, fileName));
                //上传之后图片的相对路径
                string relativePath = Path.Combine(Request.ApplicationPath, "Upload", "userHead", fileName);

                return PackagingAjaxmsg(new AjaxMsgModel { BackUrl = relativePath, Data = null, Msg = "上传成功", Statu = AjaxStatu.ok });
            }
        }
        #endregion

        #region 生成用户信息二维码
        [Skip]
        public void GenerateUserTdc(int uId)
        {
            Sys_UserInfo user = oc.BllSession.ISys_UserInfoBLL.Entities.Where(u => u.uId == uId).SingleOrDefault();
            if (user != null)
            {
                string data = string.Format(@"MECARD:N:{0};ADR:{1};TEL:{2}; EMAIL:{3};URL:{4};QQ:{5};; ",
                    user.uLoginName,
                    "上海,中国",
                    user.uPost,
                    "lxl_qqemail@qq.com",
                    "http://www.ibeifeng.com",
                    "234643556"
                   );

                QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
                qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                qrCodeEncoder.QRCodeScale = 4;
                qrCodeEncoder.QRCodeVersion = 8;
                qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
                //设置二维码的前景色
                //System.Drawing.Color c1 = System.Drawing.Color.FromArgb(51, 255, 0);
                ////qrCodeEncoder.QRCodeForegroundColor = c1;
                ////qrCodeEncoder.QRCodeBackgroundColor = System.Drawing.Color.Red;
                //设置二维码的渐变效果           
                Image tdcImage;
                //设置二维码的渐变效果
                // image = qrCodeEncoder.Encode(data,System.Drawing.Color.Red,System.Drawing.Color.Blue);     
                //设置特殊二维码
                string bgImagPath = Path.Combine(Server.MapPath(Request.ApplicationPath), "Upload", "userHead", "FreshnessCloud.jpg");
                Image bgImage = Image.FromFile(bgImagPath);
                Bitmap bmBgImage = new Bitmap(bgImage, 330, 368);
                Bitmap bmHdImage=null;
                if (user.uImgUrl.Length > 0)
                {
                    string headImagPath = Path.Combine(Server.MapPath(user.uImgUrl));
                    Image headImage = Image.FromFile(headImagPath);
                    bmHdImage = new Bitmap(headImage, 30, 30);
                }
                //二维码图片
                tdcImage = qrCodeEncoder.Encode(data, System.Drawing.Color.Red, System.Drawing.Color.Blue);
                using (Graphics g = Graphics.FromImage(bmBgImage))
                {
                    g.DrawImage(tdcImage, (bmBgImage.Width - tdcImage.Width) / 2, (bmBgImage.Height - tdcImage.Height) / 2);
                }

                using (Graphics g = Graphics.FromImage(bmBgImage))
                {
                    g.DrawImage(bmHdImage, (bmBgImage.Width - bmHdImage.Width) / 2, (bmBgImage.Height - bmHdImage.Height) / 2);
                }

                ResponseImage(bmBgImage);
            }
        }

        private void ResponseImage(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Response.ClearContent();
                Response.ContentType = "image/jpeg";
                Response.BinaryWrite(ms.ToArray());
                image.Dispose();
            }
        }
        #endregion

        //#region 导出用户信息统计报表
        //[Skip]
        //public FileContentResult ExportUserReport()
        //{
        //    //得到报表数据源
        //    List<R_Sys_UserInfo> rUsers = Model_Sys_UserInfo.GetUserInfoForReport();

        //    //创建本地处理模式报表对象
        //    LocalReport lr = new LocalReport();
        //    //设置报表格式
        //    string deviceInfo =
        //     "<DeviceInfo>" +
        //     "<SimplePageHeaders>True</SimplePageHeaders>" +
        //    "</DeviceInfo>";
        //    //设置报表路径
        //    lr.ReportPath = Server.MapPath("~/Report/Report1.rdlc");
        //    //设置报表数据源
        //    ReportDataSource reportDataSource = new ReportDataSource();
        //    reportDataSource.Name = "DataSet1";
        //    reportDataSource.Value = rUsers;
        //    lr.DataSources.Add(reportDataSource);
        //    //以Excel的格式呈现报表,并返回报表对象
        //    byte[] bytes = lr.Render("Excel", deviceInfo);
        //    //下载报表文件
        //    return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "R_Sys_UserInfo.xls");
        //    //向磁盘写报表文件
        //    //using (FileStream fs = new FileStream(@"D:\References\RDLC\usersInfo.xls", FileMode.Create))
        //    //{
        //    //    fs.Write(bytes, 0, bytes.Length);
        //    //    fs.Close();
        //    //}

        //}
        //#endregion

//        #region 显示用户信息统计报表
//        [Skip]
//        public FileContentResult ShowUserReport()
//        {
//            //得到报表数据源
//            List<R_Sys_UserInfo> rUsers = Model_Sys_UserInfo.GetUserInfoForReport();

//            //创建本地处理模式报表对象
//            LocalReport lr = new LocalReport();
//            //设置报表格式
//            string deviceInfo =
//              @"<DeviceInfo>
//                <OutputFormat>jpeg</OutputFormat>
//                <PageWidth>8.5in</PageWidth>
//                <PageHeight>11in</PageHeight>
//                <MarginTop>0.25in</MarginTop>
//                <MarginLeft>0.25in</MarginLeft>
//                <MarginRight>0.25in</MarginRight>
//                <MarginBottom>0.25in</MarginBottom>
//            </DeviceInfo>";
//            //设置报表路径
//            lr.ReportPath = Server.MapPath("~/Report/Report1.rdlc");
//            //设置报表数据源
//            ReportDataSource reportDataSource = new ReportDataSource();
//            reportDataSource.Name = "DataSet1";
//            reportDataSource.Value = rUsers;
//            lr.DataSources.Add(reportDataSource);
//            //以Excel的格式呈现报表,并返回报表对象
//            byte[] bytes = lr.Render("Image", deviceInfo);
//            //下载报表文件
//            return File(bytes, "image/jpeg");
//            //向磁盘写报表文件
//            //using (FileStream fs = new FileStream(@"D:\References\RDLC\usersInfo.xls", FileMode.Create))
//            //{
//            //    fs.Write(bytes, 0, bytes.Length);
//            //    fs.Close();
//            //}

//        }
//        #endregion

        //#region 打印用户信息统计报表

       
        //// Create a local report for Report.rdlc, load the data,
        ////    export the report to an .emf file, and print it.
        //[Skip]
        //public ActionResult PintUserReport()
        //{
        //    //得到报表数据源
        //    List<R_Sys_UserInfo> rUsers = Model_Sys_UserInfo.GetUserInfoForReport();

        //    LocalReport report = new LocalReport();
        //    report.ReportPath = Server.MapPath("~/Report/Report1.rdlc"); ;
        //    report.DataSources.Add(
        //       new ReportDataSource("DataSet1", rUsers));
        //    Export(report);
        //    Print();
        //    StreamDispose();
        //    return PackagingAjaxmsg(new AjaxMsgModel { BackUrl = null, Data = null, Msg = "成功打印", Statu = AjaxStatu.ok });
        //}

        //#endregion
    }
}

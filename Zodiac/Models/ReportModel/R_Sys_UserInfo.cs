using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ReportModel
{
    public class R_Sys_UserInfo
    {
        //        select u.uId,
        public int uId { get; set; }
        //u.uLoginName,
        public string uLoginName { get; set; }
        //d.depName,
        public string depName { get; set; }
        //case when u.uGender=1 then '男' else '女' end as uGender,
        public string uGender { get; set; }
        //u.uPost,
        public string uPost { get; set; }
        //u.uRemark,
        public string uRemark { get; set; }
        //case when u.uIsDel =1 then '禁用' else '户用' end uIsDel,
        public string uIsDel { get; set; }
        //u.uAddTime
        public DateTime uAddTime { get; set; }
        //from [dbo].[Sys_UserInfo] as u
        //left join [dbo].[Sys_Department] as d
        //on u.uDepId = d.depId
    }
}

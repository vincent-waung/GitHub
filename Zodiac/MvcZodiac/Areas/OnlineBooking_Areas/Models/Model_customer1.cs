using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common;
using Models;
using System.Linq.Expressions;
using Models.PocoModel;


namespace MvcZodiac.Areas.Models
{
    public partial class Model_customer1
    {

        #region 查询所有Customer
        public static dynamic GetAllCustomer()
        {
           
            //var loadplans = oc.BllSession.IFinalLoadingPlanBLL.Entities.Where(r => r.JOB_NO.Contains(JobNo) && r.Customer_Name.Contains(customer) && r.SalesOrd_STO.Contains(SalesOrd), page, rows, out total, psc);
            var customers = oc.BllSession.Icustomer1BLL.Entities.Select(a => new {a.cust_name}).Distinct().ToList();
            return customers;
        }
        #endregion

        #region 查询所有SM Operator
        public static dynamic GetAllOperator()
        {

            //var loadplans = oc.BllSession.IFinalLoadingPlanBLL.Entities.Where(r => r.JOB_NO.Contains(JobNo) && r.Customer_Name.Contains(customer) && r.SalesOrd_STO.Contains(SalesOrd), page, rows, out total, psc);
            var operators = oc.BllSession.Icustomer1BLL.Entities.Select(a => new { a.SM_Operator }).Distinct().ToList();
         
            return operators;
        }
        #endregion
    }
}
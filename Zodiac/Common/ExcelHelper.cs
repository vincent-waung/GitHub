﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Common
{
    public class ExcelHelper
    {
         /// <summary>
        /// 获取excel的DataTable
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="sheetName"></param>
        /// <returns></returns>
        public static DataTable GetExcelContent(String filePath, string sheetName)
        {
            if (sheetName == "_xlnm#_FilterDatabase")
                return null;
            DataSet dateSet = new DataSet();
            String connectionString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;HDR=NO;IMEX=1;'", filePath);
            String commandString = string.Format("SELECT * FROM [{0}$]", sheetName);
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(commandString, connection))
                {
                    OleDbCommand objCmd = new OleDbCommand(commandString, connection);
                    OleDbDataAdapter myData = new OleDbDataAdapter(commandString, connection);
                    myData.Fill(dateSet, sheetName);
                    DataTable table = dateSet.Tables[sheetName];

                    table.Rows.RemoveAt(0);
                    table.Rows.RemoveAt(0);
                    table.Rows.RemoveAt(0);
                    for (int i = 0; i < table.Rows[0].ItemArray.Length; i++)
                    {
                        var cloumnName = table.Rows[0].ItemArray[i].ToString();
                        if (!string.IsNullOrEmpty(cloumnName))
                            table.Columns[i].ColumnName = cloumnName;
                    }
                    table.Rows.RemoveAt(0);
                    return table;
                }
            }
        }
 
        /// <summary>
        /// 获取excel文件里面的所有的工作表名称
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static List<string> GetExcelSheetNames(string filePath)
        {
            OleDbConnection connection = null;
            System.Data.DataTable dt = null;
            try
            {
                String connectionString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;HDR=YES;IMEX=1;'", filePath);
                connection = new OleDbConnection(connectionString);
                connection.Open();
                dt = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
 
                if (dt == null)
                {
                    return new List<string>();
                }
 
                String[] excelSheets = new String[dt.Rows.Count];
                int i = 0;
                foreach (DataRow row in dt.Rows)
                {
                    excelSheets[i] = row["TABLE_NAME"].ToString().Split('$')[0];
                    i++;
                }
                return excelSheets.Distinct().ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
                if (dt != null)
                {
                    dt.Dispose();
                }
            }
        }
 
        

    }
}
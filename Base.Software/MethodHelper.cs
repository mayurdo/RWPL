using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using Base.Software.Helper;
using DocumentFormat.OpenXml.Packaging;
using RWPLEntityModel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Base.Software
{
    public static class MethodHelper
    {
        public static string CurrentFinacialYear()
        {
            string finacialYear;

            if (DateTime.Now.Month < 4)
            {
                finacialYear = DateTime.Now.AddYears(-1).ToString("yyyy") + "-" + DateTime.Now.ToString("yy");
            }
            else
            {
                finacialYear = DateTime.Now.ToString("yyyy") + "-" + DateTime.Now.AddYears(1).ToString("yy");
            }

            return finacialYear;
        }


        public static void ExportDataSet(DataGridView dataGridView1, string destination)
        {
            using (var workbook = SpreadsheetDocument.Create(destination, DocumentFormat.OpenXml.SpreadsheetDocumentType.Workbook))
            {
                var workbookPart = workbook.AddWorkbookPart();

                workbook.WorkbookPart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();

                workbook.WorkbookPart.Workbook.Sheets = new DocumentFormat.OpenXml.Spreadsheet.Sheets();



                var sheetPart = workbook.WorkbookPart.AddNewPart<WorksheetPart>();
                var sheetData = new DocumentFormat.OpenXml.Spreadsheet.SheetData();
                sheetPart.Worksheet = new DocumentFormat.OpenXml.Spreadsheet.Worksheet(sheetData);

                DocumentFormat.OpenXml.Spreadsheet.Sheets sheets = workbook.WorkbookPart.Workbook.GetFirstChild<DocumentFormat.OpenXml.Spreadsheet.Sheets>();
                string relationshipId = workbook.WorkbookPart.GetIdOfPart(sheetPart);

                uint sheetId = 1;
                if (sheets.Elements<DocumentFormat.OpenXml.Spreadsheet.Sheet>().Count() > 0)
                {
                    sheetId =
                        sheets.Elements<DocumentFormat.OpenXml.Spreadsheet.Sheet>().Select(s => s.SheetId.Value).Max() + 1;
                }

                DocumentFormat.OpenXml.Spreadsheet.Sheet sheet = new DocumentFormat.OpenXml.Spreadsheet.Sheet() { Id = relationshipId, SheetId = sheetId, Name = "TestName" };
                sheets.Append(sheet);

                DocumentFormat.OpenXml.Spreadsheet.Row headerRow = new DocumentFormat.OpenXml.Spreadsheet.Row();

                List<String> columns = new List<string>();
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (!column.Visible)
                        continue;

                    columns.Add(column.Name);
                    DocumentFormat.OpenXml.Spreadsheet.Cell cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                    cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                    cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(column.Name);
                    headerRow.AppendChild(cell);

                }


                sheetData.AppendChild(headerRow);

                foreach (DataGridViewRow dsrow in dataGridView1.Rows)
                {
                    DocumentFormat.OpenXml.Spreadsheet.Row newRow = new DocumentFormat.OpenXml.Spreadsheet.Row();
                    foreach (String col in columns)
                    {
                        DocumentFormat.OpenXml.Spreadsheet.Cell cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                        cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;

                        cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue((dsrow.Cells[col].Value == null) ? string.Empty : dsrow.Cells[col].Value.ToString()); //
                        newRow.AppendChild(cell);
                    }

                    sheetData.AppendChild(newRow);
                }
            }
        }

        public static void ExportToExcel<T>(DataGridViewColumnCollection datagridViewColumns, List<T> dataList)
        {
            Application.UseWaitCursor = true;

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            int rowIndex = 1;
            int colIndex = 1;

            var columns = new List<string>();
            foreach (DataGridViewColumn column in datagridViewColumns)
            {
                if (!column.Visible)
                    continue;

                columns.Add(column.Name);
                xlWorkSheet.Cells[rowIndex, colIndex] = column.Name;
                colIndex++;
            }

            rowIndex++;
            var properties = typeof(T).GetProperties();
            foreach (var data in dataList)
            {
                colIndex = 1;
                foreach (var property in properties)
                {
                    if (!columns.Contains(property.Name))
                        continue;

                    string cellValue = Convert.ToString(typeof(T).GetProperty(property.Name).GetValue(data, null));

                    xlWorkSheet.Cells[rowIndex, colIndex] = cellValue;

                    if (property.Name.Contains("Date"))
                        ((Excel.Range)xlWorkSheet.Cells[rowIndex, colIndex]).NumberFormat = "dd-MMM-yyyy";

                    if (property.Name.Contains("Time"))
                        ((Excel.Range)xlWorkSheet.Cells[rowIndex, colIndex]).NumberFormat = "hh:mm AM/PM";

                    colIndex++;
                }
                rowIndex++;
            }

            xlWorkSheet.get_Range(xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[1, colIndex - 1]).Font.Bold = true;
            xlWorkSheet.get_Range(xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[rowIndex - 1, colIndex - 1]).Borders.Weight = Excel.XlBorderWeight.xlThin;


            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string full_name = saveFileDialog1.InitialDirectory + saveFileDialog1.FileName;
                xlWorkBook.SaveAs(full_name + ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                MessageBox.Show("Excel file created , you can find the file " + full_name + ".xls");
            }

            Application.UseWaitCursor = false;
        }

        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }


        public static List<T> Import_From_Excel<T>(DataGridViewColumnCollection datagridViewColumns, long maxSrNo, string excelPath)
           where T : IEntity, new()
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;

            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Open(excelPath);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Sheets[1];
            var lastRow = xlWorkSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;

            int rowIndex = 1;
            int colIndex = 1;

            var columns = new List<string>();
            foreach (DataGridViewColumn column in datagridViewColumns)
            {
                if (!column.Visible)
                    continue;

                columns.Add(column.Name);
                //xlWorkSheet.Cells[rowIndex, colIndex] = column.Name;
                colIndex++;
            }


            var dataList = new List<T>();
            var propertyInfos = typeof(T).GetProperties();

            for (rowIndex = 2; rowIndex <= lastRow; rowIndex++)
            {
                var obj = new T();

                var rowValues = (Array)xlWorkSheet.Range[xlWorkSheet.Cells[rowIndex, 1], xlWorkSheet.Cells[rowIndex, columns.Count]].Cells.Value;

                for (var col = 0; col < columns.Count; col++)
                {
                    var propertyInfo = propertyInfos.SingleOrDefault(x => x.Name == columns[col]);
                    if (propertyInfo == null)
                        continue;

                    object value = null;
                    object cellValue = rowValues.GetValue(1, col + 1);
                    if (propertyInfo.PropertyType == typeof(bool))
                    {
                        value = (cellValue == "Y");
                    }
                    else
                    {
                        try
                        {
                            Type type = Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType;

                            if (cellValue == null || string.IsNullOrEmpty(cellValue.ToString()))
                            {
                                value = SetDefaultValue(propertyInfo.PropertyType);
                            }
                            else if (type == typeof(DateTime))
                            {
                                try
                                {
                                    var cellFormat = ((Excel.Range)xlWorkSheet.Cells[rowIndex, col + 1]).NumberFormat;

                                    value = ((string)cellFormat == "hh:mm AM/PM")
                                                ? DateTime.FromOADate((double)cellValue)
                                                : (DateTime)cellValue;
                                }
                                catch (Exception ex)
                                {
                                    throw ex;
                                }
                            }
                            else
                            {
                                value = Convert.ChangeType(cellValue, type);
                            }
                        }
                        catch (Exception ex)
                        {
                            var errorMessage = string.Format("Row No '{0}' has invalid value '{1}' in column '{2}', " +
                                                             "Please correct it in excel and try again",
                                                                            rowIndex, cellValue, columns[col]);
                            MessageBox.Show(errorMessage, "Error Message", MessageBoxButtons.OK);

                            xlApp.Quit();
                            releaseObject(xlWorkSheet);
                            releaseObject(xlWorkBook);
                            releaseObject(xlApp);
                            return new List<T>();
                        }
                    }
                    propertyInfo.SetValue(obj, value, null);
                }

                obj.CreatedBy = "Excel Import";
                obj.CreatedDate = DateTime.Now;
                obj.IsDeleted = false;

                //if (obj.SrNo == 0)
                //    continue;

                obj.SrNo = maxSrNo + 1;
                maxSrNo++;

                dataList.Add(obj);
            }


            xlApp.Quit();
            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            return dataList;
        }

        private static object SetDefaultValue(Type type)
        {
            if (type.IsGenericType &&
                type.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                return null;
            }

            if (type == typeof(string))
                return string.Empty;

            if (type == typeof(DateTime))
                return DateTime.Now;

            return 0;
        }

        //public static ResultResponse<T> GetServiceResponse<T>(string servicePath, ReportRequest request) where T : Entity
        //{
        //    var client = new HttpClient
        //    {
        //        BaseAddress = new Uri("http://localhost:4005/")
        //    };

        //    // Add an Accept header for JSON format.
        //    client.DefaultRequestHeaders.Accept.Add(
        //        new MediaTypeWithQualityHeaderValue("application/json"));

        //    var json = JsonConvert.SerializeObject(request);
        //    HttpContent requestContent = new StringContent(json);
        //    requestContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        //    var httpResponse = client.PostAsync(servicePath, requestContent).Result;

        //    var response = new ResultResponse<T>();
        //    if (httpResponse.IsSuccessStatusCode)
        //    {
        //        response = JObject.Parse(httpResponse.Content.ReadAsStringAsync().Result).ToObject<ResultResponse<T>>();
        //    }
        //    else
        //    {
        //        response.Exception = new Exception(string.Format("Status Code : {0}", httpResponse.StatusCode));
        //    }

        //    return response;
        //}

        //public static ResultResponse<T> GetServicePageDataResponse<T>(string servicePath)
        //{
        //    var client = new HttpClient
        //    {
        //        BaseAddress = new Uri("http://localhost:4005/")
        //    };

        //    // Add an Accept header for JSON format.
        //    client.DefaultRequestHeaders.Accept.Add(
        //        new MediaTypeWithQualityHeaderValue("application/json"));

        //    var httpResponse = client.GetAsync(servicePath).Result;

        //    var response = new ResultResponse<T>();
        //    if (httpResponse.IsSuccessStatusCode)
        //    {
        //        response = JObject.Parse(httpResponse.Content.ReadAsStringAsync().Result).ToObject<ResultResponse<T>>();
        //    }
        //    else
        //    {
        //        response.Exception = new Exception(string.Format("Status Code : {0}", httpResponse.StatusCode));
        //    }

        //    return response;
        //}

        //public static ResultResponse<T> SaveServiceResponse<T>(T entity) where T : Entity
        //{
        //    var serviceAssembly = typeof(DispatchDataService).Assembly;
        //    var t = serviceAssembly.GetType(serviceAssembly.GetName().Name + "." + typeof(T).Name + "DataService");

        //    var method = t.BaseType.GetMethod("Save", BindingFlags.Public | BindingFlags.Static);

        //    return (ResultResponse<T>)method.Invoke(null, new object[] { entity });
        //}
    }
}

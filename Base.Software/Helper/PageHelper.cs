using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using DocumentFormat.OpenXml.Drawing.Charts;
using RWPLEntityModel;
using RWPLLinqDataService;
//using excel = DocumentFormat.OpenXml.Office2010.Excel;

namespace Base.Software.Helper
{
    public class PageHelper
    {
        public static User UserDetail { get; set; }

        public static ApplicationDataRequest ApplicationData { get; set; }

        public static void LoadApplicationData()
        {
            var services = new WinServices(typeof(ApplicationDataRequest).Name);
            var response = services.CustomServiceResponse<ApplicationDataRequest>("Get");
            if (!response.IsSuccess)
            {
                MessageBox.Show(@"Application Data not loaded", @"Error Message", MessageBoxButtons.OK);
                return;
            }

            ApplicationData = response.Object;
        }

        public static void AcceptOnlyNumber(KeyPressEventArgs e)
        {
            int key = Convert.ToInt32(e.KeyChar);
            if (!((key >= 48 && key <= 57) || (key > 1 && key <= 26) || key == 8))
            {
                e.Handled = true;
            }
        }

        public static void AcceptOnlyDecimal(KeyPressEventArgs e, string oldText)
        {
            int key = Convert.ToInt32(e.KeyChar);

            if (!((key >= 48 && key <= 57) || (key > 1 && key <= 26) || key == 8
                || (key == 46 && !oldText.Contains("."))))
            {
                e.Handled = true;
            }
        }

        public static void AcceptOnlyNumberWithMultiplyAndCommas(KeyPressEventArgs e, string oldText)
        {
            int key = Convert.ToInt32(e.KeyChar);

            var lastCharIsNumber = !string.IsNullOrEmpty(oldText) && char.IsNumber(oldText[oldText.Length - 1]);

            if (!((key >= 48 && key <= 57) || (key > 1 && key <= 26) || key == 8 || (key == 42 && lastCharIsNumber) || (key == 44 && lastCharIsNumber)))
            {
                e.Handled = true;
            }
        }

        public static void ColumnFormating(DataGridView dataGridView)
        {
            var entityProperties = typeof(IEntity).GetProperties().Where(x => x.Name != "SrNo").Select(x => x.Name).ToList();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column.Name.Contains("Date"))
                    column.DefaultCellStyle.Format = "dd/MM/yyyy";

                if (column.Name.Contains("Time"))
                    column.DefaultCellStyle.Format = "hh:mm tt";

                if (entityProperties.Contains(column.Name))
                    column.Visible = false;

                if (column.Name == "SrNo")
                    column.DisplayIndex = 0;
            }
        }



        public static void CalculateQtyXAny(string qtyXBundlesValue, TextBox totalQtyTextBox = null, TextBox totalBundlesTextBox = null)
        {
            var commaSeperated = qtyXBundlesValue.Split(',');

            long totalQty = 0;
            long totalBundles = 0;
            foreach (var multiplyValue in commaSeperated)
            {
                if (string.IsNullOrEmpty(multiplyValue))
                    continue;

                var multiplySeperater = multiplyValue.Split('*');
                var qtyPerBundle = (multiplySeperater.Length < 1 || string.IsNullOrEmpty(multiplySeperater[0]))
                                ? 0
                                : Convert.ToInt64(multiplySeperater[0]);
                var bundles = (multiplySeperater.Length < 2 || string.IsNullOrEmpty(multiplySeperater[1]))
                                ? 0
                                : Convert.ToInt64(multiplySeperater[1]);

                totalQty += (qtyPerBundle * bundles);
                totalBundles += bundles;
            }

            if (totalQtyTextBox != null)
                totalQtyTextBox.Text = totalQty.ToString(CultureInfo.InvariantCulture);

            if (totalBundlesTextBox != null)
                totalBundlesTextBox.Text = totalBundles.ToString(CultureInfo.InvariantCulture);
        }

        public static void ExportToExcel()
        {
            //var dataTable = new DataTable();
            // CreateExcelFile.CreateExcelDocument(dataTable, "C:\\Sample.xlsx");
            //DocumentFormat

        }
    }
}

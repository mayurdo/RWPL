using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Base.Software.Helper;
using RWPLEntityModel.PageDataRequest;
using RWPLEntityModel.SearchRequest;
using RWPLLinqDataService;

namespace RWPLSoftware.FrmDuplexPrintedPaper
{
    public partial class FrmDuplexPrintedPaperReport : Form
    {
        private readonly ReportForm<DuplexPrintedPaper, DuplexPrintedPaperSearchRequest, DuplexPrintedPaper> _reportForm;

        public FrmDuplexPrintedPaperReport()
        {
            InitializeComponent();

            _reportForm = new ReportForm<DuplexPrintedPaper, DuplexPrintedPaperSearchRequest, DuplexPrintedPaper>(groupBox1, bindingNavigator1, dataGridView1,
                                                                                          bindingNavigatorPositionItem.TextBox, lblReportStatus, lblReportSummary);
        }

        private void FrmDuplexPrintedPaperReport_Load(object sender, EventArgs e)
        {
            lblHeader.Width = this.Width;
            lblHeader.Text = @"Duplex Printed Paper Report";
            panel1.Width = this.Width - 40;
            dataGridView1.Width = panel1.Width;
            bindingNavigatorPositionItem.Text = @"1";

            _reportForm.FillDropDownAndAutoComplete<DuplexPrintedPaperReportPageRequest>();
            _reportForm.BindGridViewWithFilter();

            dataGridView1.Columns[@"PaperSizeDeckle"].DefaultCellStyle.Format = "0.000##";
            dataGridView1.Columns[@"PaperSizeCutting"].DefaultCellStyle.Format = "0.000##";
            dataGridView1.Columns[@"StockInMM"].DefaultCellStyle.Format = "0.000##";
            dataGridView1.Columns[@"TotalPaperQty"].DefaultCellStyle.Format = "0.000##";
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _reportForm.AddNewPage<FrmDuplexPrintedPaperEntry>();
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            _reportForm.EditPage<FrmDuplexPrintedPaperEntry>();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            _reportForm.DeleteSelectedData();
        }

        private void txtBindCustomerName_TextChanged(object sender, EventArgs e)
        {
            _reportForm.BindGridViewWithFilter();
        }

        private void toolStripButtonExportToExcel_Click(object sender, EventArgs e)
        {
            _reportForm.ExportToExcel();
        }
    }
}

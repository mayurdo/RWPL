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

namespace RWPLSoftware.FrmPaperReelConsumption
{
    public partial class FrmPaperReelConsumptionReport : Form
    {
        private readonly string _reelNo = string.Empty;
        private readonly ReportForm<PaperReelConsumption, PaperReelConsumptionSearchRequest, PaperReelConsumption> _reportForm;

        public FrmPaperReelConsumptionReport()
        {
            InitializeComponent();

            _reportForm = new ReportForm<PaperReelConsumption, PaperReelConsumptionSearchRequest, PaperReelConsumption>(groupBox1, bindingNavigator1, dataGridView1,
                                                                                           bindingNavigatorPositionItem.TextBox, lblReportStatus, lblReportSummary);
        }

        public FrmPaperReelConsumptionReport(string realNo = "")
        {
            InitializeComponent();

            _reelNo = realNo;
            _reportForm = new ReportForm<PaperReelConsumption, PaperReelConsumptionSearchRequest, PaperReelConsumption>(groupBox1, bindingNavigator1, dataGridView1,
                                                                                           bindingNavigatorPositionItem.TextBox, lblReportStatus, lblReportSummary);
        }

        private void PaperReelConsumptionReport_Load(object sender, EventArgs e)
        {
            lblHeader.Width = this.Width;
            lblHeader.Text = @"Paper Reel Consumption Report";
            panel1.Width = this.Width - 40;
            dataGridView1.Width = panel1.Width;
            bindingNavigatorPositionItem.Text = @"1";
            txtBindReelNo.Text = _reelNo;

            _reportForm.FillDropDownAndAutoComplete<PaperReelConsumptionReportPageRequest>();
            _reportForm.BindGridViewWithFilter();

            dataGridView1.Columns[@"Weight"].DefaultCellStyle.Format = "0.000##";
            dataGridView1.Columns[@"Consumption"].DefaultCellStyle.Format = "0.000##";
            dataGridView1.Columns[@"Balance"].DefaultCellStyle.Format = "0.000##";
            dataGridView1.Columns[@"SrNo"].Visible = false;
            //dataGridView1.Columns[@"TIMEConsume"].DefaultCellStyle.Format = "0##";
        }

        private void txtBindReelNo_TextChanged(object sender, EventArgs e)
        {
            _reportForm.BindGridViewWithFilter();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _reportForm.AddNewPage<FrmPaperReelConsumptionEntry>();
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            _reportForm.EditPage<FrmPaperReelConsumptionEntry>();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            _reportForm.DeleteSelectedData();
        }

        private void toolStripButtonExportToExcel_Click(object sender, EventArgs e)
        {
            _reportForm.ExportToExcel();
        }
    }
}

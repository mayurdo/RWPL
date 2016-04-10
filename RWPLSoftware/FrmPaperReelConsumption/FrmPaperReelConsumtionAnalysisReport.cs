using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Base.Software.Helper;
using RWPLEntityModel.SearchRequest;
using RWPLLinqDataService;

namespace RWPLSoftware.FrmPaperReelConsumption
{
    public partial class FrmPaperReelConsumtionAnalysisReport : Form
    {
        private readonly ReportForm<PaperReelConsumptionAnalysi, PaperReelConsumptionAnalysiSearchRequest, PaperReelConsumptionAnalysi> _reportForm;

        public FrmPaperReelConsumtionAnalysisReport()
        {
            InitializeComponent();
            _reportForm = new ReportForm<PaperReelConsumptionAnalysi, PaperReelConsumptionAnalysiSearchRequest, PaperReelConsumptionAnalysi>(groupBox1, bindingNavigator1, dataGridView1,
                                                                                          bindingNavigatorPositionItem.TextBox, lblReportStatus, lblReportSummary);
        }

        private void FrmPaperReelConsumtionAnalysisReport_Load(object sender, EventArgs e)
        {
            lblHeader.Width = this.Width;
            lblHeader.Text = @"Carogation Production Analysis";
            panel1.Width = this.Width - 40;
            dataGridView1.Width = panel1.Width;
            bindingNavigatorPositionItem.Text = @"1";

            _reportForm.BindGridViewWithFilter();

            dataGridView1.Columns["Date"].Width = 70;
            dataGridView1.Columns["Machine"].Width = 70;
            dataGridView1.Columns["NoOfReel"].Width = 70;

        }

        private void cmbBindMachine_TextChanged(object sender, EventArgs e)
        {
            _reportForm.BindGridViewWithFilter();
        }
    }
}

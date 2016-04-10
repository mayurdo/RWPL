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

namespace RWPLSoftware.FrmDispatch
{
    public partial class FrmDispatchAnalysis : Form
    {
        private readonly ReportForm<DispatchAnalysi, DispatchAnalysiSearchRequest, DispatchAnalysi> _reportForm;

        public FrmDispatchAnalysis()
        {
            InitializeComponent();
            _reportForm = new ReportForm<DispatchAnalysi, DispatchAnalysiSearchRequest, DispatchAnalysi>(groupBox1, bindingNavigator1, dataGridView1,
                                                                                         bindingNavigatorPositionItem.TextBox, lblReportStatus, lblReportSummary);
        
        }

        private void FrmDispatchAnalysis_Load(object sender, EventArgs e)
        {
            lblHeader.Width = this.Width;
            lblHeader.Text = @"Dispatch Analysis";
            panel1.Width = this.Width - 40;
            dataGridView1.Width = panel1.Width;
            bindingNavigatorPositionItem.Text = @"1";

            _reportForm.BindGridViewWithFilter();
        }
    }
}

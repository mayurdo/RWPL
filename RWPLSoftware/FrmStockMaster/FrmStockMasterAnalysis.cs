using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Base.Software.Helper;
using RWPLEntityModel;
using RWPLEntityModel.PageDataRequest;
using RWPLEntityModel.SearchRequest;
using RWPLLinqDataService;

namespace RWPLSoftware.FrmStockMaster
{
    public partial class FrmStockMasterAnalysis : Form
    {
        private readonly ReportForm<StockMasterReport, InwardMasterSearchRequest, StockMasterReport> _reportForm;

        public FrmStockMasterAnalysis()
        {
            InitializeComponent();

            _reportForm = new ReportForm<StockMasterReport, InwardMasterSearchRequest, StockMasterReport>(groupBox1, bindingNavigator1, dataGridView1,
                                                                                           bindingNavigatorPositionItem.TextBox, lblReportStatus, lblReportSummary);
        }

        private void FrmStockMasterAnalysis_Load(object sender, EventArgs e)
        {
            lblHeader.Width = this.Width;
            //lblHeader.Text = @"RaStock Master";
            panel1.Width = this.Width - 40;
            dataGridView1.Width = panel1.Width;
            btnBack.Location = new Point(btnBack.Location.X, groupBox1.Location.Y + 20);

            bindingNavigatorPositionItem.Text = @"1";

            _reportForm.FillDropDownAndAutoComplete<InwardMasterReportPageRequest>();
            _reportForm.BindGridViewWithFilter();
        }

        private void txtBindMill_TextChanged(object sender, EventArgs e)
        {
            _reportForm.BindGridViewWithFilter();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var bf = dataGridView1.SelectedRows[0].Cells[@"BF"].Value.ToString();
                var gsm = dataGridView1.SelectedRows[0].Cells[@"GSM"].Value.ToString();
                var size = dataGridView1.SelectedRows[0].Cells[@"Size"].Value.ToString();

                PageHelper.GoToPage<FrmStockMasterReport>(AccessPages.StockMaster, bf,gsm,size);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

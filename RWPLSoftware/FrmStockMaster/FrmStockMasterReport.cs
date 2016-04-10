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
    public partial class FrmStockMasterReport : Form
    {
        private readonly ReportForm<InwardMasterView, InwardMasterSearchRequest, InwardMaster> _reportForm;
        private string _bf;
        private string _gsm;
        private string _size;


        public FrmStockMasterReport()
        {
            InitializeComponent();

            _reportForm = new ReportForm<InwardMasterView, InwardMasterSearchRequest, InwardMaster>(groupBox1, bindingNavigator1, dataGridView1,
                                                                                           bindingNavigatorPositionItem.TextBox, lblReportStatus, lblReportSummary);
        }

        public FrmStockMasterReport(string bf = "", string gsm = "", string size = "")
        {
            InitializeComponent();

            _bf = bf;
            _gsm = gsm;
            _size = size;
            _reportForm = new ReportForm<InwardMasterView, InwardMasterSearchRequest, InwardMaster>(groupBox1, bindingNavigator1, dataGridView1,
                                                                                           bindingNavigatorPositionItem.TextBox, lblReportStatus, lblReportSummary);
        }

        private void FrmStockMasterReport_Load(object sender, EventArgs e)
        {
            lblHeader.Width = this.Width;
            lblHeader.Text = @"Inward Master Report";
            panel1.Width = this.Width - 40;
            dataGridView1.Width = panel1.Width;
            btnBack.Location = new Point(btnBack.Location.X, groupBox1.Location.Y+20);

            bindingNavigatorPositionItem.Text = @"1";
            txtBindBF.Text = _bf;
            txtBindGSM.Text = _gsm;
            txtBindSize.Text = _size;

            _reportForm.FillDropDownAndAutoComplete<InwardMasterReportPageRequest>();
            _reportForm.BindGridViewWithFilter();

            dataGridView1.Columns[@"Received"].DefaultCellStyle.Format = "0.000##";
        }

        private void txtBindReelNo_TextChanged(object sender, EventArgs e)
        {
            _reportForm.BindGridViewWithFilter();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _reportForm.AddNewPage<FrmStockMasterEntry>();
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            _reportForm.EditPage<FrmStockMasterEntry>();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            _reportForm.DeleteSelectedData();
        }

        private void toolStripButtonExportToExcel_Click(object sender, EventArgs e)
        {
            _reportForm.ExportToExcel();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var realNo = dataGridView1.SelectedRows[0].Cells[@"ReelNo"].Value;
                PageHelper.GoToPage<FrmPaperReelConsumption.FrmPaperReelConsumptionReport>(AccessPages.PaperReelConsumption, realNo);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

namespace RWPLSoftware.FrmCustomerMaster
{
    public partial class FrmCustomerMasterReport : Form
    {
        private readonly ReportForm<RWPLLinqDataService.CustomerMaster, CustomerMasterSearchRequest, RWPLLinqDataService.CustomerMaster> _reportForm;

        public FrmCustomerMasterReport()
        {
            InitializeComponent();

            _reportForm = new ReportForm<RWPLLinqDataService.CustomerMaster, CustomerMasterSearchRequest, RWPLLinqDataService.CustomerMaster>(groupBox1, bindingNavigator1, dataGridView1,
                                                                                       bindingNavigatorPositionItem.TextBox, lblReportStatus, lblReportSummary);
        }

        private void FrmCustomerMasterReport_Load(object sender, EventArgs e)
        {
            lblHeader.Width = this.Width;
            lblHeader.Text = @"Item Master Report";
            panel1.Width = this.Width - 40;
            dataGridView1.Width = panel1.Width;
            bindingNavigatorPositionItem.Text = @"1";

            //_reportForm.FillDropDownAndAutoComplete<CustomerMasterReportPageRequest>();
            _reportForm.BindGridViewWithFilter();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _reportForm.AddNewPage<FrmCustomerMasterEntry>();
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            _reportForm.EditPage<FrmCustomerMasterEntry>();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            _reportForm.DeleteSelectedData();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            _reportForm.BindGridViewWithFilter();
        }
    }
}

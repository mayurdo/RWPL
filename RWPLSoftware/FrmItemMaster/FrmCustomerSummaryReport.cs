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
using RWPLEntityModel.SearchRequest;
using RWPLLinqDataService;

namespace RWPLSoftware.FrmItemMaster
{
    public partial class FrmCustomerSummaryReport : Form
    {
        private readonly ReportForm<CustomerSummary, CustomerSummarySearchRequest, CustomerSummary> _reportForm;

        public FrmCustomerSummaryReport()
        {
            InitializeComponent();

            _reportForm = new ReportForm<CustomerSummary, CustomerSummarySearchRequest, CustomerSummary>(groupBox1, bindingNavigator1, dataGridView1,
                                                                                          bindingNavigatorPositionItem.TextBox, lblReportStatus, lblReportSummary);
        }

        private void FrmCustomerSummaryReport_Load(object sender, EventArgs e)
        {
            lblHeader.Width = this.Width;
            lblHeader.Text = @"Customer Summary";
            panel1.Width = this.Width - 40;
            dataGridView1.Width = panel1.Width;
            bindingNavigatorPositionItem.Text = @"1";
            
            _reportForm.BindGridViewWithFilter();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _reportForm.AddNewPage<FrmItemMasterEntry>();
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            _reportForm.EditPage<FrmItemMasterEntry>();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            _reportForm.DeleteSelectedData();
        }

        private void txtBindCustomerName_TextChanged(object sender, EventArgs e)
        {
            _reportForm.BindGridViewWithFilter();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var companyName = dataGridView1.SelectedRows[0].Cells[@"CompanyName"].Value;
                PageHelper.GoToPage<FrmItemMasterReport>(AccessPages.ItemMaster, companyName);
            }
        }
    }
}

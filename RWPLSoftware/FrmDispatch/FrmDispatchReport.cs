using System;
using System.Windows.Forms;
using Base.Software.Helper;
using RWPLEntityModel;
using RWPLEntityModel.PageDataRequest;
using RWPLEntityModel.ReportView;
using RWPLEntityModel.SearchRequest;
using RWPLLinqDataService;

namespace RWPLSoftware.FrmDispatch
{
    public partial class FrmDispatchReport : Form
    {
        private readonly ReportForm<DispatchReportView, DispatchSearchRequest,Dispatch> _reportForm;

        public FrmDispatchReport()
        {
            InitializeComponent();

            _reportForm = new ReportForm<DispatchReportView, DispatchSearchRequest, Dispatch>(groupBox1, bindingNavigator1, dataGridView1,
                                                                                            bindingNavigatorPositionItem.TextBox, lblReportStatus,lblReportSummary);
        }

        private void FrmDispatchReport_Load(object sender, EventArgs e)
        {
            lblHeader.Width = this.Width;
            lblHeader.Text = @"Dispatch Report";
            panel1.Width = this.Width - 40;
            dataGridView1.Width = panel1.Width;
            bindingNavigatorPositionItem.Text = @"1";

            if (!_reportForm.UserAccessPage.View)
            {
                MessageBox.Show(@"You don't have access to this page, Please contact your administrator", @"Access Message");
                this.Close();
            }

            _reportForm.FillDropDownAndAutoComplete<DispatchReportPageRequest>();
            _reportForm.BindGridViewWithFilter();
            
        }

        private void txtBindCustomerName_TextChanged(object sender, EventArgs e)
        {
            _reportForm.BindGridViewWithFilter();
        }

        private void dtpBindFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (cbBindIsSearchByDate.Checked)
                _reportForm.BindGridViewWithFilter();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _reportForm.AddNewPage<FrmDispatchEntry>();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            _reportForm.DeleteSelectedData();
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            _reportForm.EditPage<FrmDispatchEntry>();
        }
    }
}

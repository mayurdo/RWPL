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
using RWPLEntityModel.ReportView;
using RWPLEntityModel.SearchRequest;
using RWPLLinqDataService;

namespace Base.Software
{
    public partial class FrmUserAccessReport : Form
    {
        private readonly ReportForm<UserReportView, UserSearchRequest, User> _reportForm;

        public FrmUserAccessReport()
        {
            InitializeComponent();

            _reportForm = new ReportForm<UserReportView, UserSearchRequest, User>(groupBox1, bindingNavigator1, dataGridView1,
                                                                                            bindingNavigatorPositionItem.TextBox, lblReportStatus, lblReportSummary);
        }

        private void UserAccessReport_Load(object sender, EventArgs e)
        {
            lblHeader.Width = this.Width;
            lblHeader.Text = @"Dispatch Report";
            panel1.Width = this.Width - 40;
            dataGridView1.Width = panel1.Width;
            bindingNavigatorPositionItem.Text = @"1";

            //_reportForm.FillDropDownAndAutoComplete<UserReportPageRequest>();
            _reportForm.BindGridViewWithFilter();
            dataGridView1.Columns["SrNo"].Visible = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _reportForm.AddNewPage<FrmUserAccessEntry>();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            _reportForm.DeleteSelectedData();
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            _reportForm.EditPage<FrmUserAccessEntry>();
        }

        private void txtBindUserName_TextChanged(object sender, EventArgs e)
        {
            _reportForm.BindGridViewWithFilter();
            dataGridView1.Columns["SrNo"].Visible = false;
        }
    }
}

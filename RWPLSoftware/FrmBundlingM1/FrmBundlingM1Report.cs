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

namespace RWPLSoftware.FrmBundlingM1
{
    public partial class FrmBundlingM1Report : Form
    {
        private readonly ReportForm<BundlingM1, BundlingM1SearchRequest, BundlingM1> _reportForm;

        public FrmBundlingM1Report()
        {
            InitializeComponent();

            _reportForm = new ReportForm<BundlingM1, BundlingM1SearchRequest, BundlingM1>(groupBox1, bindingNavigator1, dataGridView1,
                                                                                           bindingNavigatorPositionItem.TextBox, lblReportStatus,lblReportSummary);
        }

        private void FrmBundlingM1Report_Load(object sender, EventArgs e)
        {
            lblHeader.Width = this.Width;
            lblHeader.Text = @"Bundling M1 Report";
            panel1.Width = this.Width - 40;
            dataGridView1.Width = panel1.Width;
            bindingNavigatorPositionItem.Text = @"1";

            _reportForm.FillDropDownAndAutoComplete<BundlingM1ReportPageRequest>();
            _reportForm.BindGridViewWithFilter();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _reportForm.AddNewPage<FrmBundlingM1Entry>();
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            _reportForm.EditPage<FrmBundlingM1Entry>();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            _reportForm.DeleteSelectedData();
        }

        private void txtBindClient_TextChanged(object sender, EventArgs e)
        {
            _reportForm.BindGridViewWithFilter();
        }
    }
}

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

namespace RWPLSoftware.FrmRotary
{
    public partial class FrmRotaryReport : Form
    {
        private readonly ReportForm<Rotary, RotarySearchRequest, Rotary> _reportForm;

        public FrmRotaryReport()
        {
            InitializeComponent();

            _reportForm = new ReportForm<Rotary, RotarySearchRequest, Rotary>(groupBox1, bindingNavigator1, dataGridView1,
                                                                                          bindingNavigatorPositionItem.TextBox, lblReportStatus, lblReportSummary);
        }

        private void FrmRotaryReport_Load(object sender, EventArgs e)
        {
            lblHeader.Width = this.Width;
            lblHeader.Text = @"Rotary Report";
            panel1.Width = this.Width - 40;
            dataGridView1.Width = panel1.Width;
            bindingNavigatorPositionItem.Text = @"1";

            _reportForm.FillDropDownAndAutoComplete<RotaryReportPageRequest>();
            _reportForm.BindGridViewWithFilter();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _reportForm.AddNewPage<FrmRotaryEntry>();
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            _reportForm.EditPage<FrmRotaryEntry>();
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

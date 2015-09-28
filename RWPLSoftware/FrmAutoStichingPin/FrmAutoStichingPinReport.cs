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

namespace RWPLSoftware.FrmAutoStichingPin
{
    public partial class FrmAutoStichingPinReport : Form
    {
        private readonly ReportForm<AutoStichingPin, AutoStichingPinSearchRequest, AutoStichingPin> _reportForm;


        public FrmAutoStichingPinReport()
        {
            InitializeComponent();

            _reportForm = new ReportForm<AutoStichingPin, AutoStichingPinSearchRequest, AutoStichingPin>(groupBox1, bindingNavigator1, dataGridView1,
                                                                                           bindingNavigatorPositionItem.TextBox, lblReportStatus,lblReportSummary);
        }

        private void FrmAutoStichingPinReport_Load(object sender, EventArgs e)
        {
            lblHeader.Width = this.Width;
            lblHeader.Text = @"Auto Stiching (Pins) Report";
            panel1.Width = this.Width - 40;
            dataGridView1.Width = panel1.Width;
            bindingNavigatorPositionItem.Text = @"1";

            //_reportForm.FillDropDownAndAutoComplete<AutoStichingPinReportPageRequest>();
            _reportForm.BindGridViewWithFilter();
        }
        
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _reportForm.AddNewPage<FrmAutoStichingPinEntry>();
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            _reportForm.EditPage<FrmAutoStichingPinEntry>();
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

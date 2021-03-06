﻿using System;
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

namespace RWPLSoftware.FrmItemMaster
{
    public partial class FrmItemMasterReport : Form
    {
        private readonly string _companyName;

        private readonly ReportForm<RWPLLinqDataService.ItemMaster, ItemMasterSearchRequest, RWPLLinqDataService.ItemMaster> _reportForm;

        public FrmItemMasterReport()
        {
            InitializeComponent();

            _companyName = string.Empty;
            _reportForm = new ReportForm<RWPLLinqDataService.ItemMaster, ItemMasterSearchRequest, RWPLLinqDataService.ItemMaster>(groupBox1, bindingNavigator1, dataGridView1,
                                                                                          bindingNavigatorPositionItem.TextBox, lblReportStatus, lblReportSummary);
        }

        public FrmItemMasterReport(string companyName)
        {
            InitializeComponent();

            _companyName = companyName;
            _reportForm = new ReportForm<RWPLLinqDataService.ItemMaster, ItemMasterSearchRequest, RWPLLinqDataService.ItemMaster>(groupBox1, bindingNavigator1, dataGridView1,
                                                                                          bindingNavigatorPositionItem.TextBox, lblReportStatus, lblReportSummary);
        }

        private void FrmItemMasterReport_Load(object sender, EventArgs e)
        {
            lblHeader.Width = this.Width;
            lblHeader.Text = @"Item Master Report";
            panel1.Width = this.Width - 40;
            dataGridView1.Width = panel1.Width;
            bindingNavigatorPositionItem.Text = @"1";
            txtBindCustomerName.Text = _companyName;

            //_reportForm.FillDropDownAndAutoComplete<ItemMasterReportPageRequest>();
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

        private void txtBindCompanyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                _reportForm.BindGridViewWithFilter();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _reportForm.BindGridViewWithFilter();
        }
    }
}

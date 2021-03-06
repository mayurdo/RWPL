﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Base.Software.Helper;
using RWPLLinqDataService;

namespace RWPLSoftware.FrmBundlingM1
{
    public partial class FrmBundlingM1Entry : Form
    {
        private readonly EntryForm<BundlingM1> _entryForm;

        public FrmBundlingM1Entry()
        {
            InitializeComponent();

            _entryForm = new EntryForm<BundlingM1>(this);
        }

        public FrmBundlingM1Entry(long srNo = 0)
        {
            InitializeComponent();

            _entryForm = new EntryForm<BundlingM1>(this,srNo);
        }

        private void txtBindRBundleUnit_TextChanged(object sender, EventArgs e)
        {
            PageHelper.CalculateQtyXAny(txtBindBundleUnit.Text,txtBindBoxQty,txtBindBundleQty);
        }

        private void FrmBundlingM1Entry_Load(object sender, EventArgs e)
        {
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Base.Software.Helper;
using RWPLEntityModel.PageDataRequest;
using RWPLLinqDataService;

namespace RWPLSoftware.FrmDispatch
{
    public partial class FrmDispatchEntry : Form
    {
        private readonly EntryWithGridForm<Dispatch, DispatchItem> _entryForm;

        public FrmDispatchEntry()
        {
            InitializeComponent();

            _entryForm = new EntryWithGridForm<Dispatch, DispatchItem>(this);
        }

        public FrmDispatchEntry(long srNo)
        {
            InitializeComponent();

            _entryForm = new EntryWithGridForm<Dispatch, DispatchItem>(this, srNo);
        }

        private void FrmDispatchEntry_Load(object sender, EventArgs e)
        {
            _entryForm.FillDropDownAndAutoComplete<DispatchEntryPageRequest>();
            
        }
        private void txtBindRQtyPerBundle_TextChanged(object sender, EventArgs e)
        {
            PageHelper.CalculateQtyXAny(txtBindQtyPerBundle.Text, txtBindTotalQty, txtBindTotalBundles);
        }
    }
}

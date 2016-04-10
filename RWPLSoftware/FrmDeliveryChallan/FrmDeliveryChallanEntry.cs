using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Base.Software;
using Base.Software.Helper;
using RWPLLinqDataService;

namespace RWPLSoftware.FrmDeliveryChallan
{
    public partial class FrmDeliveryChallanEntry : Form
    {
        private readonly EntryWithGridForm<DeliveryChallan, DeliveryChallanItem> _entryForm;

        public FrmDeliveryChallanEntry()
        {
            InitializeComponent();

            _entryForm = new EntryWithGridForm<DeliveryChallan, DeliveryChallanItem>(this);
        }

        public FrmDeliveryChallanEntry(long srNo)
        {
            InitializeComponent();

            _entryForm = new EntryWithGridForm<DeliveryChallan, DeliveryChallanItem>(this, srNo);
        }

        private void FrmDeliveryChallanEntry_Load(object sender, EventArgs e)
        {
            //_entryForm.FillDropDownAndAutoComplete<DeliveryChallanEntryPageRequest>();

            cmbBindFinacialYear.Text = MethodHelper.CurrentFinacialYear();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Base.Software.Helper;
using RWPLEntityModel.PageDataRequest;
using RWPLLinqDataService;

namespace RWPLSoftware.FrmAutoStichingPin
{
    public partial class FrmAutoStichingPinEntry : Form
    {
        private readonly EntryForm<AutoStichingPin> _entryForm;

        public FrmAutoStichingPinEntry()
        {
            InitializeComponent();

            _entryForm = new EntryForm<AutoStichingPin>(this);
        }

        public FrmAutoStichingPinEntry(long srNo = 0)
        {
            InitializeComponent();

            _entryForm = new EntryForm<AutoStichingPin>(this,srNo);
        }

        private void FrmAutoStichingPinEntry_Load(object sender, EventArgs e)
        {
        }

        private void txtBindNPinsPerBoxDetail_TextChanged(object sender, EventArgs e)
        {
            PageHelper.CalculateQtyXAny(txtBindPinsPerBoxDetail.Text, txtBindPinsPerBoxQty);
        }

        private void txtBindRBoxQty_TextChanged(object sender, EventArgs e)
        {
            var pinPerBox = string.IsNullOrEmpty(txtBindPinsPerBoxQty.Text)
                                                                ? 0
                                                                : Convert.ToInt32(txtBindPinsPerBoxQty.Text);

            var boxQty = string.IsNullOrEmpty(txtBindBoxQty.Text)
                                                                ? 0
                                                                : Convert.ToInt32(txtBindBoxQty.Text);

            var totalPins = pinPerBox*boxQty;

            txtBindTotalPins.Text = totalPins.ToString(CultureInfo.InvariantCulture);
        }
    }
}

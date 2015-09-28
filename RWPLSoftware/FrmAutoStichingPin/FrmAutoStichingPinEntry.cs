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
            //Auto Stiching (Pin) Entry
            //_entryForm.FillDropDownAndAutoComplete<AutoStichingPinEntryPageRequest>();
            
            _entryForm.FillDropDownAndAutoCompleteByApplicationData();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _entryForm.SavePageData();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBindRBoxQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            PageHelper.AcceptOnlyNumber(e);
        }

        private void txtBindNPinsPerBoxDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            PageHelper.AcceptOnlyNumberWithMultiplyAndCommas(e,((TextBox)sender).Text);
        }

        private void txtBindNPinsPerBoxDetail_TextChanged(object sender, EventArgs e)
        {
            PageHelper.CalculateQtyXAny(txtBindRPinsPerBoxDetail.Text, txtBindNPinsPerBoxQty);
        }

        private void txtBindRBoxQty_TextChanged(object sender, EventArgs e)
        {
            var pinPerBox = string.IsNullOrEmpty(txtBindNPinsPerBoxQty.Text)
                                                                ? 0
                                                                : Convert.ToInt32(txtBindNPinsPerBoxQty.Text);

            var boxQty = string.IsNullOrEmpty(txtBindRBoxQty.Text)
                                                                ? 0
                                                                : Convert.ToInt32(txtBindRBoxQty.Text);

            var totalPins = pinPerBox*boxQty;

            txtBindRTotalPins.Text = totalPins.ToString(CultureInfo.InvariantCulture);
        }
    }
}

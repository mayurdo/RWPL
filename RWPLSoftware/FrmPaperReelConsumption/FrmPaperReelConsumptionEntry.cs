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

namespace RWPLSoftware.FrmPaperReelConsumption
{
    public partial class FrmPaperReelConsumptionEntry : Form
    {
        private readonly EntryForm<PaperReelConsumption> _entryForm;

        public FrmPaperReelConsumptionEntry()
        {
            InitializeComponent();

            _entryForm = new EntryForm<PaperReelConsumption>(this);
        }

        public FrmPaperReelConsumptionEntry(long srNo=0)
        {
            InitializeComponent();

            _entryForm = new EntryForm<PaperReelConsumption>(this, srNo);
        }

        private void PaperReelConsumption_Load(object sender, EventArgs e)
        {
            _entryForm.FillDropDownAndAutoComplete<PaperReelConsumptionEntryPageRequest>();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _entryForm.SavePageData();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBindBF_KeyPress(object sender, KeyPressEventArgs e)
        {
            PageHelper.AcceptOnlyNumber(e);
        }

        private void txtBindSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            PageHelper.AcceptOnlyDecimal(e, ((TextBox)sender).Text);
        }

        private void txtBindRConsumption_TextChanged(object sender, EventArgs e)
        {
            var weight = string.IsNullOrEmpty(txtBindRWeight.Text) ? 0 : Convert.ToDecimal(txtBindRWeight.Text);
            var consumtion = string.IsNullOrEmpty(txtBindRConsumption.Text) ? 0 : Convert.ToDecimal(txtBindRConsumption.Text);
            var balance = weight - consumtion;
            txtBindRBalance.Text = balance.ToString(CultureInfo.InvariantCulture);
        }
    }
}

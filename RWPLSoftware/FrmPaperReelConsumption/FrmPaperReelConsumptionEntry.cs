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

        public FrmPaperReelConsumptionEntry(long srNo = 0)
        {
            InitializeComponent();

            _entryForm = new EntryForm<PaperReelConsumption>(this, srNo);
        }

        private void PaperReelConsumption_Load(object sender, EventArgs e)
        {
            //_entryForm.FillDropDownAndAutoComplete<PaperReelConsumptionEntryPageRequest>();
        }

        private void txtBindRConsumption_TextChanged(object sender, EventArgs e)
        {
            var weight = string.IsNullOrEmpty(txtBindWeight.Text) ? 0 : Convert.ToDecimal(txtBindWeight.Text);
            var consumtion = string.IsNullOrEmpty(txtBindConsumption.Text) ? 0 : Convert.ToDecimal(txtBindConsumption.Text);
            var balance = weight - consumtion;
            txtBindBalance.Text = balance.ToString(CultureInfo.InvariantCulture);
        }

        private void dtpBindStartTime_ValueChanged(object sender, EventArgs e)
        {
            var startTime = new DateTime(dtpBindStartTime.Value.Year, dtpBindStartTime.Value.Month, dtpBindStartTime.Value.Day,
                      dtpBindStartTime.Value.Hour, dtpBindStartTime.Value.Minute, 0);

            var endTime = new DateTime(dtpBindEndTime.Value.Year, dtpBindEndTime.Value.Month, dtpBindEndTime.Value.Day,
                      dtpBindEndTime.Value.Hour, dtpBindEndTime.Value.Minute, 0);

            txtBindTIMEConsume.Text = ((int)(endTime - startTime).TotalMinutes).ToString(CultureInfo.InvariantCulture);
        }
    }
}

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

namespace RWPLSoftware.FrmDuplexPrintedPaper
{
    public partial class FrmDuplexPrintedPaperEntry : Form
    {
        private readonly EntryForm<DuplexPrintedPaper> _entryForm;

        public FrmDuplexPrintedPaperEntry()
        {
            InitializeComponent();

            _entryForm = new EntryForm<DuplexPrintedPaper>(this);
        }

        public FrmDuplexPrintedPaperEntry(long srNo = 0)
        {
            InitializeComponent();

            _entryForm = new EntryForm<DuplexPrintedPaper>(this, srNo);
        }

        private void FrmDuplexPrintedPaperEntry_Load(object sender, EventArgs e)
        {
            _entryForm.FillDropDownAndAutoComplete<DuplexPrintedPaperEntryPageRequest>();
        }

        private void txtBindStockInMM_TextChanged(object sender, EventArgs e)
        {
            var stockInMm = string.IsNullOrEmpty(txtBindStockInMM.Text) ? 0 : Convert.ToInt64(txtBindStockInMM.Text);
            var totalPaperQty = (stockInMm * 100) / 30;
            txtBindTotalPaperQty.Text = totalPaperQty.ToString(CultureInfo.InvariantCulture);
        }
    }
}

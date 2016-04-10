using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Base.Software.Helper;
using RWPLEntityModel.PageDataRequest;
using RWPLLinqDataService;

namespace RWPLSoftware.FrmStockMaster
{
    public partial class FrmStockMasterEntry : Form
    {
         private readonly EntryForm<InwardMaster> _entryForm;

        public FrmStockMasterEntry()
        {
            InitializeComponent();

            _entryForm = new EntryForm<InwardMaster>(this);
        }

        public FrmStockMasterEntry(long srNo=0)
        {
            InitializeComponent();

            _entryForm = new EntryForm<InwardMaster>(this, srNo);
        }

        private void FrmStockMasterEntry_Load(object sender, EventArgs e)
        {
            _entryForm.FillDropDownAndAutoComplete<StockMasterEntryPageRequest>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Base.Software.Helper;
using RWPLLinqDataService;

namespace RWPLSoftware.FrmCustomerMaster
{
    public partial class FrmCustomerMasterEntry : Form
    {
        private readonly EntryForm<CustomerMaster> _entryForm;

        public FrmCustomerMasterEntry()
        {
            InitializeComponent();

            _entryForm = new EntryForm<CustomerMaster>(this);
        }

        public FrmCustomerMasterEntry(long srNo = 0)
        {
            InitializeComponent();

            _entryForm = new EntryForm<CustomerMaster>(this,srNo);
        }

        private void FrmCustomerMasterEntry_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Base.Software.Helper;

namespace RWPLSoftware.FrmCustomerMaster
{
    public partial class FrmCustomerMasterEntry : Form
    {
        private readonly EntryForm<RWPLLinqDataService.CustomerMaster> _entryForm;

        public FrmCustomerMasterEntry()
        {
            InitializeComponent();

            _entryForm = new EntryForm<RWPLLinqDataService.CustomerMaster>(this);
        }

        public FrmCustomerMasterEntry(long srNo = 0)
        {
            InitializeComponent();

            _entryForm = new EntryForm<RWPLLinqDataService.CustomerMaster>(this,srNo);
        }

        private void FrmCustomerMasterEntry_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _entryForm.SavePageData();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

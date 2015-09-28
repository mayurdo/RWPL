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

namespace RWPLSoftware.FrmItemMaster
{
    public partial class FrmItemMasterEntry : Form
    {
        private readonly EntryForm<RWPLLinqDataService.ItemMaster> _entryForm;

        public FrmItemMasterEntry()
        {
            InitializeComponent();

            _entryForm = new EntryForm<RWPLLinqDataService.ItemMaster>(this);
        }

        public FrmItemMasterEntry(long srNo = 0)
        {
            InitializeComponent();

            _entryForm = new EntryForm<RWPLLinqDataService.ItemMaster>(this, srNo);
        }

        private void FrmItemMasterEntry_Load(object sender, EventArgs e)
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

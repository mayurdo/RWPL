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

namespace RWPLSoftware.FrmRotary
{
    public partial class FrmRotaryEntry : Form
    {
        private readonly EntryForm<Rotary> _entryForm;

        public FrmRotaryEntry()
        {
            InitializeComponent();

            _entryForm = new EntryForm<Rotary>(this);
        }

        public FrmRotaryEntry(long srNo = 0)
        {
            InitializeComponent();

            _entryForm = new EntryForm<Rotary>(this, srNo);
        }

        private void FrmRotaryEntry_Load(object sender, EventArgs e)
        {
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

        private void txtBindRQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            PageHelper.AcceptOnlyNumber(e);
        }
    }
}

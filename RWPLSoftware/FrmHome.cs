using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Base.Software;
using Base.Software.Helper;
using RWPLEntityModel;
using RWPLLinqDataService;

namespace RWPLSoftware
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            var frm = new Login();
            frm.ShowDialog();

            if (!frm.IsSuccessLogin)
                this.Close();

            PageHelper.LoadApplicationData();
        }

        private void GoToPage<TForm>(AccessPages accessPage) where TForm : Form, new()
        {
            var access = PageHelper.UserDetail.UserAccessPages.SingleOrDefault(x => x.PageName == accessPage.ToString());

            if (access == null || !access.View)
            {
                MessageBox.Show(@"You don't have access to this page, please contact administrator", @"Accesss Message", MessageBoxButtons.OK);
                return;
            }

            var frm = new TForm();
            frm.ShowDialog();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToPage<FrmUserAccessReport>(AccessPages.User);
        }

        private void dispatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToPage<FrmDispatch.FrmDispatchReport>(AccessPages.Dispatch);
        }

        private void paperReeLConsumptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToPage<FrmPaperReelConsumption.FrmPaperReelConsumptionReport>(AccessPages.PaperReelConsumption);
        }

        private void autoStichingPinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToPage<FrmAutoStichingPin.FrmAutoStichingPinReport>(AccessPages.AutoStichingPin);
        }

        private void bundlingM1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToPage<FrmBundlingM1.FrmBundlingM1Report>(AccessPages.AutoStichingPin);
        }

        private void rotaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToPage<FrmRotary.FrmRotaryReport>(AccessPages.Rotary);
        }

        private void itemMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToPage<FrmItemMaster.FrmItemMasterReport>(AccessPages.ItemMaster);
        }

        private void customerMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToPage<FrmCustomerMaster.FrmCustomerMasterReport>(AccessPages.CustomerMaster);
        }

        
    }
}

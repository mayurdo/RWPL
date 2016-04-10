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
using RWPLSoftware.FrmDispatch;
using RWPLSoftware.FrmPaperReelConsumption;
using RWPLSoftware.FrmStockMaster;

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

            //PageHelper.LoadApplicationData();
        } 

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageHelper.GoToPage<FrmUserAccessReport>(AccessPages.User);
        }

        private void dispatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageHelper.GoToPage<FrmDispatch.FrmDispatchReport>(AccessPages.Dispatch);
        }

        private void paperReeLConsumptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageHelper.GoToPage<FrmPaperReelConsumption.FrmPaperReelConsumptionReport>(AccessPages.PaperReelConsumption);
        }

        private void autoStichingPinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageHelper.GoToPage<FrmAutoStichingPin.FrmAutoStichingPinReport>(AccessPages.AutoStichingPin);
        }

        private void bundlingM1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageHelper.GoToPage<FrmBundlingM1.FrmBundlingM1Report>(AccessPages.AutoStichingPin);
        }

        private void rotaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageHelper.GoToPage<FrmRotary.FrmRotaryReport>(AccessPages.Rotary);
        }

        private void itemMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageHelper.GoToPage<FrmItemMaster.FrmItemMasterReport>(AccessPages.ItemMaster);
        }

        private void customerMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageHelper.GoToPage<FrmItemMaster.FrmCustomerSummaryReport>(AccessPages.CustomerMaster);
        }

        private void deliveryChallanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageHelper.GoToPage<FrmDeliveryChallan.FrmDeliveryChallanEntry>(AccessPages.DeliveryChallan);
        }

        private void duplexPrintedPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageHelper.GoToPage<FrmDuplexPrintedPaper.FrmDuplexPrintedPaperReport>(AccessPages.DuplexPrintedPaper);
        }

        private void appConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageHelper.GoToPage<FrmAppConfigSettings>(AccessPages.AppConfig);
        }

        private void stockMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageHelper.GoToPage<FrmStockMaster.FrmStockMasterReport>(AccessPages.StockMaster);
        }

        private void paperReelConsumtionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageHelper.GoToPage<FrmPaperReelConsumtionAnalysisReport>(AccessPages.CarogationProductionAnalysis);
        }

        private void dispatchAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageHelper.GoToPage<FrmDispatchAnalysis>(AccessPages.DispatchAnalysis);
        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageHelper.GoToPage<FrmStockMasterAnalysis>(AccessPages.StockMaster);
        }

        
    }
}

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
using RWPLLinqDataService;

namespace RWPLSoftware.FrmItemMaster
{
    public partial class FrmItemMasterEntry : Form
    {
        private readonly EntryForm<ItemMaster> _entryForm;

        public FrmItemMasterEntry()
        {
            InitializeComponent();

            _entryForm = new EntryForm<ItemMaster>(this);
        }

        public FrmItemMasterEntry(long srNo = 0)
        {
            InitializeComponent();

            _entryForm = new EntryForm<ItemMaster>(this, srNo);
        }

        private void FrmItemMasterEntry_Load(object sender, EventArgs e)
        {

        }

        private void CalculateWeight(TextBox txtGSM, TextBox txtWeight, bool isFluting = false)
        {
            var deckle = string.IsNullOrEmpty(txtBindSheetSizeDeckle.Text) ? 0 : Convert.ToSingle(txtBindSheetSizeDeckle.Text);
            var cutting = string.IsNullOrEmpty(txtBindSheetSizeCutting.Text) ? 0 : Convert.ToSingle(txtBindSheetSizeCutting.Text);
            var gsm = string.IsNullOrEmpty(txtGSM.Text) ? 0 : Convert.ToInt32(txtGSM.Text);

            var flutingAdustment = isFluting ? 1.5 : 1;

            var weight = (deckle * cutting * ((float)gsm / 1000) * flutingAdustment) / 1550;

            txtWeight.Text = string.IsNullOrEmpty(txtGSM.Text) ? string.Empty : weight.ToString("0.000");
        }

        private void CalculateBursting(TextBox txtBF, TextBox txtGSM, TextBox txtBursting, bool isFluting = false)
        {
            var bf = string.IsNullOrEmpty(txtBF.Text) ? 0 : Convert.ToSingle(txtBF.Text);
            var gsm = string.IsNullOrEmpty(txtGSM.Text) ? 0 : Convert.ToSingle(txtGSM.Text);

            var flutingAdustment = isFluting ? 2 : 1;

            var bursting = (bf * gsm) / (1000 * flutingAdustment);

            txtBursting.Text = string.IsNullOrEmpty(txtBF.Text + txtGSM.Text) ? string.Empty : bursting.ToString("0.000");
        }

        private void txtBindTopGSM_TextChanged(object sender, EventArgs e)
        {
            CalculateWeight(txtBindTopGSM, txtBindTopWeight);
            CalculateBursting(txtBindTopBF, txtBindTopGSM, txtBindTopBursting);
        }

        private void txtBindFlute1GSM_TextChanged(object sender, EventArgs e)
        {
            CalculateWeight(txtBindFlute1GSM, txtBindFlute1Weight, true);
            CalculateBursting(txtBindFlute1BF, txtBindFlute1GSM, txtBindFlute1Bursting, true);
        }

        private void txtBindLine1GSM_TextChanged(object sender, EventArgs e)
        {
            CalculateWeight(txtBindLine1GSM, txtBindLine1Weight);
            CalculateBursting(txtBindLine1BF, txtBindLine1GSM, txtBindLine1Bursting);
        }

        private void txtBindFlute2GSM_TextChanged(object sender, EventArgs e)
        {
            CalculateWeight(txtBindFlute2GSM, txtBindFlute2Weight, true);
            CalculateBursting(txtBindFlute2BF, txtBindFlute2GSM, txtBindFlute2Bursting, true);
        }

        private void txtBindLine2GSM_TextChanged(object sender, EventArgs e)
        {
            CalculateWeight(txtBindLine2GSM, txtBindLine2Weight);
            CalculateBursting(txtBindLine2BF, txtBindLine2GSM, txtBindLine2Bursting);
        }

        private void txtBindFlute3GSM_TextChanged(object sender, EventArgs e)
        {
            CalculateWeight(txtBindFlute3GSM, txtBindFlute3Weight, true);
            CalculateBursting(txtBindFlute3BF, txtBindFlute3GSM, txtBindFlute3Bursting, true);
        }

        private void txtBindLine3GSM_TextChanged(object sender, EventArgs e)
        {
            CalculateWeight(txtBindLine3GSM, txtBindLine3Weight);
            CalculateBursting(txtBindLine3BF, txtBindLine3GSM, txtBindLine3Bursting);
        }

        private void txtBindSheetSizeDeckle_TextChanged(object sender, EventArgs e)
        {
            CalculateWeight(txtBindTopGSM, txtBindTopWeight);
            CalculateWeight(txtBindFlute1GSM, txtBindFlute1Weight, true);
            CalculateWeight(txtBindLine1GSM, txtBindLine1Weight);
            CalculateWeight(txtBindFlute2GSM, txtBindFlute2Weight, true);
            CalculateWeight(txtBindLine2GSM, txtBindLine2Weight);
            CalculateWeight(txtBindFlute3GSM, txtBindFlute3Weight, true);
            CalculateWeight(txtBindLine3GSM, txtBindLine3Weight);
        }

        private void txtBindTopWeight_TextChanged(object sender, EventArgs e)
        {
            var topWeight = string.IsNullOrEmpty(txtBindTopWeight.Text) ? 0 : Convert.ToSingle(txtBindTopWeight.Text);
            var flute1Weight = string.IsNullOrEmpty(txtBindFlute1Weight.Text) ? 0 : Convert.ToSingle(txtBindFlute1Weight.Text);
            var line1Weight = string.IsNullOrEmpty(txtBindLine1Weight.Text) ? 0 : Convert.ToSingle(txtBindLine1Weight.Text);
            var flute2Weight = string.IsNullOrEmpty(txtBindFlute2Weight.Text) ? 0 : Convert.ToSingle(txtBindFlute2Weight.Text);
            var line2Weight = string.IsNullOrEmpty(txtBindLine2Weight.Text) ? 0 : Convert.ToSingle(txtBindLine2Weight.Text);
            var flute3Weight = string.IsNullOrEmpty(txtBindFlute3Weight.Text) ? 0 : Convert.ToSingle(txtBindFlute3Weight.Text);
            var line3Weight = string.IsNullOrEmpty(txtBindLine3Weight.Text) ? 0 : Convert.ToSingle(txtBindLine3Weight.Text);
            var qty = string.IsNullOrEmpty(txtBindQty.Text) ? 0 : Convert.ToSingle(txtBindQty.Text);

            var totalWeight = topWeight + flute1Weight + line1Weight + flute2Weight +
                                        line2Weight + flute3Weight + line3Weight;

            txtBindTotalWeight.Text = (totalWeight*qty).ToString("0.000");
        }

        private void txtBindTopBF_TextChanged(object sender, EventArgs e)
        {
            CalculateBursting(txtBindTopBF, txtBindTopGSM, txtBindTopBursting);
        }

        private void txtBindFlute1BF_TextChanged(object sender, EventArgs e)
        {
            CalculateBursting(txtBindFlute1BF, txtBindFlute1GSM, txtBindFlute1Bursting,true);
        }

        private void txtBindLine1BF_TextChanged(object sender, EventArgs e)
        {
            CalculateBursting(txtBindLine1BF, txtBindLine1GSM, txtBindLine1Bursting);
        }

        private void txtBindFlute2BF_TextChanged(object sender, EventArgs e)
        {
            CalculateBursting(txtBindFlute2BF, txtBindFlute2GSM, txtBindFlute2Bursting, true);
        }

        private void txtBindLine2BF_TextChanged(object sender, EventArgs e)
        {
            CalculateBursting(txtBindLine2BF, txtBindLine2GSM, txtBindLine2Bursting);
        }

        private void txtBindFlute3BF_TextChanged(object sender, EventArgs e)
        {
            CalculateBursting(txtBindFlute3BF, txtBindFlute3GSM, txtBindFlute3Bursting, true);
        }

        private void txtBindLine3BF_TextChanged(object sender, EventArgs e)
        {
            CalculateBursting(txtBindLine3BF, txtBindLine3GSM, txtBindLine3Bursting);
        }

        private void txtBindTopBursting_TextChanged(object sender, EventArgs e)
        {
            var topBursting = string.IsNullOrEmpty(txtBindTopBursting.Text) ? 0 : Convert.ToSingle(txtBindTopBursting.Text);
            var flute1Bursting = string.IsNullOrEmpty(txtBindFlute1Bursting.Text) ? 0 : Convert.ToSingle(txtBindFlute1Bursting.Text);
            var line1Bursting = string.IsNullOrEmpty(txtBindLine1Bursting.Text) ? 0 : Convert.ToSingle(txtBindLine1Bursting.Text);
            var flute2Bursting = string.IsNullOrEmpty(txtBindFlute2Bursting.Text) ? 0 : Convert.ToSingle(txtBindFlute2Bursting.Text);
            var line2Bursting = string.IsNullOrEmpty(txtBindLine2Bursting.Text) ? 0 : Convert.ToSingle(txtBindLine2Bursting.Text);
            var flute3Bursting = string.IsNullOrEmpty(txtBindFlute3Bursting.Text) ? 0 : Convert.ToSingle(txtBindFlute3Bursting.Text);
            var line3Bursting = string.IsNullOrEmpty(txtBindLine3Bursting.Text) ? 0 : Convert.ToSingle(txtBindLine3Bursting.Text);

            var totalBursting = topBursting + flute1Bursting + line1Bursting + flute2Bursting +
                                        line2Bursting + flute3Bursting + line3Bursting;

            txtBindTotalBursting.Text = totalBursting.ToString("0.000");
        }

        private void txtBindNoofPly_TextChanged(object sender, EventArgs e)
        {
            var noofPly = string.IsNullOrEmpty(txtBindNoofPly.Text) ? 0 : Convert.ToInt32(txtBindNoofPly.Text);
            var fistPlay = (noofPly >= 1);
            var secondPlay = (noofPly >= 3);
            var thirdPlay = (noofPly >= 5);
            var forthPlay = (noofPly >= 7);

            txtBindTopBF.Enabled = fistPlay;
            txtBindTopGSM.Enabled = fistPlay;
            txtBindFlute1BF.Enabled = secondPlay;
            txtBindFlute1GSM.Enabled = secondPlay;
            txtBindLine1BF.Enabled = secondPlay;
            txtBindLine1GSM.Enabled = secondPlay;
            txtBindFlute2BF.Enabled = thirdPlay;
            txtBindFlute2GSM.Enabled = thirdPlay;
            txtBindLine2BF.Enabled = thirdPlay;
            txtBindLine2GSM.Enabled = thirdPlay;
            txtBindFlute3BF.Enabled = forthPlay;
            txtBindFlute3GSM.Enabled = forthPlay;
            txtBindLine3BF.Enabled = forthPlay;
            txtBindLine3GSM.Enabled = forthPlay;



            //switch (noofPly)
            //{
            //    case 1:
            //        txtBindTopBF.Enabled = true;
            //        txtBindTopGSM.Enabled = true;
            //        break;
            //    case 3:
            //        txtBindTopBF.Enabled = true;
            //        txtBindTopGSM.Enabled = true;
            //        txtBindFlute1BF.Enabled = true;
            //        txtBindFlute1GSM.Enabled = true;
            //        txtBindLine1BF.Enabled = true;
            //        txtBindLine1GSM.Enabled = true;
            //        break;
            //    case 5:
            //        txtBindTopBF.Enabled = true;
            //        txtBindTopGSM.Enabled = true;
            //        txtBindFlute1BF.Enabled = true;
            //        txtBindFlute1GSM.Enabled = true;
            //        txtBindLine1BF.Enabled = true;
            //        txtBindLine1GSM.Enabled = true;
            //        txtBindFlute2BF.Enabled = true;
            //        txtBindFlute2GSM.Enabled = true;
            //        txtBindLine2BF.Enabled = true;
            //        txtBindLine2GSM.Enabled = true;
            //        break;
            //    case 7:
            //        txtBindTopBF.Enabled = true;
            //        txtBindTopGSM.Enabled = true;
            //        txtBindFlute1BF.Enabled = true;
            //        txtBindFlute1GSM.Enabled = true;
            //        txtBindLine1BF.Enabled = true;
            //        txtBindLine1GSM.Enabled = true;
            //        txtBindFlute2BF.Enabled = true;
            //        txtBindFlute2GSM.Enabled = true;
            //        txtBindLine2BF.Enabled = true;
            //        txtBindLine2GSM.Enabled = true;
            //        txtBindFlute3BF.Enabled = true;
            //        txtBindFlute3GSM.Enabled = true;
            //        txtBindLine3BF.Enabled = true;
            //        txtBindLine3GSM.Enabled = true;
            //        break;
            //}
        }


    }
}

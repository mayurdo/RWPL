namespace RWPLSoftware.FrmAutoStichingPin
{
    partial class FrmAutoStichingPinEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.dtpBindNOutTime = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBindNSrNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBindNInTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBindNDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBindRClient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBindRBoxCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBindRPinsPerBoxDetail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBindNPinsPerBoxQty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBindRBoxQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBindRTotalPins = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBindNOperator = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBindNBoxName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblHeader.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(666, 33);
            this.lblHeader.TabIndex = 184;
            this.lblHeader.Text = "Auto Stiching (Pin) Entry";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpBindNOutTime
            // 
            this.dtpBindNOutTime.CustomFormat = "hh:mm tt";
            this.dtpBindNOutTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBindNOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBindNOutTime.Location = new System.Drawing.Point(452, 148);
            this.dtpBindNOutTime.Name = "dtpBindNOutTime";
            this.dtpBindNOutTime.ShowUpDown = true;
            this.dtpBindNOutTime.Size = new System.Drawing.Size(103, 26);
            this.dtpBindNOutTime.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(382, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 15);
            this.label16.TabIndex = 214;
            this.label16.Text = "Out Time :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 212;
            this.label1.Text = "Sr No :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBindNSrNo
            // 
            this.txtBindNSrNo.Enabled = false;
            this.txtBindNSrNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindNSrNo.Location = new System.Drawing.Point(112, 67);
            this.txtBindNSrNo.Name = "txtBindNSrNo";
            this.txtBindNSrNo.Size = new System.Drawing.Size(209, 26);
            this.txtBindNSrNo.TabIndex = 202;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(324, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 22);
            this.label4.TabIndex = 211;
            this.label4.Text = "*";
            // 
            // dtpBindNInTime
            // 
            this.dtpBindNInTime.CustomFormat = "hh:mm tt";
            this.dtpBindNInTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBindNInTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBindNInTime.Location = new System.Drawing.Point(452, 108);
            this.dtpBindNInTime.Name = "dtpBindNInTime";
            this.dtpBindNInTime.ShowUpDown = true;
            this.dtpBindNInTime.Size = new System.Drawing.Size(103, 26);
            this.dtpBindNInTime.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 210;
            this.label2.Text = "In Time :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpBindNDate
            // 
            this.dtpBindNDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpBindNDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBindNDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBindNDate.Location = new System.Drawing.Point(452, 67);
            this.dtpBindNDate.Name = "dtpBindNDate";
            this.dtpBindNDate.Size = new System.Drawing.Size(144, 26);
            this.dtpBindNDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 209;
            this.label3.Text = "Date :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBindRClient
            // 
            this.txtBindRClient.AccessibleName = "CustomerName";
            this.txtBindRClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindRClient.Location = new System.Drawing.Point(112, 108);
            this.txtBindRClient.Name = "txtBindRClient";
            this.txtBindRClient.Size = new System.Drawing.Size(209, 26);
            this.txtBindRClient.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 207;
            this.label6.Text = "Client :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBindRBoxCode
            // 
            this.txtBindRBoxCode.AccessibleName = "ItemCode";
            this.txtBindRBoxCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindRBoxCode.Location = new System.Drawing.Point(112, 148);
            this.txtBindRBoxCode.Name = "txtBindRBoxCode";
            this.txtBindRBoxCode.Size = new System.Drawing.Size(209, 26);
            this.txtBindRBoxCode.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 208;
            this.label5.Text = "Box Code :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBindRPinsPerBoxDetail
            // 
            this.txtBindRPinsPerBoxDetail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindRPinsPerBoxDetail.Location = new System.Drawing.Point(112, 228);
            this.txtBindRPinsPerBoxDetail.Name = "txtBindRPinsPerBoxDetail";
            this.txtBindRPinsPerBoxDetail.Size = new System.Drawing.Size(117, 26);
            this.txtBindRPinsPerBoxDetail.TabIndex = 3;
            this.txtBindRPinsPerBoxDetail.TextChanged += new System.EventHandler(this.txtBindNPinsPerBoxDetail_TextChanged);
            this.txtBindRPinsPerBoxDetail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBindNPinsPerBoxDetail_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 216;
            this.label7.Text = "Pins Per Box :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBindNPinsPerBoxQty
            // 
            this.txtBindNPinsPerBoxQty.Enabled = false;
            this.txtBindNPinsPerBoxQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindNPinsPerBoxQty.Location = new System.Drawing.Point(256, 228);
            this.txtBindNPinsPerBoxQty.Name = "txtBindNPinsPerBoxQty";
            this.txtBindNPinsPerBoxQty.Size = new System.Drawing.Size(65, 26);
            this.txtBindNPinsPerBoxQty.TabIndex = 217;
            this.txtBindNPinsPerBoxQty.TextChanged += new System.EventHandler(this.txtBindRBoxQty_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(232, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 19);
            this.label8.TabIndex = 218;
            this.label8.Text = "=";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBindRBoxQty
            // 
            this.txtBindRBoxQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindRBoxQty.Location = new System.Drawing.Point(112, 269);
            this.txtBindRBoxQty.Name = "txtBindRBoxQty";
            this.txtBindRBoxQty.Size = new System.Drawing.Size(209, 26);
            this.txtBindRBoxQty.TabIndex = 4;
            this.txtBindRBoxQty.TextChanged += new System.EventHandler(this.txtBindRBoxQty_TextChanged);
            this.txtBindRBoxQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBindRBoxQty_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 220;
            this.label9.Text = "Box Qty :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBindRTotalPins
            // 
            this.txtBindRTotalPins.Enabled = false;
            this.txtBindRTotalPins.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindRTotalPins.Location = new System.Drawing.Point(112, 311);
            this.txtBindRTotalPins.Name = "txtBindRTotalPins";
            this.txtBindRTotalPins.Size = new System.Drawing.Size(209, 26);
            this.txtBindRTotalPins.TabIndex = 221;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 15);
            this.label10.TabIndex = 222;
            this.label10.Text = "Total Pins :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBindNOperator
            // 
            this.txtBindNOperator.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindNOperator.Location = new System.Drawing.Point(452, 191);
            this.txtBindNOperator.Name = "txtBindNOperator";
            this.txtBindNOperator.Size = new System.Drawing.Size(144, 26);
            this.txtBindNOperator.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(382, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 224;
            this.label11.Text = "Operator :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = global::RWPLSoftware.Properties.Resources.exit;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBack.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBack.Location = new System.Drawing.Point(517, 311);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(79, 66);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.BackgroundImage = global::RWPLSoftware.Properties.Resources.network_save;
            this.buttonSave.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.Location = new System.Drawing.Point(410, 309);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(70, 70);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(324, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 22);
            this.label12.TabIndex = 225;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(324, 269);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 22);
            this.label13.TabIndex = 226;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(324, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 22);
            this.label14.TabIndex = 227;
            this.label14.Text = "*";
            // 
            // txtBindNBoxName
            // 
            this.txtBindNBoxName.AccessibleName = "ItemName";
            this.txtBindNBoxName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindNBoxName.Location = new System.Drawing.Point(112, 188);
            this.txtBindNBoxName.Name = "txtBindNBoxName";
            this.txtBindNBoxName.Size = new System.Drawing.Size(209, 26);
            this.txtBindNBoxName.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(39, 195);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 15);
            this.label17.TabIndex = 229;
            this.label17.Text = "Box Name :";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmAutoStichingPinEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(664, 393);
            this.Controls.Add(this.txtBindNBoxName);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.txtBindNOperator);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBindRTotalPins);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBindRBoxQty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBindNPinsPerBoxQty);
            this.Controls.Add(this.txtBindRPinsPerBoxDetail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpBindNOutTime);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBindNSrNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpBindNInTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpBindNDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBindRClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBindRBoxCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblHeader);
            this.Name = "FrmAutoStichingPinEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAutoStichingPinEntry";
            this.Load += new System.EventHandler(this.FrmAutoStichingPinEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DateTimePicker dtpBindNOutTime;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBindNSrNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBindNInTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBindNDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBindRClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBindRBoxCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBindRPinsPerBoxDetail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBindNPinsPerBoxQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBindRBoxQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBindRTotalPins;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBindNOperator;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBindNBoxName;
        private System.Windows.Forms.Label label17;
    }
}
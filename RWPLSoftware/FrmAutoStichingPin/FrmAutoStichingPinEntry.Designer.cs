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
            this.dtpBindOutTime = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBindSrNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBindInTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBindDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBindClient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBindBoxCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBindPinsPerBoxDetail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBindPinsPerBoxQty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBindBoxQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBindTotalPins = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBindOperator = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBindBoxName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
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
            // dtpBindOutTime
            // 
            this.dtpBindOutTime.CustomFormat = "hh:mm tt";
            this.dtpBindOutTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBindOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBindOutTime.Location = new System.Drawing.Point(452, 148);
            this.dtpBindOutTime.Name = "dtpBindOutTime";
            this.dtpBindOutTime.ShowUpDown = true;
            this.dtpBindOutTime.Size = new System.Drawing.Size(103, 26);
            this.dtpBindOutTime.TabIndex = 7;
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
            // txtBindSrNo
            // 
            this.txtBindSrNo.Enabled = false;
            this.txtBindSrNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindSrNo.Location = new System.Drawing.Point(112, 67);
            this.txtBindSrNo.Name = "txtBindSrNo";
            this.txtBindSrNo.Size = new System.Drawing.Size(209, 26);
            this.txtBindSrNo.TabIndex = 202;
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
            // dtpBindInTime
            // 
            this.dtpBindInTime.CustomFormat = "hh:mm tt";
            this.dtpBindInTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBindInTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBindInTime.Location = new System.Drawing.Point(452, 108);
            this.dtpBindInTime.Name = "dtpBindInTime";
            this.dtpBindInTime.ShowUpDown = true;
            this.dtpBindInTime.Size = new System.Drawing.Size(103, 26);
            this.dtpBindInTime.TabIndex = 6;
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
            // dtpBindDate
            // 
            this.dtpBindDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpBindDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBindDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBindDate.Location = new System.Drawing.Point(452, 67);
            this.dtpBindDate.Name = "dtpBindDate";
            this.dtpBindDate.Size = new System.Drawing.Size(144, 26);
            this.dtpBindDate.TabIndex = 5;
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
            // txtBindClient
            // 
            this.txtBindClient.AccessibleDescription = "Req";
            this.txtBindClient.AccessibleName = "CustomerName";
            this.txtBindClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindClient.Location = new System.Drawing.Point(112, 108);
            this.txtBindClient.Name = "txtBindClient";
            this.txtBindClient.Size = new System.Drawing.Size(209, 26);
            this.txtBindClient.TabIndex = 0;
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
            // txtBindBoxCode
            // 
            this.txtBindBoxCode.AccessibleDescription = "Req";
            this.txtBindBoxCode.AccessibleName = "ItemCode";
            this.txtBindBoxCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindBoxCode.Location = new System.Drawing.Point(112, 148);
            this.txtBindBoxCode.Name = "txtBindBoxCode";
            this.txtBindBoxCode.Size = new System.Drawing.Size(209, 26);
            this.txtBindBoxCode.TabIndex = 1;
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
            // txtBindPinsPerBoxDetail
            // 
            this.txtBindPinsPerBoxDetail.AccessibleDescription = "Req.NumMultComa";
            this.txtBindPinsPerBoxDetail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindPinsPerBoxDetail.Location = new System.Drawing.Point(112, 228);
            this.txtBindPinsPerBoxDetail.Name = "txtBindPinsPerBoxDetail";
            this.txtBindPinsPerBoxDetail.Size = new System.Drawing.Size(117, 26);
            this.txtBindPinsPerBoxDetail.TabIndex = 3;
            this.txtBindPinsPerBoxDetail.TextChanged += new System.EventHandler(this.txtBindNPinsPerBoxDetail_TextChanged);
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
            // txtBindPinsPerBoxQty
            // 
            this.txtBindPinsPerBoxQty.AccessibleDescription = "Num";
            this.txtBindPinsPerBoxQty.Enabled = false;
            this.txtBindPinsPerBoxQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindPinsPerBoxQty.Location = new System.Drawing.Point(256, 228);
            this.txtBindPinsPerBoxQty.Name = "txtBindPinsPerBoxQty";
            this.txtBindPinsPerBoxQty.Size = new System.Drawing.Size(65, 26);
            this.txtBindPinsPerBoxQty.TabIndex = 217;
            this.txtBindPinsPerBoxQty.TextChanged += new System.EventHandler(this.txtBindRBoxQty_TextChanged);
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
            // txtBindBoxQty
            // 
            this.txtBindBoxQty.AccessibleDescription = "Req.Num";
            this.txtBindBoxQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindBoxQty.Location = new System.Drawing.Point(112, 269);
            this.txtBindBoxQty.Name = "txtBindBoxQty";
            this.txtBindBoxQty.Size = new System.Drawing.Size(209, 26);
            this.txtBindBoxQty.TabIndex = 4;
            this.txtBindBoxQty.TextChanged += new System.EventHandler(this.txtBindRBoxQty_TextChanged);
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
            // txtBindTotalPins
            // 
            this.txtBindTotalPins.AccessibleDescription = "Req";
            this.txtBindTotalPins.Enabled = false;
            this.txtBindTotalPins.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindTotalPins.Location = new System.Drawing.Point(112, 311);
            this.txtBindTotalPins.Name = "txtBindTotalPins";
            this.txtBindTotalPins.Size = new System.Drawing.Size(209, 26);
            this.txtBindTotalPins.TabIndex = 221;
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
            // txtBindOperator
            // 
            this.txtBindOperator.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindOperator.Location = new System.Drawing.Point(452, 191);
            this.txtBindOperator.Name = "txtBindOperator";
            this.txtBindOperator.Size = new System.Drawing.Size(144, 26);
            this.txtBindOperator.TabIndex = 8;
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
            // txtBindBoxName
            // 
            this.txtBindBoxName.AccessibleName = "ItemName";
            this.txtBindBoxName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindBoxName.Location = new System.Drawing.Point(112, 188);
            this.txtBindBoxName.Name = "txtBindBoxName";
            this.txtBindBoxName.Size = new System.Drawing.Size(209, 26);
            this.txtBindBoxName.TabIndex = 2;
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
            // btnBack
            // 
            this.btnBack.AccessibleDescription = "Back";
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::RWPLSoftware.Properties.Resources.exit;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(517, 311);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 66);
            this.btnBack.TabIndex = 10;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleDescription = "Save";
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::RWPLSoftware.Properties.Resources.network_save;
            this.btnSave.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(410, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 70);
            this.btnSave.TabIndex = 9;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // FrmAutoStichingPinEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(664, 393);
            this.Controls.Add(this.txtBindBoxName);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBindOperator);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBindTotalPins);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBindBoxQty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBindPinsPerBoxQty);
            this.Controls.Add(this.txtBindPinsPerBoxDetail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpBindOutTime);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBindSrNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpBindInTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpBindDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBindClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBindBoxCode);
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
        private System.Windows.Forms.DateTimePicker dtpBindOutTime;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBindSrNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBindInTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBindDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBindClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBindBoxCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBindPinsPerBoxDetail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBindPinsPerBoxQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBindBoxQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBindTotalPins;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBindOperator;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBindBoxName;
        private System.Windows.Forms.Label label17;
    }
}
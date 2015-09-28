namespace RWPLSoftware.FrmRotary
{
    partial class FrmRotaryEntry
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
            this.txtBindNBoxName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBindNOperator = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBindRQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBindNSrNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBindNTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBindNDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBindRClient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBindRBoxCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpRadioBindNType = new System.Windows.Forms.Panel();
            this.rbRotary1 = new System.Windows.Forms.RadioButton();
            this.label22 = new System.Windows.Forms.Label();
            this.rbRotary2 = new System.Windows.Forms.RadioButton();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.txtBindNWastage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpRadioBindNType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblHeader.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(639, 33);
            this.lblHeader.TabIndex = 180;
            this.lblHeader.Text = "Rotary";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBindNBoxName
            // 
            this.txtBindNBoxName.AccessibleName = "ItemName";
            this.txtBindNBoxName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindNBoxName.Location = new System.Drawing.Point(101, 231);
            this.txtBindNBoxName.Name = "txtBindNBoxName";
            this.txtBindNBoxName.Size = new System.Drawing.Size(209, 26);
            this.txtBindNBoxName.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(28, 238);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 15);
            this.label17.TabIndex = 285;
            this.label17.Text = "Box Name :";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(313, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 22);
            this.label12.TabIndex = 283;
            this.label12.Text = "*";
            // 
            // txtBindNOperator
            // 
            this.txtBindNOperator.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindNOperator.Location = new System.Drawing.Point(441, 150);
            this.txtBindNOperator.Name = "txtBindNOperator";
            this.txtBindNOperator.Size = new System.Drawing.Size(144, 26);
            this.txtBindNOperator.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(371, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 282;
            this.label11.Text = "Operator :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBindRQty
            // 
            this.txtBindRQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindRQty.Location = new System.Drawing.Point(101, 276);
            this.txtBindRQty.Name = "txtBindRQty";
            this.txtBindRQty.Size = new System.Drawing.Size(209, 26);
            this.txtBindRQty.TabIndex = 5;
            this.txtBindRQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBindRQty_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 279;
            this.label9.Text = "Qty :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 277;
            this.label1.Text = "Sr No :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBindNSrNo
            // 
            this.txtBindNSrNo.Enabled = false;
            this.txtBindNSrNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindNSrNo.Location = new System.Drawing.Point(101, 69);
            this.txtBindNSrNo.Name = "txtBindNSrNo";
            this.txtBindNSrNo.Size = new System.Drawing.Size(209, 26);
            this.txtBindNSrNo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(313, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 22);
            this.label4.TabIndex = 276;
            this.label4.Text = "*";
            // 
            // dtpBindNTime
            // 
            this.dtpBindNTime.CustomFormat = "hh:mm tt";
            this.dtpBindNTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBindNTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBindNTime.Location = new System.Drawing.Point(441, 110);
            this.dtpBindNTime.Name = "dtpBindNTime";
            this.dtpBindNTime.ShowUpDown = true;
            this.dtpBindNTime.Size = new System.Drawing.Size(103, 26);
            this.dtpBindNTime.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 275;
            this.label2.Text = "Time :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpBindNDate
            // 
            this.dtpBindNDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpBindNDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBindNDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBindNDate.Location = new System.Drawing.Point(441, 69);
            this.dtpBindNDate.Name = "dtpBindNDate";
            this.dtpBindNDate.Size = new System.Drawing.Size(144, 26);
            this.dtpBindNDate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 274;
            this.label3.Text = "Date :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBindRClient
            // 
            this.txtBindRClient.AccessibleName = "CustomerName";
            this.txtBindRClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindRClient.Location = new System.Drawing.Point(101, 151);
            this.txtBindRClient.Name = "txtBindRClient";
            this.txtBindRClient.Size = new System.Drawing.Size(209, 26);
            this.txtBindRClient.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 272;
            this.label6.Text = "Client :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBindRBoxCode
            // 
            this.txtBindRBoxCode.AccessibleName = "ItemCode";
            this.txtBindRBoxCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindRBoxCode.Location = new System.Drawing.Point(101, 191);
            this.txtBindRBoxCode.Name = "txtBindRBoxCode";
            this.txtBindRBoxCode.Size = new System.Drawing.Size(209, 26);
            this.txtBindRBoxCode.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 273;
            this.label5.Text = "Box Code :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpRadioBindNType
            // 
            this.grpRadioBindNType.Controls.Add(this.rbRotary1);
            this.grpRadioBindNType.Controls.Add(this.label22);
            this.grpRadioBindNType.Controls.Add(this.rbRotary2);
            this.grpRadioBindNType.Location = new System.Drawing.Point(8, 107);
            this.grpRadioBindNType.Name = "grpRadioBindNType";
            this.grpRadioBindNType.Size = new System.Drawing.Size(341, 31);
            this.grpRadioBindNType.TabIndex = 1;
            // 
            // rbRotary1
            // 
            this.rbRotary1.AutoSize = true;
            this.rbRotary1.Checked = true;
            this.rbRotary1.Font = new System.Drawing.Font("Arial", 12F);
            this.rbRotary1.Location = new System.Drawing.Point(93, 5);
            this.rbRotary1.Name = "rbRotary1";
            this.rbRotary1.Size = new System.Drawing.Size(80, 22);
            this.rbRotary1.TabIndex = 0;
            this.rbRotary1.TabStop = true;
            this.rbRotary1.Text = "Rotary1";
            this.rbRotary1.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(48, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 15);
            this.label22.TabIndex = 114;
            this.label22.Text = "Type :";
            // 
            // rbRotary2
            // 
            this.rbRotary2.AutoSize = true;
            this.rbRotary2.Font = new System.Drawing.Font("Arial", 12F);
            this.rbRotary2.Location = new System.Drawing.Point(194, 5);
            this.rbRotary2.Name = "rbRotary2";
            this.rbRotary2.Size = new System.Drawing.Size(80, 22);
            this.rbRotary2.TabIndex = 1;
            this.rbRotary2.Text = "Rotary2";
            this.rbRotary2.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = global::RWPLSoftware.Properties.Resources.exit;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBack.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBack.Location = new System.Drawing.Point(506, 328);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(79, 66);
            this.buttonBack.TabIndex = 11;
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
            this.buttonSave.Location = new System.Drawing.Point(399, 326);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(70, 70);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // txtBindNWastage
            // 
            this.txtBindNWastage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindNWastage.Location = new System.Drawing.Point(101, 318);
            this.txtBindNWastage.Name = "txtBindNWastage";
            this.txtBindNWastage.Size = new System.Drawing.Size(209, 26);
            this.txtBindNWastage.TabIndex = 6;
            this.txtBindNWastage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBindRQty_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 287;
            this.label7.Text = "Wastage :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmRotaryEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(638, 427);
            this.Controls.Add(this.txtBindNWastage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grpRadioBindNType);
            this.Controls.Add(this.txtBindNBoxName);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.txtBindNOperator);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBindRQty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBindNSrNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpBindNTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpBindNDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBindRClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBindRBoxCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblHeader);
            this.Name = "FrmRotaryEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRotaryEntry";
            this.Load += new System.EventHandler(this.FrmRotaryEntry_Load);
            this.grpRadioBindNType.ResumeLayout(false);
            this.grpRadioBindNType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtBindNBoxName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox txtBindNOperator;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBindRQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBindNSrNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBindNTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBindNDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBindRClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBindRBoxCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel grpRadioBindNType;
        private System.Windows.Forms.RadioButton rbRotary1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RadioButton rbRotary2;
        private System.Windows.Forms.TextBox txtBindNWastage;
        private System.Windows.Forms.Label label7;
    }
}
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
            this.txtBindBoxName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBindOperator = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBindQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBindSrNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBindTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBindDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBindClient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBindBoxCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpRadioBindNType = new System.Windows.Forms.Panel();
            this.rbRotary1 = new System.Windows.Forms.RadioButton();
            this.label22 = new System.Windows.Forms.Label();
            this.rbRotary2 = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBindWastage = new System.Windows.Forms.TextBox();
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
            // txtBindBoxName
            // 
            this.txtBindBoxName.AccessibleName = "ItemName";
            this.txtBindBoxName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindBoxName.Location = new System.Drawing.Point(101, 231);
            this.txtBindBoxName.Name = "txtBindBoxName";
            this.txtBindBoxName.Size = new System.Drawing.Size(209, 26);
            this.txtBindBoxName.TabIndex = 4;
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
            // txtBindOperator
            // 
            this.txtBindOperator.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindOperator.Location = new System.Drawing.Point(441, 150);
            this.txtBindOperator.Name = "txtBindOperator";
            this.txtBindOperator.Size = new System.Drawing.Size(144, 26);
            this.txtBindOperator.TabIndex = 9;
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
            // txtBindQty
            // 
            this.txtBindQty.AccessibleDescription = "Req";
            this.txtBindQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindQty.Location = new System.Drawing.Point(101, 276);
            this.txtBindQty.Name = "txtBindQty";
            this.txtBindQty.Size = new System.Drawing.Size(209, 26);
            this.txtBindQty.TabIndex = 5;
            this.txtBindQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBindRQty_KeyPress);
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
            // txtBindSrNo
            // 
            this.txtBindSrNo.Enabled = false;
            this.txtBindSrNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindSrNo.Location = new System.Drawing.Point(101, 69);
            this.txtBindSrNo.Name = "txtBindSrNo";
            this.txtBindSrNo.Size = new System.Drawing.Size(209, 26);
            this.txtBindSrNo.TabIndex = 0;
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
            // dtpBindTime
            // 
            this.dtpBindTime.CustomFormat = "hh:mm tt";
            this.dtpBindTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBindTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBindTime.Location = new System.Drawing.Point(441, 110);
            this.dtpBindTime.Name = "dtpBindTime";
            this.dtpBindTime.ShowUpDown = true;
            this.dtpBindTime.Size = new System.Drawing.Size(103, 26);
            this.dtpBindTime.TabIndex = 8;
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
            // dtpBindDate
            // 
            this.dtpBindDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpBindDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBindDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBindDate.Location = new System.Drawing.Point(441, 69);
            this.dtpBindDate.Name = "dtpBindDate";
            this.dtpBindDate.Size = new System.Drawing.Size(144, 26);
            this.dtpBindDate.TabIndex = 7;
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
            // txtBindClient
            // 
            this.txtBindClient.AccessibleDescription = "Req";
            this.txtBindClient.AccessibleName = "CustomerName";
            this.txtBindClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindClient.Location = new System.Drawing.Point(101, 151);
            this.txtBindClient.Name = "txtBindClient";
            this.txtBindClient.Size = new System.Drawing.Size(209, 26);
            this.txtBindClient.TabIndex = 2;
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
            // txtBindBoxCode
            // 
            this.txtBindBoxCode.AccessibleDescription = "Req";
            this.txtBindBoxCode.AccessibleName = "ItemCode";
            this.txtBindBoxCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindBoxCode.Location = new System.Drawing.Point(101, 191);
            this.txtBindBoxCode.Name = "txtBindBoxCode";
            this.txtBindBoxCode.Size = new System.Drawing.Size(209, 26);
            this.txtBindBoxCode.TabIndex = 3;
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
            // btnBack
            // 
            this.btnBack.AccessibleDescription = "Back";
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::RWPLSoftware.Properties.Resources.exit;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(506, 328);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 66);
            this.btnBack.TabIndex = 11;
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
            this.btnSave.Location = new System.Drawing.Point(399, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 70);
            this.btnSave.TabIndex = 10;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txtBindWastage
            // 
            this.txtBindWastage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindWastage.Location = new System.Drawing.Point(101, 318);
            this.txtBindWastage.Name = "txtBindWastage";
            this.txtBindWastage.Size = new System.Drawing.Size(209, 26);
            this.txtBindWastage.TabIndex = 6;
            this.txtBindWastage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBindRQty_KeyPress);
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
            this.Controls.Add(this.txtBindWastage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grpRadioBindNType);
            this.Controls.Add(this.txtBindBoxName);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBindOperator);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBindQty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBindSrNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpBindTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpBindDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBindClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBindBoxCode);
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
        private System.Windows.Forms.TextBox txtBindBoxName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBindOperator;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBindQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBindSrNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBindTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBindDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBindClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBindBoxCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel grpRadioBindNType;
        private System.Windows.Forms.RadioButton rbRotary1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RadioButton rbRotary2;
        private System.Windows.Forms.TextBox txtBindWastage;
        private System.Windows.Forms.Label label7;
    }
}
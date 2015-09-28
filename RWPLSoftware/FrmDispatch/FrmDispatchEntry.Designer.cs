namespace RWPLSoftware.FrmDispatch
{
    partial class FrmDispatchEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBindNInTime = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.dtpBindNDate = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.txtBindRClient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBindNVehicalNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBindNSrNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpGridBindRDispatchItems = new System.Windows.Forms.Panel();
            this.cmbBindRItemType = new System.Windows.Forms.ComboBox();
            this.txtBindRQtyPerBundle = new System.Windows.Forms.TextBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBindRItemCode = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBindRTotalQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBindRTotalBundles = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBindRItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBindNDriverName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dtpBindNOutTime = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.grpGridBindRDispatchItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblHeader.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(920, 33);
            this.lblHeader.TabIndex = 180;
            this.lblHeader.Text = "Dispatch Entry";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(450, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 22);
            this.label4.TabIndex = 194;
            this.label4.Text = "*";
            // 
            // dtpBindNInTime
            // 
            this.dtpBindNInTime.CustomFormat = "hh:mm tt";
            this.dtpBindNInTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBindNInTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBindNInTime.Location = new System.Drawing.Point(578, 105);
            this.dtpBindNInTime.Name = "dtpBindNInTime";
            this.dtpBindNInTime.ShowUpDown = true;
            this.dtpBindNInTime.Size = new System.Drawing.Size(103, 26);
            this.dtpBindNInTime.TabIndex = 182;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(518, 111);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 15);
            this.label19.TabIndex = 193;
            this.label19.Text = "In Time :";
            // 
            // dtpBindNDate
            // 
            this.dtpBindNDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpBindNDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBindNDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBindNDate.Location = new System.Drawing.Point(578, 64);
            this.dtpBindNDate.Name = "dtpBindNDate";
            this.dtpBindNDate.Size = new System.Drawing.Size(144, 26);
            this.dtpBindNDate.TabIndex = 181;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(533, 70);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(39, 15);
            this.label26.TabIndex = 192;
            this.label26.Text = "Date :";
            // 
            // txtBindRClient
            // 
            this.txtBindRClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindRClient.Location = new System.Drawing.Point(238, 105);
            this.txtBindRClient.Name = "txtBindRClient";
            this.txtBindRClient.Size = new System.Drawing.Size(209, 26);
            this.txtBindRClient.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(187, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 187;
            this.label6.Text = "Client :";
            // 
            // txtBindNVehicalNo
            // 
            this.txtBindNVehicalNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindNVehicalNo.Location = new System.Drawing.Point(238, 145);
            this.txtBindNVehicalNo.Name = "txtBindNVehicalNo";
            this.txtBindNVehicalNo.Size = new System.Drawing.Size(209, 26);
            this.txtBindNVehicalNo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 188;
            this.label5.Text = "Vehical No :";
            // 
            // txtBindNSrNo
            // 
            this.txtBindNSrNo.Enabled = false;
            this.txtBindNSrNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindNSrNo.Location = new System.Drawing.Point(238, 64);
            this.txtBindNSrNo.Name = "txtBindNSrNo";
            this.txtBindNSrNo.Size = new System.Drawing.Size(209, 26);
            this.txtBindNSrNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 196;
            this.label1.Text = "Sr No :";
            // 
            // grpGridBindRDispatchItems
            // 
            this.grpGridBindRDispatchItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpGridBindRDispatchItems.Controls.Add(this.cmbBindRItemType);
            this.grpGridBindRDispatchItems.Controls.Add(this.txtBindRQtyPerBundle);
            this.grpGridBindRDispatchItems.Controls.Add(this.btnDeleteItem);
            this.grpGridBindRDispatchItems.Controls.Add(this.label14);
            this.grpGridBindRDispatchItems.Controls.Add(this.txtBindRItemCode);
            this.grpGridBindRDispatchItems.Controls.Add(this.btnAddItem);
            this.grpGridBindRDispatchItems.Controls.Add(this.dataGridView1);
            this.grpGridBindRDispatchItems.Controls.Add(this.label10);
            this.grpGridBindRDispatchItems.Controls.Add(this.txtBindRTotalQty);
            this.grpGridBindRDispatchItems.Controls.Add(this.label9);
            this.grpGridBindRDispatchItems.Controls.Add(this.txtBindRTotalBundles);
            this.grpGridBindRDispatchItems.Controls.Add(this.label7);
            this.grpGridBindRDispatchItems.Controls.Add(this.label3);
            this.grpGridBindRDispatchItems.Controls.Add(this.txtBindRItemName);
            this.grpGridBindRDispatchItems.Controls.Add(this.label2);
            this.grpGridBindRDispatchItems.Location = new System.Drawing.Point(12, 230);
            this.grpGridBindRDispatchItems.Name = "grpGridBindRDispatchItems";
            this.grpGridBindRDispatchItems.Size = new System.Drawing.Size(908, 234);
            this.grpGridBindRDispatchItems.TabIndex = 4;
            // 
            // cmbBindRItemType
            // 
            this.cmbBindRItemType.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbBindRItemType.FormattingEnabled = true;
            this.cmbBindRItemType.Location = new System.Drawing.Point(8, 29);
            this.cmbBindRItemType.Name = "cmbBindRItemType";
            this.cmbBindRItemType.Size = new System.Drawing.Size(128, 26);
            this.cmbBindRItemType.TabIndex = 0;
            // 
            // txtBindRQtyPerBundle
            // 
            this.txtBindRQtyPerBundle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindRQtyPerBundle.Location = new System.Drawing.Point(467, 29);
            this.txtBindRQtyPerBundle.Name = "txtBindRQtyPerBundle";
            this.txtBindRQtyPerBundle.Size = new System.Drawing.Size(152, 26);
            this.txtBindRQtyPerBundle.TabIndex = 3;
            this.txtBindRQtyPerBundle.TextChanged += new System.EventHandler(this.txtBindRQtyPerBundle_TextChanged);
            this.txtBindRQtyPerBundle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtyXBundle_KeyPress);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeleteItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.ForeColor = System.Drawing.Color.White;
            this.btnDeleteItem.Location = new System.Drawing.Point(839, 75);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(58, 32);
            this.btnDeleteItem.TabIndex = 7;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(170, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 15);
            this.label14.TabIndex = 216;
            this.label14.Text = "Item Code";
            // 
            // txtBindRItemCode
            // 
            this.txtBindRItemCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindRItemCode.Location = new System.Drawing.Point(154, 29);
            this.txtBindRItemCode.Name = "txtBindRItemCode";
            this.txtBindRItemCode.Size = new System.Drawing.Size(101, 26);
            this.txtBindRItemCode.TabIndex = 1;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(839, 23);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(58, 32);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(816, 167);
            this.dataGridView1.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(754, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 208;
            this.label10.Text = "Total Qty";
            // 
            // txtBindRTotalQty
            // 
            this.txtBindRTotalQty.Enabled = false;
            this.txtBindRTotalQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindRTotalQty.Location = new System.Drawing.Point(742, 29);
            this.txtBindRTotalQty.Name = "txtBindRTotalQty";
            this.txtBindRTotalQty.Size = new System.Drawing.Size(82, 26);
            this.txtBindRTotalQty.TabIndex = 5;
            this.txtBindRTotalQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBindRQtyPerBundle1_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(637, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 15);
            this.label9.TabIndex = 206;
            this.label9.Text = "Total Bundles";
            // 
            // txtBindRTotalBundles
            // 
            this.txtBindRTotalBundles.Enabled = false;
            this.txtBindRTotalBundles.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindRTotalBundles.Location = new System.Drawing.Point(638, 29);
            this.txtBindRTotalBundles.Name = "txtBindRTotalBundles";
            this.txtBindRTotalBundles.Size = new System.Drawing.Size(82, 26);
            this.txtBindRTotalBundles.TabIndex = 4;
            this.txtBindRTotalBundles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBindRQtyPerBundle1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(498, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 202;
            this.label7.Text = "Qty. Per Bundle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 200;
            this.label3.Text = "Item Name";
            // 
            // txtBindRItemName
            // 
            this.txtBindRItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindRItemName.Location = new System.Drawing.Point(276, 29);
            this.txtBindRItemName.Name = "txtBindRItemName";
            this.txtBindRItemName.Size = new System.Drawing.Size(172, 26);
            this.txtBindRItemName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 198;
            this.label2.Text = "Type";
            // 
            // txtBindNDriverName
            // 
            this.txtBindNDriverName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindNDriverName.Location = new System.Drawing.Point(238, 184);
            this.txtBindNDriverName.Name = "txtBindNDriverName";
            this.txtBindNDriverName.Size = new System.Drawing.Size(209, 26);
            this.txtBindNDriverName.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(149, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 15);
            this.label15.TabIndex = 199;
            this.label15.Text = "Driver Name :";
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = global::RWPLSoftware.Properties.Resources.exit;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBack.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBack.Location = new System.Drawing.Point(793, 482);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(79, 66);
            this.buttonBack.TabIndex = 6;
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
            this.buttonSave.Location = new System.Drawing.Point(663, 480);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(70, 70);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dtpBindNOutTime
            // 
            this.dtpBindNOutTime.CustomFormat = "hh:mm tt";
            this.dtpBindNOutTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBindNOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBindNOutTime.Location = new System.Drawing.Point(578, 145);
            this.dtpBindNOutTime.Name = "dtpBindNOutTime";
            this.dtpBindNOutTime.ShowUpDown = true;
            this.dtpBindNOutTime.Size = new System.Drawing.Size(103, 26);
            this.dtpBindNOutTime.TabIndex = 200;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(508, 152);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 15);
            this.label16.TabIndex = 201;
            this.label16.Text = "Out Time :";
            // 
            // FrmDispatchEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(920, 555);
            this.Controls.Add(this.dtpBindNOutTime);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.txtBindNDriverName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.grpGridBindRDispatchItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBindNSrNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpBindNInTime);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dtpBindNDate);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtBindRClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBindNVehicalNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblHeader);
            this.Name = "FrmDispatchEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dispatch Entry";
            this.Load += new System.EventHandler(this.FrmDispatchEntry_Load);
            this.grpGridBindRDispatchItems.ResumeLayout(false);
            this.grpGridBindRDispatchItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBindNInTime;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtpBindNDate;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtBindRClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBindNVehicalNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBindNSrNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel grpGridBindRDispatchItems;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBindRTotalQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBindRTotalBundles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBindRItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBindNDriverName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBindRItemCode;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker dtpBindNOutTime;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBindRQtyPerBundle;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.ComboBox cmbBindRItemType;
    }
}
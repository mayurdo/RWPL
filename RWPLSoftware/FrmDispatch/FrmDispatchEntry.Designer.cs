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
            this.dtpBindInTime = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.dtpBindDate = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.txtBindClient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBindVehicalNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBindSrNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpGridBindDispatchItems = new System.Windows.Forms.Panel();
            this.cmbBindItemType = new System.Windows.Forms.ComboBox();
            this.txtBindQtyPerBundle = new System.Windows.Forms.TextBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBindItemCode = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBindTotalQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBindTotalBundles = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBindItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBindDriverName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpBindOutTime = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.grpGridBindDispatchItems.SuspendLayout();
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
            // dtpBindInTime
            // 
            this.dtpBindInTime.CustomFormat = "hh:mm tt";
            this.dtpBindInTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBindInTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBindInTime.Location = new System.Drawing.Point(578, 105);
            this.dtpBindInTime.Name = "dtpBindInTime";
            this.dtpBindInTime.ShowUpDown = true;
            this.dtpBindInTime.Size = new System.Drawing.Size(103, 26);
            this.dtpBindInTime.TabIndex = 182;
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
            // dtpBindDate
            // 
            this.dtpBindDate.AccessibleDescription = "";
            this.dtpBindDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpBindDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBindDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBindDate.Location = new System.Drawing.Point(578, 64);
            this.dtpBindDate.Name = "dtpBindDate";
            this.dtpBindDate.Size = new System.Drawing.Size(144, 26);
            this.dtpBindDate.TabIndex = 181;
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
            // txtBindClient
            // 
            this.txtBindClient.AccessibleDescription = "Req.AppData";
            this.txtBindClient.AccessibleName = "CustomerName";
            this.txtBindClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindClient.Location = new System.Drawing.Point(238, 105);
            this.txtBindClient.Name = "txtBindClient";
            this.txtBindClient.Size = new System.Drawing.Size(209, 26);
            this.txtBindClient.TabIndex = 1;
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
            // txtBindVehicalNo
            // 
            this.txtBindVehicalNo.AccessibleDescription = "";
            this.txtBindVehicalNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindVehicalNo.Location = new System.Drawing.Point(238, 145);
            this.txtBindVehicalNo.Name = "txtBindVehicalNo";
            this.txtBindVehicalNo.Size = new System.Drawing.Size(209, 26);
            this.txtBindVehicalNo.TabIndex = 2;
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
            // txtBindSrNo
            // 
            this.txtBindSrNo.Enabled = false;
            this.txtBindSrNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindSrNo.Location = new System.Drawing.Point(238, 64);
            this.txtBindSrNo.Name = "txtBindSrNo";
            this.txtBindSrNo.Size = new System.Drawing.Size(209, 26);
            this.txtBindSrNo.TabIndex = 0;
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
            // grpGridBindDispatchItems
            // 
            this.grpGridBindDispatchItems.AccessibleDescription = "Req";
            this.grpGridBindDispatchItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grpGridBindDispatchItems.Controls.Add(this.cmbBindItemType);
            this.grpGridBindDispatchItems.Controls.Add(this.txtBindQtyPerBundle);
            this.grpGridBindDispatchItems.Controls.Add(this.btnDeleteItem);
            this.grpGridBindDispatchItems.Controls.Add(this.label14);
            this.grpGridBindDispatchItems.Controls.Add(this.txtBindItemCode);
            this.grpGridBindDispatchItems.Controls.Add(this.btnAddItem);
            this.grpGridBindDispatchItems.Controls.Add(this.dataGridView1);
            this.grpGridBindDispatchItems.Controls.Add(this.label10);
            this.grpGridBindDispatchItems.Controls.Add(this.txtBindTotalQty);
            this.grpGridBindDispatchItems.Controls.Add(this.label9);
            this.grpGridBindDispatchItems.Controls.Add(this.txtBindTotalBundles);
            this.grpGridBindDispatchItems.Controls.Add(this.label7);
            this.grpGridBindDispatchItems.Controls.Add(this.label3);
            this.grpGridBindDispatchItems.Controls.Add(this.txtBindItemName);
            this.grpGridBindDispatchItems.Controls.Add(this.label2);
            this.grpGridBindDispatchItems.Location = new System.Drawing.Point(12, 230);
            this.grpGridBindDispatchItems.Name = "grpGridBindDispatchItems";
            this.grpGridBindDispatchItems.Size = new System.Drawing.Size(908, 234);
            this.grpGridBindDispatchItems.TabIndex = 4;
            // 
            // cmbBindItemType
            // 
            this.cmbBindItemType.AccessibleName = "Req";
            this.cmbBindItemType.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbBindItemType.FormattingEnabled = true;
            this.cmbBindItemType.Location = new System.Drawing.Point(8, 29);
            this.cmbBindItemType.Name = "cmbBindItemType";
            this.cmbBindItemType.Size = new System.Drawing.Size(128, 26);
            this.cmbBindItemType.TabIndex = 0;
            // 
            // txtBindQtyPerBundle
            // 
            this.txtBindQtyPerBundle.AccessibleDescription = "Req.NumMultComa";
            this.txtBindQtyPerBundle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindQtyPerBundle.Location = new System.Drawing.Point(467, 29);
            this.txtBindQtyPerBundle.Name = "txtBindQtyPerBundle";
            this.txtBindQtyPerBundle.Size = new System.Drawing.Size(152, 26);
            this.txtBindQtyPerBundle.TabIndex = 3;
            this.txtBindQtyPerBundle.TextChanged += new System.EventHandler(this.txtBindRQtyPerBundle_TextChanged);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.AccessibleDescription = "DeleteItem";
            this.btnDeleteItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeleteItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.ForeColor = System.Drawing.Color.White;
            this.btnDeleteItem.Location = new System.Drawing.Point(839, 75);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(58, 32);
            this.btnDeleteItem.TabIndex = 7;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
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
            // txtBindItemCode
            // 
            this.txtBindItemCode.AccessibleDescription = "Req.AppData";
            this.txtBindItemCode.AccessibleName = "ItemCode";
            this.txtBindItemCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindItemCode.Location = new System.Drawing.Point(154, 29);
            this.txtBindItemCode.Name = "txtBindItemCode";
            this.txtBindItemCode.Size = new System.Drawing.Size(101, 26);
            this.txtBindItemCode.TabIndex = 1;
            // 
            // btnAddItem
            // 
            this.btnAddItem.AccessibleDescription = "AddItem";
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(839, 23);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(58, 32);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = false;
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
            // txtBindTotalQty
            // 
            this.txtBindTotalQty.AccessibleDescription = "Req.Num";
            this.txtBindTotalQty.Enabled = false;
            this.txtBindTotalQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindTotalQty.Location = new System.Drawing.Point(742, 29);
            this.txtBindTotalQty.Name = "txtBindTotalQty";
            this.txtBindTotalQty.Size = new System.Drawing.Size(82, 26);
            this.txtBindTotalQty.TabIndex = 5;
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
            // txtBindTotalBundles
            // 
            this.txtBindTotalBundles.AccessibleDescription = "Req.Num";
            this.txtBindTotalBundles.Enabled = false;
            this.txtBindTotalBundles.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindTotalBundles.Location = new System.Drawing.Point(638, 29);
            this.txtBindTotalBundles.Name = "txtBindTotalBundles";
            this.txtBindTotalBundles.Size = new System.Drawing.Size(82, 26);
            this.txtBindTotalBundles.TabIndex = 4;
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
            // txtBindItemName
            // 
            this.txtBindItemName.AccessibleDescription = "Req.AppData";
            this.txtBindItemName.AccessibleName = "";
            this.txtBindItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindItemName.Location = new System.Drawing.Point(276, 29);
            this.txtBindItemName.Name = "txtBindItemName";
            this.txtBindItemName.Size = new System.Drawing.Size(172, 26);
            this.txtBindItemName.TabIndex = 2;
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
            // txtBindDriverName
            // 
            this.txtBindDriverName.AccessibleDescription = "";
            this.txtBindDriverName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBindDriverName.Location = new System.Drawing.Point(238, 184);
            this.txtBindDriverName.Name = "txtBindDriverName";
            this.txtBindDriverName.Size = new System.Drawing.Size(209, 26);
            this.txtBindDriverName.TabIndex = 3;
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
            // btnBack
            // 
            this.btnBack.AccessibleDescription = "Back";
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::RWPLSoftware.Properties.Resources.exit;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(793, 482);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 66);
            this.btnBack.TabIndex = 6;
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
            this.btnSave.Location = new System.Drawing.Point(663, 480);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 70);
            this.btnSave.TabIndex = 5;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // dtpBindOutTime
            // 
            this.dtpBindOutTime.CustomFormat = "hh:mm tt";
            this.dtpBindOutTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBindOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBindOutTime.Location = new System.Drawing.Point(578, 145);
            this.dtpBindOutTime.Name = "dtpBindOutTime";
            this.dtpBindOutTime.ShowUpDown = true;
            this.dtpBindOutTime.Size = new System.Drawing.Size(103, 26);
            this.dtpBindOutTime.TabIndex = 200;
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
            this.Controls.Add(this.dtpBindOutTime);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBindDriverName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.grpGridBindDispatchItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBindSrNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpBindInTime);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dtpBindDate);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtBindClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBindVehicalNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblHeader);
            this.Name = "FrmDispatchEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dispatch Entry";
            this.Load += new System.EventHandler(this.FrmDispatchEntry_Load);
            this.grpGridBindDispatchItems.ResumeLayout(false);
            this.grpGridBindDispatchItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBindInTime;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtpBindDate;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtBindClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBindVehicalNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBindSrNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel grpGridBindDispatchItems;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBindTotalQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBindTotalBundles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBindItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBindDriverName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBindItemCode;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpBindOutTime;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBindQtyPerBundle;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.ComboBox cmbBindItemType;
    }
}
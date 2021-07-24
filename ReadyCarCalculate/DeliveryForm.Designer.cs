namespace ReadyCarCalculate
{
    partial class DeliveryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryForm));
            this.labelDistance = new System.Windows.Forms.Label();
            this.labelItemCategory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textEditDistance = new DevExpress.XtraEditors.TextEdit();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.lookUpEditCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLabour = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textEditServiceFee = new DevExpress.XtraEditors.TextEdit();
            this.btnCalculate = new DevExpress.XtraEditors.SimpleButton();
            this.labelServiceFee = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelGst = new System.Windows.Forms.Label();
            this.labelLabourFee = new System.Windows.Forms.Label();
            this.checkBoxAddLabourFee = new System.Windows.Forms.CheckBox();
            this.labelDiscountAdded = new System.Windows.Forms.Label();
            this.comboBoxDiscount = new System.Windows.Forms.ComboBox();
            this.LookUpEditItemWeight = new DevExpress.XtraEditors.LookUpEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textEditLabourCostPerHour = new DevExpress.XtraEditors.TextEdit();
            this.labelLabourCost = new System.Windows.Forms.Label();
            this.textEditNoOfHours = new DevExpress.XtraEditors.TextEdit();
            this.labelLabourHours = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxProvinces = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDistance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditServiceFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditItemWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLabourCostPerHour.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNoOfHours.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistance.Location = new System.Drawing.Point(97, 165);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(143, 24);
            this.labelDistance.TabIndex = 0;
            this.labelDistance.Text = "Distance (km):";
            // 
            // labelItemCategory
            // 
            this.labelItemCategory.AutoSize = true;
            this.labelItemCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemCategory.Location = new System.Drawing.Point(97, 232);
            this.labelItemCategory.Name = "labelItemCategory";
            this.labelItemCategory.Size = new System.Drawing.Size(144, 24);
            this.labelItemCategory.TabIndex = 1;
            this.labelItemCategory.Text = "Item Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Discount (%):";
            // 
            // textEditDistance
            // 
            this.textEditDistance.Location = new System.Drawing.Point(268, 167);
            this.textEditDistance.Name = "textEditDistance";
            this.textEditDistance.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.textEditDistance.Properties.Appearance.Options.UseFont = true;
            this.textEditDistance.Size = new System.Drawing.Size(250, 24);
            this.textEditDistance.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelTitle.Location = new System.Drawing.Point(277, 69);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(475, 46);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Delivery Quote Calculator";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCost.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCost.Location = new System.Drawing.Point(403, 553);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(111, 39);
            this.labelCost.TabIndex = 7;
            this.labelCost.Text = "Total: ";
            // 
            // lookUpEditCategory
            // 
            this.lookUpEditCategory.Location = new System.Drawing.Point(268, 232);
            this.lookUpEditCategory.Name = "lookUpEditCategory";
            this.lookUpEditCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookUpEditCategory.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lookUpEditCategory.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCategory.Properties.NullText = "No Selection";
            this.lookUpEditCategory.Size = new System.Drawing.Size(249, 24);
            this.lookUpEditCategory.TabIndex = 8;
            this.lookUpEditCategory.EditValueChanged += new System.EventHandler(this.LookUpEditCategory_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(579, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Labour needed:";
            // 
            // comboBoxLabour
            // 
            this.comboBoxLabour.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLabour.FormattingEnabled = true;
            this.comboBoxLabour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxLabour.Location = new System.Drawing.Point(770, 162);
            this.comboBoxLabour.Name = "comboBoxLabour";
            this.comboBoxLabour.Size = new System.Drawing.Size(136, 24);
            this.comboBoxLabour.TabIndex = 10;
            this.comboBoxLabour.Text = "0";
            this.comboBoxLabour.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLabour_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Service Fee (per km):";
            // 
            // textEditServiceFee
            // 
            this.textEditServiceFee.Location = new System.Drawing.Point(268, 287);
            this.textEditServiceFee.Name = "textEditServiceFee";
            this.textEditServiceFee.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.textEditServiceFee.Properties.Appearance.Options.UseFont = true;
            this.textEditServiceFee.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEditServiceFee.Size = new System.Drawing.Size(250, 24);
            this.textEditServiceFee.TabIndex = 12;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalculate.Appearance.Options.UseFont = true;
            this.btnCalculate.Appearance.Options.UseForeColor = true;
            this.btnCalculate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculate.ImageOptions.Image")));
            this.btnCalculate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCalculate.Location = new System.Drawing.Point(733, 534);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(184, 54);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // labelServiceFee
            // 
            this.labelServiceFee.AutoSize = true;
            this.labelServiceFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServiceFee.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelServiceFee.Location = new System.Drawing.Point(406, 458);
            this.labelServiceFee.Name = "labelServiceFee";
            this.labelServiceFee.Size = new System.Drawing.Size(115, 20);
            this.labelServiceFee.TabIndex = 14;
            this.labelServiceFee.Text = "Service Fee:";
            this.labelServiceFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(579, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Item Weight (lbs):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(98, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "(auto generated)";
            // 
            // labelGst
            // 
            this.labelGst.AutoSize = true;
            this.labelGst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGst.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelGst.Location = new System.Drawing.Point(406, 521);
            this.labelGst.Name = "labelGst";
            this.labelGst.Size = new System.Drawing.Size(84, 20);
            this.labelGst.TabIndex = 19;
            this.labelGst.Text = "GST: 5%";
            this.labelGst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLabourFee
            // 
            this.labelLabourFee.AutoSize = true;
            this.labelLabourFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLabourFee.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelLabourFee.Location = new System.Drawing.Point(406, 488);
            this.labelLabourFee.Name = "labelLabourFee";
            this.labelLabourFee.Size = new System.Drawing.Size(110, 20);
            this.labelLabourFee.TabIndex = 20;
            this.labelLabourFee.Text = "Labour Fee:";
            this.labelLabourFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxAddLabourFee
            // 
            this.checkBoxAddLabourFee.AutoSize = true;
            this.checkBoxAddLabourFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAddLabourFee.Location = new System.Drawing.Point(583, 199);
            this.checkBoxAddLabourFee.Name = "checkBoxAddLabourFee";
            this.checkBoxAddLabourFee.Size = new System.Drawing.Size(140, 21);
            this.checkBoxAddLabourFee.TabIndex = 21;
            this.checkBoxAddLabourFee.Text = "Add Labour Fee?";
            this.checkBoxAddLabourFee.UseVisualStyleBackColor = true;
            this.checkBoxAddLabourFee.CheckedChanged += new System.EventHandler(this.CheckBoxAddLabourFee_CheckedChanged);
            // 
            // labelDiscountAdded
            // 
            this.labelDiscountAdded.AutoSize = true;
            this.labelDiscountAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscountAdded.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDiscountAdded.Location = new System.Drawing.Point(269, 568);
            this.labelDiscountAdded.Name = "labelDiscountAdded";
            this.labelDiscountAdded.Size = new System.Drawing.Size(140, 20);
            this.labelDiscountAdded.TabIndex = 22;
            this.labelDiscountAdded.Text = "(Discount Added)";
            this.labelDiscountAdded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDiscountAdded.Visible = false;
            // 
            // comboBoxDiscount
            // 
            this.comboBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDiscount.FormattingEnabled = true;
            this.comboBoxDiscount.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50"});
            this.comboBoxDiscount.Location = new System.Drawing.Point(268, 401);
            this.comboBoxDiscount.Name = "comboBoxDiscount";
            this.comboBoxDiscount.Size = new System.Drawing.Size(250, 24);
            this.comboBoxDiscount.TabIndex = 23;
            this.comboBoxDiscount.Text = "0";
            this.comboBoxDiscount.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiscount_SelectedIndexChanged);
            // 
            // LookUpEditItemWeight
            // 
            this.LookUpEditItemWeight.Location = new System.Drawing.Point(770, 232);
            this.LookUpEditItemWeight.Name = "LookUpEditItemWeight";
            this.LookUpEditItemWeight.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.LookUpEditItemWeight.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LookUpEditItemWeight.Properties.Appearance.Options.UseFont = true;
            this.LookUpEditItemWeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEditItemWeight.Properties.NullText = "No Selection";
            this.LookUpEditItemWeight.Size = new System.Drawing.Size(136, 24);
            this.LookUpEditItemWeight.TabIndex = 24;
            this.LookUpEditItemWeight.EditValueChanged += new System.EventHandler(this.LookUpEditItemWeight_EditValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // textEditLabourCostPerHour
            // 
            this.textEditLabourCostPerHour.EditValue = "$ 25.00";
            this.textEditLabourCostPerHour.Location = new System.Drawing.Point(770, 283);
            this.textEditLabourCostPerHour.Name = "textEditLabourCostPerHour";
            this.textEditLabourCostPerHour.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.textEditLabourCostPerHour.Properties.Appearance.Options.UseFont = true;
            this.textEditLabourCostPerHour.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEditLabourCostPerHour.Properties.ReadOnly = true;
            this.textEditLabourCostPerHour.Size = new System.Drawing.Size(136, 24);
            this.textEditLabourCostPerHour.TabIndex = 27;
            this.textEditLabourCostPerHour.Visible = false;
            // 
            // labelLabourCost
            // 
            this.labelLabourCost.AutoSize = true;
            this.labelLabourCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLabourCost.Location = new System.Drawing.Point(580, 286);
            this.labelLabourCost.Name = "labelLabourCost";
            this.labelLabourCost.Size = new System.Drawing.Size(180, 17);
            this.labelLabourCost.TabIndex = 26;
            this.labelLabourCost.Text = "Labour Cost (per hour):";
            this.labelLabourCost.Visible = false;
            // 
            // textEditNoOfHours
            // 
            this.textEditNoOfHours.Location = new System.Drawing.Point(770, 353);
            this.textEditNoOfHours.Name = "textEditNoOfHours";
            this.textEditNoOfHours.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.textEditNoOfHours.Properties.Appearance.Options.UseFont = true;
            this.textEditNoOfHours.Size = new System.Drawing.Size(136, 24);
            this.textEditNoOfHours.TabIndex = 30;
            this.textEditNoOfHours.Visible = false;
            // 
            // labelLabourHours
            // 
            this.labelLabourHours.AutoSize = true;
            this.labelLabourHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLabourHours.Location = new System.Drawing.Point(581, 351);
            this.labelLabourHours.Name = "labelLabourHours";
            this.labelLabourHours.Size = new System.Drawing.Size(149, 24);
            this.labelLabourHours.TabIndex = 29;
            this.labelLabourHours.Text = "Hours of Work:";
            this.labelLabourHours.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Province:";
            // 
            // comboBoxProvinces
            // 
            this.comboBoxProvinces.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProvinces.FormattingEnabled = true;
            this.comboBoxProvinces.Items.AddRange(new object[] {
            "AB",
            "BC",
            "MB",
            "SK",
            "QC",
            "ON",
            "NT",
            "NL"});
            this.comboBoxProvinces.Location = new System.Drawing.Point(268, 351);
            this.comboBoxProvinces.Name = "comboBoxProvinces";
            this.comboBoxProvinces.Size = new System.Drawing.Size(249, 24);
            this.comboBoxProvinces.TabIndex = 32;
            this.comboBoxProvinces.Text = "0";
            this.comboBoxProvinces.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProvinces_SelectedIndexChanged);
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 628);
            this.Controls.Add(this.comboBoxProvinces);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEditNoOfHours);
            this.Controls.Add(this.labelLabourHours);
            this.Controls.Add(this.textEditLabourCostPerHour);
            this.Controls.Add(this.labelLabourCost);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LookUpEditItemWeight);
            this.Controls.Add(this.comboBoxDiscount);
            this.Controls.Add(this.labelDiscountAdded);
            this.Controls.Add(this.checkBoxAddLabourFee);
            this.Controls.Add(this.labelLabourFee);
            this.Controls.Add(this.labelGst);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelServiceFee);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.textEditServiceFee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxLabour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lookUpEditCategory);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textEditDistance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelItemCategory);
            this.Controls.Add(this.labelDistance);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DeliveryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Jobs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.textEditDistance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditServiceFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditItemWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLabourCostPerHour.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNoOfHours.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Label labelItemCategory;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textEditDistance;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCost;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLabour;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit textEditServiceFee;
        private DevExpress.XtraEditors.SimpleButton btnCalculate;
        private System.Windows.Forms.Label labelServiceFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelGst;
        private System.Windows.Forms.Label labelLabourFee;
        private System.Windows.Forms.CheckBox checkBoxAddLabourFee;
        private System.Windows.Forms.Label labelDiscountAdded;
        private System.Windows.Forms.ComboBox comboBoxDiscount;
        private DevExpress.XtraEditors.LookUpEdit LookUpEditItemWeight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TextEdit textEditLabourCostPerHour;
        private System.Windows.Forms.Label labelLabourCost;
        private DevExpress.XtraEditors.TextEdit textEditNoOfHours;
        private System.Windows.Forms.Label labelLabourHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxProvinces;
    }
}


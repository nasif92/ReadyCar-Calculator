namespace ReadyCarCalculate
{
    partial class Form1
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
            this.labelDistance = new System.Windows.Forms.Label();
            this.labelItemCategory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textEditDistance = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.lookUpEditCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLabour = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textEditServiceFee = new DevExpress.XtraEditors.TextEdit();
            this.btnCalculate = new DevExpress.XtraEditors.SimpleButton();
            this.labelServiceFee = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textEditItemWeight = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelLabourFee = new System.Windows.Forms.Label();
            this.checkBoxAddLabourFee = new System.Windows.Forms.CheckBox();
            this.labelDiscountAdded = new System.Windows.Forms.Label();
            this.comboBoxDiscount = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDistance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditServiceFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditItemWeight.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistance.Location = new System.Drawing.Point(54, 126);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(143, 24);
            this.labelDistance.TabIndex = 0;
            this.labelDistance.Text = "Distance (km):";
            // 
            // labelItemCategory
            // 
            this.labelItemCategory.AutoSize = true;
            this.labelItemCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemCategory.Location = new System.Drawing.Point(54, 193);
            this.labelItemCategory.Name = "labelItemCategory";
            this.labelItemCategory.Size = new System.Drawing.Size(144, 24);
            this.labelItemCategory.TabIndex = 1;
            this.labelItemCategory.Text = "Item Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Discount (%):";
            // 
            // textEditDistance
            // 
            this.textEditDistance.Location = new System.Drawing.Point(225, 128);
            this.textEditDistance.Name = "textEditDistance";
            this.textEditDistance.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.textEditDistance.Properties.Appearance.Options.UseFont = true;
            this.textEditDistance.Size = new System.Drawing.Size(250, 24);
            this.textEditDistance.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(284, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "ReadyCar Calculator";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCost.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCost.Location = new System.Drawing.Point(340, 537);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(111, 39);
            this.labelCost.TabIndex = 7;
            this.labelCost.Text = "Total: ";
            // 
            // lookUpEditCategory
            // 
            this.lookUpEditCategory.Location = new System.Drawing.Point(225, 195);
            this.lookUpEditCategory.Name = "lookUpEditCategory";
            this.lookUpEditCategory.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lookUpEditCategory.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCategory.Properties.NullText = "";
            this.lookUpEditCategory.Size = new System.Drawing.Size(249, 24);
            this.lookUpEditCategory.TabIndex = 8;
            this.lookUpEditCategory.EditValueChanged += new System.EventHandler(this.lookUpEditCategory_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 123);
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
            this.comboBoxLabour.Location = new System.Drawing.Point(715, 123);
            this.comboBoxLabour.Name = "comboBoxLabour";
            this.comboBoxLabour.Size = new System.Drawing.Size(136, 24);
            this.comboBoxLabour.TabIndex = 10;
            this.comboBoxLabour.Text = "0";
            this.comboBoxLabour.SelectedIndexChanged += new System.EventHandler(this.comboBoxLabour_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Service Fee (per km):";
            // 
            // textEditServiceFee
            // 
            this.textEditServiceFee.Location = new System.Drawing.Point(225, 248);
            this.textEditServiceFee.Name = "textEditServiceFee";
            this.textEditServiceFee.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.textEditServiceFee.Properties.Appearance.Options.UseFont = true;
            this.textEditServiceFee.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEditServiceFee.Size = new System.Drawing.Size(136, 24);
            this.textEditServiceFee.TabIndex = 12;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalculate.Appearance.Options.UseFont = true;
            this.btnCalculate.Appearance.Options.UseForeColor = true;
            this.btnCalculate.Location = new System.Drawing.Point(692, 483);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(159, 42);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // labelServiceFee
            // 
            this.labelServiceFee.AutoSize = true;
            this.labelServiceFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServiceFee.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelServiceFee.Location = new System.Drawing.Point(343, 442);
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
            this.label7.Location = new System.Drawing.Point(536, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Item Weight (lbs):";
            // 
            // textEditItemWeight
            // 
            this.textEditItemWeight.Location = new System.Drawing.Point(715, 195);
            this.textEditItemWeight.Name = "textEditItemWeight";
            this.textEditItemWeight.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.textEditItemWeight.Properties.Appearance.Options.UseFont = true;
            this.textEditItemWeight.Size = new System.Drawing.Size(136, 24);
            this.textEditItemWeight.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "(auto generated)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(343, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "GST: 5%";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLabourFee
            // 
            this.labelLabourFee.AutoSize = true;
            this.labelLabourFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLabourFee.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelLabourFee.Location = new System.Drawing.Point(343, 472);
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
            this.checkBoxAddLabourFee.Location = new System.Drawing.Point(540, 160);
            this.checkBoxAddLabourFee.Name = "checkBoxAddLabourFee";
            this.checkBoxAddLabourFee.Size = new System.Drawing.Size(140, 21);
            this.checkBoxAddLabourFee.TabIndex = 21;
            this.checkBoxAddLabourFee.Text = "Add Labour Fee?";
            this.checkBoxAddLabourFee.UseVisualStyleBackColor = true;
            this.checkBoxAddLabourFee.CheckedChanged += new System.EventHandler(this.checkBoxAddLabourFee_CheckedChanged);
            // 
            // labelDiscountAdded
            // 
            this.labelDiscountAdded.AutoSize = true;
            this.labelDiscountAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscountAdded.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDiscountAdded.Location = new System.Drawing.Point(206, 552);
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
            this.comboBoxDiscount.Location = new System.Drawing.Point(225, 313);
            this.comboBoxDiscount.Name = "comboBoxDiscount";
            this.comboBoxDiscount.Size = new System.Drawing.Size(136, 24);
            this.comboBoxDiscount.TabIndex = 23;
            this.comboBoxDiscount.Text = "0";
            this.comboBoxDiscount.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiscount_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 590);
            this.Controls.Add(this.comboBoxDiscount);
            this.Controls.Add(this.labelDiscountAdded);
            this.Controls.Add(this.checkBoxAddLabourFee);
            this.Controls.Add(this.labelLabourFee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textEditItemWeight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelServiceFee);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.textEditServiceFee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxLabour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lookUpEditCategory);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEditDistance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelItemCategory);
            this.Controls.Add(this.labelDistance);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "ReadyCarCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.textEditDistance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditServiceFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditItemWeight.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Label labelItemCategory;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textEditDistance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCost;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLabour;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit textEditServiceFee;
        private DevExpress.XtraEditors.SimpleButton btnCalculate;
        private System.Windows.Forms.Label labelServiceFee;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit textEditItemWeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelLabourFee;
        private System.Windows.Forms.CheckBox checkBoxAddLabourFee;
        private System.Windows.Forms.Label labelDiscountAdded;
        private System.Windows.Forms.ComboBox comboBoxDiscount;
    }
}


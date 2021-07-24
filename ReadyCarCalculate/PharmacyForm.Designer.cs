namespace ReadyCarCalculate
{
    partial class PharmacyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharmacyForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxProvinces = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textEditServiceFee = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.lookUpEditCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.textEditDistance = new DevExpress.XtraEditors.TextEdit();
            this.labelItemCategory = new System.Windows.Forms.Label();
            this.labelDistance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditServiceFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDistance.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelTitle.Location = new System.Drawing.Point(254, 44);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(475, 46);
            this.labelTitle.TabIndex = 28;
            this.labelTitle.Text = "Delivery Quote Calculator";
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
            this.comboBoxProvinces.Location = new System.Drawing.Point(209, 349);
            this.comboBoxProvinces.Name = "comboBoxProvinces";
            this.comboBoxProvinces.Size = new System.Drawing.Size(249, 24);
            this.comboBoxProvinces.TabIndex = 41;
            this.comboBoxProvinces.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Province:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "(auto generated)";
            // 
            // textEditServiceFee
            // 
            this.textEditServiceFee.Location = new System.Drawing.Point(209, 285);
            this.textEditServiceFee.Name = "textEditServiceFee";
            this.textEditServiceFee.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.textEditServiceFee.Properties.Appearance.Options.UseFont = true;
            this.textEditServiceFee.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEditServiceFee.Size = new System.Drawing.Size(250, 24);
            this.textEditServiceFee.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Service Fee (per km):";
            // 
            // lookUpEditCategory
            // 
            this.lookUpEditCategory.Location = new System.Drawing.Point(209, 230);
            this.lookUpEditCategory.Name = "lookUpEditCategory";
            this.lookUpEditCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookUpEditCategory.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lookUpEditCategory.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCategory.Properties.NullText = "No Selection";
            this.lookUpEditCategory.Size = new System.Drawing.Size(249, 24);
            this.lookUpEditCategory.TabIndex = 36;
            // 
            // textEditDistance
            // 
            this.textEditDistance.Location = new System.Drawing.Point(209, 165);
            this.textEditDistance.Name = "textEditDistance";
            this.textEditDistance.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.textEditDistance.Properties.Appearance.Options.UseFont = true;
            this.textEditDistance.Size = new System.Drawing.Size(250, 24);
            this.textEditDistance.TabIndex = 35;
            // 
            // labelItemCategory
            // 
            this.labelItemCategory.AutoSize = true;
            this.labelItemCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemCategory.Location = new System.Drawing.Point(38, 230);
            this.labelItemCategory.Name = "labelItemCategory";
            this.labelItemCategory.Size = new System.Drawing.Size(144, 24);
            this.labelItemCategory.TabIndex = 34;
            this.labelItemCategory.Text = "Item Category:";
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistance.Location = new System.Drawing.Point(38, 163);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(143, 24);
            this.labelDistance.TabIndex = 33;
            this.labelDistance.Text = "Distance (km):";
            // 
            // PharmacyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 631);
            this.Controls.Add(this.comboBoxProvinces);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textEditServiceFee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lookUpEditCategory);
            this.Controls.Add(this.textEditDistance);
            this.Controls.Add(this.labelItemCategory);
            this.Controls.Add(this.labelDistance);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTitle);
            this.Name = "PharmacyForm";
            this.Text = "PharmacyForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditServiceFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDistance.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxProvinces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit textEditServiceFee;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCategory;
        private DevExpress.XtraEditors.TextEdit textEditDistance;
        private System.Windows.Forms.Label labelItemCategory;
        private System.Windows.Forms.Label labelDistance;
    }
}
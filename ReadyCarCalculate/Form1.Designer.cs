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
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.lookUpEditCategory = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDistance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCategory.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistance.Location = new System.Drawing.Point(48, 126);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(115, 20);
            this.labelDistance.TabIndex = 0;
            this.labelDistance.Text = "Distance (km)";
            // 
            // labelItemCategory
            // 
            this.labelItemCategory.AutoSize = true;
            this.labelItemCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemCategory.Location = new System.Drawing.Point(48, 193);
            this.labelItemCategory.Name = "labelItemCategory";
            this.labelItemCategory.Size = new System.Drawing.Size(113, 20);
            this.labelItemCategory.TabIndex = 1;
            this.labelItemCategory.Text = "Item Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Discount (%)";
            // 
            // textEditDistance
            // 
            this.textEditDistance.Location = new System.Drawing.Point(186, 126);
            this.textEditDistance.Name = "textEditDistance";
            this.textEditDistance.Size = new System.Drawing.Size(228, 22);
            this.textEditDistance.TabIndex = 3;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(186, 274);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(228, 22);
            this.textEdit3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(133, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome to the ReadyCar Calculator";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCost.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCost.Location = new System.Drawing.Point(318, 352);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(96, 39);
            this.labelCost.TabIndex = 7;
            this.labelCost.Text = "Cost:";
            // 
            // lookUpEditCategory
            // 
            this.lookUpEditCategory.Location = new System.Drawing.Point(186, 193);
            this.lookUpEditCategory.Name = "lookUpEditCategory";
            this.lookUpEditCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCategory.Properties.NullText = "";
            this.lookUpEditCategory.Size = new System.Drawing.Size(228, 22);
            this.lookUpEditCategory.TabIndex = 8;
            this.lookUpEditCategory.EditValueChanged += new System.EventHandler(this.lookUpEditCategory_EditValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lookUpEditCategory);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.textEditDistance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelItemCategory);
            this.Controls.Add(this.labelDistance);
            this.Name = "Form1";
            this.Text = "ReadyCarCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.textEditDistance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCategory.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Label labelItemCategory;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textEditDistance;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCost;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCategory;
    }
}


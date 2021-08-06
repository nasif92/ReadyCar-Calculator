namespace ReadyCarCalculate
{
    partial class Homeform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homeform));
            this.btnDeliveryJob = new DevExpress.XtraEditors.SimpleButton();
            this.btnMovingJob = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCharts = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeliveryJob
            // 
            this.btnDeliveryJob.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.btnDeliveryJob.Appearance.Options.UseFont = true;
            this.btnDeliveryJob.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDeliveryJob.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeliveryJob.ImageOptions.SvgImage")));
            this.btnDeliveryJob.Location = new System.Drawing.Point(335, 396);
            this.btnDeliveryJob.Name = "btnDeliveryJob";
            this.btnDeliveryJob.Size = new System.Drawing.Size(307, 109);
            this.btnDeliveryJob.TabIndex = 0;
            this.btnDeliveryJob.Text = "Delivery Job";
            this.btnDeliveryJob.Click += new System.EventHandler(this.btnDeliveryJob_Click);
            // 
            // btnMovingJob
            // 
            this.btnMovingJob.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.btnMovingJob.Appearance.Options.UseFont = true;
            this.btnMovingJob.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnMovingJob.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMovingJob.ImageOptions.SvgImage")));
            this.btnMovingJob.Location = new System.Drawing.Point(770, 396);
            this.btnMovingJob.Name = "btnMovingJob";
            this.btnMovingJob.Size = new System.Drawing.Size(307, 109);
            this.btnMovingJob.TabIndex = 1;
            this.btnMovingJob.Text = "Moving Job";
            this.btnMovingJob.Click += new System.EventHandler(this.btnMovingJob_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(137, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(532, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 54);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quote Calculator";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(770, 573);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(334, 118);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Pharmacy";
            // 
            // simpleButtonCharts
            // 
            this.simpleButtonCharts.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.simpleButtonCharts.Appearance.Options.UseFont = true;
            this.simpleButtonCharts.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButtonCharts.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButtonCharts.Location = new System.Drawing.Point(308, 573);
            this.simpleButtonCharts.Name = "simpleButtonCharts";
            this.simpleButtonCharts.Size = new System.Drawing.Size(334, 118);
            this.simpleButtonCharts.TabIndex = 9;
            this.simpleButtonCharts.Text = "Charts";
            this.simpleButtonCharts.Click += new System.EventHandler(this.simpleButtonCharts_Click);
            // 
            // Homeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 877);
            this.ControlBox = false;
            this.Controls.Add(this.simpleButtonCharts);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMovingJob);
            this.Controls.Add(this.btnDeliveryJob);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Homeform";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDeliveryJob;
        private DevExpress.XtraEditors.SimpleButton btnMovingJob;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCharts;
    }
}
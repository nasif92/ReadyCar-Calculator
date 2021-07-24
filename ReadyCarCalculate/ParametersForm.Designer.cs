namespace ReadyCarCalculate
{
    partial class ParametersForm
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
            this.ratesTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.DeliveryPage = new DevExpress.XtraTab.XtraTabPage();
            this.MovingPage = new DevExpress.XtraTab.XtraTabPage();
            this.PharmacyPage = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlDeliveryRates = new DevExpress.XtraGrid.GridControl();
            this.gridViewDeliveryRates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlMovingRates = new DevExpress.XtraGrid.GridControl();
            this.gridViewMovingRates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlPharmacyRates = new DevExpress.XtraGrid.GridControl();
            this.gridViewPharmacyRates = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ratesTabControl)).BeginInit();
            this.ratesTabControl.SuspendLayout();
            this.DeliveryPage.SuspendLayout();
            this.MovingPage.SuspendLayout();
            this.PharmacyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDeliveryRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDeliveryRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMovingRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMovingRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPharmacyRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPharmacyRates)).BeginInit();
            this.SuspendLayout();
            // 
            // ratesTabControl
            // 
            this.ratesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ratesTabControl.Location = new System.Drawing.Point(0, 0);
            this.ratesTabControl.Name = "ratesTabControl";
            this.ratesTabControl.SelectedTabPage = this.MovingPage;
            this.ratesTabControl.Size = new System.Drawing.Size(1143, 564);
            this.ratesTabControl.TabIndex = 1;
            this.ratesTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.DeliveryPage,
            this.MovingPage,
            this.PharmacyPage});
            // 
            // DeliveryPage
            // 
            this.DeliveryPage.Controls.Add(this.gridControlDeliveryRates);
            this.DeliveryPage.Name = "DeliveryPage";
            this.DeliveryPage.Size = new System.Drawing.Size(1136, 530);
            this.DeliveryPage.Text = "Delivery Rates";
            // 
            // MovingPage
            // 
            this.MovingPage.Controls.Add(this.gridControlMovingRates);
            this.MovingPage.Name = "MovingPage";
            this.MovingPage.Size = new System.Drawing.Size(1136, 530);
            this.MovingPage.Text = "Moving Rates";
            // 
            // PharmacyPage
            // 
            this.PharmacyPage.Controls.Add(this.gridControlPharmacyRates);
            this.PharmacyPage.Name = "PharmacyPage";
            this.PharmacyPage.Size = new System.Drawing.Size(1136, 530);
            this.PharmacyPage.Text = "Pharmacy Rates";
            // 
            // gridControlDeliveryRates
            // 
            this.gridControlDeliveryRates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDeliveryRates.Location = new System.Drawing.Point(0, 0);
            this.gridControlDeliveryRates.MainView = this.gridViewDeliveryRates;
            this.gridControlDeliveryRates.Name = "gridControlDeliveryRates";
            this.gridControlDeliveryRates.Size = new System.Drawing.Size(1136, 530);
            this.gridControlDeliveryRates.TabIndex = 0;
            this.gridControlDeliveryRates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDeliveryRates});
            // 
            // gridViewDeliveryRates
            // 
            this.gridViewDeliveryRates.GridControl = this.gridControlDeliveryRates;
            this.gridViewDeliveryRates.Name = "gridViewDeliveryRates";
            // 
            // gridControlMovingRates
            // 
            this.gridControlMovingRates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMovingRates.Location = new System.Drawing.Point(0, 0);
            this.gridControlMovingRates.MainView = this.gridViewMovingRates;
            this.gridControlMovingRates.Name = "gridControlMovingRates";
            this.gridControlMovingRates.Size = new System.Drawing.Size(1136, 530);
            this.gridControlMovingRates.TabIndex = 1;
            this.gridControlMovingRates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMovingRates});
            // 
            // gridViewMovingRates
            // 
            this.gridViewMovingRates.GridControl = this.gridControlMovingRates;
            this.gridViewMovingRates.Name = "gridViewMovingRates";
            // 
            // gridControlPharmacyRates
            // 
            this.gridControlPharmacyRates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPharmacyRates.Location = new System.Drawing.Point(0, 0);
            this.gridControlPharmacyRates.MainView = this.gridViewPharmacyRates;
            this.gridControlPharmacyRates.Name = "gridControlPharmacyRates";
            this.gridControlPharmacyRates.Size = new System.Drawing.Size(1136, 530);
            this.gridControlPharmacyRates.TabIndex = 1;
            this.gridControlPharmacyRates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPharmacyRates});
            // 
            // gridViewPharmacyRates
            // 
            this.gridViewPharmacyRates.GridControl = this.gridControlPharmacyRates;
            this.gridViewPharmacyRates.Name = "gridViewPharmacyRates";
            // 
            // ParametersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 564);
            this.Controls.Add(this.ratesTabControl);
            this.IsMdiContainer = true;
            this.Name = "ParametersForm";
            this.Text = "Add Rates";
            ((System.ComponentModel.ISupportInitialize)(this.ratesTabControl)).EndInit();
            this.ratesTabControl.ResumeLayout(false);
            this.DeliveryPage.ResumeLayout(false);
            this.MovingPage.ResumeLayout(false);
            this.PharmacyPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDeliveryRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDeliveryRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMovingRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMovingRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPharmacyRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPharmacyRates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl ratesTabControl;
        private DevExpress.XtraTab.XtraTabPage MovingPage;
        private DevExpress.XtraGrid.GridControl gridControlMovingRates;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMovingRates;
        private DevExpress.XtraTab.XtraTabPage DeliveryPage;
        private DevExpress.XtraGrid.GridControl gridControlDeliveryRates;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDeliveryRates;
        private DevExpress.XtraTab.XtraTabPage PharmacyPage;
        private DevExpress.XtraGrid.GridControl gridControlPharmacyRates;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPharmacyRates;
    }
}
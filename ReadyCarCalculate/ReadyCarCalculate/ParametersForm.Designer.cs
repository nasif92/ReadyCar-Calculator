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
            this.gridControlDeliveryRates = new DevExpress.XtraGrid.GridControl();
            this.gridViewDeliveryRates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnItemSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBaseFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnServiceFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnLabourFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MovingPage = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlMovingRates = new DevExpress.XtraGrid.GridControl();
            this.gridViewMovingRates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PharmacyPage = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlPharmacyRates = new DevExpress.XtraGrid.GridControl();
            this.gridViewPharmacyRates = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ratesTabControl)).BeginInit();
            this.ratesTabControl.SuspendLayout();
            this.DeliveryPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDeliveryRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDeliveryRates)).BeginInit();
            this.MovingPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMovingRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMovingRates)).BeginInit();
            this.PharmacyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPharmacyRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPharmacyRates)).BeginInit();
            this.SuspendLayout();
            // 
            // ratesTabControl
            // 
            this.ratesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ratesTabControl.Location = new System.Drawing.Point(0, 0);
            this.ratesTabControl.Name = "ratesTabControl";
            this.ratesTabControl.SelectedTabPage = this.DeliveryPage;
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
            this.gridViewDeliveryRates.ColumnPanelRowHeight = 40;
            this.gridViewDeliveryRates.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnItemSize,
            this.gridColumnBaseFee,
            this.gridColumnServiceFee,
            this.gridColumnLabourFee});
            this.gridViewDeliveryRates.GridControl = this.gridControlDeliveryRates;
            this.gridViewDeliveryRates.Name = "gridViewDeliveryRates";
            this.gridViewDeliveryRates.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewDeliveryRates.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gridViewDeliveryRates_RowDeleted);
            this.gridViewDeliveryRates.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewDeliveryRates_RowUpdated);
            this.gridViewDeliveryRates.RowCountChanged += new System.EventHandler(this.gridViewDeliveryRates_RowCountChanged);
            // 
            // gridColumnItemSize
            // 
            this.gridColumnItemSize.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumnItemSize.AppearanceHeader.Options.UseFont = true;
            this.gridColumnItemSize.Caption = "Item Size";
            this.gridColumnItemSize.FieldName = "Item Size";
            this.gridColumnItemSize.MinWidth = 25;
            this.gridColumnItemSize.Name = "gridColumnItemSize";
            this.gridColumnItemSize.Visible = true;
            this.gridColumnItemSize.VisibleIndex = 0;
            this.gridColumnItemSize.Width = 94;
            // 
            // gridColumnBaseFee
            // 
            this.gridColumnBaseFee.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumnBaseFee.AppearanceHeader.Options.UseFont = true;
            this.gridColumnBaseFee.Caption = "Base Fee";
            this.gridColumnBaseFee.DisplayFormat.FormatString = "{0:00}";
            this.gridColumnBaseFee.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumnBaseFee.FieldName = "Base Fee";
            this.gridColumnBaseFee.MinWidth = 25;
            this.gridColumnBaseFee.Name = "gridColumnBaseFee";
            this.gridColumnBaseFee.Visible = true;
            this.gridColumnBaseFee.VisibleIndex = 1;
            this.gridColumnBaseFee.Width = 94;
            // 
            // gridColumnServiceFee
            // 
            this.gridColumnServiceFee.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumnServiceFee.AppearanceHeader.Options.UseFont = true;
            this.gridColumnServiceFee.Caption = "Service Fee";
            this.gridColumnServiceFee.DisplayFormat.FormatString = "{0:00}";
            this.gridColumnServiceFee.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumnServiceFee.FieldName = "Service Fee";
            this.gridColumnServiceFee.MinWidth = 25;
            this.gridColumnServiceFee.Name = "gridColumnServiceFee";
            this.gridColumnServiceFee.Visible = true;
            this.gridColumnServiceFee.VisibleIndex = 2;
            this.gridColumnServiceFee.Width = 94;
            // 
            // gridColumnLabourFee
            // 
            this.gridColumnLabourFee.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumnLabourFee.AppearanceHeader.Options.UseFont = true;
            this.gridColumnLabourFee.Caption = "Labour Charges";
            this.gridColumnLabourFee.DisplayFormat.FormatString = "c2";
            this.gridColumnLabourFee.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnLabourFee.FieldName = "Labour Charges";
            this.gridColumnLabourFee.MinWidth = 25;
            this.gridColumnLabourFee.Name = "gridColumnLabourFee";
            this.gridColumnLabourFee.Visible = true;
            this.gridColumnLabourFee.VisibleIndex = 3;
            this.gridColumnLabourFee.Width = 94;
            // 
            // MovingPage
            // 
            this.MovingPage.Controls.Add(this.gridControlMovingRates);
            this.MovingPage.Name = "MovingPage";
            this.MovingPage.Size = new System.Drawing.Size(1136, 530);
            this.MovingPage.Text = "Moving Rates";
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
            this.gridViewMovingRates.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridViewMovingRates.GridControl = this.gridControlMovingRates;
            this.gridViewMovingRates.Name = "gridViewMovingRates";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Item Size";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Base Fee";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Service Fee";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Labour Charges";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 94;
            // 
            // PharmacyPage
            // 
            this.PharmacyPage.Controls.Add(this.gridControlPharmacyRates);
            this.PharmacyPage.Name = "PharmacyPage";
            this.PharmacyPage.Size = new System.Drawing.Size(1136, 530);
            this.PharmacyPage.Text = "Pharmacy Rates";
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
            this.gridViewPharmacyRates.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridViewPharmacyRates.GridControl = this.gridControlPharmacyRates;
            this.gridViewPharmacyRates.Name = "gridViewPharmacyRates";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Item Size";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 94;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Base Fee";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 94;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Service Fee";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            this.gridColumn7.Width = 94;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Labour Charges";
            this.gridColumn8.MinWidth = 25;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            this.gridColumn8.Width = 94;
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDeliveryRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDeliveryRates)).EndInit();
            this.MovingPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMovingRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMovingRates)).EndInit();
            this.PharmacyPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPharmacyRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPharmacyRates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl ratesTabControl;
        private DevExpress.XtraTab.XtraTabPage MovingPage;
        private DevExpress.XtraTab.XtraTabPage DeliveryPage;
        private DevExpress.XtraGrid.GridControl gridControlDeliveryRates;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDeliveryRates;
        private DevExpress.XtraTab.XtraTabPage PharmacyPage;
        private DevExpress.XtraGrid.GridControl gridControlMovingRates;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMovingRates;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnItemSize;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBaseFee;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnServiceFee;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLabourFee;
        private DevExpress.XtraGrid.GridControl gridControlPharmacyRates;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPharmacyRates;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}
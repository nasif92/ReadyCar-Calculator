using DevExpress.XtraGrid;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ReadyCarCalculate
{
    public partial class ParametersForm : DevExpress.XtraEditors.XtraForm
    {
        private OuterForm outer;
        private string deliveryFile;
        private DataTable DeliveryTbl = new DataTable();
        private DataTable MovingTbl = new DataTable();
        private DataTable PharmacyTbl = new DataTable();

        public ParametersForm(OuterForm outerForm)
        {
            InitializeComponent();
            this.outer = outerForm;

            // load keyphrase.csv to gridview
            this.deliveryFile = Application.StartupPath + "\\data_values\\Delivery.csv";
            int[] numlist = { 1,2,3 };
            List<int> numList = new List<int>(numlist);
            this.DeliveryTbl = Backend.CustomUtil.LoadCsvToDataTable(deliveryFile, numlist);
            this.gridControlDeliveryRates.DataSource = this.DeliveryTbl;
        }

        // delivery rates
        private void gridViewDeliveryRates_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            this.ExportToCSV(gridControlDeliveryRates, deliveryFile);
        }

        private void gridViewDeliveryRates_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            this.ExportToCSV(gridControlDeliveryRates, deliveryFile);

        }

        private void gridViewDeliveryRates_RowCountChanged(object sender, System.EventArgs e)
        {
            this.ExportToCSV(gridControlDeliveryRates, deliveryFile);

        }


        // export to csv
        private void ExportToCSV(GridControl control, string filename)
        {           
            control.ExportToCsv(filename);
        }
    }
}
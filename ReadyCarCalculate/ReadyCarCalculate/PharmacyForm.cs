using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadyCarCalculate
{
    public partial class PharmacyForm : Form
    {
        public PharmacyForm()
        {
            InitializeComponent();
        }

        private static DataTable CreateWeightData()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Weight (lbs)", typeof(string));
            DataRow workRow = tbl.NewRow();

            tbl.Rows.Add(new Object[] { "Small (1-20 pounds)" });
            tbl.Rows.Add(new Object[] { "Medium (20-60 pounds)" });
            tbl.Rows.Add(new Object[] { "Large (60-200 pounds)" });
            tbl.Rows.Add(new Object[] { "XL (200+ pounds)" });
            DataRow newRow = tbl.NewRow();
            newRow["Weight (lbs)"] = DBNull.Value;
            tbl.Rows.InsertAt(newRow, 4);
            return tbl;
        }
    }


}

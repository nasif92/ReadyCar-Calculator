using DevExpress.XtraEditors;
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
    public partial class Form1 : Form
    {
        private string category;
        private double cost, costPerKm;
        private int labour, labourFee, discount;
        private bool addLabourFee;

        public Form1()
        {
            InitializeComponent();
            var dataSource = CreateCategoryData();

            this.lookUpEditCategory.Properties.DataSource = dataSource;
            this.lookUpEditCategory.Properties.DisplayMember = "Category";
        }


        private static DataTable CreateCategoryData()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Category", typeof(string));
            tbl.Columns.Add("Cost (base)", typeof(string));
            DataRow workRow = tbl.NewRow();

            tbl.Rows.Add(new Object[] {"Small Delivery Items (1-2 items)", "$ 10.00"});
            tbl.Rows.Add(new Object[] { "Medium Delivery Items (3-4 items)", "$ 20.00" });
            tbl.Rows.Add(new Object[] { "Large Delivery Items (5-6 items)", "$ 35.00" });
            tbl.Rows.Add(new Object[] { "XL Delivery (6+)", "$ 65.00" });

            return tbl;
        }



        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textEditDistance.EditValue == null)
                {
                    if (XtraMessageBox.Show("Please put distance data", "DATA MISSING!", MessageBoxButtons.OK) != DialogResult.OK)
                    {
                        return;
                    }
                }
                else
                {
                    int distance = Int32.Parse(textEditDistance.EditValue.ToString());
                }


                switch (this.category)
                {
                    case "Small Delivery Items (1-2 items)":
                        this.cost = 10;
                        this.costPerKm = 1.5;
                        this.labourFee = 5;
                        break;
                    case "Medium Delivery Items (3-4 items)":
                        this.cost = 20;
                        this.costPerKm = 2;
                        this.labourFee = 15;
                        break;
                    case "Large Delivery Items (5-6 items)":
                        this.cost = 35;
                        this.costPerKm = 2.5;
                        this.labourFee = 25;
                        break;
                    case "XL Delivery (6+)":
                        this.cost = 65;
                        this.costPerKm = 3.5;
                        this.labourFee = 25;
                        break;

                }

               
                if (!addLabourFee)
                {
                    this.labourFee = 0;
                    this.labelLabourFee.Text = "Labour Fee: $0.00";
                    this.labelCost.Text = "Cost: " + (this.cost + this.costPerKm * Double.Parse(this.textEditDistance.Text)) * 1.05;
       
                    this.labelServiceFee.Text = "Service Fee: $" + this.costPerKm * Double.Parse(this.textEditDistance.Text);
                }
                else
                {
                    this.labelLabourFee.Text = "Labour Fee: $" + this.labourFee * this.labour;
                    this.labelCost.Text = "Cost: " + (this.cost + this.costPerKm * Double.Parse(this.textEditDistance.Text) + (this.labourFee * this.labour)) * 1.05;
                    this.labelServiceFee.Text = "Service Fee: $" + this.costPerKm * Double.Parse(this.textEditDistance.Text);
                }

                if (this.discount != 0)
                {
                    double cost = ((this.cost + this.costPerKm * Double.Parse(this.textEditDistance.Text) + (this.labourFee * this.labour) * 1.05)) * this.discount/100;
                    double original = (this.cost + this.costPerKm * Double.Parse(this.textEditDistance.Text) + (this.labourFee * this.labour)) * 1.05;
                    this.labelCost.Text = "Cost: " + (original - cost);
                    this.labelDiscountAdded.Visible = true;
                }

            }
            catch 
            {
                    if (XtraMessageBox.Show("Invalid data or Missing Data", "DATA ERROR!", MessageBoxButtons.OK) != DialogResult.OK)
                    {
                        return;
                    }
            }

        }

        private void checkBoxAddLabourFee_CheckedChanged(object sender, EventArgs e)
        {
            if (!addLabourFee)
            {
                addLabourFee = true;
            }
            else
            {
                addLabourFee = false;
            }
        }

        private void comboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            discount = Int32.Parse(comboBoxDiscount.Text);
        }

        private void comboBoxLabour_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labour = Int32.Parse(comboBoxLabour.Text);
        }



        private void lookUpEditCategory_EditValueChanged(object sender, EventArgs e)
        {
            object obj = lookUpEditCategory.EditValue;
            category = lookUpEditCategory.Text;
            switch (this.category)
            {
                case "Small Delivery Items (1-2 items)":
                    this.textEditServiceFee.Text = "$1.50";
                    break;
                case "Medium Delivery Items (3-4 items)":
                    this.textEditServiceFee.Text = "$2.00";
                    break;
                case "Large Delivery Items (5-6 items)":
                    this.textEditServiceFee.Text = "$2.50";
                    break;
                case "XL Delivery (6+)":
                    this.textEditServiceFee.Text = "$3.50";
                    break;
            }
        }
    }
}

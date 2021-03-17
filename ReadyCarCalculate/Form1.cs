using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace ReadyCarCalculate
{
    public partial class Form1 : Form
    {
        private double cost, costPerKm;
        private int labour, labourFee, discount, category, weight;
        private bool addLabourFee;

        public Form1()
        {
            InitializeComponent();
            var dataSource = CreateCategoryData();

            this.lookUpEditCategory.Properties.DataSource = dataSource;
            this.lookUpEditCategory.Properties.DisplayMember = "Category";

            var weights = CreateWeightData();
            this.LookUpEditItemWeight.Properties.DataSource = weights;
            this.LookUpEditItemWeight.Properties.DisplayMember = "Weight (lbs)";
        }


        private static DataTable CreateCategoryData()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Category", typeof(string));
            tbl.Columns.Add("Cost (base)", typeof(string));
            DataRow workRow = tbl.NewRow();

            tbl.Rows.Add(new Object[] { "Small Delivery Items (1-2 items)", "$ 10.00" });
            tbl.Rows.Add(new Object[] { "Medium Delivery Items (3-4 items)", "$ 20.00" });
            tbl.Rows.Add(new Object[] { "Large Delivery Items (5-6 items)", "$ 35.00" });
            tbl.Rows.Add(new Object[] { "XL Delivery (6+)", "$ 65.00" });

            return tbl;
        }

        private static DataTable CreateWeightData()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Weight (lbs)", typeof(string));
            DataRow workRow = tbl.NewRow();

            tbl.Rows.Add(new Object[] {"Small (1-20 pounds)"});
            tbl.Rows.Add(new Object[] {"Medium (20-60 pounds)"});
            tbl.Rows.Add(new Object[] { "Large (60-200 pounds)" });
            tbl.Rows.Add(new Object[] {  "XL (200+ pounds)" });

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

                // check if the weight of the items is larger or the category is larger
                if (this.weight > this.category)
                {
                    doCalcution(this.weight);
                }
                else
                {
                    doCalcution(this.category);
                }

               
                if (!addLabourFee)
                {
                    this.labourFee = 0;
                    this.labelLabourFee.Text = "Labour Fee: $0.00";
                    this.labelCost.Text = "Cost: $ " + string.Format("{0:#.00}",(this.cost + this.costPerKm * Double.Parse(this.textEditDistance.Text)) * 1.05);
       
                    this.labelServiceFee.Text = "Service Fee: $" + string.Format("{0:#.00}", this.costPerKm * Double.Parse(this.textEditDistance.Text));
                }
                else
                {
                    this.labelLabourFee.Text = "Labour Fee: $" + this.labourFee * this.labour;
                    this.labelCost.Text = "Cost: $ " + string.Format("{0:#.00}", (this.cost + this.costPerKm * Double.Parse(this.textEditDistance.Text) + (this.labourFee * this.labour)) * 1.05);
                    this.labelServiceFee.Text = "Service Fee: $" + string.Format("{0:#.00}", this.costPerKm * Double.Parse(this.textEditDistance.Text));
                }

                if (this.discount != 0)
                {
                    double cost = ((this.cost + this.costPerKm * Double.Parse(this.textEditDistance.Text) + (this.labourFee * this.labour) * 1.05)) * this.discount/100;
                    double original = (this.cost + this.costPerKm * Double.Parse(this.textEditDistance.Text) + (this.labourFee * this.labour)) * 1.05;
                    this.labelCost.Text = "Cost: $ " + string.Format("{0:#.00}", (original - cost));
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

        private void doCalcution(int category)
        {
            switch (category)
            {
                case 1:
                    this.cost = 10;
                    this.costPerKm = 1.5;
                    this.labourFee = 5;
                    break;
                case 2:
                    this.cost = 20;
                    this.costPerKm = 2;
                    this.labourFee = 15;
                    break;
                case 3:
                    this.cost = 35;
                    this.costPerKm = 2.5;
                    this.labourFee = 25;
                    break;
                case 4:
                    this.cost = 65;
                    this.costPerKm = 3.5;
                    this.labourFee = 25;
                    break;

            }
        }



        private void CheckBoxAddLabourFee_CheckedChanged(object sender, EventArgs e)
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

        private void LookUpEditItemWeight_EditValueChanged(object sender, EventArgs e)
        {
            this.lookUpEditCategory.SelectedText = null;
            object obj = LookUpEditItemWeight.EditValue;
            string categoryWeight = LookUpEditItemWeight.Text;
            switch (categoryWeight)
            {
                case  "Small (1-20 pounds)":
                    this.textEditServiceFee.Text = "$1.50";
                    this.weight = 1;
                    break;
                case "Medium (20-60 pounds)":
                    this.textEditServiceFee.Text = "$2.00";
                    this.weight = 2;
                    break;
                case "Large (60-200 pounds)":
                    this.textEditServiceFee.Text = "$2.50";
                    this.weight = 3;
                    break;
                case "XL (200+ pounds)":
                    this.textEditServiceFee.Text = "$3.50";
                    this.weight = 4;
                    break;
            }

        }


        private void comboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            discount = Int32.Parse(comboBoxDiscount.Text);
        }

        private void ComboBoxLabour_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labour = Int32.Parse(comboBoxLabour.Text);
        }



        private void LookUpEditCategory_EditValueChanged(object sender, EventArgs e)
        {
            object obj = lookUpEditCategory.EditValue;
            string categoryType = lookUpEditCategory.Text;
            switch (categoryType)
            {
                case "Small Delivery Items (1-2 items)":
                    this.textEditServiceFee.Text = "$1.50";
                    this.category = 1;
                    break;
                case "Medium Delivery Items (3-4 items)":
                    this.textEditServiceFee.Text = "$2.00";
                    this.category = 2;
                    break;
                case "Large Delivery Items (5-6 items)":
                    this.textEditServiceFee.Text = "$2.50";
                    this.category = 3;
                    break;
                case "XL Delivery (6+)":
                    this.textEditServiceFee.Text = "$3.50";
                    this.category = 4;
                    break;
            }

        }
    }
}

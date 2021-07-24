using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace ReadyCarCalculate
{
    public partial class DeliveryForm : Form
    {
        private OuterForm outer;
        private double cost;
        private int labour, labourFee, discount, category, weight;
        private bool addLabourFee, deliveryForm;
        object dataSource;
        private int GST;
        private int noOfHours = 0;

        public DeliveryForm(OuterForm outer, bool del)
        {
            InitializeComponent();
            this.outer = outer;
            this.deliveryForm = del;
            if (deliveryForm)
            {
                dataSource = CreateCategoryData();
            }
            else
            {
                dataSource = CreateMovingData();
                this.checkBoxAddLabourFee.Visible = false;
                this.addLabourFee = true;
                this.labelTitle.Text = "Moving Quote Calculator";
                this.labelLabourCost.Visible = true;
                this.textEditLabourCostPerHour.Visible = true;
                this.labelLabourHours.Visible = true;
                this.textEditNoOfHours.Visible = true;
            }

            this.lookUpEditCategory.Properties.DataSource = dataSource;
            this.lookUpEditCategory.Properties.DisplayMember = "Category";
            this.comboBoxProvinces.SelectedIndex = 0;

            var weights = CreateWeightData();
            this.LookUpEditItemWeight.Properties.DataSource = weights;
            this.LookUpEditItemWeight.Properties.DisplayMember = "Weight (lbs)";
            this.textEditServiceFee.Properties.Mask.EditMask = "c";
            this.textEditServiceFee.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
        }

        // create category
        private static DataTable CreateCategoryData()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Category", typeof(string));
            tbl.Columns.Add("Cost (base)", typeof(string));
            DataRow workRow = tbl.NewRow();
            tbl.Rows.Add(new Object[] { "Handheld Items (prescriptions, small packages etc.)", "$ 8.00" });
            tbl.Rows.Add(new Object[] { "Small Delivery Items (1-2 items)", "$ 10.00" });
            tbl.Rows.Add(new Object[] { "Medium Delivery Items (3-4 items)", "$ 20.00" });
            tbl.Rows.Add(new Object[] { "Large Delivery Items (5-6 items)", "$ 35.00" });
            tbl.Rows.Add(new Object[] { "XL Delivery (6+)", "$ 65.00" });
            DataRow newRow = tbl.NewRow();
            newRow["Category"] = DBNull.Value;
            tbl.Rows.InsertAt(newRow, 5);
            return tbl;
        }

        // create weight data
        private static DataTable CreateWeightData()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Weight (lbs)", typeof(string));
            DataRow workRow = tbl.NewRow();

            tbl.Rows.Add(new Object[] {"Small (1-20 pounds)"});
            tbl.Rows.Add(new Object[] {"Medium (20-60 pounds)"});
            tbl.Rows.Add(new Object[] { "Large (60-200 pounds)" });
            tbl.Rows.Add(new Object[] {  "XL (200+ pounds)" });
            DataRow newRow = tbl.NewRow();
            newRow["Weight (lbs)"] = DBNull.Value;
            tbl.Rows.InsertAt(newRow, 4);
            return tbl;
        }

        // create moving category
        private static DataTable CreateMovingData()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Category", typeof(string));
            tbl.Columns.Add("Cost (base)", typeof(string));
            DataRow workRow = tbl.NewRow();
            tbl.Rows.Add(new Object[] { "Small (1-3)", "$ 35.00" });
            tbl.Rows.Add(new Object[] { "Med (4-6)", "$ 55.00" });
            tbl.Rows.Add(new Object[] { "Large (7-9)", "$ 75.00" });
            tbl.Rows.Add(new Object[] { "XL 10+", "$ 105.00" });
            DataRow newRow = tbl.NewRow();
            newRow["Category"] = DBNull.Value;
            tbl.Rows.InsertAt(newRow, 4);
            return tbl;
        }






        private void BtnCalculate_Click(object sender, EventArgs e)
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
                    double distance = Double.Parse(textEditDistance.EditValue.ToString());
                }

                // check if the weight of the items is larger or the category is larger
                if (this.weight > this.category)
                {
                    DoCalculation(this.weight);
                }
                else
                {
                    DoCalculation(this.category);
                }

                if (!deliveryForm)
                {
                    this.noOfHours = Int32.Parse(this.textEditNoOfHours.Text);
                }

                if (!addLabourFee)
                {
                    this.labourFee = 0;
                    this.labelLabourFee.Text = "Labour Fee: $0.00";
                    this.labelCost.Text = "Cost: $ " + string.Format("{0:#.00}", (this.cost + Double.Parse(this.textEditServiceFee.Text) * Double.Parse(this.textEditDistance.Text)) * (1 + 0.01 * this.GST));

                    this.labelServiceFee.Text = "Service Fee: $" + string.Format("{0:#.00}", Double.Parse(this.textEditServiceFee.Text) * Double.Parse(this.textEditDistance.Text));
                }
                else
                {
                    this.labelLabourFee.Text = "Labour Fee: $" + this.labourFee * this.labour * this.noOfHours;
                    this.labelCost.Text = "Cost: $ " + string.Format("{0:#.00}", (this.cost + Double.Parse(this.textEditServiceFee.Text) * Double.Parse(this.textEditDistance.Text) + (this.labourFee * this.labour * this.noOfHours)) * (1 + 0.01 * this.GST)) + (this.noOfHours * 25);
                    this.labelServiceFee.Text = "Service Fee: $" + string.Format("{0:#.00}", Double.Parse(this.textEditServiceFee.Text) * Double.Parse(this.textEditDistance.Text));
                }

                if (this.discount != 0)
                {
                    double cost = ((this.cost + Double.Parse(this.textEditServiceFee.Text) * Double.Parse(this.textEditDistance.Text) + (this.labourFee * this.labour * this.noOfHours) * 1.05)) * this.discount / 100;
                    double original = (this.cost + Double.Parse(this.textEditServiceFee.Text) * Double.Parse(this.textEditDistance.Text) + (this.labourFee * this.labour * this.noOfHours)) * 1.05;
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

        private void LookUpEditItemWeight_EditValueChanged(object sender, EventArgs e)
        {
            this.lookUpEditCategory.SelectedText = null;
            object obj = LookUpEditItemWeight.EditValue;
            string categoryWeight = LookUpEditItemWeight.Text;
            switch (categoryWeight)
            {
                case  "Small (1-20 pounds)":
                    this.textEditServiceFee.Text = "1.50";
                    this.weight = 1;
                    break;
                case "Medium (20-60 pounds)":
                    this.textEditServiceFee.Text = "2.00";
                    this.weight = 2;
                    break;
                case "Large (60-200 pounds)":
                    this.textEditServiceFee.Text = "2.50";
                    this.weight = 3;
                    break;
                case "XL (200+ pounds)":
                    this.textEditServiceFee.Text = "3.50";
                    this.weight = 4;
                    break;
            }

        }


        private void LookUpEditCategory_EditValueChanged(object sender, EventArgs e)
        {
            object obj = lookUpEditCategory.EditValue;
            string categoryType = lookUpEditCategory.Text;
            switch (categoryType)
            {
                case "Handheld Items (prescriptions, small packages etc.)":
                    this.textEditServiceFee.Text = "0.10";
                    this.weight = 0;
                    break;
                case "Small Delivery Items (1-2 items)":
                    this.textEditServiceFee.Text = "1.50";
                    this.category = 1;
                    break;
                case "Medium Delivery Items (3-4 items)":
                    this.textEditServiceFee.Text = "2.00";
                    this.category = 2;
                    break;
                case "Large Delivery Items (5-6 items)":
                    this.textEditServiceFee.Text = "2.50";
                    this.category = 3;
                    break;
                case "XL Delivery (6+)":
                    this.textEditServiceFee.Text = "3.50";
                    this.category = 4;
                    break;
                case "Small (1-3)":
                case "Med (4-6)":
                case "Large (7-9)":
                case "XL 10+":
                    this.textEditServiceFee.Text = "2.00";
                    CalculateMovingCost(categoryType);
                    break;
            }
        }

        // selected provincial gst calculation
        private void ComboBoxProvinces_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxProvinces.SelectedItem)
            {
                case "AB":
                case "BC":
                case "MB":
                case "QC":
                case "SK":
                    this.labelGst.Text = "GST: 5%";
                    this.GST = 5;
                    break;
                case "ON":
                    this.labelGst.Text = "GST/HST: 13%";
                    this.GST = 13;
                    break;
                case "NL":
                    this.labelGst.Text = "GST/HST: 15%";
                    this.GST = 15;
                    break;
            }
        }

        private void CalculateMovingCost(string category)
        {
            switch (category)
            {
                case "Small (1-3)":
                    this.cost = 35;
                    break;
                case "Med (4-6)":
                    this.cost = 55;
                    break;
                case "Large (7-9)":
                    this.cost = 75;
                    break;
                case "XL 10+":
                    this.cost = 105;
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

        private void comboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            discount = Int32.Parse(comboBoxDiscount.Text);
        }

        private void ComboBoxLabour_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labour = Int32.Parse(comboBoxLabour.Text);
        }

        private void DoCalculation(int category)
        {
            switch (category)
            {
                case 0:
                    this.cost = 8;
                    this.labourFee = 0;
                    break;
                case 1:
                    this.cost = 10;
                    this.labourFee = 5;
                    break;
                case 2:
                    this.cost = 20;
                    this.labourFee = 15;
                    break;
                case 3:
                    this.cost = 35;
                    this.labourFee = 25;
                    break;
                case 4:
                    this.cost = 65;
                    this.labourFee = 25;
                    break;
                // case moving
                case 5:
                    this.cost = 65;
                    this.labourFee = 25;
                    this.labour = Int32.Parse(this.textEditNoOfHours.Text);
                    break;

            }
        }
    }
}

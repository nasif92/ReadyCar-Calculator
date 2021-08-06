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
    public partial class Homeform : Form
    {
        private OuterForm outer;
        public Homeform(OuterForm outerForm)
        {
            this.outer = outerForm;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void btnDeliveryJob_Click(object sender, EventArgs e)
        {
            new DeliveryForm(outer, true) { MdiParent = this.outer }.Show();
        }

        private void btnMovingJob_Click(object sender, EventArgs e)
        {
            new DeliveryForm(outer, false) { MdiParent = this.outer }.Show();
        }

        private void barButtonCharts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void simpleButtonCharts_Click(object sender, EventArgs e)
        {
            new ChartsForm(outer) { MdiParent = this.outer }.Show();

        }
    }
}

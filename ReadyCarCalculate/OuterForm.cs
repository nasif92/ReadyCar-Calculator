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
    public partial class OuterForm : DevExpress.XtraEditors.XtraForm
    {
        public OuterForm()
        {
            InitializeComponent();
            new Homeform(this) { MdiParent = this, StartPosition = FormStartPosition.CenterScreen, }.Show();
        }

        private void btnAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new AboutForm(this) { MdiParent = this, StartPosition = FormStartPosition.CenterScreen, }.Show();
        }

        private void btnHome_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Homeform(this) { MdiParent = this, StartPosition = FormStartPosition.CenterScreen, }.Show();
        }
    }
}

using System.Windows.Forms;

namespace ReadyCarCalculate
{
    public partial class ParametersForm : DevExpress.XtraEditors.XtraForm
    {
        private OuterForm outer;

        public ParametersForm(OuterForm outerForm)
        {
            InitializeComponent();
            this.outer = outerForm;

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailStoreCashRegister.Forms
{
    public partial class SalesAndBillingForm : Form
    {
        public SalesAndBillingForm()
        {
            InitializeComponent();
        }

        public Panel GetPanelCategories() { return panelCategories; }

        public TextBox GetTxtFormula() { return txtFormula; }

        public FlowLayoutPanel GetFlowLayoutPanelProducts() { return flowLayoutPanelProducts; }
    }
}

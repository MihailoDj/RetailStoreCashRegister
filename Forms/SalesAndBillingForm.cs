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
        public Button GetBtnInsert0() { return btnInsert0; }
        public Button GetBtnInsert1() { return btnInsert1; }
        public Button GetBtnInsert2() { return btnInsert2; }
        public Button GetBtnInsert3() { return btnInsert3; }
        public Button GetBtnInsert4() { return btnInsert4; }
        public Button GetBtnInsert5() { return btnInsert5; }
        public Button GetBtnInsert6() { return btnInsert6; }
        public Button GetBtnInsert7() { return btnInsert7; }
        public Button GetBtnInsert8() { return btnInsert8; }
        public Button GetBtnInsert9() { return btnInsert9; }
        public Button GetBtnInsertComma() { return btnInsertComma; }
        public Button GetBtnTimes() { return btnTimes; }
        public Button GetBtnEnter() { return btnEnter; }
        public Button GetBtnCheckout() { return btnCheckout; }
        public Button GetBtnDeleteFormulaCharacter() { return btnDeleteFormulaCharacter; }
        public Button GetBtnClearFormula() { return btnClearFormula; }
        public Button GetBtnDeleteInvoiceItem() { return btnDeleteInvoiceItem; }
        public Button GetBtnSaveInvoice() { return btnSaveInvoice; }
        public Button GetBtnNewTransaction() { return btnNewTransaction; }
        public Label GetLblTotalPrice() { return lblTotalPrice; }
        public ListBox GetListBoxEntry() { return listBoxEntry; }
        public ListBox GetListBoxInvoice() { return listBoxInvoice; }
        public TabControl GetTablControlInvoice() { return tabControlInvoice; }

    }
}

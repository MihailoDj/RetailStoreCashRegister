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
    public partial class AdministrationAndStatisticsForm : Form
    {
        public AdministrationAndStatisticsForm()
        {
            InitializeComponent();
        }

        //TAB PAGE 1
        public TextBox GetTxtCategory() { return txtCategory; }

        public Button GetBtnAddCategory() { return btnAddCategory; }

        public Button GetBtnUpdateCategory() { return btnUpdateCategory; }

        public Button GetBtnDeleteCategory() { return btnDeleteCategory; }

        public ListBox GetListBoxCategory() { return listBoxCategory; }

        //TAB PAGE 2
        public ComboBox GetCbCategory() { return cbCategory; }

        public ComboBox GetCbUnitOfMeasure() { return cbUnitOfMeasure; }

        public TextBox GetTxtProductName() { return txtProductName; }

        public TextBox GetTxtProductPrice() { return txtProductPrice; }

        public Button GetBtnAddProduct() { return btnAddProduct; }

        public Button GetBtnUpdateProduct() { return btnUpdateProduct; }

        public Button GetBtnDeleteProduct() { return btnDeleteProduct; }

        public ListBox GetListBoxProduct() { return listBoxProduct; }

        //TAB PAGE 3
        public DateTimePicker GetDateTimePickerStats() { return dateTimePickerStats; }

        public Panel GetPanelStatistics() { return panelStatistics; }
    }
}

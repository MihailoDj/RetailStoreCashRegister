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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AdminAndStatsBtn_Click(object sender, EventArgs e)
        {
            AdministrationAndStatisticsForm adminForm = new();
            adminForm.ShowDialog();
        }

        private void SalesAndBillingBtn_Click(object sender, EventArgs e)
        {
            SalesAndBillingForm salesForm = new();
            salesForm.ShowDialog();
        }
    }
}

using RetailStoreCashRegister.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStoreCashRegister.Controllers
{
    public class MainController
    {
        private MainForm _form;

        public MainController(MainForm form)
        {
            _form = form;
            AddActionListeners();
        }

        private void AddActionListeners()
        {
            _form.GetAdminAndStatsButton().Click += new EventHandler(OpenAdminForm);
            _form.GetSalesAndBillingButton().Click += new EventHandler(OpenSalesForm);
        }

        private void OpenSalesForm(object sender, EventArgs e)
        {
            Coordinator.GetInstance().OpenSalesForm();
        }

        private void OpenAdminForm(object sender, EventArgs e)
        {
            Coordinator.GetInstance().OpenAdministrationForm();
        }
    }
}

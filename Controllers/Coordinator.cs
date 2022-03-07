using RetailStoreCashRegister.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStoreCashRegister.Controllers
{
    public class Coordinator
    {
        private static Coordinator _instance;
        private AdministrationController _administrationController;
        private SalesController _salesController;
        private MainController _mainController;

        private Coordinator()
        {
            
        }

        internal void SetMainForm(MainForm mainForm)
        {
            _mainController = new MainController(mainForm);
        }

        public static Coordinator GetInstance()
        {
            if (_instance == null)
                _instance = new Coordinator();
            return _instance;
        }

        public void OpenAdministrationForm()
        {
            _administrationController = new AdministrationController(new AdministrationAndStatisticsForm());
            _administrationController.OpenForm();
        }
        public void OpenSalesForm()
        {
            _salesController = new SalesController(new SalesAndBillingForm());
            _salesController.OpenForm();
        }
    }
}

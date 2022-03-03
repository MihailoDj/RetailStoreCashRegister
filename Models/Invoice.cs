using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStoreCashRegister.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public Dictionary<Product, double> ProductAmounts { get; set; }
        public DateTime BillingDate { get; set; }
        public decimal TotalPrice { get; set; }

        public Invoice()
        {
            ProductAmounts = new Dictionary<Product, double>();
            BillingDate = DateTime.Now;
        }
    }
}

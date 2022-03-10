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

        public Invoice()
        {
            ProductAmounts = new Dictionary<Product, double>();
            BillingDate = DateTime.Today.Date;
        }

        public double ComputeTotalPrice()
        {
            double totalPrice = 0;
            
            foreach(KeyValuePair<Product, double> product in ProductAmounts)
            {
                totalPrice += product.Key.Price * product.Value;
            }

            return Math.Round(totalPrice, 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RetailStoreCashRegister.Models.Enums;

namespace RetailStoreCashRegister.Models
{
    public class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public Category category { get; set; }
        public UnitOfMeasure UnitOfMeasure { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Product product &&
                   Id == product.Id &&
                   Price == product.Price &&
                   Name == product.Name &&
                   EqualityComparer<Category>.Default.Equals(category, product.category) &&
                   UnitOfMeasure == product.UnitOfMeasure;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Price, Name, category, UnitOfMeasure);
        }
    }
}

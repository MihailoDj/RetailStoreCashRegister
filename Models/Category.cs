using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStoreCashRegister.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Category()
        {

        }
        public Category(string name)
        {
            Name = name;
        }

        public override bool Equals(object? obj)
        {
            return obj is Category category &&
                   Id == category.Id &&
                   Name == category.Name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return Name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koe_23_5
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public decimal CalculateDiscountedPrice()
        {
            decimal discount = Price * 0.2m;
            decimal discountedPrice = Price - discount;
            return discountedPrice;
        }
    }

}

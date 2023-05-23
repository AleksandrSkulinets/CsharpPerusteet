using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Pizza
    {
        public List<Topping> Toppings { get; set; }
        public int basePrice { get; set; }
        public Pizza()
        {
            Toppings = new List<Topping>();
            basePrice = 15;
        }

        public int CalculatePrice()
        {
            int result = 0;
            if(Toppings.Count > 3)
            {
                result += Toppings.Count - 3;
            }
            return basePrice + result;
        }
    }
}

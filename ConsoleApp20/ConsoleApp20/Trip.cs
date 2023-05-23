using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Trip
    {
        // Properties

        public string Name { get; set; }
        public double Distance { get; set; }

        public double AverageConsumption { get; set; }

        public double FuelPrice { get; set; }
       
        private double privateProperty { get; set; }

        // Constructor

        public Trip(string name, double distance, double averageConsumption, double fuelPrice)
        {
            Name = name;
            Distance = distance;
            AverageConsumption = averageConsumption;
            FuelPrice = fuelPrice;

        }

        // Methods
        public double CalcullateCost()
        {
            return Distance * AverageConsumption * FuelPrice / 100;
        }

    }
}

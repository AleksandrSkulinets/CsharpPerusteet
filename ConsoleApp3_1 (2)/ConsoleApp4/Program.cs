using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Funktiot: Bensankulutus
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159675

            bool userEndsLoop = false;

            List<decimal> userDistances = new List<decimal>();
            List<decimal> userAverageConsumption = new List<decimal>();
            List<decimal> userfuelPrice = new List<decimal>();


            (decimal, decimal, decimal)[] trips = new (decimal, decimal, decimal)[1];

            while (userEndsLoop == false)
            {
                Console.Write("Syötä ajettu matka(km): ");
                decimal distance = decimal.Parse(Console.ReadLine());
                userDistances.Add(distance); ;

                Console.Write("Syötä ajeneuvon keskikulutus(l/100km): ");
                decimal averageConsumption = decimal.Parse(Console.ReadLine());
                userAverageConsumption.Add(averageConsumption);

                Console.Write("Syötä polttoaineen hinta(Euro/l): ");
                decimal fuelPrice = decimal.Parse(Console.ReadLine());
                userfuelPrice.Add(fuelPrice);

                trips[trips.Length - 1] = (distance, averageConsumption, fuelPrice);

                //decimal tripCost = carTripCostCalculator(distance, averageConsumption, fuelPrice);

                //Console.WriteLine(); // Tyhjä rivi
                //Console.WriteLine($"Ajetun matkan hinta on: {tripCost} euroa.");
                //Console.WriteLine(); // Tyhjä rivi


                Console.Write("Calculate another trip? (y/n)");
                string input = Console.ReadLine().ToLower();
                if (input == "n")
                {
                    userEndsLoop = true;
                }
                else
                {
                    trips = expandArray(trips);
                }
            }
            //Käydään listat läpi
            for (int i = 0; i < userDistances.Count; i++)
            {
                Console.WriteLine($" Matkan {i + 1} hinta on: {carTripCostCalculator(userDistances[i], userAverageConsumption[i], userfuelPrice[i])}");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }


        // Parametrien yksiköt joko kommentoidaan tai lisätään parametrien nimiin.
        private static decimal carTripCostCalculator(decimal distanceInKilomteres, decimal averageConsumption, decimal fuelCost)
        {
            decimal result = distanceInKilomteres * averageConsumption * fuelCost / 100;
            return result;
        }
        private static (decimal, decimal, decimal)[] expandArray((decimal, decimal, decimal)[] originalArray)
        {
            (decimal, decimal, decimal)[] newArray = new (decimal, decimal, decimal)[originalArray.Length + 1] ;
            for(int i=0; i < originalArray.Length;i++)
            {
                newArray[i] = originalArray[i];
            }
            return newArray;
        }


    }
}

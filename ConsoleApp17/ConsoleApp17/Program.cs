using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            //37 C# String: Lämpötilan seuranta
            #region
            // 1.Luo taulukko ja lista arvoille.

            string[] mesurementTimes = { "6:00", "12:00", "18:00", "24:00" };
            double[] temperaturesArray = new double[mesurementTimes.Length];
            List<double> temperaturesList = new List<double>();

            int numberOfReadingsPerDay = 4;
           
            // 2.Lue silmukka, jossa käyttäjän arvo luetaan ja tallennetaan taulukkoon ja listaan. (Arvo luetaan vain kerran per kierros ja se tallennetaan sekä taulukkoon ja listaan)

            for (int i=0; i <mesurementTimes.Length; i++)
            {
                Console.WriteLine($"Syötä kello {mesurementTimes[i]} lämpötila: ");
                double input = double.Parse(Console.ReadLine());
                   
                temperaturesArray[i] = input; // Taulukko
                temperaturesList.Add(input); // Lista
            }

            // 3a.Ilmoita suurin, pienin ja keskilämpötila käyttämällä valmiita metodeja.

            //array
            Console.WriteLine($"Taulukon suurin lämpötila on {temperaturesArray.Max()}");
            Console.WriteLine($"Taulukon pienin lämpötila on {temperaturesArray.Min()}");
            Console.WriteLine($"Taulukon keskilämpötila on {temperaturesArray.Average()}");
           //list
            Console.WriteLine($"Taulukon suurin lämpötila on {temperaturesList.Max()}");
            Console.WriteLine($"Taulukon pienin lämpötila on {temperaturesList.Min()}");
            Console.WriteLine($"Taulukon keskilämpötila on {temperaturesList.Average()}");

            // 3b.Suorita arvojen etsiminen omalla koodilla. (Kysy esim ChatGPT: How to find the smallest value in an array using for loop)
            int count = 0;
            double sum = 0;

            foreach(double temp in temperaturesArray)
            {
                sum += temp;
                count++;
            }
            Console.WriteLine($"Taulukon keskiarvo on {sum / count}");

            // Tässä algoritmi joka hakee listasta suurin arvo
            double value = 0;
            for(int i=0; i < temperaturesList.Count; i++)
            {
                if(i==0)
                {
                    value = temperaturesList[i];
                }
             //Onko uusi arvo suurempi kuin vanha arvo
             if(temperaturesList[i] > value)
                {
                    value = temperaturesList[i]; // otetaan talteen isompi arvo
                }
            }
            Console.WriteLine($"Listan suurin arvo on: {value}");

            // Tässä algoritmi joka hakee listasta pienimmän arvo

            double valueMin = 0;

            for (int i = 0; i < temperaturesList.Count; i++)
            {
                if (i == 0)
                {
                    valueMin = temperaturesList[i];
                }

                if (temperaturesList[i] < valueMin)
                {
                    valueMin = temperaturesList[i]; 
                }
            }
            Console.WriteLine($"Listan pienimmän arvo on: {valueMin}");
            #endregion

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

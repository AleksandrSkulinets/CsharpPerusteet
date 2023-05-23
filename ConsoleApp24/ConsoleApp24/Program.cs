using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä mitta (m): ");
            double meters = double.Parse(Console.ReadLine());

            Console.WriteLine($"{meters}m to centimeters{MeterConverter.ToCentimeter(meters)}");
            Console.WriteLine($"{meters}m to kilometres{MeterConverter.ToKilometer(meters)}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

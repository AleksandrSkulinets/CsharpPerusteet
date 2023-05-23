using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Funktiot: Kolmion pinta ala (Yhdessä päivä 9)
            #region
            Console.WriteLine("Syötä korkeus: ");
            double heightTriangle = double.Parse(Console.ReadLine());

            Console.WriteLine("Syötä korkeus: ");
            double baseTriangle = double.Parse(Console.ReadLine());

            double area = triangleArea(baseTriangle, heightTriangle);

            Console.WriteLine($"Kolmio pinta-ala: {area}");

            #endregion
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        private static double triangleArea(double baseTriangle , double heightTriangle)
        {

            return baseTriangle * heightTriangle /2;

        }
    }
}

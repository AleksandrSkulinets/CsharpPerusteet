using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Anna kolmion kanta");

            double triangleBase = double.Parse(Console.ReadLine());

            double triangleHeigt = double.Parse(Console.ReadLine());

            Console.WriteLine($"Kolmion pinta-ala: {triangleBase* triangleHeigt / 2}");

           Console.Write("Anna kolmion kanta");

            double triangleBase = double.Parse(Console.ReadLine());

            double triangleHeigt = double.Parse(Console.ReadLine());

            Console.WriteLine($"Kolmion pinta-ala: {triangleBase* triangleHeigt / 2}");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}

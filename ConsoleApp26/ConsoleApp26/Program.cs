using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.codewars.com/kata/59ca8246d751df55cc00014c/solutions/csharp

            Console.WriteLine(Hero(5, 3));
            Console.WriteLine(Hero(55, 13));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        public static bool Hero(int bullets, int dragons)
        {
            //Do Some Magic...
            return dragons * 2 <= bullets ? true : false;
        }
    }
}

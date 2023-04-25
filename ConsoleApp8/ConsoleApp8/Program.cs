using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            char star = '*';
            int number = int.Parse(Console.ReadLine());
            for (int i=1; i <= number; i++)
            {
                Console.Write(star);
            }
            Console.ReadKey();
        }
    }
}

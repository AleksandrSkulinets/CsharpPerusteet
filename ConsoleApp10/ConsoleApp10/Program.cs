using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of rows");
            int row = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < row; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine($"{row} accamulated to {sum}");

            Console.ReadKey();
        }
    }
}

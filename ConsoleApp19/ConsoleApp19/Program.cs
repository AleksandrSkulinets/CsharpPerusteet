using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someValuues = new int[4];
            someValuues[0] = 5;
            someValuues[1] = 8;
            someValuues[2] = 6;
            someValuues[3] = 100;

            Console.WriteLine(keski(someValuues));

            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
        private static double keski(int[] numbers)
        {
            int count = 0;
            double  sum = 0;
            foreach(double temp in numbers)
            {
                sum += temp;
                count++;
            }
            return sum / count;
            
        }
    }
}

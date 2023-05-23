using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SecondSymbol("Hello world" , 'H'));


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        public static int SecondSymbol(string str, char symbol)
        {
            int foundInstance = 0; 
            for (int i = 0; i < str.Length ; i++)
            {
                if (str[i] == symbol)
                    if (foundInstance > 1)
                    {
                        foundInstance++;
                    }
                    else
                    {
                        return i;
                    }
            }
            return -1;

        }
    }
}

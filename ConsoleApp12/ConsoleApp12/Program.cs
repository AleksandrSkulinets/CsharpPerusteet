using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialValue = 12d;
            for(int i = 1; i < 5; i++)
            {
                switch (i) {
                    case 1:
                        initialValue += i;
                        break;
                    case 2:
                        initialValue = initialValue * i;
                        break;
                    case 3:
                        initialValue /= i;
                        break;
                    case 4:
                        initialValue = initialValue - i;
                        break;

                
                
                
                }
                
            }

            Console.WriteLine(initialValue);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

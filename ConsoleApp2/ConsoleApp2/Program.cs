using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

                    
        
            Console.Write("Anna kuukauden numero");
            int monthNumber = int.Parse(Console.ReadLine());
            if (monthNumber == 11 || monthNumber == 12 || monthNumber == 1 || monthNumber == 2 || monthNumber == 3)
            {
                Console.WriteLine("Talvi");
            }
            else if (monthNumber == 4 || monthNumber == 5)
            {                
                Console.WriteLine("Kevät");  
            }
            else if (monthNumber == 6 || monthNumber == 7 || monthNumber == 9)
            {
                Console.WriteLine("Kesä");
            }
            else if(monthNumber == 9 || monthNumber == 10 )
            {
                Console.WriteLine("Syksy");
            }
            else
            {
                Console.WriteLine("wrong input");
            }
            Console.ReadKey();
        }
    }
}

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
            //Console.Write("Anna kuukauden numero");
            //int monthNumber = int.Parse(Console.ReadLine());
            //if (monthNumber == 11 || monthNumber == 12 || monthNumber == 1 || monthNumber == 2 || monthNumber == 3)
            //{
            //    Console.WriteLine("Talvi");
            //}
            //else if (monthNumber == 4 || monthNumber == 5)
            //{
            //    Console.WriteLine("Kevät");
            //}
            //else if (monthNumber == 6 || monthNumber == 7 || monthNumber == 9)
            //{
            //    Console.WriteLine("Kesä");
            //}
            //else if (monthNumber == 9 || monthNumber == 10)
            //{
            //    Console.WriteLine("Syksy");
            //}
            //else
            //{
            //    Console.WriteLine("wrong input");
            //}
            // Console.ReadKey();
            //Console.WriteLine("Anna kuukausi numero : ");
            //int MonthSwitch = int.Parse(Console.ReadLine());
            //switch(MonthSwitch)
            //{
            //    case 11:
            //    case 12:
            //    case 1:
            //    case 2:
            //    case 3:
            //        Console.WriteLine("Talvi kuukausi");
            //        break;
            //    case 4:
            //    case 5:
            //        Console.WriteLine("Kevät kuukausi");
            //        break;
            //    case int xyz when ( xyz >= 6 && xyz <= 8):
            //        Console.WriteLine("Kesä kuukausi");
            //        break;
            //    case int xyz when (xyz >= 9 && xyz <= 10):
            //        Console.WriteLine("Syys kuukausi ");
            //        break;
            //    default:
            //        Console.WriteLine("Virheellinen numero");
            //        break;


            //}
            //Console.ReadKey();
            Console.Write("Kuukausi numero");
            int monthTernary = int.Parse(Console.ReadLine());
            string message = "";
            Console.WriteLine(message);
            message = monthTernary == 11 || monthTernary == 12 || monthTernary >= 1 && monthTernary <= 3 ? "Talvi" : 
            monthTernary >= 4 && monthTernary <= 5 ? "Kevät" :
            monthTernary >= 6 && monthTernary <= 8 ? "Kesä" : 
            monthTernary >= 9 && monthTernary <= 10 ? "Syksy" : "Virheellinen arvo";
            Console.WriteLine(message);


            Console.ReadKey();
        }
    }
}

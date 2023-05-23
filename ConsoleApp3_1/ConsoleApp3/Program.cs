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
            //Console.WriteLine("Syötä numero: ");
            //double input = double.Parse(Console.ReadLine());
            //Console.WriteLine("Choose 1-CaloriestoJoules, 2- JoulestoCalories ");
            //int choise = int.Parse(Console.ReadLine());
            //if (choise==1)
            //{
            //    double j = CaloriestoJoules(input);
            //    Console.WriteLine($"Calories {input} are equals to {j} joules");
            //}
            //if(choise==2)
            //{
            //    double c = JoulestoCalories(input);
            //    Console.WriteLine($"Joules {input} are equals to {c} calories");
            //}

            #region
            Console.WriteLine("Syötä kalorit: ");
            decimal calories = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Syötä joules: ");
            decimal joules = decimal.Parse(Console.ReadLine());


            Console.WriteLine($" CaloriestoJoules: {CaloriestoJoules(calories)}");
            Console.WriteLine($"JoulestoCalories: {JoulestoCalories(joules)}");
            #endregion

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        private static decimal CaloriestoJoules(decimal calories)
        {
            return calories * 4.184m;
        }
        private static decimal JoulestoCalories(decimal joules)
        {
            return joules * 0.2390m;
        }
        //private static double CaloriestoJoules(double input)
        //{


        //    return input * 4.184 ;

        //}
        //private static double JoulestoCalories (double input)
        //{


        //    return input * 0.2390; ;

        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {


            #region
            //1. Funktio/Function
            // UUSI TERMI: olio/object
            //olio on instanssi

            Program test = new Program();
            test.printText("Hello",123);
            test.printText("World",321);


            Console.WriteLine("");
            // Program.mutiplyNumbers(5 , 3);
            int FiveTimesThree = mutiplyNumbers(5, 3);
            Console.WriteLine(mutiplyNumbers(5, 3));

            #endregion
            // Luoka /class     
            #region
            #endregion
            #region
            #endregion
            #region
            #endregion


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        } //Main funktio

        //Uusi metodi
        //[näkyvyys][palautettavaDatatyyppi][metodinNimi]([parametrit], pilkulla eroteltuna)
        private void printText(string message, int number)
        {
            Console.WriteLine($"Text :{message}{number}");
        }
        public static int mutiplyNumbers(int number1, int number2)
        {
            // public näkyy luokan ulkopuolille
            // static - tekee metodista staattisen
            // int - palauta int arvo
            return number1*number2;
        }
    } //Class programm

} //Namespace

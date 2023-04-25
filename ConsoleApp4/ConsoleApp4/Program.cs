using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            int sumWhileLoop = 0;
            bool continueLoop = true; // Muuttuja, jota käytetään while silmukan ehtona. Kun käyttäjä syöttää merkin 'e', annetaan muuttujan arvoksi false ja silmukka päättyy.
            string input = "";
            Console.WriteLine("Anna summattavia lukuja: (e päättää lukujen summauksen)");
            while (continueLoop)
            {
                input = Console.ReadLine();
                if (input == "e")
                {
                    continueLoop = false;
                }
                else
                {
                    sumWhileLoop += int.Parse(input);
                }
            }
            Console.WriteLine($"Summa: {sumWhileLoop}");

        }
    }
}

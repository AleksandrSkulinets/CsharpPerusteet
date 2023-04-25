using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            // 34B C# Vokaalit taulukkoon
            // 1.Lue käyttäjältä sana talteen

            Console.Write("Syötä sana ");
            string userInput = Console.ReadLine();


            // 2.Luo taulukko sanan vokaaleille

            char[] vokalsInWord = new char[userInput.Length];

            List<char> vocalsUsingList = new List<char>();

            // 3.Käy sanan merkit läpi silmukassa

            for (int i = 0; i < userInput.Length; i++)
            {
            // 4.Tallenna merkki taulukkoon, jos se on vokaali.
                
                if (userInput[i] == 'a' || userInput[i] == 'e' ||
                    userInput[i] == 'i' || userInput[i] == 'o' || userInput[i] == 'u'||
                    userInput[i] == 'y' || userInput[i] == 'ä' || userInput[i] == 'ö' )
                {
                    vokalsInWord[i] = userInput[i];
                    vocalsUsingList.Add(userInput[i]);

                }

            }

            // 5.Luo silmukka, jossa tulostetaan vokaalit taulukosta käyttäjälle.

            foreach (char symbol in vokalsInWord)
            {
                if (symbol != 0)
                {
                    Console.WriteLine(symbol);
                }
            }
            for(int i=0; i < vocalsUsingList.Count; i++)
            {
                Console.WriteLine("Lista:" + vocalsUsingList[i]);
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

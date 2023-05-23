using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;



            //Dice noppa1 = new Dice(6);            
            //Dice noppa2 = new Dice(6,1);
            //do
            //{
            //    noppa1.Roll();
            //    noppa2.Roll();

            //    Console.WriteLine($"Noppan 1 silmäluku on: {noppa1.Value}");
            //    Console.WriteLine($"Noppan 2 silmäluku on: {noppa2.Value}");
            //    if (noppa1.Value > noppa2.Value)
            //        Console.WriteLine("player 1 wins");
            //    else if (noppa1.Value < noppa2.Value)
            //        Console.WriteLine("Player 2 wins");
            //    else if (noppa1.Value == noppa2.Value)
            //        Console.WriteLine("Draw");
            //} while(noppa1.Value != noppa2.Value);


            //List < ShoppingList > order = new List<ShoppingList>();

            Console.Write("Mihin kauppaan tehdään ostoslista: ");
            string shop = Console.ReadLine();

            ShoppingList newOrder = new ShoppingList(shop);

            // Waterfall - Agile Waterfall (scrum) - Agile(pari ohjelmointi)
            bool userExitsProductsLoop = false;
            do // Käyttäjä lisää ostoksia
            {
                Console.Clear();
                Console.WriteLine($"Valittu kauppa on {newOrder.ShopName}");
                Console.WriteLine();
                newOrder.PrintProduct();

                Console.Write("Syötä tuote ja lukumäärä(maito, 3): ");
                string input = Console.ReadLine();
                if (input != "")
                {
                    string[] splitInput = input.Split(',');
                    int amount = int.Parse(splitInput[1].Trim());

                    // Lisätään tuote listaan käyttäjän syöttämän luvun verran
                    for (int i = 1; i <= amount; i++)
                    {
                        newOrder.AddProduct(splitInput[0]);
                    }
                }
                else
                {
                    userExitsProductsLoop = true;
                }
            } while (userExitsProductsLoop != true); // TODO this condition

             Console.WriteLine();

             Console.WriteLine($"Ostoksien summa on: {newOrder.Sum}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

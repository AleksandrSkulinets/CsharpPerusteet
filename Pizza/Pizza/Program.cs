using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Topping> allToppings = new List<Topping>
            { new Topping("Pepperoni"),
              new Topping ("Herkkusieni"),
              new Topping ("Oliivi"),
              new Topping ("Jauheliha"),
              new Topping("Tonnikala")};

            List<string> userToppings = new List<string>();

            Pizza userPizza = new Pizza();

            bool userIsDoneOrdering = false;

            while (userIsDoneOrdering == false)
            {
                Console.Clear();

                Console.WriteLine("Pizzan tilaus: ");
                Console.WriteLine();

                Console.WriteLine("Valitut täytteet: ");
                Console.WriteLine();
                for (int i = 0; i < allToppings.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{allToppings[i].Name} ");
                }

                Console.WriteLine();
                //Console.WriteLine("Vaihtoehdot: ");
                //Console.WriteLine("1. Pepperoni");
                //Console.WriteLine("2. Herkkusieni");
                //Console.WriteLine("3. Oliivi");
                //Console.WriteLine("4. Jauheliha");
                //Console.WriteLine("5. Tonnikala");

                Console.WriteLine();

                Console.WriteLine($"Syötä täytteet (1-{allToppings.Count} tai e): ");
                string input = Console.ReadLine();
                if(input=="e")
                {
                    userIsDoneOrdering = true;
                }
                else
                {
                    int indexOfTopping = int.Parse(input) - 1;
                    Topping tempTopping = allToppings[indexOfTopping];
                    userPizza.Toppings.Add(tempTopping);
                    //userPizza.Toppings.Add(allToppings[int.Parse(input)-1]);
                }

                //switch(input)
                //{
                //    case "1":
                //        userToppings.Add("Pepperoni");
                //        break;
                //    case "2":
                //        userToppings.Add("Herkkusieni");
                //        break;
                //    case "3":
                //        userToppings.Add("Oliivi");
                //        break;
                //    case "4":
                //        userToppings.Add("Jauheliha");
                //        break;
                //    case "5":
                //        userToppings.Add("Tonnikala");
                //        break;
                //    case "e":
                //        userIsDoneOrdering = true;
                //        break;
                //    default:

                //        break;
                //}

            }
            Console.WriteLine();

            //int price = 15;
            //if(userToppings.Count > 3)
            //{
            //    price += userToppings.Count - 3;
            //}
            int price = userPizza.CalculatePrice();
            Console.Clear();
            Console.WriteLine("Tilaus :");
            for (int i = 0; i < userPizza.Toppings.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{userPizza.Toppings[i].Name} ");
            }
            Console.WriteLine();
          
            Console.WriteLine($"Summa on : {price} euroa");
            Console.WriteLine();
            Console.WriteLine("Hyväksy tilaus (k) :");
            string userOrders = Console.ReadLine();
            if (userOrders =="k")
            {
                Console.WriteLine("Syötä osoite : ");
                string adress = Console.ReadLine();
                Console.WriteLine("Tilaus lahetu ");
            }
            else
            {
                Console.WriteLine("Tilaus peruttu.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

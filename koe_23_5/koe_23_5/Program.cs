using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koe_23_5
{
    class JavelinThrow
    {
        int Id { get; set; }
        string AthleteName { get; set; }
        int Meters { get; set; }
        int Centimeters { get; set; }
        public JavelinThrow(int id, string athleteName, int meters, int centimeters)
        {
            Id = id;
            AthleteName = athleteName;
            Meters = meters;
            Centimeters = centimeters;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Product> products = new List<Product>();

            Console.WriteLine("Add a product: ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter product details {i + 1}:");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                Product product = new Product(id, name, price);
                products.Add(product);

                Console.WriteLine("Product added");
                Console.WriteLine();
            }

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"Id: {products[i].Id}, Name: {products[i].Name}, Price: {products[i].Price}, Discounted Price: {products[i].CalculateDiscountedPrice()}");
            }



            List<JavelinThrow> throws = new List<JavelinThrow>();


            Console.Write("Enter name of thrower:");
            string tname = Console.ReadLine();

            Console.Write("Enter meters:");
            int meters = int.Parse(Console.ReadLine());

            Console.Write("Enter centimeters:");
            int centimeters = int.Parse(Console.ReadLine());

            int throwId = throws.Count + 1;

            JavelinThrow newThrow = new JavelinThrow(throwId, tname, meters, centimeters);

            throws.Add(newThrow);

            Console.WriteLine("New throw added!");


            bool isInputCorrect = false;

            while (!isInputCorrect)
            {
                Console.WriteLine("Enter a phone number: ");
                string phoneInput = Console.ReadLine();

                if (phoneInput.StartsWith("+358") && phoneInput.Length == 13 && phoneInput.Substring(1).All(char.IsDigit))
                {
                    Console.WriteLine("Input correct");
                    isInputCorrect = true;
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            } 

            string user1 = Username("John", "DoeDoeDoe");
            Console.WriteLine("User 1: " + user1); 
            
            string user2 = Username("Tom", "Smith");
            Console.WriteLine("User 2: " + user2);

            string user3 = Username("Ana", "Hill");
            Console.WriteLine("User 3: " + user3);

            string user4 = Username("P", "J");
            Console.WriteLine("User 4: " + user4);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        public static string Username(string firstName, string lastName)
        {
            string result = "";
            if (lastName.Length >= 5 && firstName.Length >= 3)
            {
                string last5 = lastName.Substring(0, 5);
                string first3 = firstName.Substring(0, 3);
                result = last5 + first3;
            }
            else if (lastName.Length < 5 && firstName.Length >= 3)
            {
                string last5 = lastName.Substring(0, lastName.Length);
                string first3 = firstName.Substring(0, 3);
                result = last5 + first3;
            }
            else if (firstName.Length < 3 && lastName.Length >= 5)
            {
                string last5 = lastName.Substring(0, 5);
                string first3 = firstName.Substring(0, firstName.Length);
                result = last5 + first3;
            }
            else if (lastName.Length < 5 && firstName.Length < 3)
            {
                string last5 = lastName.Substring(0, lastName.Length);
                string first3 = firstName.Substring(0, firstName.Length);
                result = last5 + first3;
            }
            return result;
        }
    }
   
}

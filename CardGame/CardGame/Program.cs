using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {

            //All cards in game
            Deck deck = new Deck();

            //Player's 1 hand
            Deck player1Deck = new Deck();
            // Player's 2 hand
            Deck player2Deck = new Deck();

            deck.GenerateCards();
            deck.Shuffle();

            player1Deck.Cards.Add(deck.Draw());
               
            player2Deck.Cards.Add(deck.Draw());
                
                if (player1Deck.Cards[0].Value > player2Deck.Cards[0].Value)
                {
                    Console.WriteLine("Player 1 wins!");
                }
                else if (player1Deck.Cards[0].Value < player2Deck.Cards[0].Value)
                {
                    Console.WriteLine("Player 2 wins!");
                }
                else
                {
                    if(player1Deck.Cards[0].Suite > player2Deck.Cards[0].Suite)
                    {
                        Console.WriteLine("Player 1 wins!");
                    }
                    else
                    {
                        Console.WriteLine("Player 2 wins!");
                    }
                
                }

            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

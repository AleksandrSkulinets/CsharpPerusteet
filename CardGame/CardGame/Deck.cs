using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Deck
    {   
        //Properties

        //List of Card objects
        public List<Card> Cards = new List<Card>();



        //Methods
        public void GenerateCards()
        {
            const int numberOfValues = 13;

            for (int i = 1; i <= numberOfValues; i++)
            {
                foreach (Card.Suites suite in Enum.GetValues(typeof(Card.Suites)))
                {
                    Cards.Add(new Card(i, suite));
                }
            }
        }
        public Card Draw()
        {
            Card tempCard = Cards[0];
            Cards.RemoveAt(0);

            return tempCard;
        }
        public void Shuffle()
        {
            Random random = new Random();
            int n = Cards.Count;
            while(n>1)
            {
                n--;
                int k = random.Next(n + 1);
                Card temp = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = temp;
            }

            //for(int i= Cards.Count - 1; i > 0;i--)
            //{
            //    int j = random.Next(i + 1);
            //    Card temp = Cards[i];
            //    Cards[i] = Cards[j];
            //    Cards[j] = temp;
            //}

        }
    }
}

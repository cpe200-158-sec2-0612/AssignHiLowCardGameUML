using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Deck
    {
        private List<Card> _cards;
        //properties
        public List<Card> Cards
        {
            get { return _cards; }
            set { _cards = new List<Card>(value); }
        }

        //constructor
        public Deck()
        {
            Cards = new List<Card>(52); // this is the box of cards , not cards
            // 1 is ACE is The highest rank and 13 is KING is the lowest rank
            string[] CardFace = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" }; //face
            string[] CardSuit = { "Spades", "Hearts", "Diamonds", "Clubs" }; //suits
            //Card [] Decks = new Card[52]; //num of cards
            for (int i = 0; i < CardSuit.Length; i++)
            {
                for (int j = 0; j < CardFace.Length; j++)
                {

                    Card c = new Card(CardFace[j], CardSuit[i], j + 1); //creat a card that have face and suit
                    //Cards.Add(new Card(CardFace[j], CardSuit[i], j + 1)); 
                    Cards.Add(c); // input all cards to a box = master box
                }
            }
            ShuffleCard();
        }
        //function
        public void ShuffleCard() //shuffle card in a box
        {
            List<Card> randomList = new List<Card>(); //create a new box of cards
            Random rnd = new Random();
            while (Cards.Count > 0) // count quantity of cards in a master box
            {
                int index = rnd.Next(0, Cards.Count); //pick a random item from the master box
                randomList.Add(Cards[index]); //place it at the end of the randomized list = stack
                Cards.RemoveAt(index); // remove that card was copied
            }
            Cards = randomList; // a new box become a master box

        }

        public Card DrawCard() // draw cards
        {
            Card c = Cards.ElementAt(0); //copy cards to keep in c variable
            Cards.RemoveAt(0); // remove that card
            return c; // the lastest card in the box
        }
        public void PutBack(List<Card> c) // put cards back
        {
            Cards = Cards.Concat(c).ToList();   // merg cards and c then make it list
            ShuffleCard();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Player
    {
        private string _namePlayer;
        //private int _numPlayer; numplayer can use by List 
        private int _score = 0; // quantity of cards in their hand
        private List<Card> _cardInHand = new List<Card>();

        public string NamePlayer
        {
            get { return _namePlayer; }
            set { _namePlayer = value; }
        }

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }
        public List<Card> CardInHand
        {
            get { return _cardInHand; }
        }

        //constructor
        public Player(string nm) //26 cards for each player
        {
            NamePlayer = nm;
        }

        //funtion
        public void DrawToHand(Deck dck)
        {
            _cardInHand.Add(dck.DrawCard()); //player draw card into hand then save cards in hand
        }
        //clear cards in hand
        public void ClearCardsInHand()
        {
            _cardInHand = new List<Card>();
        }
        public Card LastCardInHand()
        {
            int numCards = CardInHand.ToArray().Length;
            return CardInHand.ElementAt(numCards - 1); // you got the lastest card
        }
        public void ShowCard() //show card in hand
        {
            Console.WriteLine(NamePlayer + " got " + LastCardInHand().Face + " " + LastCardInHand().Suit + "------ Rank is :" + LastCardInHand().Rank);
        }
    }
}

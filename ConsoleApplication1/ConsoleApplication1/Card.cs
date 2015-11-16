using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Card
    {
        private string _face;
        private string _suit;
        private int _rank;
        // 1 is ACE is The highest rank and 13 is KING is the lowest rank
        //private string[] CardFace = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        //private string[] CardSuit = { "Spades", "Hearts", "Diamonds", "Clubs" };



        //properties
        public string Face
        {
            get { return _face; }
            set { _face = value; }
        }
        public string Suit
        {
            get { return _suit; }
            set { _suit = value; }
        }
        public int Rank
        {
            get { return _rank; }
            set
            {
                _rank = (value >= 1 && value <= 13) ? value : 0;
            }
        }
        //constructor
        public Card(string f, string s, int r)
        {
            Face = f;
            Suit = s;
            Rank = r;
        }
        //function for compare rank card
        public int compareTo(Object o)
        {
            Card other = (Card)o;
            return Rank - other.Rank;
            //return _rank - other.Rank;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Game
    {
        public void Start()
        {
            Console.WriteLine("Welcome to The HIGH-LOW Games");
            Console.WriteLine("Let's Have some FUN!");

            Console.WriteLine("First Player Name :");
            string name1 = Console.ReadLine();

            Console.WriteLine("Second Player Name :");
            string name2 = Console.ReadLine();
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

            Player p1 = new Player(name1);
            Player p2 = new Player(name2);

            Deck deck = new Deck(); //create deck for play game

            while (deck.Cards.ToArray().Length > 0)
            {
                p1.DrawToHand(deck);
                p2.DrawToHand(deck);

                p1.ShowCard();
                p2.ShowCard();
                //Console.WriteLine(p1.NamePlayer + " got " + p1.LastLastCardInHand()().Face + " " + p1.LastLastCardInHand()().Suit + "" + p1.LastLastCardInHand()().Rank);
                //Console.WriteLine(p2.NamePlayer + " got " + p2.LastCardInHand().Face + " " + p2.LastCardInHand().Suit + "" + p2.LastCardInHand().Rank);

                if (p1.LastCardInHand().Rank < p2.LastCardInHand().Rank)
                {
                    p1.Score = p1.Score + 2;
                    Console.WriteLine(p1.NamePlayer + " Score is " + p1.Score);
                }
                else if (p1.LastCardInHand().Rank > p2.LastCardInHand().Rank)
                {
                    p2.Score = p2.Score + 2;
                    Console.WriteLine(p2.NamePlayer + " Score is " + p2.Score);
                }
                else //when rank card is equal
                {
                    int oldRank = p1.LastCardInHand().Rank; //keep old rank for draw cards  to looping for
                    for (int i = 0; (i < oldRank) && (deck.Cards.ToArray().Length > 0); i++) //draw card as number of rank from deck
                    {
                        p1.DrawToHand(deck);
                        p2.DrawToHand(deck);
                    }
                    p1.ShowCard(); // show last card
                    p2.ShowCard();
                    Console.WriteLine(2 + (oldRank * 2));
                    if (p1.LastCardInHand().Rank < p2.LastCardInHand().Rank)
                    {
                        p1.Score = p1.Score + 2 + (oldRank * 2);
                        Console.WriteLine(p1.NamePlayer + " Score is " + p1.Score);
                    }
                    else if (p1.LastCardInHand().Rank > p2.LastCardInHand().Rank)
                    {
                        p2.Score = p2.Score + 2 + (oldRank * 2);
                        Console.WriteLine(p2.NamePlayer + " Score is " + p2.Score);
                    }
                    else
                    {
                        deck.PutBack(p1.CardInHand); // putback all cards in hand to deck
                        deck.PutBack(p2.CardInHand);
                        p1.ClearCardsInHand(); //clear all cards in hand
                        p2.ClearCardsInHand();
                    }

                }

                Console.WriteLine("#########################################################");
            }

            if (p1.Score > p2.Score)
            {
                Console.WriteLine(p1.NamePlayer + " is The winner with " + p1.Score + " score ");

            }
            else if (p1.Score < p2.Score)
            {
                Console.WriteLine(p2.NamePlayer + " is The winner with " + p2.Score + " score ");
            }
            else
            {
                Console.WriteLine(p1.NamePlayer + " and " + p2.NamePlayer + " Draw!!");
            }



        }
    }
}

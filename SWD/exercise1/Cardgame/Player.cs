using System;
using System.Dynamic;

namespace exercise1
{
    class Player
    {
        public Player(string n)
        {
            NoCards = 0;
            ValueOfCards = 0;
            Name = n;
            Hand = new List<Cards>();
        }
        public string Name{get;set;}
        public int NoCards{get;set;}
        public int ValueOfCards{get;set;}
        public List<Cards> Hand{get;set;}
        public int totalValue()
        {
            return ValueOfCards;
        }
        public virtual void receiveCard(Cards x)
        {
            NoCards += 1;
            ValueOfCards += x.Value;
            Hand.Add(x);
        }
        public void showHand()
        {
            Console.WriteLine("Cards in hand for player " + Name, ": ");
            foreach (var cards in Hand)
            {
                Console.WriteLine(cards.Color + ", " + cards.Number);
            }
        }
    }

    class weakPlayer : Player
    {
        public weakPlayer(string n) : base(n){}
        public override void receiveCard(Cards x)
        {
            if(NoCards < 3)
            {
                base.receiveCard(x);
            }
        }
    }
}
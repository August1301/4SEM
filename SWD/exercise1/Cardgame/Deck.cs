using System;

namespace exercise1
{
    class Deck
    {
        public Deck(int size)
        {
            NumberOfColors = 5;
            DeckSize = size;
            Stack = new List<Cards>();
            Random random = new Random();
            Cards card;
            for(var i = 0;i<DeckSize/NumberOfColors;i++)
            {
                card = new RedCard(random.Next(1,9),"red");
                Stack.Add(card);
                card = new YellowCard(random.Next(1,9),"yellow");
                Stack.Add(card);
                card = new BlueCard(random.Next(1,9),"blue");
                Stack.Add(card);
                card = new GreenCard(random.Next(1,9),"green");
                Stack.Add(card);
                card = new GoldCard(random.Next(1,9),"gold");
                Stack.Add(card);
            }
        }
        private int DeckSize{get;set;}
        public List<Cards> Stack{get;set;}
        private int NumberOfColors{get;set;}
        public void DealCards(Player player, int amount)
        {
            Random random = new Random();
            for(var i = 0;i<amount;i++)
            {
                Cards lastCard = Stack.Last();
                player.receiveCard(lastCard);
                Stack.RemoveAt(Stack.Count - 1);
            }
        }
    }
}
using System;
using System.Linq;

namespace exercise1
{
    class Game
    {
        public List<Player> Competors{get;set;}
        public Deck Deck_{get;set;}

        public Game()
        {
            Competors = new List<Player>();
            Deck_ = new Deck(50);
        }
        public void JoinGame(Player player)
        {
            Competors.Add(player);
        }
        public void GiveCards(int amount)
        {
            foreach(var player in Competors)
            {
                Deck_.DealCards(player,amount);
            }
        }

        public string DetermineWinner()
        {
            int[] scores = new int[Competors.Count()];
            string[] names = new string[Competors.Count()];
            var i = 0;
            foreach(var player in Competors)
            {
                names[i] = player.Name;
                scores[i] = player.totalValue();
                i++;
            }

            var max = scores[0];
            var maxIndex = 0;

            for(i = 1;i<scores.Length;i++)
            {
                if(scores[i] > max)
                {
                    max = scores[i];
                    maxIndex = i;
                }
            }
            return names[maxIndex];
        }

        public void AnnounceWinner()
        {
            foreach(var player in Competors)
            {
                player.showHand();
                Console.WriteLine("which amounts to: " + player.totalValue() + " points");
            }
            Console.WriteLine("The winner of the game is....  " + DetermineWinner() + "!!!");
        }
    }
}
// See https://aka.ms/new-console-template for more information
using System;

namespace exercise1
{ 
class Program        
    {
        static void Main()
    {
        Game game = new Game();
        Player p1 = new Player("Bo");
        Player p2 = new Player("Bobbo");
        Player p3 = new Player("Bobbeline");
        Player p4 = new weakPlayer("Bobbyyyyyyyyyyy");

        game.JoinGame(p1);
        game.JoinGame(p2);
        game.JoinGame(p3);
        game.JoinGame(p4);

        game.GiveCards(5);

        game.AnnounceWinner();
    }
}
}
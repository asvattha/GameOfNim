using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfNim
{
    class Nim
    {
        IPlayer[] players;
        Pile pile;

        public Nim(IPlayer player1, IPlayer player2)
        {
            players = new IPlayer[2];
            players[0] = player1;
            players[1] = player2;

            Random rand = new Random();
            pile = new Pile(rand.Next(20, 95));

            Console.WriteLine($"Game starts with {pile.getMarbles()} marbles");
        }

        public string play()
        {
            int marblesPicked = 0;
            int marblesRemaining = pile.getMarbles();

            int ix = 0;
            IPlayer player = players[ix];
            

            while(pile.getMarbles() > 0)
            {
                marblesPicked = player.move(pile.getMarbles());
                pile.removeMarbles(marblesPicked);
                Console.WriteLine($"{player.playerName()} picked {marblesPicked} and left with {pile.getMarbles()} marbles");

                /*
                if (ix == 0)
                {
                    ix = 1;
                }

                else
                {
                    ix = 0;
                }
                */
                ix = (ix + 1) % 2;
                player = players[ix];
                
            }

            return player.playerName();
           
        }

    }
}

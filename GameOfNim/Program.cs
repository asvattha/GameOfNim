using System;

namespace GameOfNim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to start the game?:Type yes or no");
            string reply = Console.ReadLine();

            while (reply.Equals("yes"))
            {
                Console.WriteLine("Please enter the name of player 1 (Human): ");
                IPlayer player1 = new Human(Console.ReadLine());

                Console.WriteLine("Please enter the name of player 2 (Computer): ");
                IPlayer player2 = new Computer(Console.ReadLine());

                Console.WriteLine($"Please pick who wants to go first. Type 1 for {player1.playerName()} and 2 for {player2.playerName()}");
                string choice = Console.ReadLine();

                IPlayer firstPlayer;
                IPlayer secondPlayer;

                if (choice.Equals("1"))
                {
                    firstPlayer = player1;
                    secondPlayer = player2;
                }
                else
                {
                    firstPlayer = player2;
                    secondPlayer = player1;
                }

                Nim nim = new Nim(firstPlayer, secondPlayer);
                string winner = nim.play();
                Console.WriteLine($"Congratulations {winner}, you have won the game");

                

                Console.WriteLine("Would you like to play another game?: Type yes or no");
                reply = Console.ReadLine();
            }
        }
    }
}

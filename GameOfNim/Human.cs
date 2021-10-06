using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfNim
{
    class Human: IPlayer
    {
        string name;

        public Human(string name)
        {
            this.name = name;
        }

        public int move(int marbles)
        {
            Console.WriteLine("How much would you like to pick?");
            int picked = Int32.Parse(Console.ReadLine());
            return (picked);
        }

        public string playerName()
        {
            return this.name;
        }
    }
}

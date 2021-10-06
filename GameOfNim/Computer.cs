using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfNim
{
    class Computer: IPlayer
    {
        string name;

        public Computer(string name)
        {
            this.name = name;
            
        }

        public int move(int marbles)
        {
            Random rand = new Random();
            if(marbles>= 2)
            {
                return rand.Next(1, marbles / 2);
            }
            else
            {
                return marbles;
            }
            
        }

        public string playerName()
        {
            return this.name;
        }
    }
}

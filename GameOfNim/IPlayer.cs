using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfNim
{
    interface IPlayer
    {
        public int move(int m);
        public string playerName();
    }
}

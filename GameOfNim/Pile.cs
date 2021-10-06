using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfNim
{
    class Pile
    {
        private int marbles;

        public Pile(int marbles)
        {
            this.marbles = marbles;
        }

        public int getMarbles()
        {
            return this.marbles;
        }

        public void removeMarbles(int marbles)
        {
            this.marbles -= marbles;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardF
{
    public class Game
    {
        int size;
        public int moves { get; private set; }

        public Game(int size)
        {
            this.size = size;
        }

        public void Start(int speep = 0)
        { 
        }

        public int PressAt( int x, int y)
        {
            return 0;
        }

        public int GetDigitAt(int x, int y)
        {
            return 0;
        }

        public bool Solved()
        {
            return false;
        }
    }
}

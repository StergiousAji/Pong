using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Player
    {
        private bool up, down;
        private int speed;

        public Player() { }

        public Player(int s)
        {
            speed = s;
        }

        public bool Up
        {
            get { return up; }
            set { up = value; }
        }

        public bool Down
        {
            get { return down; }
            set { down = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }
}

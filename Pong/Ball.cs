using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Ball
    {
        private int speed;
        private bool up, down, left, right;

        public Ball() { }

        public Ball(int s)
        {
            speed = s;
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
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

        public bool Left
        {
            get { return left; }
            set { left = value; }
        }

        public bool Right
        {
            get { return right; }
            set { right = value; }
        }
    }
}

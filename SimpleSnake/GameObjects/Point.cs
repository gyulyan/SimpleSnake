using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnake.GameObjects
{
    public class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X
        {
            get => x;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input");
                }

                x = value;
            }
        }
        public int Y
        {
            get => y;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input");
                }

                y = value;
            }
        }
    }
}

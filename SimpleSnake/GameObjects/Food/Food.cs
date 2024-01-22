﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnake.GameObjects.Food
{
    internal class Food : GameObject
    {
        public Food(char drawSymbol, int points)
            : base(drawSymbol)
        {
            Points = points;
        }


        public int Points { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnake.GameObjects.Food
{
    internal class FoodAsterics : Food
    {
        private const char Symbol = '*';
        private const int Points = 1;
        public FoodAsterics(char drawSymbol)
            : base(Symbol, Points)
        {
        }
    }
}

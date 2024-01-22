using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnake.GameObjects.Food
{
    internal class FoodHash : Food
    {
        private const char Symbol = '#';
        private const int Points = 3;
        public FoodHash()
            : base(Symbol, Points)
        {
        }
    }
}

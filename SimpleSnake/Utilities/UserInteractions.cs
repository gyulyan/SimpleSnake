using SimpleSnake.Core.Interfaces;
using SimpleSnake.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnake.Utilities
{
    internal class UserInteractions
    {
        public static void Draw(GameObject gameObject)
        {
            Console.SetCursorPosition(gameObject.X, gameObject.Y);
            Console.Write(gameObject.DrawSymbol);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnake.GameObjects
{
    internal class Wall : GameObject
    {
        private const char WallSymbol = '\u25A0';


        public Wall(int x, int y)
           : base(WallSymbol, x, y)
        {
        }

        public override void Draw()
        {
            DrawHorizontalLine(0);
            DrawHorizontalLine(Y);

            DrawVerticalLine(0);
            DrawVerticalLine(X - 1);
        }
        private void DrawHorizontalLine(int column)
        {
            for (int row = 0; row < X; row++)
            {
                GameObject drawPoint = new GameObject(DrawSymbol, row, column);
                drawPoint.Draw();
            }
        }

        private void DrawVerticalLine(int row)
        {
            for (int col = 0; col < Y; col++)
            {
                GameObject drawPoint = new GameObject(DrawSymbol, row, col);
                drawPoint.Draw();
            }
        }
    }
}

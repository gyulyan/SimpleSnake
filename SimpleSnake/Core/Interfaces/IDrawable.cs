namespace SimpleSnake.Core.Interfaces
{
    internal interface IDrawable
    {
        char DrawSymbol { get; }
        public void Draw();
    }
}
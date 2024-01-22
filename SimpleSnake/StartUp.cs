namespace SimpleSnake
{
    using SimpleSnake.GameObjects;
    using System;
    using Utilities;

    public class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();
            Wall borders = new Wall(60, 20);
            borders.Draw();
            //Snake snake;
            //Engine engine = new Engine(Wall, snake);

            //engine.Run();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

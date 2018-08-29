using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEngine.Test
{
    class Test
    {
        public static void Main()
        {
            Console.BufferHeight = Console.WindowHeight;
            Console.WriteLine($"Window: {Console.WindowHeight}({Console.BufferHeight}) rows x {Console.WindowWidth}({Console.BufferWidth}) columns");
            Console.Clear();

            Camera mainCamera = new Camera(0, 0, Console.WindowWidth, Console.WindowHeight - 1);
            Sprite sprite = new Sprite(new char[,] { { ' ', ' ', 'A', ' ', ' ' }, { ' ', '/', '|', '\\', ' ' }, { '/', '|', '|', '|', '\\' } });
            GameObject gameObject = new GameObject(5, 23, sprite);

            ColoredChar[,] render = mainCamera.Render(new GameObject[] { gameObject });

            foreach(ColoredChar coloredChar in render)
            {
                Console.BackgroundColor = coloredChar.BackgroundColor;
                Console.ForegroundColor = coloredChar.CharacterColor;
                Console.Write(coloredChar.Character);
            }
        }
    }
}

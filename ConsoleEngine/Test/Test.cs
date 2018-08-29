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
            Console.CursorVisible = false;
            Console.WriteLine($"Window: {Console.WindowHeight}({Console.BufferHeight}) rows x {Console.WindowWidth}({Console.BufferWidth}) columns");
            Console.Clear();

            Camera mainCamera = new Camera(0, 0, Console.WindowWidth, Console.WindowHeight - 1);
            Sprite sprite = new Sprite(new char[,] { { ' ', ' ', 'A', ' ', ' ' }, { ' ', '/', '|', '\\', ' ' }, { '/', '|', '|', '|', '\\' } });
            GameObject object1 = new GameObject(78, 20, sprite);
            GameObject object2 = new GameObject(1, -1, sprite);
            GameObject object3 = new GameObject(2, 22, sprite);

            ColoredChar[,] render = mainCamera.Render(new GameObject[] { object1, object2, object3 });

            foreach(ColoredChar coloredChar in render)
            {
                Console.BackgroundColor = coloredChar.BackgroundColor;
                Console.ForegroundColor = coloredChar.CharacterColor;
                Console.Write(coloredChar.Character);
            }
        }
    }
}

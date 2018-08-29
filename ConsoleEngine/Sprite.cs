using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEngine
{
    /// <summary>
    /// Defines a thing to be drawn to the console.
    /// </summary>
    public class Sprite
    {
        /// <summary>
        /// A collection of ColoredChars defining what will be drawn to the console.
        /// </summary>
        public ColoredChar[,] Appearance;

        /// <summary>
        /// The width of this Sprite.
        /// </summary>
        public int Width
        {
            get
            {
                return Appearance.GetLength(1);
            }
        }

        /// <summary>
        /// The height of this Sprite.
        /// </summary>
        public int Height
        {
            get
            {
                return Appearance.GetLength(0);
            }
        }

        public Sprite() : this (new ColoredChar[0, 0])
        {
        }

        public Sprite(char[,] appearance) : this(ConvertCharsToColoredChars(appearance))
        {
        }

        public Sprite(ColoredChar[,] appearance)
        {
            this.Appearance = appearance;
        }

        /// <summary>
        /// Generates and returns a collection of ColoredChars that should be drawn
        /// to the console to represent this Sprite.
        /// </summary>
        /// <returns>The visual appearance of this Sprite.</returns>
        public ColoredChar[,] Draw()
        {
            return Appearance;
        }

        private static ColoredChar[,] ConvertCharsToColoredChars(char[,] characters)
        {
            ColoredChar[,] result = new ColoredChar[characters.GetLength(0), characters.GetLength(1)];
            for (int row = 0; row < characters.GetLength(0); row++)
            {
                for (int col = 0; col < characters.GetLength(1); col++)
                {
                    result[row, col] = characters[row, col];
                }
            }
            return result;
        }
    }
}

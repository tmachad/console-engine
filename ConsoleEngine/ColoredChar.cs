using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEngine
{
    /// <summary>
    /// A colored character to be displayed on the console.
    /// </summary>
    public struct ColoredChar
    {
        /// <summary>
        /// Default instance of a ColoredChar.
        /// </summary>
        public static readonly ColoredChar Default = new ColoredChar(' ');

        /// <summary>
        /// The background color of the character.
        /// </summary>
        public readonly ConsoleColor BackgroundColor;

        /// <summary>
        /// The color of the character itself.
        /// </summary>
        public readonly ConsoleColor CharacterColor;

        /// <summary>
        /// The character.
        /// </summary>
        public readonly char Character;

        public ColoredChar(char character) : this(ConsoleColor.Black, ConsoleColor.White, character)
        {
        }

        public ColoredChar(ConsoleColor backgroundColor, ConsoleColor characterColor, char character)
        {
            this.BackgroundColor = backgroundColor;
            this.CharacterColor = characterColor;
            this.Character = character;
        }

        /// <summary>
        /// Custom cast operator from char to ColoredChar. This will cause characters casted to ColoredChars
        /// to have the default black background and white text color.
        /// </summary>
        /// <param name="character">The char being cast.</param>
        public static implicit operator ColoredChar (char character)
        {
            return new ColoredChar(character);
        }
    }
}

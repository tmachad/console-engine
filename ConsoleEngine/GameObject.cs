using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEngine
{
    public class GameObject
    {
        /// <summary>
        /// Represents the top-left corner of the game object.
        /// </summary>
        public Point Position;

        /// <summary>
        /// Represents the width of the object in characters.
        /// </summary>
        public readonly int Width;

        /// <summary>
        /// Represents the height of the object in characters.
        /// </summary>
        public readonly int Height;

        /// <summary>
        /// A read-only bounds object representing the boundaries of the game object.
        /// </summary>
        public Bounds Bounds
        {
            get
            {
                return new Bounds(Position, new Point(Position.x + Width, Position.y + Height));
            }
        }

        /// <summary>
        /// A Sprite object that defines how this object should be renderd to the console.
        /// </summary>
        public Sprite Sprite;

        public GameObject() : this(new Point(), new Sprite())
        {
        }

        public GameObject(Point position, Sprite sprite) : this(position, sprite.Width, sprite.Height, sprite)
        {
        }

        public GameObject(int x, int y, Sprite sprite) : this(new Point(x, y), sprite.Width, sprite.Height, sprite)
        {
        }

        public GameObject(Point position, int width, int height) : this(position, width, height, new Sprite())
        {
        }

        public GameObject(Point position, int width, int height, Sprite sprite)
        {
            this.Position = position;
            this.Width = width;
            this.Height = height;
            this.Sprite = sprite;
        }
    }
}

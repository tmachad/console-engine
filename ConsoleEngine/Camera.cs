using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEngine
{
    public class Camera : GameObject
    {

        private readonly ColoredChar[,] _buffer;
        private readonly Bounds _bufferBounds;

        public Camera() : this(new Point(), 10, 10)
        {
        }

        public Camera(int width, int height) : this(new Point(), width, height)
        {
        }

        public Camera(Point position, int width, int height) : base(position, width, height)
        {
            this._buffer = new ColoredChar[height, width];
            this._bufferBounds = new Bounds(0, 0, width, height);
        }

        public Camera(int x, int y, int width, int height) : this(new Point(x, y), width, height)
        {
        }

        public ColoredChar[,] Render(IEnumerable<GameObject> gameObjects)
        {
            ClearBuffer();

            Bounds cameraBounds = Bounds;

            foreach (GameObject gameObject in gameObjects)
            {
                Bounds objectBounds = gameObject.Bounds;

                if (cameraBounds.Intersects(objectBounds))
                {
                    int colOffset = gameObject.Position.x - Position.x;
                    int rowOffset = gameObject.Position.y - Position.y;

                    ColoredChar[,] sprite = gameObject.Sprite.Draw();
                    for (int row = 0; row < sprite.GetLength(0); row++)
                    {
                        for (int col = 0; col < sprite.GetLength(1); col++)
                        {
                            int bufferCol = colOffset + col;
                            int bufferRow = rowOffset + row;

                            if (_bufferBounds.ContainsPoint(new Point(bufferCol, bufferRow)))
                            {
                                _buffer[bufferRow, bufferCol] = sprite[row, col];
                            }
                        }
                    }
                }
            }

            return (ColoredChar[,])_buffer.Clone();
        }

        private void ClearBuffer()
        {
            for (int row = 0; row < base.Height; row++)
            {
                for (int col = 0; col < base.Width; col++)
                {
                    _buffer[row, col] = ColoredChar.Default;
                }
            }
        }
    }
}

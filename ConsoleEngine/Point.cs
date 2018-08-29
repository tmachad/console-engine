using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEngine
{
    public class Point
    {
        /// <summary>
        /// The position of this point along the X (horizontal) axis of the world.
        /// </summary>
        public int x;

        /// <summary>
        /// The position of this point along the Y (vertical) axis of the world.
        /// </summary>
        public int y;

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}

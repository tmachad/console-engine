using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEngine
{
    public class Bounds
    {
        /// <summary>
        /// The top-left corner of this bounds object.
        /// </summary>
        public Point TopLeft;

        /// <summary>
        /// The bottom-right corner of this bounds object.
        /// </summary>
        public Point BottomRight;

        public Bounds() : this(new Point(0, 0), new Point(0, 0))
        {
        }

        public Bounds(int x1, int y1, int x2, int y2) : this(new Point(x1, y1), new Point(x2, y2))
        {
        }

        public Bounds(Point topLeft, Point bottomRight)
        {
            this.TopLeft = topLeft;
            this.BottomRight = bottomRight;
        }

        /// <summary>
        /// Determines whether or not the given point is within this bounds.
        /// If the point is on the edge of the bounds it is considered to be within the bounds.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>True if the point is within this bounds, false otherwise.</returns>
        public bool ContainsPoint(Point point)
        {
            return Bounds.ContainsPoint(this, point);
        }

        /// <summary>
        /// Determines whether or not the given point is within the given bounds.
        /// If the point is on the edge of the bounds it is considered to be within the bounds.
        /// </summary>
        /// <param name="bounds">The bounds to look for the point in.</param>
        /// <param name="point">The point.</param>
        /// <returns>True if the point is within the bounds, false otherwise.</returns>
        public static bool ContainsPoint(Bounds bounds, Point point)
        {
            return point.x >= bounds.TopLeft.x                      // To the right of (or on) left edge
                && point.y >= bounds.TopLeft.y                      // Below (or on) top edge
                && point.x <= bounds.BottomRight.x                  // To the left of (or on) right edge
                && point.y <= bounds.BottomRight.y;                 // Above (or on) bottom edge
        }

        /// <summary>
        /// Determines whether or not this bounds object intersects with the other bounds object.
        /// If the other bounds touches the edge of this bounds it is considered to be intersecting.
        /// </summary>
        /// <param name="other">The other bounds object.</param>
        /// <returns>True of the two bounds intersect, false otherwise.</returns>
        public bool Intersects(Bounds other)
        {
            return Bounds.Intersects(this, other);
        }

        /// <summary>
        /// Determines whether or not the given bounds objects intersect with each other.
        /// Bounds whos edges touch are considered to be intersecting.
        /// </summary>
        /// <param name="bounds1">The first bounds object.</param>
        /// <param name="bounds2">The second bounds object.</param>
        /// <returns>True if the two bounds intersect, false otherwise.</returns>
        public static bool Intersects(Bounds bounds1, Bounds bounds2)
        {
            return bounds1.BottomRight.x >= bounds2.TopLeft.x          // Bottom right corner is to the right of (or on) the left edge.
                && bounds1.BottomRight.y >= bounds2.TopLeft.y          // Bottom right corner is below (or on) the top edge.
                && bounds1.TopLeft.x <= bounds2.BottomRight.x          // Top left corner is to the left of (or on) the right edge.
                && bounds1.TopLeft.y <= bounds2.BottomRight.y;         // Top left corner is above (or on) the bottom edge.
        }
    }
}

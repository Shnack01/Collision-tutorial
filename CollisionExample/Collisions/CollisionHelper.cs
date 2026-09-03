using System;
using CollisionExample.Collisions;

namespace CollisionExample.Collisions
{
    static public class CollisionHelper
    {
        /// <summary>
        /// Detects collisions between two bounding circles
        /// </summary>
        /// <param name="a">the first circle</param>
        /// <param name="b">the second circle</param>
        /// <returns>true for collisions, false otherwise</returns>
        public static bool Collides(BoundingCircle a, BoundingCircle b)
        {
            return Math.Pow(a.Radius + b.Radius, 2) >= 
                Math.Pow(a.Center.X - b.Center.X, 2) + 
                Math.Pow(a.Center.Y - b.Center.Y, 2);
        }
    }
}
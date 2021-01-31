using System;
using System.Drawing;

namespace Ventus
{
    internal class Util
    {
        public static double DistanceToOrigin(Point p)
        {
            return Math.Sqrt(p.X * p.X + p.Y * p.Y);
        }
    }
}
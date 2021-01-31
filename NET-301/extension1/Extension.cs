using System;
using System.Drawing;

namespace Ventus
{
    internal static class Extension
    {
        public static double DistanceToOrigin(this Point p)
        {
            return Math.Sqrt(p.X * p.X + p.Y * p.Y);
        }
    }
}

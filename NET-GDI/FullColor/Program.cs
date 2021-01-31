using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Ventus
{
    internal class Program
    {
        private static void Main()
        {
            var bmp = new Bitmap(4096, 4096, PixelFormat.Format24bppRgb);
            var x = 0;
            var y = 0;
            for (var r = 0; r < 256; r++)
            {
                for (var g = 0; g < 256; g++)
                {
                    for (var b = 0; b < 256; b++)
                    {
                        bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                        x++;
                        if (x >= 4096)
                        {
                            x = 0;
                            y++;
                        }
                    }
                }
                Console.Write(r);
                Console.Write(' ');
            }
            bmp.Save("palette.png", ImageFormat.Png);
        }
    }
}
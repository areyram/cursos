using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Ventus
{
    public static class Extension
    {
        public static byte[] ToByteArray(this Image image)
        {
            var ms = new MemoryStream();
            image.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }
    }
}
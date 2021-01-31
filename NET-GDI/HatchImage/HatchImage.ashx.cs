using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Web;

namespace Ventus
{
    public class HatchImage : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            var style = (HatchStyle)Enum.Parse(typeof(HatchStyle), context.Request.QueryString["v"]);
            context.Response.ContentType = "image/png";
            var bmp = new Bitmap(121, 41);
            var g = Graphics.FromImage(bmp);
            g.FillRectangle(new HatchBrush(style, Color.Black, Color.White), g.ClipBounds);
            context.Response.BinaryWrite(bmp.ToByteArray());
        }

        public bool IsReusable
        {
            get { return false; }
        }
    }
}
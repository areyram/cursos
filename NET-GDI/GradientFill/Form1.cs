using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Ventus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Paint += (o, e) =>
            {
                var p = (Control)o;
                var g = e.Graphics;
                var brush = new LinearGradientBrush(p.ClientRectangle, Color.CornflowerBlue, Color.LightYellow, 90f);
                g.FillRectangle(brush, p.ClientRectangle);
            };
            panel2.Paint += (o, e) =>
            {
                var p = (Control)o;
                var g = e.Graphics;
                var brush = new LinearGradientBrush(p.ClientRectangle, Color.CornflowerBlue, Color.LightYellow, 0f);
                g.FillRectangle(brush, p.ClientRectangle);
            };
            panel3.Paint += (o, e) =>
            {
                var p = (Control)o;
                var g = e.Graphics;
                var brush = new LinearGradientBrush(p.ClientRectangle, Color.CornflowerBlue, Color.LightYellow, 60f);
                g.FillRectangle(brush, p.ClientRectangle);
            };
            panel4.Paint += (o, e) =>
            {
                var p = (Control)o;
                var g = e.Graphics;
                var rect = p.ClientRectangle;
                g.FillRectangle(new SolidBrush(Color.CornflowerBlue), rect);
                var path = new GraphicsPath();
                path.AddEllipse(rect);
                var brush = new PathGradientBrush(path)
                {
                    CenterPoint = new PointF((float)(rect.Width / 2.0), (float)(rect.Height / 2.0)),
                    CenterColor = Color.LightYellow,
                    SurroundColors = new[] { Color.CornflowerBlue }
                };
                g.FillPath(brush, path);
            };
        }
    }
}

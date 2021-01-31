using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ventus
{
    public partial class MainForm : Form
    {
        private static Ball _ball;
        private static readonly Random Rnd = new Random();

        private const float Restitution = 0.9f;
        private const float Gravity = 1.0f;
        private const float Radius = 50f;

        public MainForm()
        {
            InitializeComponent();
            animate.Tick += (o, e) =>
            {
                CalculateNewPositions();
                Invalidate();
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _ball = new Ball
            {
                Position = new PointF
                {
                    X = (float)ClientSize.Width / 2,
                    Y = (float)ClientSize.Height / 2
                }
            };
            InitializeSpeed();
            animate.Start();
        }

        private void CalculateNewPositions()
        {
            var bounds = new RectangleF(Radius / 2, Radius / 2,
                ClientSize.Width - Radius - 1, ClientSize.Height - Radius - 1);

            var pos = _ball.Position;
            var vel = _ball.Velocity;

            vel.Y += Gravity;

            pos.X += vel.X;
            if (pos.X < bounds.Left || pos.X > bounds.Right)
            {
                vel.X = -vel.X * Restitution;
                pos.X += vel.X;
            }

            pos.Y += vel.Y;
            if (pos.Y < bounds.Top || pos.Y > bounds.Bottom)
            {
                vel.Y = -vel.Y * Restitution;
                pos.Y += vel.Y;
            }

            if (pos.X < bounds.Left) pos.X = bounds.Left;
            if (pos.X > bounds.Right) pos.X = bounds.Right;
            if (pos.Y < bounds.Top) pos.Y = bounds.Top;
            if (pos.Y > bounds.Bottom) pos.Y = bounds.Bottom;

            _ball.Position = pos;
            _ball.Velocity = vel;
        }

        private static void InitializeSpeed()
        {
            _ball.Velocity = new PointF(
                Convert.ToSingle(Rnd.NextDouble() * 100 - 50),
                Convert.ToSingle(Rnd.NextDouble() * 100 - 50));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.FillEllipse(Brushes.Red,
                _ball.Position.X - Radius / 2, _ball.Position.Y - Radius / 2,
                Radius, Radius);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            InitializeSpeed();
        }
    }
}

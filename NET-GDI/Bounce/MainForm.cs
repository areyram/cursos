using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Ventus.Properties;

namespace Ventus
{
    public sealed partial class MainForm : Form
    {
        private static Ball[] _balls;
        private static RectangleF _bounds;
        private static readonly Random Rnd = new Random();
        private static Point _current;

        public MainForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Load += (o, a) =>
            {
                InitializeBounds();
                MakeBalls();
                InitializeSpeed();
                animate.Start();
            };
            Paint += (o, e) => DrawBalls(e.Graphics);
            Resize += (o, e) => InitializeBounds();
            animate.Tick += (o, e) =>
            {
                CalculateNewPositions();
                Invalidate();
            };
            MouseMove += (o, e) => _current = new Point(e.X, e.Y);
            Click += (o, e) => AttractBalls();
        }

        private void InitializeBounds()
        {
            var radius = Settings.Default.Radius;
            _bounds = new RectangleF(radius / 2, radius / 2,
                ClientSize.Width - radius - 1, ClientSize.Height - radius - 1);
        }

        private void MakeBalls()
        {
            _balls = new Ball[Settings.Default.N];
            for (var i = 0; i < _balls.Length; i++)
            {
                _balls[i] = new Ball
                {
                    Position = new PointF
                    {
                        X = (float)ClientSize.Width / 2,
                        Y = (float)ClientSize.Height / 2
                    },
                    Brush = new SolidBrush(Color.FromArgb(192, Rnd.Next(255), Rnd.Next(255), Rnd.Next(255)))
                };
            }
        }

        private static void InitializeSpeed()
        {
            foreach (var ball in _balls)
            {
                ball.Velocity = new PointF(
                    Convert.ToSingle(Rnd.NextDouble() * 100 - 50),
                    Convert.ToSingle(Rnd.NextDouble() * 100 - 50));
            }
        }

        private static void CalculateNewPositions()
        {
            foreach (var ball in _balls)
            {
                var pos = ball.Position;
                var vel = ball.Velocity;

                vel.Y += Settings.Default.Gravity;

                pos.X += vel.X;
                if (pos.X < _bounds.Left || pos.X > _bounds.Right)
                {
                    vel.X = -vel.X * Settings.Default.Restitution;
                    pos.X += vel.X;
                }

                pos.Y += vel.Y;
                if (pos.Y < _bounds.Top || pos.Y > _bounds.Bottom)
                {
                    vel.Y = -vel.Y * Settings.Default.Restitution;
                    pos.Y += vel.Y;
                }

                if (pos.Y > _bounds.Bottom - 1 && Math.Abs(vel.Y) < 0.5)
                    vel.X *= Settings.Default.Friction;

                if (pos.X < _bounds.Left) pos.X = _bounds.Left;
                if (pos.X > _bounds.Right) pos.X = _bounds.Right;
                if (pos.Y < _bounds.Top) pos.Y = _bounds.Top;
                if (pos.Y > _bounds.Bottom) pos.Y = _bounds.Bottom;

                ball.Position = pos;
                ball.Velocity = vel;
            }
        }

        private static void DrawBalls(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            var radius = Settings.Default.Radius;
            foreach (var ball in _balls)
            {
                g.FillEllipse(ball.Brush,
                    ball.Position.X - radius / 2, ball.Position.Y - radius / 2,
                    radius, radius);
            }
        }

        private static void AttractBalls()
        {
            foreach (var ball in _balls)
            {
                var angle = Math.Atan2(ball.Position.Y - _current.Y, ball.Position.X - _current.X);
                var power = Rnd.NextDouble() * 100 - 50;
                ball.Velocity = new PointF((float)(Math.Cos(angle) * power), (float)(Math.Sin(angle) * power));
            }
        }

        private void mnuConfigure_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
            if (SettingsForm.Cancelled) return;
            MakeBalls();
            InitializeBounds();
            InitializeSpeed();
        }
    }
}

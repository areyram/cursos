using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Ventus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var doc = new PrintDocument
            {
                DefaultPageSettings = { PaperSize = new PaperSize("Letter", 850, 1100) }
            };
            doc.PrintPage += doc_PrintPage;
            printPreview.Document = doc;
        }

        private int _currentPage;

        private void doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            var g = e.Graphics;
            switch (_currentPage)
            {
                case 0:
                    g.DrawEllipse(Pens.Black, e.PageBounds);
                    break;
                case 1:
                    g.DrawString(Properties.Resources.LoremIpsum,
                        new Font("Times New Roman", 28f, FontStyle.Bold), Brushes.Black, e.MarginBounds);
                    break;
                case 2:
                    for (var x = 0; x < e.PageBounds.Width; x += e.PageBounds.Width / 20)
                        g.DrawLine(Pens.Black, e.PageBounds.Width, 0, x, e.PageBounds.Height);
                    break;
            }
            _currentPage++;
            e.HasMorePages = _currentPage < 3;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            _currentPage = 0;
            printPreview.Document.Print();
        }

        private void btnZoomFit_Click(object sender, EventArgs e)
        {
            printPreview.AutoZoom = true;
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            printPreview.Zoom *= 1.5;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            printPreview.Zoom /= 1.5;
        }

        private void btnZoom100_Click(object sender, EventArgs e)
        {
            printPreview.Zoom = 1;
        }

        private void cboPage1_Click(object sender, EventArgs e)
        {
            GoToPage(0);
        }

        private void cboPage2_Click(object sender, EventArgs e)
        {
            GoToPage(1);
        }

        private void cboPage3_Click(object sender, EventArgs e)
        {
            GoToPage(2);
        }

        private void GoToPage(int p)
        {
            cboPage.Text = (p + 1).ToString();
            printPreview.StartPage = p;
        }
    }
}

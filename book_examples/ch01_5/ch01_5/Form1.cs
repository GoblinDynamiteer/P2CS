/* Programmering 2 med C#
 * Example 1.5
 * Page 26
 * 
 * Drawing, pen, brush, lines, geometry
 * 
 * Johan Kämpe
 * https://github.com/GoblinDynamiteer/
 * https://www.linkedin.com/in/johankampe/
 * 
 */
using System.Drawing;
using System.Windows.Forms;

namespace ch01_5
{
    public partial class Draw : Form
    {
        public Draw()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, 0, 160, 600, 160);

            pen = new Pen(Color.Green);
            g.DrawLine(pen, 0, 256, 600, 160);

            pen = new Pen(Color.Violet);
            g.DrawLine(pen, 0, 160, 600, 265);

            SolidBrush brush = new SolidBrush(Color.Turquoise);
            g.FillRectangle(brush, 90, 30, 150, 90);

            pen = new Pen(Color.Red);
            g.DrawLine(pen, 90, 30, 110, 40);
            g.DrawLine(pen, 90, 120, 110, 130);
            g.DrawLine(pen, 240, 30, 260, 40);
            g.DrawLine(pen, 240, 120, 260, 130);
            g.DrawRectangle(pen, 110, 40, 150, 90);

            brush.Color = Color.Blue;
            g.FillEllipse(brush, 380, 75, 100, 50);

            g.DrawLine(pen, 380, 45, 380, 100);
            g.DrawLine(pen, 480, 45, 480, 100);

            g.DrawEllipse(pen, 380, 20, 100, 50);
        }
    }
}

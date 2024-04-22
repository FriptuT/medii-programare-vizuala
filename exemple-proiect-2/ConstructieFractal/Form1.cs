using System.Timers;

namespace ConstructieFractal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void START_Click(object sender, EventArgs e)
        {
            m = 1;
            timer1.Start();
        }

        void patrat(int n, int x, int y, int l)
        {
            int l2 = l / 2;
            int l4 = l / 4;
            int l3 = l2 + l4;

            if (n > 1)
            {
                patrat(n - 1, x - 14, y - 14, 12);
                patrat(n - 1, x - 14, y + 13, 12);
                patrat(n - 1, x + 13, y - 14, 12);
                patrat(n - 1, x + 13, y + 13, 12);
            }
            Graphics graph = this.CreateGraphics();
            Pen penc;
            if (n % 2 == 0)
            {
                penc = new Pen(Color.Brown);
            }
            else
            {
                penc = new Pen(Color.BlueViolet);
                Point[] p = new Point[4];
                p[0].X = x; p[0].Y = y;
                p[1].X = x; p[1].Y = y + 1;
                p[2].X = x + 1; p[2].Y = y + 1;
                p[3].X = x + 1; p[3].Y = y;
                graph.DrawPolygon(penc, p);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (m <= Convert.ToInt32(textBox1.Text))
            {
                int x = 300, y = 300, l = 150;
                patrat(m, x, y, 1);
                m = m + 1;
            }
        }
    }
}

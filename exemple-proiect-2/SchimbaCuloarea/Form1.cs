using System;
using System.Drawing;
using System.Windows.Forms;

namespace SchimbaCuloarea
{
    public partial class SchimbaCuloarea : Form
    {
        public SchimbaCuloarea()
        {
            InitializeComponent();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
        }
    }
}

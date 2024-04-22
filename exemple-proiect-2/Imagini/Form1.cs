namespace Imagini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\teodo\\Downloads\\football.png");
            pictureBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\teodo\\Downloads\\net.png");
            pictureBox1.Visible = true;
        }
    }
}

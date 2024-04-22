namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var n = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < n; i += 2)
            {
                textBox2.Text = textBox2.Text + " " + Convert.ToString(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = " ";
            textBox1.Text = " ";
        }
    }
}

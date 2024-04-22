namespace CaseteDeDialog
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxText = textBox1.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 v = new Form2();
            v.ShowDialog();
            if (v.DialogResult != DialogResult.OK)
            {
                this.textBox1.Clear();
            }
        }

    }
}

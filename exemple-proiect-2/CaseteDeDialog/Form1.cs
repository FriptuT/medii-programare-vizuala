namespace CaseteDeDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Form2 w = new Form2();
            w.ShowDialog();
        }
    }
}

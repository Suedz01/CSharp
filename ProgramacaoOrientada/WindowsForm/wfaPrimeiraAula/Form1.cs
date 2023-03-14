namespace wfaPrimeiraAula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(textBox1.Text);
            double n2 = Convert.ToDouble(textBox2.Text);

            double media = (n1 + n2) / 2;

            textBox3.Text = Convert.ToString(media);
        }
    }
}
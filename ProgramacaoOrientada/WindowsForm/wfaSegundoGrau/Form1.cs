namespace wfaSegundoGrau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double delta, x1, x2;

            //cálculo das raízes
            delta = Math.Pow(b,2) - (4 * a * c);
            if (delta < 0)
            {
                MessageBox.Show("Não tem raízes reais", "Delta negativo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                textBox4.Text = Convert.ToString(delta);
                textBox5.Text = Convert.ToString(x1);
                textBox6.Text = Convert.ToString(x2);
            }
        }
    }
}
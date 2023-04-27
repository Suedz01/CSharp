namespace wfaConta_Especial
{
    public partial class Form1 : Form
    {
        string nconta;
        double saldo, limite;
        Conta[] listaContas = new Conta[10];

        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
            textBoxLimite.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonContaEspecial_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            textBoxLimite.Visible = true;

        }

        private void radioButtonConta_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            textBoxLimite.Visible = false;
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            nconta = textBoxNConta.Text;
            saldo = Convert.ToDouble(textBoxSaldo.Text);

            for (int i = 0; i < listaContas.Length; i++)
            {
                if (radioButtonContaEspecial.Checked)
                {
                    limite = Convert.ToDouble(textBoxLimite.Text);

                    ContaEspecial especial = new ContaEspecial(nconta, saldo, limite);
                    listaContas[i] = especial;
                    MessageBox.Show("Conta ESPECIAL cadastrada!\nNúmero da Conta: " + nconta + "\nSaldo: " + saldo + "\nLimite: " + limite);

                }
                else
                {
                    Conta normal = new Conta(nconta, saldo);
                    listaContas[i] = normal;
                    MessageBox.Show("Conta cadastrada!\nNúmero da Conta: " + nconta + "\nSaldo: " + saldo);
                }
            }
            MessageBox.Show("Atingiu o limite de contas do sistema!");
        }
    }
}
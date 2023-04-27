namespace CadastroDeMateriais
{
    public partial class Form1 : Form
    {
        //criando array
        Materia[] listaDeMaterias = new Materia[30];
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            //Criando objeto da classe materia
            string nome = textBoxNome.Text;
            string codigo = textBoxCodigo.Text;
            Materia m = new Materia(nome, codigo);

            listaDeMaterias[i] = m;
            i++;

            MessageBox.Show("Materia adicionada com sucesso");
            textBoxNome.Clear();
            textBoxCodigo.Clear();

        }

        private void buttonRelatorio_Click(object sender, EventArgs e)
        {
            string relatorio = "";
            for (int j = 0;  j < i; j++)
            {
                //concatenar todas as strings em uma única
                relatorio = relatorio + listaDeMaterias[j].Nome
                    + listaDeMaterias[j].Codigo + "\n";
            }
            textBoxTerminal.Text = relatorio;
        }
    }
}
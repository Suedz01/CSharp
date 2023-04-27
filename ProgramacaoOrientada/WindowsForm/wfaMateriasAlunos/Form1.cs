namespace wfaMateriasAlunos
{
    public partial class Form1 : Form
    {
        Materia[] materias = new Materia[80];
        Aluno[] alunos = new Aluno[10];

        int i = 0, j = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMateria_Click(object sender, EventArgs e)
        {
            Materia m = new Materia(textBoxNomeMateria.Text, textBoxCodigoMateria.Text);
            materias[i] = m;
            MessageBox.Show("Materia adicionada com sucesso:\n" +
                "\n[ Matéria: " + materias[i].Nome + " Código: " + materias[i].Codigo + " ]");
            i++;
        }

        private void buttonAluno_Click(object sender, EventArgs e)
        {
            Aluno a = new Aluno(textBoxNomeAluno.Text,
                textBoxNumeroMatricula.Text, Convert.ToInt32(textBoxPeriodo.Text));
            alunos[j] = a;
            MessageBox.Show("Aluno adicionado com sucesso:\n" +
                "\n[ Matéria: " + alunos[j].Nome + " Código: " + alunos[j].NumeroMatricula +
                " Código: " + alunos[j].Periodo + " ]");
            j++;
        }

        private void buttonGravarMatricula_Click(object sender, EventArgs e)
        {
            //pegar o nome do aluno
            for (int k = 0; k < alunos.Length; k++)
            {

            }

            //localizar este (objeto) aluno "a" no array de alunos criados
            //pegar nome da matéria
            //localizar (objeto) a matéria "m"

            //adicionar a matéria "m" ao array do aluno "a"
        }

        private void textBoxAlunoMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRelatorioMatricula_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < alunos.Length; i++)
            {
                if (alunos[i] != null)
                {
                    groupBoxListaAlunos. = Convert.ToString(alunos[i].Nome);
                }
            }
        }

        private void groupBoxListaAlunos_Enter(object sender, EventArgs e)
        {

        }
    }
}
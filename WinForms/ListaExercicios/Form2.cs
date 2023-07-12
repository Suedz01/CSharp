using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ListaExercicios
{
    public partial class Form2 : Form
    {
        //FORMULARIO DA SECRETARIA
        public Form2()
        {
            InitializeComponent();
            rbCadastrarCursos.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void rbCadastrarCursos_CheckedChanged(object sender, EventArgs e)
        {
            mostrarTelaCursos();
            atualizarCBCoordenadores();
        }
        void atualizarCBCoordenadores()
        {
            //Atualizar o cb dos coordenadores - cbSecretaria
            List<string> lista = new List<string>();
            cbSecretaria.Items.Clear(); // Limpa os itens existentes no ComboBox

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();
            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco
            con.Open(); // Abre a conexao com o banco

            string commandText = "select nome_str_coordenador from tb_coordenador order by nome_str_coordenador";

            using (NpgsqlCommand command = new NpgsqlCommand(commandText, con))
            {
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string item = reader.GetString(0);
                        lista.Add(item); // Adiciona o valor na lista
                        cbSecretaria.Items.Add(item); // Adiciona o valor ao ComboBox
                    }
                }
            }
            con.Close();
        }
        private void rbDisciplinas_CheckedChanged(object sender, EventArgs e)
        {
            mostrarTelaDisciplinas();
        }
        private void rbAlunos_CheckedChanged(object sender, EventArgs e)
        {
            mostrarTelaAlunos();
        }
        private void rbTurmas_CheckedChanged(object sender, EventArgs e)
        {
            mostrarTelaTurmas();
        }
        private void rbAlocacaoAlunos_CheckedChanged(object sender, EventArgs e)
        {
            mostrarTelaAlunoAloc();
        }
        private void rbSituacaoAlunos_CheckedChanged(object sender, EventArgs e)
        {
            mostrarTelaAlunoSituacao();
        }
        private void btDiario_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }
        private void btHistorico_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }
        void mostrarTelaCursos()
        {
            esconderTudo();

            label1.Show();
            label2.Show();
            label3.Show();
            textBox1.Show();
            textBox2.Show();
            cbSecretaria.Show();

            label1.Text = "Código:";
            label2.Text = "Descrição:";
            label3.Text = "Coordenadores:";
        }
        void mostrarTelaDisciplinas()
        {
            esconderTudo();

            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();

            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            textBox5.Show();
            textBox6.Show();

            cbSecretaria.Show();

            label1.Text = "Código:";
            label2.Text = "Descrição:";
            label3.Text = "Curso:";
            label4.Text = "Carga Horária:";
            label5.Text = "Ementa:";
            label6.Text = "Bibliografia:";
            label7.Text = "Pré-Requisitos:";
        }
        void mostrarTelaAlunos()
        {
            esconderTudo();

            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();

            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();

            cbSecretaria.Show();

            label1.Text = "Matrícula:";
            label2.Text = "Nome:";
            label3.Text = "Curso:";
            label4.Text = "Endereço:";
            label5.Text = "Telefone:";
        }
        void mostrarTelaTurmas()
        {
            esconderTudo();

            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();

            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();

            cbSecretaria.Show();

            label1.Text = "Ano:";
            label2.Text = "Semestre:";
            label3.Text = "Curso:";
            label4.Text = "Dias da Semana:";
            label5.Text = "Horários:";
        }
        void mostrarTelaAlunoAloc()
        {
            esconderTudo();

            label3.Show();
            label5.Show();

            cbSecretaria.Show();
            cbTurmaAloc.Show();

            label3.Text = "Aluno:";
            label5.Text = "Turma:";
        }
        void mostrarTelaAlunoSituacao()
        {
            esconderTudo();
            label3.Text = "Aluno:";
            label3.Show();

            cbSecretaria.Show();
            cbTurmaAloc.Show();
            cbTurmaAloc.Items.Add("Matriculado");
            cbTurmaAloc.Items.Add("Trancado");
            cbTurmaAloc.Items.Add("Formado");
            cbTurmaAloc.Items.Add("Evadido");

            label5.Text = "Situação:";
            label5.Show();
        }
        void esconderTudo()
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();

            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();

            cbTurmaAloc.Hide();
            cbTurmaAloc.Items.Clear();
            cbTurmaAloc.Text = "";

            cbSecretaria.Hide();
            cbSecretaria.Items.Clear();
            cbSecretaria.Text = "";

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (rbAlunos.Checked)
            {
                /*Aluno objCurso = new Aluno(textBox1.Text, textBox7.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), cbTurmaMateria.Text);
                ConexaoString stringConexao = new ConexaoString();
                string conexao = stringConexao.ConnString();
                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco
                con.Open(); // Abre a conexao com o banco

                string commandText = String.Format("INSERT INTO tb_alunos (str_nome_aluno, str_matricula, int_prova1, int_prova2, int_prova3, id_turma) " +
                                                    "SELECT '{0}', '{1}', {2}, {3}, {4}, id_turma " +
                                                    "FROM tb_turmas " +
                                                    "WHERE str_codigo = '{5}';",
                                                    objCurso.NomeAluno, objCurso.MatriculaAluno, objCurso.Nota1,
                                                    objCurso.Nota2, objCurso.Nota3, objCurso.CodigoTurma);

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Cadastro Inserido com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                */
            } else if (rbCadastrarCursos.Checked)
            {
                Curso objCurso = new Curso(textBox1.Text, textBox2.Text, cbSecretaria.Text);

                ConexaoString stringConexao = new ConexaoString();
                string conexao = stringConexao.ConnString();
                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco
                con.Open(); // Abre a conexao com o banco

                string commandText = String.Format("INSERT INTO tb_curso (codigo_str_curso, descricao_str_curso,id_coordenador_curso) " +
                                                    "SELECT '{0}', '{1}', id_int_coordenador " +
                                                    "FROM tb_coordenador " +
                                                    "WHERE nome_str_coordenador = '{2}';",
                                                    objCurso.Codigo, objCurso.Descricao, objCurso.NomeCoordenador);

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Cadastro Inserido com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else if (rbDisciplinas.Checked)
            {

            } else if (rbTurmas.Checked)
            {

            } else if (rbAlocacaoAlunos.Checked)
            {

            } else if (rbSituacaoAlunos.Checked)
            {

            }
        }
    }
}
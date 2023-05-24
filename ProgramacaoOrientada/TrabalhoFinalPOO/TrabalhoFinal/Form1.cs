using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoFinal
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            esconderTela();
            rbMateria.Checked = true;
            exibirInfo();
        }
        private void rbMateria_CheckedChanged(object sender, EventArgs e)
        {
            exibirInfo();
            limparCampos();
            esconderTela();

            /*TELA MATÉRIAS*/
            mostrarLinha("Nome:", 1);
            mostrarLinha("Descrição:", 6);
            mostrarLinha("Área:", 2);
            mostrarLinha("Sala:", 5);
        }
        private void rbTurma_CheckedChanged(object sender, EventArgs e)
        {
            exibirInfo();
            limparCampos();
            esconderTela();
            /*logica: encher cb*/
            atualizarCBMateria();

            /*TELA TURMA*/
            mostrarLinha("Código:", 1); //tb1
            mostrarLinha("Descrição:", 6); //tb7
            mostrarLinha("Vagas:", 2); //tb2
            mostrarLinha("Matéria:", 3); //tb3
        }
        private void rbAluno_CheckedChanged(object sender, EventArgs e)
        {
            exibirInfo();
            limparCampos();
            esconderTela();
            /*logica: encher cb*/
            atualizarCBTurma();

            /*TELA ALUNOS*/
            mostrarLinha("Nome:", 1); //tb1
            mostrarLinha("Matrícula:", 6); //tb7
            mostrarLinha("Turma:", 3); //tb3
            mostrarLinha("Notas:", 4); //tb456
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (rbAluno.Checked)
            {
                Aluno objAluno = new Aluno(textBox1.Text, textBox7.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), cbTurmaMateria.Text);
                ConexaoString stringConexao = new ConexaoString();
                string conexao = stringConexao.ConnString();
                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco
                con.Open(); // Abre a conexao com o banco

                string commandText = String.Format("INSERT INTO tb_alunos (str_nome_aluno, str_matricula, int_prova1, int_prova2, int_prova3, id_turma) " +
                                                    "SELECT '{0}', '{1}', {2}, {3}, {4}, id_turma " +
                                                    "FROM tb_turmas " +
                                                    "WHERE str_codigo = '{5}';",
                                                    objAluno.NomeAluno, objAluno.MatriculaAluno, objAluno.Nota1,
                                                    objAluno.Nota2, objAluno.Nota3, objAluno.CodigoTurma);

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Cadastro Inserido com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                exibirInfo();
            }
            else if (rbMateria.Checked)
            {
                Materia objMateria = new Materia(textBox1.Text, textBox7.Text, textBox2.Text, textBox3.Text);
                ConexaoString stringConexao = new ConexaoString();
                string conexao = stringConexao.ConnString();
                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco
                con.Open(); // Abre a conexao com o banco

                string commandText = String.Format("INSERT INTO tb_materias(str_nome_materia, str_descricao_materia, str_area, str_sala) " +
                                                    "values('{0}','{1}','{2}','{3}');", objMateria.NomeMateria, objMateria.DescricaoMateria, objMateria.AreaMateria, objMateria.SalaMateria);

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Cadastro Inserido com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparCampos();
                exibirInfo();
            }
            else if (rbTurma.Checked)
            {
                Turma objTurma = new Turma(textBox1.Text, textBox7.Text, Convert.ToInt32(textBox2.Text),cbTurmaMateria.Text);

                ConexaoString stringConexao = new ConexaoString();
                string conexao = stringConexao.ConnString();
                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco
                con.Open(); // Abre a conexao com o banco

                string commandText = String.Format("INSERT INTO tb_turmas(str_codigo, str_descricao_turma, int_vagas, id_materia) " +
                                                    "SELECT '{0}', '{1}', {2}, id_materia " +
                                                    "FROM tb_materias " +
                                                    "WHERE str_nome_materia = '{3}';", objTurma.CodigoTurma, objTurma.DescricaoTurma, objTurma.VagasTurma, objTurma.MateriaTurma);
                
                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Cadastro Inserido com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparCampos();
                exibirInfo();
            }
        }
        private void btEditar_Click(object sender, EventArgs e)
        {
            if (rbAluno.Checked)
            {

                /*
                UPDATE tb_alunos
                SET str_matricula = '<nova_matricula>', str_codigo = (SELECT str_codigo FROM tb_turmas WHERE id_turma = <id_turma_aluno>),
                int_prova1 = <nova_prova1>, int_prova2 = <nova_prova2>, int_prova3 = <nova_prova3>
                WHERE str_nome_aluno = '<nome_aluno>';
                */

                Aluno objAluno = new Aluno(textBox1.Text, textBox7.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), cbTurmaMateria.Text);
                ConexaoString stringConexao = new ConexaoString();
                string conexao = stringConexao.ConnString();
                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

                con.Open(); // Abre a conexao com o banco

                string commandText = String.Format("UPDATE tb_alunos "+
                                                    "SET str_nome_aluno = '{0}', str_matricula = '{1}', " +
                                                    "int_prova1 = {2}, int_prova2 = {3}, int_prova3 = {4}, " +
                                                    "id_turma = (select id_turma from tb_turmas where str_codigo = '{5}') " +
                                                    "where str_nome_aluno ='{0}';", objAluno.NomeAluno,objAluno.MatriculaAluno,objAluno.Nota1,
                                                    objAluno.Nota2,objAluno.Nota3,objAluno.CodigoTurma);

                MessageBox.Show(commandText);

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {

                    pgsqlcommand.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Cadastro Atualizado com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();

            }
            else if (rbMateria.Checked)
            {
                Materia objMateria = new Materia(textBox1.Text, textBox7.Text, textBox2.Text, textBox3.Text);
                ConexaoString stringConexao = new ConexaoString();
                string conexao = stringConexao.ConnString();
                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

                con.Open(); // Abre a conexao com o banco

                string commandText = String.Format("UPDATE tb_materias SET str_nome_materia = '" + objMateria.NomeMateria + "' , str_descricao_materia = '"
                    + objMateria.DescricaoMateria + "', str_area = '" + objMateria.AreaMateria + "', str_sala = '" + objMateria.SalaMateria
                    + "' Where str_nome_materia = '" + objMateria.NomeMateria + "'");
                MessageBox.Show(commandText);

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {

                    pgsqlcommand.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Cadastro Atualizado com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparCampos();
            }
            else if (rbTurma.Checked)
            {
                Turma objTurma = new Turma(textBox1.Text, textBox7.Text, Convert.ToInt32(textBox2.Text), cbTurmaMateria.Text);
                ConexaoString stringConexao = new ConexaoString();
                string conexao = stringConexao.ConnString();
                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

                con.Open(); // Abre a conexao com o banco

                string commandText = String.Format("UPDATE tb_turmas " +
                                                    "SET str_codigo = '{0}', str_descricao_turma = '{1}', " +
                                                    "int_vagas = {2}, " +
                                                    "id_materia = (SELECT id_materia FROM tb_materias WHERE str_nome_materia = '{3}') " +
                                                    "WHERE str_codigo = '{0}'; ", objTurma.CodigoTurma,objTurma.DescricaoTurma,objTurma.VagasTurma,
                                                    objTurma.MateriaTurma);
                MessageBox.Show(commandText);

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {

                    pgsqlcommand.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Cadastro Atualizado com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
            }
        }
        private void btExibir_Click(object sender, EventArgs e)
        {
            exibirInfo();
        }
        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (rbAluno.Checked)
            {
                string nomeAluno = textBox1.Text;

                ConexaoString stringConexao = new ConexaoString();
                string conexao = stringConexao.ConnString();
                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco
                con.Open(); // Abre a conexao com o banco

                string commandText = String.Format("DELETE FROM tb_alunos WHERE str_nome_aluno = '{0}'", nomeAluno);

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Cadastro Excluido com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                exibirInfo();
            }
            else if (rbMateria.Checked) //feito
            {
                string nomeMateria = textBox1.Text;

                ConexaoString stringConexao = new ConexaoString();
                string conexao = stringConexao.ConnString();
                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco
                con.Open(); // Abre a conexao com o banco

                string commandText = String.Format("DELETE FROM tb_materias WHERE str_nome_materia = '{0}'", nomeMateria);

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Cadastro Excluido com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                exibirInfo();
            }
            else if (rbTurma.Checked)
            {
                string codigoTurma = textBox1.Text;

                ConexaoString stringConexao = new ConexaoString();
                string conexao = stringConexao.ConnString();
                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco
                con.Open(); // Abre a conexao com o banco

                string commandText = String.Format("DELETE FROM tb_alunos " +
                                                   "WHERE id_turma IN(SELECT id_turma FROM tb_turmas WHERE str_codigo = '{0}'); " +
                                                   "DELETE FROM tb_turmas " +
                                                   "WHERE str_codigo = '{0}';", codigoTurma);

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Cadastro Excluido com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                exibirInfo();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rbAluno.Checked)
            {
                textBox1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                textBox7.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                textBox4.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                textBox5.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                textBox6.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                cbTurmaMateria.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            }
            else if (rbMateria.Checked) //feito
            {
                textBox1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                textBox7.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                textBox2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                textBox3.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            }
            else if (rbTurma.Checked)
            {
                textBox1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                textBox7.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                textBox2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                cbTurmaMateria.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            }
        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        void atualizarCBMateria()
        {
            List<string> lista = new List<string>();
            cbTurmaMateria.Items.Clear(); // Limpa os itens existentes no ComboBox

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();
            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco
            con.Open(); // Abre a conexao com o banco

            string commandText = "SELECT str_nome_materia FROM tb_materias ORDER BY str_nome_materia";

            using (NpgsqlCommand command = new NpgsqlCommand(commandText, con))
            {
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string item = reader.GetString(0);
                        lista.Add(item); // Adiciona o valor na lista
                        cbTurmaMateria.Items.Add(item); // Adiciona o valor ao ComboBox
                    }
                }
            }

            con.Close();
        }
        void atualizarCBTurma()
        {
            List<string> lista = new List<string>();
            cbTurmaMateria.Items.Clear(); // Limpa os itens existentes no ComboBox

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();
            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco
            con.Open(); // Abre a conexao com o banco

            string commandText = "SELECT str_codigo FROM tb_turmas ORDER BY id_turma";

            using (NpgsqlCommand command = new NpgsqlCommand(commandText, con))
            {
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string item = reader.GetString(0);
                        lista.Add(item); // Adiciona o valor na lista
                        cbTurmaMateria.Items.Add(item); // Adiciona o valor ao ComboBox
                    }
                }
            }

            con.Close();
        }
        void exibirInfo()
        {
            if (rbAluno.Checked)
            {
                ConexaoString stringConexao = new ConexaoString();
                string conexao = stringConexao.ConnString();
                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco
                con.Open(); // Abre a conexao com o banco


                DataTable dt = new DataTable(); // Objeto que pode conter tabelas
                string commandText = "SELECT a.str_nome_aluno, a.str_matricula, t.str_codigo, a.int_prova1, a.int_prova2, a.int_prova3 " +
                                     "FROM tb_alunos a " +
                                     "JOIN tb_turmas t ON a.id_turma = t.id_turma " +
                                     "ORDER BY a.id_aluno;";

                using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con)) // faz a ligação em bd e o datatable
                {
                    Adpt.Fill(dt);
                }

                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (rbMateria.Checked) //feito
            {
                ConexaoString stringConexao = new ConexaoString();
                string conexao = stringConexao.ConnString();
                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco
                con.Open(); // Abre a conexao com o banco

                DataTable dt = new DataTable(); // Objeto que pode conter tabelas
                string commandText = "SELECT str_nome_materia, str_descricao_materia, str_area, str_sala FROM tb_materias ORDER BY id_materia;";

                using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con)) // faz a ligação em bd e o datatable
                {
                    Adpt.Fill(dt);
                }
                dataGridView1.DataSource = dt;

                con.Close();
            }
            else if (rbTurma.Checked)
            {
                ConexaoString stringConexao = new ConexaoString();
                string conexao = stringConexao.ConnString();
                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco
                con.Open(); // Abre a conexao com o banco

                DataTable dt = new DataTable(); // Objeto que pode conter tabelas
                string commandText = "SELECT tb_turmas.str_codigo, tb_turmas.str_descricao_turma, tb_materias.str_nome_materia, tb_turmas.int_vagas " +
                                     "FROM tb_turmas JOIN tb_materias ON tb_turmas.id_materia = tb_materias.id_materia;";

                using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con)) // faz a ligação em bd e o datatable
                {
                    Adpt.Fill(dt);
                }

                dataGridView1.DataSource = dt;
                con.Close();
            }
        }
        void mostrarLinha(string nome, int i)
        {
            //Lógica: Otimizar a troca de cenas - Aluno/Materia/Turma 
            if (i == 1)
            {
                label1.Show();
                label1.Text = nome;
                textBox1.Show();
            }
            else if (i == 2)
            {
                label2.Show();
                label2.Text = nome;
                textBox2.Show();
            }
            else if (i == 3)
            {
                label3.Show();
                label3.Text = nome;
                cbTurmaMateria.Show();
            }
            else if (i == 4)
            {
                label2.Show();
                label2.Text = nome;

                textBox4.Show();
                textBox5.Show();
                textBox6.Show();
            }
            else if (i == 5)
            {
                label3.Show();
                label3.Text = nome;
                textBox3.Show();
            }
            else if (i == 6)
            {
                label4.Show();
                label4.Text = nome;
                textBox7.Show();
            }
        }
        void esconderTela()
        {
            label1.Hide();
            textBox1.Hide();
            label2.Hide();
            textBox2.Hide();
            label3.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            label4.Hide();
            cbTurmaMateria.Hide();
        }
        void limparCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            cbTurmaMateria.Text = "";
        }
    }
}

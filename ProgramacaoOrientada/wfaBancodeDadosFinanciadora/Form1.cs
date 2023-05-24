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

namespace wfaBancodeDadosFinanciadora
{
    public partial class dgvContas : Form
    {
        public dgvContas()
        {
            InitializeComponent();
        }
        private void btInserir_Click(object sender, EventArgs e)
        {
            Pessoa objPessoa = new Pessoa(tbCPF.Text, tbNome.Text, Convert.ToDouble(tbSalario.Text));

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            string commandText = String.Format("INSERT INTO cliente(cpf_cliente,nome_cliente,salario_cliente,credito_cliente) " +
                                                "values('{0}','{1}',{2},{3})", objPessoa.Cpf, objPessoa.Nome, objPessoa.Salario, objPessoa.calcCredito());

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Cadastro Inserido com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //limparTextbox();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            string cpf = tbCPF.Text;

            Pessoa objPessoa = new Pessoa(tbCPF.Text, tbNome.Text, Convert.ToDouble(tbSalario.Text));

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            string commandText = String.Format("UPDATE cliente SET cpf_Cliente = '" + objPessoa.Cpf + "' , nome_cliente = '"
                + objPessoa.Nome + "', salario_cliente = " + objPessoa.Salario + " , credito_cliente = " + objPessoa.calcCredito()
                + " Where cpf_Cliente = '" + cpf + "'");
            MessageBox.Show(commandText);

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {

                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();

            MessageBox.Show("Cadastro Atualizado com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            limparTextBox();
        }
        public void limparTextBox()
        {
            tbNome.Text = String.Empty;
            tbCPF.Text = String.Empty;
            tbSalario.Text = String.Empty;
        }

        private void btExibir_Click(object sender, EventArgs e)
        {
            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            DataTable dt = new DataTable(); // Objeto que pode conter tabelas

            string commandText = "SELECT * FROM cliente ORDER BY id_cliente";

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con)) // faz a ligação em bd e o datatable
            {
                Adpt.Fill(dt);
            }

            dGV.DataSource = dt;

            con.Close();  // Fecha a Conexao com o banco
        }

        private void dGV_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbCPF.Text = Convert.ToString(dGV.Rows[e.RowIndex].Cells[1].Value);
            tbNome.Text = Convert.ToString(dGV.Rows[e.RowIndex].Cells[2].Value);
            tbSalario.Text = Convert.ToString(dGV.Rows[e.RowIndex].Cells[3].Value);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            string cpf = tbCPF.Text;

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            string commandText = String.Format("DELETE FROM cliente WHERE cpf_Cliente = '{0}'", cpf);

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();

            MessageBox.Show("Cadastro Excluido com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            limparTextBox();
        }
    }
}

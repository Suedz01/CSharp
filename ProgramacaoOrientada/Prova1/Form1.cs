using System.ComponentModel;
using System.Drawing;

namespace Prova1
{
    public partial class Form1 : Form
    {
        Pagamentos[] pagamentos = new Pagamentos[6];
        long cpf;
        double valor, faturamento;
        int codigo;
        string descricao, estabelecimento;
        int i = 0;

        public Form1()
        {
            InitializeComponent();
            configurarListView();
        }

        private void foodRB_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Descrição:";
        }

        private void healthRB_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Estabelecimento:";
        }
        private void gravarBT_Click(object sender, EventArgs e)
        {
            cadastroItem();
        }
        private void limparBT_Click(object sender, EventArgs e)
        {
            cpfTB.Text = ""; //CPF
            valorTB.Text = "";//Valor
            codigoTB.Text = ""; //Codigo
            descricaoestabelecimentoTB.Text = ""; //Descrição ou Estabelecimento
        }

        /*métodos forms*/
        void configurarListView()
        {
            cadastroListView.Columns.Add("CPF", 100).TextAlign = HorizontalAlignment.Center;
            cadastroListView.Columns.Add("Valor", 60).TextAlign = HorizontalAlignment.Center;
            cadastroListView.Columns.Add("Código", 60).TextAlign = HorizontalAlignment.Center;
            cadastroListView.Columns.Add("Descrição", 100).TextAlign = HorizontalAlignment.Center;
            cadastroListView.Columns.Add("Estabelecimento", 100).TextAlign = HorizontalAlignment.Center;
            cadastroListView.Columns.Add("Faturamento", 60).TextAlign = HorizontalAlignment.Center;
            cadastroListView.View = View.Details;
        }
        void cadastroItem()
        {
            cpf = Convert.ToInt64(cpfTB.Text); //CPF
            valor = Convert.ToDouble(valorTB.Text); //Valor
            codigo = Convert.ToInt32(codigoTB.Text); //Codigo

            if (foodRB.Checked)
            {
                descricao = descricaoestabelecimentoTB.Text; //Descrição
                estabelecimento = "--"; //Estabelecimento

                Alimentacao pagamento = new Alimentacao(cpf,valor,codigo,descricao);
                pagamentos[i] = pagamento;
                faturamento = pagamento.faturar(valor);
                preencherLista(pagamento,0);
                i++;
                capacidadeMaxima(i);
            }
            else if(healthRB.Checked)
            {
                descricao = "--"; //Descrição
                estabelecimento = descricaoestabelecimentoTB.Text; //Estabelecimento

                Saude pagamento = new Saude(cpf, valor, codigo, estabelecimento);
                faturamento = pagamento.faturar(valor);
                pagamentos[i] = pagamento;
                preencherLista(pagamento,1);
                i++;
                capacidadeMaxima(i);
            }
            else
            {
                MessageBox.Show("Erro de cadastro.");

            }
        }

        void preencherLista(Pagamentos pagamento, int i)
        {
            if (i == 1)
            {
                ListViewItem item = new ListViewItem(new[] {
                        cpf.ToString(),
                        valor.ToString(),
                        codigo.ToString(),
                        descricao,
                        estabelecimento,
                        faturamento.ToString()
                    });
                cadastroListView.Items.Add(item);
            }
            else
            {
                ListViewItem item = new ListViewItem(new[] {
                        cpf.ToString(),
                        valor.ToString(),
                        codigo.ToString(),
                        descricao,
                        estabelecimento,
                        faturamento.ToString()
                    });
                cadastroListView.Items.Add(item);
            }

        }

        void capacidadeMaxima(int i)
        {
            if(i < 6 && i > 0)
            {
                MessageBox.Show("Atualmente há "+ i +" conta(s) cadastrada(s)");
            }
            else
            {
                MessageBox.Show("Atualmente há " + i + " conta(s) cadastrada(s).\nVocê atingiu a capacidade máxima!");

            }
        }
    }
}
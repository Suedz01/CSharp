namespace CadastroPessoas
{
    public partial class Form1 : Form
    {
        //atributos
        Pessoa[] listaDePessoas = new Pessoa[10];

        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            ShowManagement(radioButton1.Checked);
            gerarGradeListViewPf();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ShowManagement(!radioButton2.Checked);
        }

        void ShowManagement(bool state)
        {
            if (state)
            {
                //labels PJ 
                labelCNPJ.Visible = false;
                labelFuncionarios.Visible = false;
                labelFaturamento.Visible = false;
                labelNomeFantasia.Visible = false;
                //textbox PJ
                textBoxCNPJ.Visible = false;
                textBoxFuncionarios.Visible = false;
                textBoxFaturamento.Visible = false;
                textBoxNomeFantasia.Visible = false;
                //label PF
                labelFilhos.Visible = true;
                labelSalario.Visible = true;
                //textBox PF
                textBoxQtdFilhos.Visible = true;
                textBoxSalario.Visible = true;

            }
            else
            {
                //labels
                label3.Visible = true;
                labelCNPJ.Visible = true;
                labelFuncionarios.Visible = true;
                labelFaturamento.Visible = true;
                labelNomeFantasia.Visible = true;
                //textBox PJ
                textBoxCNPJ.Visible = true;
                textBoxFuncionarios.Visible = true;
                textBoxFaturamento.Visible = true;
                textBoxNomeFantasia.Visible = true;
                //label PF
                labelFilhos.Visible = false;
                labelSalario.Visible = false;
                //textBox PF
                textBoxQtdFilhos.Visible = false;
                textBoxSalario.Visible = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxCPF.Text = "";
            textBoxCNPJ.Text = "";
            textBoxNome.Text = "";
            textBoxCidade.Text = "";
            textBoxQtdFilhos.Text = "";
            textBoxFuncionarios.Text = "";
            textBoxSalario.Text = "";
            textBoxFaturamento.Text = "";
            textBoxNomeFantasia.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Checar Pessoa é primeiro com o radial 
            //Salvar conteúdos de textBox no Container
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void gerarGradeListViewPf() // Gera as grades do ListView PF
        {
            listView1.Columns.Add("CPF", 150).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Nome", 150).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Cidade", 100).TextAlign = HorizontalAlignment.Center;
            listView1.View = View.Details;

            string[] item1 = new string[3];
            item1[0] = "João";
            item1[1] = "25";
            item1[2] = "São Paulo";
            listView1.Items.Add(new ListViewItem(item1));
        }
    }
}
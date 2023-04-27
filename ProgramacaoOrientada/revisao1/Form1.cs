namespace revisao1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            configurarListView();

            Bitmap image = new Bitmap("C:/Users/Sued/Desktop/branco.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = image;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap("C:/Users/Sued/Desktop/carro.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = image;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap("C:/Users/Sued/Desktop/moto.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = image;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        void configurarListView()
        {
            /* List View */
            listView1.Columns.Add("Coluna1", 100).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Coluna2", 100).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Coluna3", 100).TextAlign = HorizontalAlignment.Center;
            listView1.View = View.Details;

            listView2.Columns.Add("Coluna1", 100).TextAlign = HorizontalAlignment.Center;
            listView2.Columns.Add("Coluna2", 100).TextAlign = HorizontalAlignment.Center;
            listView2.Columns.Add("Coluna3", 100).TextAlign = HorizontalAlignment.Center;
            listView2.View = View.Details;
        }
        void acrescentarLista()
        {
            /* Acrescentar Item */
            string[] lista = new string[3];

            lista[0] = textBox1.Text; //tanque
            lista[1] = textBox2.Text; //rodas
            lista[2] = textBox3.Text; //cor

            if (radioButton1.Checked) listView1.Items.Add(new ListViewItem(lista));
            else listView2.Items.Add(new ListViewItem(lista));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            acrescentarLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; //tanque
            textBox2.Text = ""; //rodas
            textBox3.Text = ""; //cor
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
using System.Runtime.Versioning;

namespace Revisao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap image = new Bitmap("C:/Users/Sued/Desktop/branco.png");
            pictureBox1.Image = image;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap("C:/Users/Sued/Desktop/circulo.png");
            pictureBox1.Image = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap("C:/Users/Sued/Desktop/retangulo.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = image;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap("C:/Users/Sued/Desktop/trapezio.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = image;
        }
    }
}
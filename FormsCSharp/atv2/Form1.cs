using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            label1.Text = "[Lista de Curses]";
            a = int.Parse(textBox1.Text);
            curse(a);
        }

        private void curse(int a)
        {
            int dado;
            Random number = new Random();

            for (int i = 0; i < a; i++)    // 3curse:|| i=0 
            {
                dado = number.Next(1001);
                if (dado == 1 | dado == 1000)
                {
                    if (dado == 1)
                    {
                        label1.Text = "Dado[1]: O Conjurador MORREU...";
                        i = 1000;
                    }
                    else
                    {
                        label1.Text = "Dado[0]: O inimigo MORRE!";
                        i = 1000;
                    }
                }
                else
                {
                    if (dado == 0)
                    {
                        i--;
                    }

                    else if (dado >= 2 & dado <= 50)
                    {
                        label1.Text = label1.Text + "\nDado[2~50] Causar 5% de dano no inimigo";
                    }
                    else if (dado >= 51 & dado <= 100)
                    {
                        label1.Text = label1.Text + "\nDado[51~100]: Ganhar 5% de Souls";
                    }
                    else if (dado >= 101 & dado <= 130)
                    {
                        label1.Text = label1.Text + "\nDado[101~130]: Causar 5% de dano";
                    }
                    else if (dado >= 131 & dado <= 150)
                    {
                        label1.Text = label1.Text + "\nDado[131~150]: Cause 5% de dano no inimigo";
                    }
                    else if (dado >= 151 & dado <= 175)
                    {
                        label1.Text = label1.Text + "\nDado[151~175]: Roda +3 curses";  //Aumentar a rolagem
                    }
                    else if (dado >= 176 & dado <= 200)
                    {
                        label1.Text = label1.Text + "\nDado[176~200]: Inimigo mais próximo é puxado até você";
                    }
                    else if (dado >= 201 & dado <= 230)
                    {
                        label1.Text = label1.Text + "\nDado[201~230]: Você é puxado pelo inimigo mais próximo";
                    }
                    else if (dado >= 231 & dado <= 250)
                    {
                        label1.Text = label1.Text + "\nDado[231~250]: Causa cegueira por 1 turno";
                    }
                    else if (dado >= 251 & dado <= 275)
                    {
                        label1.Text = label1.Text + "\nDado[251~275]: Desativar Efeito de condição por 1 turno do inimigo";
                    }
                    else if (dado >= 276 & dado <= 300)
                    {
                        label1.Text = label1.Text + "\nDado[276~300]: Inimigo não irá lhe atacar por 1 turno (em x1 o inimigo guarda 1 turno)";
                    }
                    else if (dado >= 301 & dado <= 350)
                    {
                        label1.Text = label1.Text + "\nDado[301~350]: Cause silencio no inimigo por 1 turno (não acumula)";
                    }
                    else if (dado >= 351 & dado <= 400)
                    {
                        label1.Text = label1.Text + "\nDado[351~400]: Ganhar 5% de souls";
                    }
                    else if (dado >= 401 & dado <= 450)
                    {
                        label1.Text = label1.Text + "\nDado[401~450]: Causa Sangramento por 2 turnos, causando 5% de dano por turno";
                    }
                    else if (dado >= 451 & dado <= 500)
                    {
                        label1.Text = label1.Text + "\nDado[451~500]: Causa 5% de dano";
                    }
                    else if (dado >= 501 & dado <= 550)
                    {
                        label1.Text = label1.Text + "\nDado[501~550]: Use uma habilidade de raça aleatória do inimigo";
                    }
                    else if (dado >= 551 & dado <= 600)
                    {
                        label1.Text = label1.Text + "\nDado[551~600]: Seu próximo ataque é 100% de acerto critico";
                    }
                    else if (dado >= 601 & dado <= 650)
                    {
                        label1.Text = label1.Text + "\nDado[601~650]: Enraizar inimigo por 1 turno";
                    }
                    else if (dado >= 651 & dado <= 700)
                    {
                        label1.Text = label1.Text + "\nDado[651~700]: Causa 150% de dano no próximo ataque";
                    }
                    else if (dado >= 701 & dado <= 725)
                    {
                        label1.Text = label1.Text + "\nDado[701~725]: Inimigo sofre Exposto por 1 turno";
                    }
                    else if (dado >= 726 & dado <= 750)
                    {
                        label1.Text = label1.Text + "\nDado[726~750]: Inimigo não Pode usar a raça por 1 turno";
                    }
                    else if (dado >= 751 & dado <= 775)
                    {
                        label1.Text = label1.Text + "\nDado[751~775]: Impede o próximo contra-ataque inimigo";
                    }
                    else if (dado >= 776 & dado <= 800)
                    {
                        label1.Text = label1.Text + "\nDado[776~800]: Impede o próximo de uma criação de souls";
                    }
                    else if (dado >= 801 & dado <= 850)
                    {
                        label1.Text = label1.Text + "\nDado[801~850]: Inimigo fica desarmado por 1 turno";
                    }
                    else if (dado >= 851 & dado <= 875)
                    {
                        label1.Text = label1.Text + "\nDado[851~875]: Você ganha a arma do inimigo por 1 turno";
                    }
                    else if (dado >= 876 & dado <= 900)
                    {
                        label1.Text = label1.Text + "\nDado[876~900]: Todos perdem 20% de vida (aliado e inimigo)";
                    }
                    else if (dado >= 901 & dado <= 910)
                    {
                        label1.Text = label1.Text + "\nDado[901~910]: Todos os inimigos perdem 20% de vida (inimigos)";
                    }
                    else if (dado >= 911 & dado <= 921)
                    {
                        label1.Text = label1.Text + "\nDado[911~921]: Todos os aliados perdem 15% de vida (aliados)";
                    }
                    else if (dado >= 922 & dado <= 930)
                    {
                        label1.Text = label1.Text + "\nDado[922~930]: Todos irão me atacar (aliados irão tentar defender)";
                    }
                    else if (dado >= 931 & dado <= 950)
                    {
                        label1.Text = label1.Text + "\nDado[931~950]: alguém vai ficar com 0% de Souls decidido no dado";
                    }
                    else if (dado >= 951 & dado <= 960)
                    {
                        label1.Text = label1.Text + "\nDado[951~960]: inimigo Fica imóvel por 1 turno";
                    }
                    else if (dado >= 961 & dado <= 970)
                    {
                        label1.Text = label1.Text + "\nDado[961~970]: Eu recebo 5 curses";
                    }
                    else if (dado >= 971 & dado <= 980)
                    {
                        label1.Text = label1.Text + "\nDado[971~980]: Todos perdem as reduções de dano, ninguém pode se defender até o final da luta";
                    }
                    else
                    {
                        label1.Text = label1.Text + "\nDado[981~999]: Todos ficam com 1% de vida e 1% de souls";
                    }
                }
            }
            label1.Text = label1.Text + "\nConta aí para a gente o que veio O.O";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "[Lista de Curses]";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}

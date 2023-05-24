using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Destino();
        }
        private void continuarButton_Click(object sender, EventArgs e)
        {
        }

        public async void DigitarPausadamente(string texto, int intervalo)
        {
            foreach (char c in texto)
            {
                destinoRTB.AppendText(c.ToString()); // adiciona o caractere ao RichTextBox
                await Task.Delay(intervalo); // espera um intervalo de tempo antes de adicionar o pr�ximo caractere
            }
        }


        public void Destino()
        {
            //Introdu��o - Uma luta & 2 decis�es
            string texto = "                O vilarejo Sunville repousava no vale, cercado de montanhas imponentes que emolduravam a paisagem. As casas, feitas de pedras e madeira, formavam ruas sinuosas que pareciam se perder no tempo.\r\n                A pra�a central era o cora��o da aldeia, onde as pessoas se reuniam para conversar, vender seus produtos e celebrar festividades. No centro da pra�a, uma fonte de pedra antiga jorrava �gua cristalina, refrescando a todos em dias de calor.";
            DigitarPausadamente(texto, 15);

            //Criar um sistema de dialogo onde toda vez que aperto continuar,
            //  o dialogo se desenrola;

            /*
                O vilarejo Sunville repousava no vale, cercado de montanhas imponentes que emolduravam a paisagem.
                As casas, feitas de pedras e madeira, formavam ruas sinuosas que pareciam se perder no tempo.
                A pra�a central era o cora��o da aldeia, onde as pessoas se reuniam para conversar, vender
                seus produtos e celebrar festividades. No centro da pra�a, uma fonte de pedra antiga jorrava �gua
                cristalina, refrescando a todos em dias de calor.

                As colinas em torno da aldeia eram verdes e exuberantes, repletas de flores silvestres e
                �rvores frut�feras. O canto dos p�ssaros ecoava pelas ruas estreitas, enquanto os cheiros das
                cozinhas caseiras invadiam as narinas.
                O sol brilhava alto no c�u, iluminando as casas com seus raios dourados.
                A igreja no alto da colina era um marco de Sunville, seu campan�rio se erguia acima das
                �rvores, chamando os fi�is para a missa dominical. Os sinos tocavam alegremente, chamando a
                todos para as celebra��es.

                As pessoas da aldeia se aglomeravam em pequenos grupos, seus olhos fitando o horizonte enquanto
                o medo come�ava a se instalar em seus cora��es. Os p�ssaros voavam em c�rculos, agitados,
                enquanto um vento frio soprava do norte. Naquele dia, havia uma tens�o no ar que n�o
                podia ser ignorada. O que voc� faz?

                << Acalmar a multid�o [Vinho]  --  [Fogo] Averiguar a situa��o >>


                Era um dia tranquilo, como todos os outros, mas algo estava diferente. Os moradores
                come�aram a notar figuras estranhas se aproximando do vilarejo. Um bando de homens selvagens
                montados em cavalos, vestidos em couro e armados at� os dentes. Eles se aproximavam
                em um ritmo constante, empunhando suas espadas e lan�as com destreza.

                Os moradores da aldeia observavam em sil�ncio enquanto os saqueadores se aproximavam,
                suas m�os tremendo e seus cora��es batendo r�pido. Em um instante, a vila foi tomada por
                uma onda de p�nico. As casas foram invadidas, as portas foram quebradas e as pessoas foram
                arrastadas para fora de suas casas. Sem demora, voc� observa uma alde� sendo pisoteada
                multid�o desesperada. Ela pede ajuda mas s� voc� a escuta no mesmo momento em que
                ru�dos abafados de socorro vindos de uma casa em chamas cortam sua percep��o.
                O que voc� faz?

                << "Ningu�m merece morrer pisoteado" [Vinho]  --  [Fogo] "Ningu�m merece morrer queimado" >>    


                O som de metal se chocando contra metal preenchia o ar enquanto os saqueadores lutavam com
                os alde�es. Os gritos e lamentos dos moradores se misturavam com o som das espadas
                cortando o ar. Aos poucos, a aldeia foi transformada em um campo de batalha, um lugar
                onde a morte rondava a cada esquina.
                
                E voce encontra a morte te esperando. Dessa vez ela est� em forma de homem com uma
                lan�a em m�os prostada na frente
                de um beco que leva a sua casa. Ele parece ser amedrontador e te pressiona
                dando um passo em sua dire��o. O que voc� faz?
                
                << Fugir [Vinho]  --  [Fogo] Lutar >>
                

            */



            //Desenvolvimento - Duas lutas & 1 decis�o

            //Conclus�o - 3 lutas

        }
    }
}
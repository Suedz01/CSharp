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
                await Task.Delay(intervalo); // espera um intervalo de tempo antes de adicionar o próximo caractere
            }
        }


        public void Destino()
        {
            //Introdução - Uma luta & 2 decisões
            string texto = "                O vilarejo Sunville repousava no vale, cercado de montanhas imponentes que emolduravam a paisagem. As casas, feitas de pedras e madeira, formavam ruas sinuosas que pareciam se perder no tempo.\r\n                A praça central era o coração da aldeia, onde as pessoas se reuniam para conversar, vender seus produtos e celebrar festividades. No centro da praça, uma fonte de pedra antiga jorrava água cristalina, refrescando a todos em dias de calor.";
            DigitarPausadamente(texto, 15);

            //Criar um sistema de dialogo onde toda vez que aperto continuar,
            //  o dialogo se desenrola;

            /*
                O vilarejo Sunville repousava no vale, cercado de montanhas imponentes que emolduravam a paisagem.
                As casas, feitas de pedras e madeira, formavam ruas sinuosas que pareciam se perder no tempo.
                A praça central era o coração da aldeia, onde as pessoas se reuniam para conversar, vender
                seus produtos e celebrar festividades. No centro da praça, uma fonte de pedra antiga jorrava água
                cristalina, refrescando a todos em dias de calor.

                As colinas em torno da aldeia eram verdes e exuberantes, repletas de flores silvestres e
                árvores frutíferas. O canto dos pássaros ecoava pelas ruas estreitas, enquanto os cheiros das
                cozinhas caseiras invadiam as narinas.
                O sol brilhava alto no céu, iluminando as casas com seus raios dourados.
                A igreja no alto da colina era um marco de Sunville, seu campanário se erguia acima das
                árvores, chamando os fiéis para a missa dominical. Os sinos tocavam alegremente, chamando a
                todos para as celebrações.

                As pessoas da aldeia se aglomeravam em pequenos grupos, seus olhos fitando o horizonte enquanto
                o medo começava a se instalar em seus corações. Os pássaros voavam em círculos, agitados,
                enquanto um vento frio soprava do norte. Naquele dia, havia uma tensão no ar que não
                podia ser ignorada. O que você faz?

                << Acalmar a multidão [Vinho]  --  [Fogo] Averiguar a situação >>


                Era um dia tranquilo, como todos os outros, mas algo estava diferente. Os moradores
                começaram a notar figuras estranhas se aproximando do vilarejo. Um bando de homens selvagens
                montados em cavalos, vestidos em couro e armados até os dentes. Eles se aproximavam
                em um ritmo constante, empunhando suas espadas e lanças com destreza.

                Os moradores da aldeia observavam em silêncio enquanto os saqueadores se aproximavam,
                suas mãos tremendo e seus corações batendo rápido. Em um instante, a vila foi tomada por
                uma onda de pânico. As casas foram invadidas, as portas foram quebradas e as pessoas foram
                arrastadas para fora de suas casas. Sem demora, você observa uma aldeã sendo pisoteada
                multidão desesperada. Ela pede ajuda mas só você a escuta no mesmo momento em que
                ruídos abafados de socorro vindos de uma casa em chamas cortam sua percepção.
                O que você faz?

                << "Ninguém merece morrer pisoteado" [Vinho]  --  [Fogo] "Ninguém merece morrer queimado" >>    


                O som de metal se chocando contra metal preenchia o ar enquanto os saqueadores lutavam com
                os aldeões. Os gritos e lamentos dos moradores se misturavam com o som das espadas
                cortando o ar. Aos poucos, a aldeia foi transformada em um campo de batalha, um lugar
                onde a morte rondava a cada esquina.
                
                E voce encontra a morte te esperando. Dessa vez ela está em forma de homem com uma
                lança em mãos prostada na frente
                de um beco que leva a sua casa. Ele parece ser amedrontador e te pressiona
                dando um passo em sua direção. O que você faz?
                
                << Fugir [Vinho]  --  [Fogo] Lutar >>
                

            */



            //Desenvolvimento - Duas lutas & 1 decisão

            //Conclusão - 3 lutas

        }
    }
}
using System;

class Program
{
    static void Main()
    {
        int menu=0, qtde=0;

        while(menu==0)
        {
            Console.Clear();
            Console.WriteLine("Quantos Curses você pretende castar?");
            qtde = int.Parse(Console.ReadLine());
            curse(qtde);

            Console.WriteLine("E ae, mestrinho... Por acaso você pretende a continuar jogando curses :-) ?\n[0]Sim ou [1]Não?");
            menu = int.Parse(Console.ReadLine());
        }
    }
    static void curse(int a)
    {
        int dado;
        Random number = new Random();
        Console.Clear();

        for(int i = 0; i<a; i++)    // 3curse:|| i=0 
        {
            dado = number.Next(1001);
            if(dado == 1 | dado == 1000)
            {
                if(dado == 1)
                {
                    Console.WriteLine("O Conjurador morreu...");
                    Console.WriteLine("Dado[{0}]:", dado);
                    i=1000;
                }
                else
                {
                    Console.WriteLine("O inimigo irá morrer!");
                    Console.WriteLine("Dado[{0}]:", dado);
                    i=1000;
                }
            }
            else
            {
                if(dado == 0)
                {
                    Console.WriteLine("Curse {0}-\tDado[2~50][{1}]: Nada acontece eheheh", i+1, dado);
                    i--;
                }

                else if(dado >= 2 & dado <=50)
                {
                    Console.WriteLine("Curse {0}-\tDado[2~50][{1}]: Causar 5% de dano no inimigo", i+1, dado);
                }
                else if(dado >= 51 & dado <=100)
                {
                    Console.WriteLine("Curse {0}-\tDado[51~100][{1}]: Ganhar 5% de Souls", i+1, dado);
                }
                else if(dado >= 101 & dado <=130)
                {
                    Console.WriteLine("Curse {0}-\tDado[101~130][{1}]: Causar 5% de dano", i+1, dado);
                }
                else if(dado >= 131 & dado <=150)
                {
                    Console.WriteLine("Curse {0}-\tDado[131~150][{1}]: Cause 5% de dano no inimigo", i+1, dado);
                }
                else if(dado >= 151 & dado <=175)
                {
                    Console.WriteLine("Curse {0}-\tDado[151~175][{1}]: Roda +3 curses", i+1, dado);  //Aumentar a rolagem
                }
                else if(dado >= 176 & dado <=200)
                {
                    Console.WriteLine("Curse {0}-\tDado[176~200][{1}]: Inimigo mais próximo é puxado até você", i+1, dado);
                }
                else if(dado >= 201 & dado <=230)
                {
                    Console.WriteLine("Curse {0}-\tDado[201~230][{1}]: Você é puxado pelo inimigo mais próximo", i+1, dado);
                }
                else if(dado >= 231 & dado <=250)
                {
                    Console.WriteLine("Curse {0}-\tDado[231~250][{1}]: Causa cegueira por 1 turno", i+1, dado);
                }
                else if(dado >= 251 & dado <=275)
                {
                    Console.WriteLine("Curse {0}-\tDado[251~275][{1}]: Desativar Efeito de condição por 1 turno do inimigo", i+1, dado);
                }
                else if(dado >= 276 & dado <=300)
                {
                    Console.WriteLine("Curse {0}-\tDado[276~300][{1}]: Inimigo não irá lhe atacar por 1 turno (em x1 o inimigo guarda 1 turno)", i+1, dado);
                }
                else if(dado >= 301 & dado <=350)
                {
                    Console.WriteLine("Curse {0}-\tDado[301~350][{1}]: Cause silencio no inimigo por 1 turno (não acumula)", i+1, dado);
                }
                else if(dado >= 351 & dado <=400)
                {
                    Console.WriteLine("Curse {0}-\tDado[351~400][{1}]: Ganhar 5% de souls", i+1, dado);
                }
                else if(dado >= 401 & dado <=450)
                {
                    Console.WriteLine("Curse {0}-\tDado[401~450][{1}]: Causa Sangramento por 2 turnos, causando 5% de dano por turno", i+1, dado);
                }
                else if(dado >= 451 & dado <=500)
                {
                    Console.WriteLine("Curse {0}-\tDado[451~500][{1}]: Causa 5% de dano", i+1, dado);
                }
                else if(dado >= 501 & dado <=550)
                {
                    Console.WriteLine("Curse {0}-\tDado[501~550][{1}]: Use uma habilidade de raça aleatória do inimigo", i+1, dado);
                }
                else if(dado >= 551 & dado <=600)
                {
                    Console.WriteLine("Curse {0}-\tDado[551~600][{1}]: Seu próximo ataque é 100% de acerto critico", i+1, dado);
                }
                else if(dado >= 601 & dado <=650)
                {
                    Console.WriteLine("Curse {0}-\tDado[601~650][{1}]: Enraizar inimigo por 1 turno", i+1, dado);
                }
                else if(dado >= 651 & dado <=700)
                {
                    Console.WriteLine("Curse {0}-\tDado[651~700][{1}]: Causa 150% de dano no próximo ataque", i+1, dado);
                }
                else if(dado >= 701 & dado <=725)
                {
                    Console.WriteLine("Curse {0}-\tDado[701~725][{1}]: Inimigo sofre Exposto por 1 turno", i+1, dado);
                }
                else if(dado >= 726 & dado <=750)
                {
                    Console.WriteLine("Curse {0}-\tDado[726~750][{1}]: Inimigo não Pode usar a raça por 1 turno", i+1, dado);
                }
                else if(dado >= 751 & dado <=775)
                {
                    Console.WriteLine("Curse {0}-\tDado[751~775][{1}]: Impede o próximo contra-ataque inimigo", i+1, dado);
                }
                else if(dado >= 776 & dado <=800)
                {
                    Console.WriteLine("Curse {0}-\tDado[776~800][{1}]: Impede o próximo de uma criação de souls)", i+1, dado);
                }
                else if(dado >= 801 & dado <=850)
                {
                    Console.WriteLine("Curse {0}-\tDado[801~850][{1}]: Inimigo fica desarmado por 1 turno", i+1, dado);
                }
                else if(dado >= 851 & dado <=875)
                {
                    Console.WriteLine("Curse {0}-\tDado[851~875][{1}]: Você ganha a arma do inimigo por 1 turno)", i+1, dado);
                }
                else if(dado >= 876 & dado <=900)
                {
                    Console.WriteLine("Curse {0}-\tDado[876~900][{1}]: Todos perdem 20% de vida (aliado e inimigo)", i+1, dado);
                }
                else if(dado >= 901 & dado <=910)
                {
                    Console.WriteLine("Curse {0}-\tDado[901~910][{1}]: Todos os inimigos perdem 20% de vida (inimigos)", i+1, dado);
                }
                else if(dado >= 911 & dado <=921)
                {
                    Console.WriteLine("Curse {0}-\tDado[911~921][{1}]: Todos os aliados perdem 15% de vida (aliados)", i+1, dado);
                }
                else if(dado >= 922 & dado <=930)
                {
                    Console.WriteLine("Curse {0}-\tDado[922~930][{1}]: Todos irão me atacar (aliados irão tentar defender)", i+1, dado);
                }
                else if(dado >= 931 & dado <=950)
                {
                    Console.WriteLine("Curse {0}-\tDado[931~950][{1}]: alguém vai ficar com 0% de Souls decidido no dado", i+1, dado);
                }
                else if(dado >= 951 & dado <=960)
                {
                    Console.WriteLine("Curse {0}-\tDado[951~960][{1}]: inimigo Fica imóvel por 1 turno", i+1, dado);
                }
                else if(dado >= 961 & dado <=970)
                {
                    Console.WriteLine("Curse {0}-\tDado[961~970][{1}]: Eu recebo 5 curses", i+1, dado);
                }
                else if(dado >= 971 & dado <=980)
                {
                    Console.WriteLine("Curse {0}-\tDado[971~980][{1}]: Todos perdem as reduções de dano, ninguém pode se defender até o final da luta", i+1, dado);
                }
                else
                {
                    Console.WriteLine("Curse {0}-\tDado[981~999][{1}]: Todos ficam com 1% de vida e 1% de souls", i+1, dado);
                }
            }
        }
        Console.WriteLine("\nConta aí para a gente o que veio O.O");
    }
}

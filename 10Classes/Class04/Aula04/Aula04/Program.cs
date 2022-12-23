using System;

namespace Aula04
{
    class Program
    {
        int teste;

        static void Main(string[] args)
        {
            char letra = 'c'; //char é um tipo de variável para caractéres
            float num = 5.3f, num1, num2;
            byte bits = 10; //pode armazenar entre 0 e 255 (sem sinal)
            string nome = "Bruno"; //conjunto de char, forma palavras e textos (aspas)
            var aux = 10; //não especifica o tipo, ele é definido na atribuição
            var x2 = num;


            Console.WriteLine("Hello World!");
            Console.WriteLine(x2);
            Console.WriteLine("O meu nome é " + nome + " E o seu?");
            // Console.WriteLine(teste); - teria que ser Static int teste = 0;
        }

        void testando ()
        {
            Console.WriteLine(teste);
        }
    }
}

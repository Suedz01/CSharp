using System;

namespace Aula05
{
    class Program
    {
        static void Main()
        {
            string nome = "Macarrão";
            float preco = 2.9f;
            float porc = 0.012f;

            // (> < >= <=) Condicionais
            // (+ - * /) - Operações
            // & - AND - E
            // | - OR  - OU 
            // \n quebra linha |  \t é um Tab

            float x = 5.4f, z;
            int y = 7;

            y += 1;

            z = x + y;
            Console.WriteLine(z);

            Console.Write("\nO valor da expressão:\n\t{0} + {1} = {2}", x, y, z);
            Console.WriteLine("Portanto... esse valor é maior que 10?");
            if (z > 10)
            {
                Console.WriteLine("Sim");
            }
            else
            {
                Console.WriteLine("Não");
            }

            Console.WriteLine("\n\nPor acaso está entre 15 e 12? Ou 9 e 7?");
            if(z<=15 & z>=12 | z<=9 & z>=7)
            {
                Console.WriteLine("Sim");
            }
            else
            {
                Console.WriteLine("Não");
            }

            Console.WriteLine("Produto:...{0,15}", nome);
            Console.WriteLine("\nPreço:...{0,15:c}", preco);
            Console.WriteLine("\nLucro:...{0,15:p}", porc);
        }
    }
}

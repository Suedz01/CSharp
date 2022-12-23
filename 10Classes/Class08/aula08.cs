using System;
class aula08
{
    static void Main()
    {
        Console.Clear();
        int menu = 0;
        float x1, x2, x3;
        x1=x2=x3=0;
        Console.WriteLine("[1] Faça uma Multiplicação\n[2] Faça uma divisão\n[3] Faça uma subtração\n[4] Faça uma adição\n[5] Sair do Programa");
        menu = int.Parse(Console.ReadLine());
        
        switch(menu)
        {
            case 1:
                Console.WriteLine("Primeiro termo a ser multiplicado: ");
                x1=float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo termo a ser multiplicado: ");
                x2=float.Parse(Console.ReadLine());
                x3 = x1 * x2;

                Console.WriteLine("O resultado da expressão:\n{0} * {1} = {2}", x1, x2, x3);
                Console.Read();
                break;

            case 2:
                Console.WriteLine("Primeiro termo a ser dividido: ");
                x1=float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo termo a ser dividido: ");
                x2=float.Parse(Console.ReadLine());
                x3 = x1 / x2;

                Console.WriteLine("O resultado da expressão:\n{0} / {1} = {2}", x1, x2, x3);
                Console.Read();
                break;

            case 3:
                Console.WriteLine("Primeiro termo a ser subtraído: ");
                x1=float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo termo a ser subtraído: ");
                x2=float.Parse(Console.ReadLine());
                x3 = x1 - x2;

                Console.WriteLine("O resultado da expressão:\n{0} - {1} = {2}", x1, x2, x3);
                Console.Read();
                break;

            case 4:
                Console.WriteLine("Primeiro termo a ser somado: ");
                x1=float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo termo a ser somado: ");
                x2=float.Parse(Console.ReadLine());
                x3 = x1 + x2;

                Console.WriteLine("O resultado da expressão:\n{0} + {1} = {2}", x1, x2, x3);
                Console.Read();
                break;

            case 5:
                Console.WriteLine("Fim do programa...");
                Console.Read();
                break;
        }
    }
}
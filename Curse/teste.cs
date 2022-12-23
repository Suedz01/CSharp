using System;
class aaaa 
{
    static void Main()
    {
        int qtde, resultado;
        Random dado = new Random();
    
        Console.WriteLine("Quantos dados você deseja rodar?");
        qtde = int.Parse(Console.ReadLine());

        for(int i = 0; i<qtde; i++)
        {
            resultado = dado.Next(1001);
            Console.WriteLine(resultado);
        }
    }
}
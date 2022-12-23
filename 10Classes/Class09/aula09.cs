using System;
class aula09
{
    static void Main()
    {
        inicio:
        int i = 0;
        string resp;
        int[] vetor1=new int[4];
        int[] vetor2=new int[4];
        int[] vetor3=new int[4] {2,3,5,7};

        Console.Clear();
        Console.WriteLine("Escreva uma sequência de números que serão multiplicados pelo 3 vetor:");
        Console.WriteLine("Número 1: ");
        vetor1[0] = int.Parse(Console.ReadLine());
        Console.WriteLine("Número 2: ");
        vetor1[1] = int.Parse(Console.ReadLine());
        Console.WriteLine("Número 3: ");
        vetor1[2] = int.Parse(Console.ReadLine());
        Console.WriteLine("Número 4: ");
        vetor1[3] = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Você digitou?");
        while(i<4)
        {
            Console.WriteLine("{0}", vetor1[i]);
            i+=1;
        }
        resp = Console.ReadLine();
        if(resp == "Não" | resp == "Nao" | resp == "nao" | resp == "não")
        {
            goto inicio;
        }

        i=0;
        while(i<4)
        {
            vetor2[i] = vetor1[i] * vetor3[i];
            i+=1;
        }

        Console.WriteLine("O vetor resultante foi:\n");
        i=0;
        while(i<4)
        {
            Console.WriteLine("{0}", vetor2[i]);
            i+=1;
        }
    }
}
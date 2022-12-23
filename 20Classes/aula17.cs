using System;
class aula17
{
    static void Main()
    {
        int div, dis, quo, rest, teste = 0;
        Console.WriteLine("Insira o dividendo: ");
        div = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o divisor: ");
        dis = int.Parse(Console.ReadLine());
        quo = quociente(div, dis, out rest, ref teste);
        Console.WriteLine("O resultado da divisão foi: {0}\nCom um resto de {1}\nVariável teste de ref: {2}", quo, rest, teste);
    }

    static int quociente(int a, int b, out int c, ref int e)    //Ref(Consigo alterar o valor de uma variável em um método alternativo) Out(Consigo retornar duas variáveis) ~ se passam da mesma forma;
    {       //Params pode ajudar na facilidade de inserção de variáveis em um método: static void soma(params int[]nome)
        int d;
        d = a/b;
        c = a%b;
        e = 10;
        return d;
    }
}
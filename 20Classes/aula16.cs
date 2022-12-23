using System;
class aula16
{
    static void Main()      //Bhaskara
    {
        int a, b, c;
        float x;
        Console.WriteLine("Insira o termo a: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o termo b: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o termo c: ");
        c = int.Parse(Console.ReadLine());
        
        x = d(a,b,c);
        Console.WriteLine(x);
    }

    static float d(int x, int y, int z)
    {
        int a;
        a = x + y + z;
        return a;
    }
}
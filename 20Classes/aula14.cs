using System;
class aula14
{
    static void Main()      //Bhaskara
    {
        int a, b, c;
        int delta;

        Console.WriteLine("Insira o termo a: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o termo b: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o termo c: ");
        c = int.Parse(Console.ReadLine());

        delta = delt(a,b,c);
        Console.WriteLine(delta);
        fim(a, b, delta);
    }

    static int delt(int a, int b, int c)
    {
        int delta;
        delta = (b*b) - 4*a*c;
        return delta;
    }

    static void fim(int a, int b, int delt)
    {
        double x1, x2;
        x1 = ((-b) + Math.Sqrt(delt))/(2*a);
        x2 = ((-b) - Math.Sqrt(delt))/(2*a);
        Console.WriteLine(x1);
        Console.WriteLine(x2);        
    }
}
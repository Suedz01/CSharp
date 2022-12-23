using System;
class Pessoa
{
    public double altura;
    public double peso;

    public double Imc()
    {
        return (peso/(altura*altura));
    }

    public void mensagem()
    {
        double x;
        x = Imc();
        Console.WriteLine(x);
        if (x>=0 & x<18.5)
        {
            Console.WriteLine("Abaixo do Peso");
        }
        else if(x>=18.5 & x<25)
        {
            Console.WriteLine("Peso Normal");
        }
        else if(x>=25 & x<30)
        {
            Console.WriteLine("Acima do Peso");
        }
        else if(x>=30 & x<35)
        {
            Console.WriteLine("Obesidade I");
        }
        else if(x>=35 & x<40)
        {
            Console.WriteLine("Obesidade II");
        }
        else
        {
            Console.WriteLine("Obesidade III");
        }
    }
}
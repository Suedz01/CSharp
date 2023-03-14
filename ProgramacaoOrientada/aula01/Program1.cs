using System;

namespace Orientar
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa Joao = new Pessoa();
            Console.WriteLine("Qual a altura do João?");
            Joao.altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a peso do João?");
            Joao.peso = double.Parse(Console.ReadLine());
            Joao.Imc();
            Joao.mensagem();
        }
    }
}
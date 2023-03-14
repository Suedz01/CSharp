using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{

  public class Program
  {
    static void Main(string[] args)
    {
      int escolha;
      double quantia;
      Cliente Alex = new Cliente("Alex", 250.56);

      do
      {
        Console.Clear();
        Console.WriteLine("Menu:\nOpção#1: Sacar\nOpção#2: Depositar\nOpção#3: Consular Saldo\nOpção#4: Sair");
        escolha = int.Parse(Console.ReadLine());
        switch (escolha)
        {
          case 1:
            Console.WriteLine("Qual valor gostaria sacar?");
            quantia = double.Parse(Console.ReadLine());
            Alex.sacar(quantia);
            break;
          case 2:
            Console.WriteLine("Qual valor gostaria Depositar?");
            quantia = double.Parse(Console.ReadLine());
            Alex.depositar(quantia);
            break;
          case 3:
            Alex.consultarSaldo();
            Console.ReadLine();
            break;
          case 4:
            Console.WriteLine("Você fechou o app");
            Console.ReadLine();
            break;
        }
      } while (escolha != 4);

    }
  }
}
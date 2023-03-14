using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_Um
{
  public class Program
  {
    static void Main(string[] args)
    {
      Resistor r1 = new Resistor(); //criação de obj (default)
      Resistor r2 = new Resistor(2.8, 3.1); //construtor inicializador
      Resistor r4 = new Resistor(10, 5); //construtor inicializador
      Resistor r3; //construtor inicializador
      Resistor r5;

      r3 = r2.resistorSerie(r1);
      r5 = r2.resistorParalelo(r4);

      r1.imprime();
      Console.ReadLine();
      r2.imprime();
      Console.ReadLine();
      r3.imprime();
      Console.ReadLine();
      r5.imprime();

    }
  }
}
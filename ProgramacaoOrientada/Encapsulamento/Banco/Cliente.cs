using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
  class Cliente
  {
    //atributos
    public string nome;
    public int idade;
    public string cpf;
    public double saldo;

    //construtor precisa ser escrito com o nome da classe
    public Cliente()
    {
      nome = "";
      idade = 0;
      cpf = "000.000.000-00";
      saldo = 0.0;

    }
    public Cliente(string nomeCompleto, double saldoInicial)
    {
      //utilizar os atributos
      nome = nomeCompleto;
      saldo = saldoInicial;
      cpf = "000.000.000-00";
      idade = 0;
    }

    public void depositar(double quantia)
    {
      this.saldo += quantia;
    }
    public void consultarSaldo()
    {
      Console.WriteLine("O seu saldo atual é de " + this.saldo);
    }
    public void sacar(double quantia)
    {
      this.saldo -= quantia;
    }
  }
}
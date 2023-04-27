using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaConta_Especial
{
    class Conta
    {
        //atributos
        protected string numeroConta;
        protected double saldo;

        public Conta()
        {
            numeroConta = "";
            saldo = 0;

        }
        public Conta(string _nConta, double _saldo)
        {
            numeroConta = _nConta;
            this.saldo = _saldo;
        }

        //Métodos
        public void deposito(double quantia)
        {
            saldo += quantia;
        }

        public virtual void saque(double quantia)
        {
            if (saldo >= quantia) saldo -= quantia;
            else MessageBox.Show("Saque Impossível");
        }

        public void verSaldo(double quantia)
        {
            saldo += quantia;
        }

        public string NumeroConta { get => numeroConta; set => numeroConta = value; }
        public double Saldo { get => saldo; set => saldo = value; }
    }
}

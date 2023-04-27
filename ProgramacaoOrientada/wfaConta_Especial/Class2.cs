using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaConta_Especial
{
    class ContaEspecial : Conta
    {
        double limite;
        public ContaEspecial(String _numeroConta, double _saldo, double _limite) : base(_numeroConta,_saldo) {
            limite = _limite;
            saldo += _saldo + limite;
        }
        public override void saque(double quantia) 
        {
            if (saldo >= quantia + limite) saldo -= quantia + limite;
            else MessageBox.Show("Saque impossíve - Limite Ultrapassado");
        }

        public double Limite { get => limite; set => limite = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    internal class Saude : Pagamentos
    {
        /*atributos*/
        string estabelecimento;
        double valorFaturaSaude;

        /*construtor - ari 5*/
        public Saude(long _cpf, double _valor, int _codigo, string _estabelecimento) : base(_cpf, _valor, _codigo)
        {
            this.Codigo = _codigo;
            this.Cpf = _cpf;
            this.Valor = _valor;
            this.valorFaturaSaude = 0.0;
            this.estabelecimento = _estabelecimento;
        }

        /*metodos*/
        public override double faturar(double valor)
        {
            double valorFinal = valor * 1.12;
            return valorFinal;
        }

        /*encapsulamento*/
        public string Estabelecimento { get => estabelecimento; set => estabelecimento = value; }
        public double ValorFaturaSaude { get => valorFaturaSaude; set => valorFaturaSaude = value; }
    }
}

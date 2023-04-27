using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    internal class Alimentacao : Pagamentos
    {
        /*atributos*/
        string descricao;
        double valorFaturaAlimentacao;

        /*construtor - ari 5*/
        public Alimentacao(long _cpf, double _valor, int _codigo, string _descricao) : base(_cpf, _valor, _codigo)
        {
            this.Codigo = _codigo;
            this.Cpf = _cpf;
            this.Valor = _valor;
            this.valorFaturaAlimentacao = 0.0;
            this.descricao = _descricao;
        }

        /*metodos*/
        public override double faturar(double valor)
        {
            double valorFinal = valor * 1.05;
            return valorFinal;
        }

        /*encapsulamento*/
        public string Descricao { get => descricao; set => descricao = value; }
        public double ValorFaturaSaude { get => valorFaturaAlimentacao; set => valorFaturaAlimentacao = value; }
    }
}

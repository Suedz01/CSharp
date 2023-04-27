using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    internal class Pagamentos
    {
        /*atributos*/
        private long cpf;
        private double valor;
        private int codigo;

        /*construtor - ari 0*/
        public Pagamentos()
        {
            this.cpf = 0;
            this.valor = 0;
            this.codigo = 0;
        }

        /*construtor - ari 3*/
        public Pagamentos(long _cpf, double _valor, int _codigo)
        {
            this.cpf = _cpf;
            this.valor = _valor;
            this.codigo = _codigo;
        }

        /*metodos*/
        public virtual double faturar(double valor) 
        {
            return 0.0;
        }

        /*encapsulamento*/
        protected long Cpf { get => cpf; set => cpf = value; }
        protected double Valor { get => valor; set => valor = value; }
        protected int Codigo { get => codigo; set => codigo = value; }
    }
}

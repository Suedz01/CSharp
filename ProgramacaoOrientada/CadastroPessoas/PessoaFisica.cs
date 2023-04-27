using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    class PessoaFisica : Pessoa
    {
        //atributos
        string cpf;
        int qtdFilhos;
        double salario;

        //construtor
        public PessoaFisica(string _cpf, int _qtdFilhos, double _salario,
            string _nome, string _cidade) : base(_nome, _cidade)
        {
            this.cpf = _cpf;
            this.qtdFilhos = _qtdFilhos;
            this.salario = _salario;
        }

        //metodo
        public override double CalCredito()
        {
            return ((salario * 12) - (qtdFilhos * 10));   
        }

        //getters and setters
        public string Cpf { get => cpf; set => cpf = value; }
        public int QtdFilhos { get => qtdFilhos; set => qtdFilhos = value; }
        public double Salario { get => salario; set => salario = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaBancodeDadosFinanciadora
{
    class Pessoa
    {
        string cpf;
        string nome;
        double salario;

        public Pessoa(string _cpf, string _nome, double _salario)
        {
            cpf = _cpf;
            nome = _nome;
            salario = _salario;
        }

        public double calcCredito()
        {
            return salario*6.0;
        }

        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Salario { get => salario; set => salario = value; }
    }
}

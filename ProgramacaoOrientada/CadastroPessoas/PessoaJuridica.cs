using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    class PessoaJuridica : Pessoa
    {
        //atributos
        string cnpj, nomeFantasia;
        int qtdFuncionarios;
        double faturamento;

        //construtor
        public PessoaJuridica(string _cnpj, string _nomeFantasia,
            int _qtdFuncionarios, double _faturamento, string _nome,
            string _cidade): base(_nome, _cidade)
        {
            this.cnpj = _cnpj;
            this.nomeFantasia = _nomeFantasia;
            this.qtdFuncionarios = _qtdFuncionarios;
            this.faturamento = _faturamento;
        }

        //metodos
        public override double CalCredito()
        {
            return ((faturamento * 12) + (qtdFuncionarios * 10));
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    class Pessoa
    {
        //atributos
        protected string cidade;
        protected string nome;

        //construtores
        public Pessoa(string _nome, string _cidade)
        {
            this.nome = _nome;
            this.cidade = _cidade;
        }

        //metodos
        public virtual double CalCredito()
        {
            return 0.0;
        }

        //getters and setters
        protected string Nome { get => nome; set => nome = value; }
        protected string Cidade { get => cidade; set => cidade = value; }
    }
}

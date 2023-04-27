using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaMateriasAlunos
{
    class Materia
    {
        //atributos
        private string nome;
        private string codigo;


        //metodos
        public Materia()
        {
            nome = "";
            codigo = "";
        }
        public Materia(string _nome, string _codigo)
        {
            this.nome = _nome;
            this.codigo = _codigo;
        }
        //getters and setters

        public string Nome { get => nome; set => nome = value; }
        public string Codigo { get => codigo; set => codigo = value; }

    } //fim da classe materia
}

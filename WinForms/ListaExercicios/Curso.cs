using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios
{
    class Curso
    {
        string codigo;
        string descricao;
        string nomeCoordenador;

        //atributos
        string nome;
        public Curso(string _codigo, string _descricao, string _nomeCoordenador)
        {
            codigo = _codigo;
            descricao = _descricao;
            nomeCoordenador = _nomeCoordenador;
        }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string NomeCoordenador { get => nomeCoordenador; set => nomeCoordenador = value; }
    }
}

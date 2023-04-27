using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaMateriasAlunos
{
    class Aluno
    {
        //atributos
        private string nome;
        private string numeroMatricula;
        private int periodo;
        public Materia[] lista_materias;

        //metodos
        public Aluno()
        {
            nome = "";
            numeroMatricula = "";
            periodo = 1;
        }
        public Aluno(string _nome, string _numeroMatricula, int _periodo)
        {
            this.nome = _nome;
            this.numeroMatricula = _numeroMatricula;
            this.periodo = _periodo;
            lista_materias = new Materia[8];
        }

        //getters and setters
        public string Nome { get => nome; set => nome = value; }
        public string NumeroMatricula { get => numeroMatricula; set => numeroMatricula = value; }
        public int Periodo { get => periodo; set => periodo = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    internal class Aluno
    {
        string matriculaAluno;
        string nomeAluno;
        double nota1;
        double nota2;
        double nota3;
        string codigoTurma;

        public Aluno(string _nomeAluno, string _matriculaAluno, double _nota1, double _nota2, double _nota3, string _codigoTurma)
        {
            this.codigoTurma = _codigoTurma;
            this.nota1 = _nota1;
            this.nota2 = _nota2;
            this.nota3 = _nota3;
            this.nomeAluno = _nomeAluno;
            this.matriculaAluno = _matriculaAluno;
        }

        public string MatriculaAluno { get => matriculaAluno; set => matriculaAluno = value; }
        public string NomeAluno { get => nomeAluno; set => nomeAluno = value; }
        public string CodigoTurma { get => codigoTurma; set => codigoTurma = value; }
        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }
        public double Nota3 { get => nota3; set => nota3 = value; }
    }
}

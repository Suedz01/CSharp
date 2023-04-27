using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caHeranca
{
    public class Empregado
    {
        //Classe Mãe
        private String nome;
        private String secao;
        private double salario;

        protected string Nome { get => nome; set => nome = value; }
        protected string Secao { get => secao; set => secao = value; }
        protected double Salario { get => salario; set => salario = value; }

        public Empregado()
        {
            nome = "";
            secao = "";
            salario = 0;
        }
        public Empregado(String _nome, String _secao, double _salario)
        {
            this.nome = _nome;
            this.secao = _secao;
            this.salario = _salario;
        }

        public virtual void aumentaSalario(double percentual)
        {
            salario *= 1 + percentual / 100;
        }


        //getters();
        //setters();
    }
}

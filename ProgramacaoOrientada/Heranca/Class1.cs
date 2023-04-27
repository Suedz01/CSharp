using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caHeranca
{
    public class Gerente : Empregado
    {
        //Classe Filha
        private String secretaria;

        public Gerente() : base() {
        }
        public Gerente(String _nome, String _secao, double _salario, String _secretaria) : base(_nome, _secao, _salario) { }

        public override void aumentaSalario(double percentual)
        {
            this.Salario += percentual;
            base.aumentaSalario(Salario);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class Hero
    {
        //info
        protected string nome;
        //stats
        protected int hp;
        protected int def;
        protected int agi;
        public Hero(string _nome, int _hp, int _def, int _agi)
        {
            this.nome = _nome;
            this.hp = _hp;
            this.def = _def;
            this.agi = _agi;
        }


    }
}

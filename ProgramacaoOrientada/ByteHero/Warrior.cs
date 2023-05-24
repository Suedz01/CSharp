using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class Warrior : Hero
    {
        int attackDamage;
        public Warrior(string _nome, int _hp, int _def, int _agi, int _attackDamage) : base(_nome,_hp,_def,_agi)
        {
            this.attackDamage = _attackDamage;
        }

    }
}

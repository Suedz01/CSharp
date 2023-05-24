using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class Paladin : Hero
    {
        int attackDamage;
        int magicPower;
        public Paladin(string _nome, int _hp, int _def, int _agi, int _attackDamage, int _magicPower) : base(_nome, _hp, _def, _agi)
        {
            this.attackDamage = _attackDamage;
            this.magicPower = _magicPower;
        }
    }
}

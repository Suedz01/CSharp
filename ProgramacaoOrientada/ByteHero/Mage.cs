using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class Mage : Hero
    {
        int magicPower;
        public Mage(string _nome, int _hp, int _def, int _agi, int _magicPower) : base(_nome, _hp, _def, _agi)
        {
            this.magicPower = _magicPower;
        }

    }
}

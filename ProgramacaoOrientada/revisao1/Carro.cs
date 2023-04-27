using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao1
{
    internal class Carro : Veiculo
    {
        int passageiros;

        public Carro(int _rodas, string _cor, int _tanque, int _passageiros): base(_tanque, _rodas, _cor)
        {
            this.passageiros = _passageiros;
            this.rodas = 4;
        }

        public int Passageiros { get => passageiros; set => passageiros = value; }

        public override double EncherTanque()
        {
            return 0.0;
        }

        public override string TrocarCor()
        {
            return "a";
        }
    }
}

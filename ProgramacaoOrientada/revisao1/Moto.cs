using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao1
{
    internal class Moto: Veiculo
    {
        int velocidade;
        public Moto(int _rodas, string _cor, int _tanque, int _passageiros, int _velocidade) :base(_rodas, _cor, _tanque)
        {
            this.velocidade = _velocidade;
        }

        public int Velocidade { get => velocidade; set => velocidade = value; }

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao1
{
    internal class Veiculo
    {
        protected int rodas;
        protected string cor;
        protected int tanque;

        public Veiculo(int _rodas, string _cor, int _tanque)
        {
            this.rodas = _rodas;
            this.cor = _cor;
            this.tanque = _tanque;
        }

        public Veiculo(int tanque, int rodas, string cor)
        {
            this.tanque = tanque;
            this.rodas = rodas;
            this.cor = cor;
        }

        public virtual string TrocarCor()
        {
            return "a";
        }
        public virtual double EncherTanque()
        {
            return 0.0;
        }

        public int Rodas { get => rodas; set => rodas = value; }
        public string Cor { get => cor; set => cor = value; }
        public int Tanque { get => tanque; set => tanque = value; }
    }
}

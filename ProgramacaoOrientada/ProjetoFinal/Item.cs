using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class Item
    {
        string nome;
        string descricao;
        int valor;
        public Item(string _nome, string _descricao, int _valor)
        {
            this.nome = _nome;
            this.descricao = _descricao;
            this.valor = _valor;
        }

        public virtual void Usar()
        {
        }
    }
}

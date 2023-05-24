using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    internal class Materia
    {
        string nomeMateria;
        string descricaoMateria;
        string areaMateria;
        string salaMateria;

        public Materia()
        {

        }
        public Materia(string _nomeMateria, string _descricaoMateria, string _areaMateria, string _salaMateria)
        {
            this.nomeMateria = _nomeMateria;
            this.descricaoMateria = _descricaoMateria;
            this.areaMateria = _areaMateria;
            this.salaMateria = _salaMateria;
        }

        public string NomeMateria { get => nomeMateria; set => nomeMateria = value; }
        public string DescricaoMateria { get => descricaoMateria; set => descricaoMateria = value; }
        public string AreaMateria { get => areaMateria; set => areaMateria = value; }
        public string SalaMateria { get => salaMateria; set => salaMateria = value; }
    }
}

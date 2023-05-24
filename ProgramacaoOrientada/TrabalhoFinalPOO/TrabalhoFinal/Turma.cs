using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    internal class Turma
    {
        string codigoTurma;
        string descricaoTurma;
        int vagasTurma;
        string materiaTurma;

        public Turma(string _codigoTurma, string _descricaoTurma, int _vagasTurma, string _materiaTurma)
        {
            this.codigoTurma = _codigoTurma;
            this.vagasTurma = _vagasTurma;
            this.descricaoTurma = _descricaoTurma;
            this.materiaTurma = _materiaTurma;
        }

        public string CodigoTurma { get => codigoTurma; set => codigoTurma = value; }
        public string DescricaoTurma { get => descricaoTurma; set => descricaoTurma = value; }
        public int VagasTurma { get => vagasTurma; set => vagasTurma = value; }
        public string MateriaTurma { get => materiaTurma; set => materiaTurma = value; }
    }
}

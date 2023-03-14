using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_Um
{
    class Resistor
    {
        //atributos
        double resistencia;
        double pot_max;

        //construtores
        public Resistor() //Aridade 0
        {
            resistencia = 0.0;
            pot_max = 0.0;
        } //default (aridade)

        //Inicializar com valores de interesse
        public Resistor(double r, double p)
        {
            resistencia = r;
            pot_max = p;
        }//inicializando valores

        public void imprime()
        {
            Console.WriteLine("Resistência: " + resistencia);
            Console.WriteLine("Potência Máxima: " + pot_max);
        }

        //Resistencia em série, soma-se
        //Potencia em série, pega-se a menor
        //Passagem por parâmetros
        public Resistor resistorSerie(Resistor R)
        {
            //"this" se refere ao atributo do objeto que chamou o método
            //Criação de Objeto
            Resistor rEQ = new Resistor();
            //Calculo das Resistencias
            rEQ.resistencia = this.resistencia + R.resistencia;
            //Calculo da Potencia Maxima
            if (this.pot_max <= R.pot_max)
            {
                rEQ.pot_max = this.pot_max;
            }
            else
            {
                rEQ.pot_max = R.pot_max;
            }
            return (rEQ);
        }

        public Resistor resistorParalelo(Resistor R)
        {
            //Criação de Objeto
            Resistor rEQ = new Resistor();

            //Calculo das Resistencias
            rEQ.resistencia = (this.resistencia * R.resistencia) / (this.resistencia + R.resistencia);

            //Calculo da Potencia Maxima
            if (this.pot_max <= R.pot_max)
            {
                rEQ.pot_max = this.pot_max;
            }
            else
            {
                rEQ.pot_max = R.pot_max;
            }
            return (rEQ);
        }
    }//Fim da classe
}
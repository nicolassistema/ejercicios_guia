using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_formas
{
   public sealed class Circulo : Figura
    {

     
        private double radio;

        public override double CalcularSuperficie()
        {
            return Math.PI*(Math.Pow(this.radio ,2));
        }

        public override string Dibujar()
        {
            return "Dibujando circulo";
        }



    }
}

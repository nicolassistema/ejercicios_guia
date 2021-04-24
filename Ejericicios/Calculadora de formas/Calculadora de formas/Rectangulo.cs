using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_formas
{
    public class Rectangulo : Figura
    {

        private double baseRectangulo;
        private double alturaRectangulo;


        public override double CalcularSuperficie()
        {
            return this.baseRectangulo * this.alturaRectangulo;
        }

        public override string Dibujar()
        {
            return "Dibujando rectangulo";
        }


     
     



    }
}

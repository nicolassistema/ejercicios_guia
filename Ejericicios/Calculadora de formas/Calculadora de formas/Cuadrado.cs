using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_formas
{
    public sealed class Cuadrado : Rectangulo
    {
        private double lado;


        public override double CalcularSuperficie()
        {
            return this.lado * 2;
        }

        public override string Dibujar()
        {
            return "Dibujando cuadrado";
        }









    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_formas
{
   public abstract class Figura
    {

           
        public virtual string  Dibujar()
        {
            return "Dibujando Forma";
        }


        public abstract double CalcularSuperficie();// se usa obligatoriamente en las clases derivadas 
        public abstract double CalcularPerimetro();




    }
}

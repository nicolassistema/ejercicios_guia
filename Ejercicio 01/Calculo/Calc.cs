using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    public class Calc
    {
        public static float Maximo(float ingreso, float numeroMaximo)
        {
            if (ingreso > numeroMaximo)
            {
                numeroMaximo = ingreso;
            }
            return numeroMaximo;
        }


        public static float Minimo(float ingreso, float numeroMinimo)
        {
            if (ingreso < numeroMinimo || numeroMinimo == 0)
            {
                numeroMinimo = ingreso;
            }
            return numeroMinimo;
        }

        public static float Sumador(float numero, float numeroDos) => (numero + numeroDos);
        public static float Promedio(float ingreso, int contador) => (ingreso / contador);

    }
}

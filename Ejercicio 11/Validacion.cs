using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11_de_la_guia
{
    public class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool salida = false;

            if (valor >= -100 && valor <= 100)
            {
                salida = true;
            }
            return salida;
        }
    }
}

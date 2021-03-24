using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculador
{
    public static class CalcularNumeroCentrico
    {

        public static bool NumeroCentrico(int numero)
        {
            bool flag = false;
            int sumador = 0;
            int sumadorDos = 0;

            for (int j = numero; j >= 1; j--)
            {
                sumador += j;
            }

            for (int m = numero; m < sumador; m++)
            {
                sumadorDos += m;

                if (sumador == sumadorDos)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
    }
}

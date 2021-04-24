using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericicio_Nro_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 04";


            int contador = 0;
            int numero = 6;
            bool numeroPerfecto;

            do
            {

                numeroPerfecto = ValidarPerfecto(numero);

                if (numeroPerfecto == true)
                {
                    Console.WriteLine($"El numero es : {numero}");
                    contador++;
                }
                numero++;

            } while (contador < 4);

            Console.ReadKey();
        }


        static bool ValidarPerfecto(int param)
        {
            bool retorno = false;
            int acumulador = 0;

            for (int i = 1; i < param; i++)
            {
                if (param % i == 0)
                    acumulador += i;
            }

            if (acumulador == param)
                retorno = true;

            return retorno;
        }


    }

}


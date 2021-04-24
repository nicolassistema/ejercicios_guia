using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calcular;

namespace Ejercicio_Nro_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejericio Nro 03";

            int numero;

            Console.WriteLine("Ingrese el numero: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                if (Calc.EsPrimo(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

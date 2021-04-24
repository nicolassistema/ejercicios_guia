using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_10
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 10";

            int altura;
            int aux;

            Console.Write("Ingrese la altura de la torre: ");
            altura = int.Parse(Console.ReadLine());
            aux = 50 + altura;

            Console.WriteLine();

            for (int i = 1; i <= (altura * 2); i += 2)
            {
                for (int m = aux; m > 0; m--)
                {
                    Console.Write(" ");
                }

                aux -= 1;

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}

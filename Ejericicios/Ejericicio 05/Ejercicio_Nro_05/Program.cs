using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculador;

namespace Ejercicio_Nro_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejerccio Nro 05";

            //inicializo variables
            int numero;
            bool numeroCentrico;
            bool flag = false;

            //input
            Console.WriteLine("Ingrese numero");
            numero = int.Parse(Console.ReadLine());

            //recorro el numero ingresado contando en forma descendente
            for (int i = numero; i > 0; i--)
            {
                //pregunto si el numero del indice tiene numeros centricos
                numeroCentrico = CalcularNumeroCentrico.NumeroCentrico(i);

                if (numeroCentrico && (flag == false))
                {
                    Console.WriteLine($"El numero ingresado tiene los siguientes numeros centricos: ");
                    flag = true;
                }

                if (numeroCentrico)
                {
                    Console.WriteLine(i);
                }

                if (numero < 6)
                {
                    Console.WriteLine($"El numero ingresado NO tiene numeros centricos");
                    break;
                }
            }
        }
    }
}

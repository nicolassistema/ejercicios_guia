using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";
            //Variables
            double numero;

            //Ingreso de numero
            Console.WriteLine("Por favor ingresar un numero: ");
            numero = double.Parse(Console.ReadLine());


            //Validacion de ingreso de numero menor a 1
            if (numero < 1)
            {
                do
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                    Console.WriteLine("Por favor re ingresar un numero mayor a 0: ");
                    numero = double.Parse(Console.ReadLine());
                } while (numero < 1);
            }

            //Imprime resultados
            Console.WriteLine($"El cuadrado del numero {numero} es: {Math.Pow(numero, 2)}");
            Console.WriteLine($"El cubo del numero {numero} es: {Math.Pow(numero, 3)}");
        }
    }
}

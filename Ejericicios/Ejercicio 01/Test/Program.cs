using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculo;


namespace Ejercicio_Nro_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";


            float numero;
            float numeroMax = 0;
            float numeroMin = 0;
            float promedio;
            float acum = 0;
            int contador = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el {i + 1} numero: ");
                numero = int.Parse(Console.ReadLine());
                numeroMax = Calc.Maximo(numero, numeroMax);
                numeroMin = Calc.Minimo(numero, numeroMin);
                acum = Calc.Sumador(numero, acum);
                contador++;

            }
            promedio = Calc.Promedio(acum, contador);

            Console.WriteLine($"El valor maximo es: {numeroMax}");
            Console.WriteLine($"El valor minimo es: {numeroMin}");
            Console.WriteLine($"El promedio es: {promedio}");

        }
    }
}

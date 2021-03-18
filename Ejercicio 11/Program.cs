using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11_de_la_guia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejericio 11 de la guia \n"+"**********************\n");

            //Iniciarlizar variables
            float ingreso;
            float resultadoMaximo = 0;
            float resultadoMinimo = 0;
            float resultadoPromedio;
            float resultadoSuma = 0;
            int contador = 0;

            do
            {
                contador++;

                //Ingreso con valiacion
                Console.Write($"Ingrese el {contador} numero: \n");
                ingreso = float.Parse(Console.ReadLine());
                var flag = Validacion.Validar((int)ingreso, -100, 100);

                if (!flag)//entra si el metodo Validar devuelve false 
                {
                    do
                    {
                        Console.Write($"Por favor re ingrese el {contador} numero: \n");
                        ingreso = float.Parse(Console.ReadLine());
                        flag = Validacion.Validar((int)ingreso, -100, 100);
                    } while (!flag);
                }

                resultadoMaximo = Calculador.Maximo(ingreso, resultadoMaximo);
                resultadoMinimo = Calculador.Minimo(ingreso, resultadoMinimo);
                resultadoSuma = Calculador.Sumador(ingreso, resultadoSuma);

            } while (contador < 10);

            resultadoPromedio = Calculador.Promedio(resultadoSuma, contador);

            Console.Write($"El numero maximo es:{resultadoMaximo} \n");
            Console.Write($"El numero minimo es: {resultadoMinimo} \n");
            Console.WriteLine("El Promedio es: {0:#,###.00} \n", resultadoPromedio);

        }
    }
}

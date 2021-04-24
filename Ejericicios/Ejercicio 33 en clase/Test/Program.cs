using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Entidades
{
    class Program
    {
        private static void MostrarIndices(Libro indexado, int cantidadIndices)
        {
            for (int i = 0; i < cantidadIndices; i++)
            {
                Console.WriteLine($"{indexado[i]}");
            }
        }

        static void Main(string[] args)
        {
            Libro harryPotter = new Libro();

            harryPotter[0] = "Capitulo 1";
            harryPotter[1] = "Capitulo 2";
            harryPotter[2] = "Capitulo 3";

            MostrarIndices(harryPotter, 4);

            harryPotter[0] = "Capitulo 0";
            harryPotter[1] = "Capitulo 1.1";

            MostrarIndices(harryPotter, 2);

            Console.ReadKey();
        }
    }
}

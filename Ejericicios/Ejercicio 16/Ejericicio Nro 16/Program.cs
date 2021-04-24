using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_de_clases;

namespace Ejericicio_Nro_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 16";

            Alumno[] listaAlumnos = new Alumno[3];//genero un array de objetos del tipo Alumno

            //instancia de la clase 
            listaAlumnos[0] = new Alumno("nicolas", "letticugna", 333666, 5, 4, 0);
            listaAlumnos[1] = new Alumno("Juan", "Perez", 123456, 1, 1, 0);
            listaAlumnos[2] = new Alumno("Pedro", "Gomez", 888456, 8, 7, 0);



            for (int i = 0; i < listaAlumnos.Length; i++)
            {
                listaAlumnos[i].CalcularFinal();
                listaAlumnos[i].Mostrar();
            }


        }
    }
}

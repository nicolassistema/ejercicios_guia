using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_con_op_impli_y_explic;

namespace Practica_Ejer_Alumno
{
    class Program
    {
        static void Main(string[] args)
        {

            int lejajoAlumno2;
            long dniAlumno1;

            Alumno alumno1 = new Alumno("Juan", "Perez", 30865445);

            Alumno alumno2 = new Alumno("Jon", "Smith", 41456778, 107645);

            //convercion implicita
            lejajoAlumno2 = alumno2;
            //convercion explicita
            dniAlumno1 = (long)alumno1;

            //if (alumno1 + 102345)
            //{
            //    Console.WriteLine("Se pudo realizar la suma! Valor del legajo: {0}", alumno1.GetLegajo());
            //}

            alumno1 += 102345;
            Console.WriteLine("Legajo Alumno 1: {0}\n", alumno1.GetLegajo());


            Console.WriteLine("Legajo Alumno 2: {0}", lejajoAlumno2);
            Console.WriteLine("Dni Alumno 1: {0}\n", dniAlumno1);

            Console.WriteLine("Son iguales?: {0}\n", alumno1 == alumno2);
            Console.WriteLine("Son distintos?: {0}\n", alumno1 != alumno2);

            Console.ReadKey();



        }
    }
}

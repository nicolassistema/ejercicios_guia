using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public class Alumno
    {
        //variables
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        private string apellido;
        private string nombre;
        private int legajo;


        //constructores

        public Alumno(string nombre, string apellido, int legajo, byte nota1, byte nota2, float notaFinal)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.notaFinal = notaFinal;
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }


        public Alumno(string nombre, string apellido, int legajo)
        {

            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }

        //*********************************************************************************************
        //setter
        public void CambiarNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void CambiarApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public void CambiarLegajo(int legajo)
        {
            this.legajo = legajo;
        }

        public void CambiarNotas(byte nota1, byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public void CambiarNotaFinal(float notaFinal)
        {
            this.notaFinal = notaFinal;
        }


        //getter

        public string obtenerNomApeLeg()
        {
            return nombre + " " + apellido + " " + legajo;
        }

        public string obtenerAlumnoCompleto()
        {
            return nombre + " " + apellido + " " + legajo + " " + nota1 + " " + nota2 + " " + notaFinal;
        }

        public byte ObtenerNota1()
        {
            return nota1;
        }

        public byte ObtenerNota2()
        {
            return nota2;
        }
        //*********************************************************************************************


        //metodos varios
        public void Estudiar(byte nota1, byte nota2)
        {
            CambiarNotas(nota1, nota2);
        }

        public void CalcularFinal()
        {
            int nota1Uax = Convert.ToInt32(this.ObtenerNota1());
            int nota2Uax = Convert.ToInt32(this.ObtenerNota2());
            float resultado;

            resultado = ((float)(nota1Uax + nota2Uax) / 2);

            if (nota1Uax >= 4 && nota2Uax >= 4)
            {
                this.CambiarNotaFinal(resultado);
            }
            else
            {
                this.CambiarNotaFinal(-1);
            }
        }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Apellido: " + this.apellido);
            sb.AppendLine("Legajo: " + this.legajo);
            sb.AppendLine("Nota 1: " + this.nota1);
            sb.AppendLine("Nota 2: " + this.nota2);


            if (this.notaFinal != -1)
            {
                sb.AppendLine("Nota Final: " + this.notaFinal);
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }
            Console.WriteLine(sb.ToString());
        }



    }
}

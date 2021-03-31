using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_con_op_impli_y_explic
{
    public class Alumno
    {
        //atributos
        private string nombre;
        private string apellido;
        private int legajo;
        private int numero;
        private long dni;


        //constructores
        public Alumno(string nombre, string apellido,  long dni, int legajo)
        :this( nombre,  apellido, dni)
        {
            this.legajo = legajo;
        }

        public Alumno(string nombre, string apellido, long dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.legajo = 0;
        }


        public void SetLegajo(Alumno alumno, int legajo)
        {
            alumno.legajo = legajo;
        }

        public long GetLegajo()
        {
            return this.legajo;
        }

        //casteo explicito que va a devolver el dni
        public static explicit operator long (Alumno alumno)
        {
            return alumno.dni;
        }

        //casteo implicito que va a devolver el legajo (es una convercion definida por el usuario)
        public static implicit operator int(Alumno alumno)
        {
            return alumno.legajo;
        }




        ///<summary>
        ///Agrega el lagajo al alumno y si pudo agregarlo retorna true
        /// </summary>
        ///<param name="alumno"></param>
        ///<param name="legajo"></param>
        ///<returns>retorna true si el legajo pusdo ser cargado</returns>
        //public static bool operator +(Alumno alumno, int legajo)
        //{
        //    bool retorno = false;
        //    alumno.SetLegajo(alumno,legajo);
        //    if (alumno.legajo != 0)
        //    {
        //        retorno = true;
        //    }
        //    return retorno;
        //}

        ///<summary>
        ///Agrega el lagajo al alumno
        /// </summary>
        ///<param name="alumno"></param>
        ///<param name="legajo"></param>
        ///<returns>retorna un alumno con el legajo agregado</returns>

        public static Alumno operator +(Alumno alumno, int legajo)
        {
            alumno.SetLegajo(alumno, legajo);

            return alumno;
        }



        ///<summary>
        ///Compara si dos alumnos son iguales por su legajo 
        /// </summary>
        ///<param name="alumno"></param>
        ///<param name="legajo"></param>
        ///<returns>retorna true si son iguales y false si son distintos</returns>
        // Explicito
        public static bool operator ==(Alumno alumno1, Alumno alumno2)
        {
            bool retorno = false;
            if (alumno1.legajo==alumno2.legajo)
            {
                retorno = true;
            }
            return  retorno; 
        }



        ///<summary>
        ///Compara si dos alumnos son disitntos por su legajo 
        /// </summary>
        ///<param name="alumno"></param>
        ///<param name="legajo"></param>
        ///<returns>retorna true si son distintos y false si son iguales</returns>

        public static bool operator !=(Alumno alumno1, Alumno alumno2)
        {
            return !(alumno1 == alumno2);// esta llamando al metodo operador explicito anterior
        }





    }
}

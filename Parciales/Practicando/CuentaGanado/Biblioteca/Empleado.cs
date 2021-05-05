using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
#pragma warning disable CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
    public class Empleado : Persona
#pragma warning restore CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
#pragma warning restore CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
    {
        int dni; 

        public Empleado(short edad, string nombre) : base(edad, nombre)
        {
        }

        public Empleado(short edad, string nombre, int dni) : this(edad, nombre)
        {
            this.dni = dni;
        }


        public int Dni 
        {
            get
            {
                return this.dni;
            }
         
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            if (this.Dni != -1)
            {
                sb.Append($"DNI: {this.Dni}");
            }
            else
            {
                sb.Append("No se cargó un empleado");
            }

            sb.AppendLine("\nES EMPLEADO");
            sb.AppendLine(base.Mostrar());

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Validar()
        {

            char[] arr;

            arr = this.Nombre.ToCharArray();

            if (this.Edad > 21 && arr.Length>2)
            {
                return true;
            }
            return false;
        }



        public static bool operator ==(Empleado e1, Empleado e2)
        {
            if (e1.Edad == e2.Edad && e1.Nombre.Equals(e2.Nombre))
            {
                return true;
            }
            return false; 
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaClases
{
    public class Cliente
    {
       private  string nombre;
        private string apellido;
        private string domicilio;
        private string telefono;
        private string mascota;

        public Cliente(string nombre, string apellido, string domicilio, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
        } 



        //setter
        public void CambiarNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void CambiarApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public void CambiarDomicilio(string domicilio)
        {
            this.domicilio = domicilio;
        }

        public void CambiarTelefono(string telefono)
        {
            this.telefono = telefono;
        }

        //getter

        public string obtenerCliente()
        {

            return nombre + " " + apellido + " " + domicilio + " " + telefono;
        }

    }
}

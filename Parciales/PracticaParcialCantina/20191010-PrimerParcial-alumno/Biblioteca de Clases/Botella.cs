using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public abstract class Botella
    {

        int capacidadML;
        int contenidoML;
        string marca;

        public Botella(string marca, int capacidadML,int contenidoML)
        {
            this.capacidadML = capacidadML;
            this.contenidoML = contenidoML;
            this.marca = marca;
        }

        public virtual string GenerarInforme()
        {


            return "Informe";
        }


        public int ServirMedida()
        {


            return;
        }


        public string ToString()
        {

            return;
        }

        public int CapacidadLitros
        { 
            get
            {
                return this.capacidadML;
            }
        }


        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
            set
            {
                this.contenidoML = contenidoML;
            }
        }


        public float PorcentajeContenido
        {
            get
            {
                return this.contenidoML;
            }
        }



        public enum Tipo
        {
           Plastico,
           Vidrio
        }






    }
}

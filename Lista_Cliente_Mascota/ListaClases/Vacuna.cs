using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaClases
{
    public class Vacuna
    {
        private string nombreVacuna;

        //constructor
        public Vacuna(string nombreVacuna)
        {
            this.nombreVacuna = nombreVacuna;
        }


        //getter
        public String ObtenerNombreVacuna()
        {
            return this.nombreVacuna;
        }

        //setter
        public String AgregarNombreVacuna()
        {
            if (this.nombreVacuna is null)
            {

            }


            return this.nombreVacuna;
        }




    }
}

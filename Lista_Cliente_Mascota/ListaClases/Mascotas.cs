using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaClases
{
    public class Mascotas
    {
        private string nombre;
        private string especie;
        private DateTime fechaNacimiento;
        private Vacuna[] vacunas;


        public Mascotas(string nombre, string especie, DateTime fechaNacimiento, Vacuna[] vacunas)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.fechaNacimiento = fechaNacimiento;
          
        }

        /*
                public Mascotas(string nombre, string especie, string fechaNacimianto, string historialVacunacion)
                {
                    this.nombre = nombre;
                    this.especie = especie;
                    this.fechaNacimianto = fechaNacimianto;
                    this.historialVacunacion = historialVacunacion;
                }

        */

        //setter
        public void CambiarNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void CambiarEspecie(string especie)
        {
            this.especie = especie;
        }

        public void CambiarFechaNAcimiento(string fechaNacimianto)
        {
            this.fechaNacimianto = fechaNacimianto;
        }

        public void CambiarHistorialVacunacion(string historialVacunacion)
        {
            this.historialVacunacion = historialVacunacion;
        }

        //getter

        public string obtenerMascota()
        {

            return nombre + " " + especie + " " + fechaNacimianto + " " + historialVacunacion;
        }

    }
}







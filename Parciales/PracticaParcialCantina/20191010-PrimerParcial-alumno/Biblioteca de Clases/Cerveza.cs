using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    class Cerveza : Botella
    {
        const int MEDIDA = 330;

        Tipo tipo;

        public Cerveza(string marca, int capacidadML, int contenidoML) : base( marca,  capacidadML,  contenidoML)
        {
           
        }

        public Cerveza(string marca, int capacidadML,Tipo tipo, int contenidoML) : base(marca, capacidadML, contenidoML)
        {
            this.tipo = tipo;
        }


        public override string GenerarInforme()
        {
            return "Informe";
        }










    }
}

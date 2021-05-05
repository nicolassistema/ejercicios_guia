using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Planta 
    {

        string nombre;
        int  tamanio;

        public Planta(string nombre, int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }


        public virtual string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{nombre} tiene un tamaño de {tamanio}");
            if (TieneFlores)
            {
                sb.AppendLine($"Tiene flores si");
            }
            else
            {
                sb.AppendLine($"Tiene flores no");
            }

            if (TieneFruto)
            {
                sb.AppendLine($"Tiene fruto si");
            }
            else
            {
                sb.AppendLine($"Tiene fruto no");
            }


            return sb.ToString();

        }

        public int  Tamanio 
        {
            get
            {
                return this.tamanio;
            }
        }

        public abstract bool TieneFlores
        {
            get;
        }

        public abstract bool TieneFruto
        {
            get;
        }





    }
}

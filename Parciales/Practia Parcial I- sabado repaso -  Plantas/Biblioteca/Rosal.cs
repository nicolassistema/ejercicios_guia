using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Rosal : Planta
    {
        Color florColor;

        public Rosal(string nombre, int tamanio) : base(nombre, tamanio)
        {

        }

        public Rosal(string nombre, int tamanio, Color flor) : this(nombre, tamanio)
        {
            this.florColor = flor;
        }




        public override bool TieneFlores
        {
            get
            {
                return true;
            }
        }

        public override bool TieneFruto
        {
            get
            {
                return false;
            }
        }

          
        public enum Color
        {
            Roja,
            Blanca,
            Amarilla,
            Rosa,
            Azul
        }


        public override string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ResumenDeDatos());

            sb.AppendLine($"Flores de color: {this.florColor}");

            return sb.ToString();
        }


    }
}

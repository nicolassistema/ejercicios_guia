using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Rosal : Planta
    {

        private Color florColor;

        public Rosal(string nombre, int tamanio) : base(nombre, tamanio)
        {
        }

        public Rosal(string nombre, int tamanio, Color color) : this(nombre, tamanio)
        {
            this.florColor = color;
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
            sb.AppendLine(base.ResumenDeDatos());
            sb.AppendLine($"Flores de color {this.florColor}");
            return sb.ToString();
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Bananno : Planta
    {
        string codigo;


        public Bananno(string codigo, int tamanio, string nombre ) : base(nombre, tamanio)
        {
            this.codigo = codigo;
        }


        public override string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ResumenDeDatos());

            sb.AppendLine($"Código internacional: {this.codigo}");

            return sb.ToString();
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
                return true;
            }
        }




    }
}

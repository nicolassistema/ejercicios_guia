﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bliblioteca
{
    public class Pera : Ingrediente
    {

        private string tipo;

        public Pera(string descripcion, int cantidad, string tipo) : base(cantidad, descripcion)
        {
            this.tipo = tipo;
        }

        public override string Proceso
        {
            get
            {
                return "cubitar";
            }
        }

        public override string UnidadDeMedida
        {
            get
            {
                return "unidades";
            }
        }



        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Informacion());
            sb.AppendLine($"Tipo: {this.tipo}");
            return sb.ToString();
        }



    }
}

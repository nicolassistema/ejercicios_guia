﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bliblioteca
{
    public class Rucula : Ingrediente
    {

        public Rucula(string descripcion, int cantidad) :base(cantidad, descripcion)
        {
         
        }

        public override string Proceso
        {
            get
            {
                return "cortar";
            }
        }

        public override string UnidadDeMedida
        {
            get
            {
                return "hojas";
            }
        }





    }
}

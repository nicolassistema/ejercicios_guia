﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Arbusto : Planta
    {

  
        public Arbusto(string nombre, int tamanio): base(nombre, tamanio)
        {

        }



        public override bool TieneFlores
        {
            get
            {
                return false;
            }
        }

        public override bool TieneFruto
        {
            get
            {
                return false;
            }
        }




    }
}

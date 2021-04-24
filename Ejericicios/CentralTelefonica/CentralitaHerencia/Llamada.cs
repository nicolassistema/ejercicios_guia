﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
            
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }


        public virtual  string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"duracion: {this.duracion}");
            sb.AppendLine($"numero destuinfo: {this.nroDestino}");
            sb.AppendLine($"numero origen: {this.nroOrigen}");
            return sb.ToString();
        }


       public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion > llamada2.Duracion)
            {
                return 1;
            }
            else if(llamada1.Duracion == llamada2.Duracion)
            {
                return -1;
            }
            return 0;
        }



        public float Duracion 
        {
            get
            {
                return this.duracion;
            }
        }


        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }


        public string NroOrigen
        {
            get
            {
                return this.nroDestino;
            }
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        } 



    }
}

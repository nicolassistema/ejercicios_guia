using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        List<Llamada> listaDellamadas ;
        string razonSocial;

        public Centralita()
        {
            this.listaDellamadas = new List<Llamada>();
        }


        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }


        public  string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon social : {this.razonSocial}");
            sb.AppendLine($"Ganacia total: {this.GananciasPorTotal}");
            sb.AppendLine($"Ganancia Provincial: {this.GananciasPorProvincial}");
            sb.AppendLine($"Ganancia Local: {this.GananciasPorLocal}");

            foreach (var item in listaDellamadas)
            {
                sb.AppendLine($"Detalle: { item.Mostrar()}");
            }
            return sb.ToString();
        }


        private float CalcularGanancias(Llamada.TipoLlamada tipo)
        {
            float acumulador = 0;

            foreach (Llamada auxLlamada in this.listaDellamadas)//Recorro la lista de llamadas
            {
                if (tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas)//accedo a cada item de la llamada y filtro si es local o provincial
                {
                    if (auxLlamada is Local)
                    {
                        acumulador += ((Local)auxLlamada).CostoLlamada;
                    }
                }
                if (tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas)
                {
                    if (auxLlamada is Provincial)
                    {
                        acumulador += ((Provincial)auxLlamada).CostoLlamada;
                    }
                }
            }
            return acumulador;
        }


        public List<Llamada> Llamadas
        {
            get
            {
              return  this.listaDellamadas;
            }
        }


        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancias(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancias(Llamada.TipoLlamada.Provincial);
            }
        }


        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancias(Llamada.TipoLlamada.Todas);
            }
        }

        public void OrdenarLlamadas()
        {
            this.listaDellamadas.Sort(Llamada.OrdenarPorDuracion);
        }




    }

}

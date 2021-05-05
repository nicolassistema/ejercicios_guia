using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jardin
    {

        int espacioTotal;
        private List<Planta> plantas;
        static Tipo suelo;

        static Jardin()
        {
            suelo = Tipo.Terrozo;
        }

        private Jardin()
        {
            plantas = new List<Planta>();
        }

        public Jardin(int espacioTotal):this()
        {
            this.espacioTotal = espacioTotal;
        }

        public Tipo TipoSuelo
        {
            set
            {
                suelo = value;
            }
        }


        public int  EspacioOcupado()//esto devuelve el total de tamaños de plantas cargadas
        {
            int acumulador = 0;

            foreach (Planta item in plantas)
            {
                acumulador += item.Tamanio;
            }
            return acumulador;
        }


        public int EspacioOcupado(Planta planta)//esto agrega el tamaños de una planta a el total de tamaños de plantas
        {
            return EspacioOcupado() + planta.Tamanio;
        }


        public static bool operator +(Jardin jardin, Planta planta)
        {
            
            if (jardin != null && planta != null)
            {
                if (jardin.EspacioOcupado(planta)<=jardin.espacioTotal)
                {
                    jardin.plantas.Add(planta);
                    return true;
                }
            }

            return false;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Composición del Jardín: {Jardin.suelo}");
            sb.AppendLine($"Espacio ocupado {EspacioOcupado()} de {espacioTotal}");
            sb.AppendLine("Lista de plantas");
            sb.AppendLine("****************");
            foreach (Planta item in plantas)
            {
                sb.AppendLine(item.ResumenDeDatos());
            }
            return sb.ToString();
        }


        public enum Tipo
        {
            Terrozo,
            Arenoso
        }

    }
}

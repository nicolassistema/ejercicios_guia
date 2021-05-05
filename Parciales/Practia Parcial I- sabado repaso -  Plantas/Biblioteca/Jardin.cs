using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jardin
    {
        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo;



        public enum Tipo
        {
            Terrozo,
            Arenoso
        }


        public Tipo Suelo
        {
            set
            {
                suelo = value;// como suelo es estatico no va con this
            }
        }



        static Jardin()
        {
            suelo = Tipo.Terrozo;
        }

        private Jardin()
        {
            plantas = new List<Planta>();
        }


        public Jardin(int espacioTotal) : this()
        {
            this.espacioTotal = espacioTotal;
        }

        public int EspacioOcupado()
        {
            int acumulador = 0;

            foreach (Planta item in plantas)
            {
                acumulador += item.Tamanio;

            }

            return acumulador;
        }


        public int EspacioOcupado(Planta planta)
        {
            return EspacioOcupado() + planta.Tamanio;
        }


        public static bool operator +(Jardin jardin, Planta planta)
        {

            if (jardin != null && planta != null)
            {
                if (jardin.EspacioOcupado(planta) <= jardin.espacioTotal)
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





    }

}


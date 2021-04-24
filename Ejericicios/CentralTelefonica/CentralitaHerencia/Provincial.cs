using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public  class Provincial : Llamada
    {

        Franja franjaHoraria;


        public Provincial(Franja franjaHoraria, Llamada llamada) :base(llamada.Duracion, llamada.NroOrigen, llamada.NroDestino)
        {
            this.franjaHoraria = franjaHoraria;
        }


        public Provincial(Franja franjaHoraria,string origen, string destino, float duracion) :base(duracion, origen, destino)
        {
            this.franjaHoraria = franjaHoraria;
        }

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }


        public float CalcularCosto()
        {
            float almacenar = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    almacenar = 0.99F;
                    break;
                case Franja.Franja_2:
                    almacenar = 1.25F;
                    break;
                case Franja.Franja_3:
                    almacenar = 0.66F;
                    break;
                default:
                    break;
            }
            return almacenar * this.Duracion;
        }


        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        } 

    }
}

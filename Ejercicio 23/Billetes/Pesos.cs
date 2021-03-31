using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes

{ 
   public class Pesos
    {
         private double cantidad;
          private static double cotizRespectoDolar;

        public Pesos()
        {
            cotizRespectoDolar = 66;
        }

        public Pesos(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
           cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }


        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static implicit operator Pesos(double p)
        {
            Pesos auxiliar = new Pesos(p);
            return auxiliar;
        }

        public static explicit operator Dolar(Pesos p)
        {
            Dolar dolar = new Dolar(p.cantidad / Pesos.GetCotizacion());
            return dolar;
        }


        public static explicit operator Euro(Pesos p)
        {
           
            Euro euro = new Euro(p.cantidad / Pesos.GetCotizacion());
            return euro;
        }


        public static bool operator !=(Pesos p, Euro e)
        {
            bool rta = false;

            if (p.cantidad != ((Pesos)e).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            bool rta = false;

            if (p.cantidad == ((Pesos)e).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            bool rta = false;

            if (p.cantidad != ((Pesos)d).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            bool rta = false;

            if (p.cantidad == ((Pesos)d).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            bool rta = false;

            if (p1.cantidad != p2.cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            bool rta = false;

            if (p1.cantidad == p2.cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            Pesos rta = new Pesos(p.cantidad - (((Pesos)e).cantidad));
            return rta;
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            Pesos rta = new Pesos(p.cantidad + (((Pesos)e).cantidad));
            return rta;
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            Pesos rta = new Pesos(p.cantidad - (((Pesos)d).cantidad));
            return rta;
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            Pesos rta = new Pesos(p.cantidad + (((Pesos)d).cantidad));
            return rta;
        }

    }
}

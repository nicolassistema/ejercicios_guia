using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{

    public class Euro
    {

        double cantidad;
       private  static double cotizRespectoDolar;



        public Euro()
        {
            cotizRespectoDolar = 1;
        }
        public Euro(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
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


        public static implicit operator Euro(double e)
        {
            Euro auxiliar = new Euro(e);
            return auxiliar;
        }

        public static explicit operator Pesos(Euro e)
        {
            Pesos pesos = new Pesos(e.cantidad / Euro.GetCotizacion());
           
            return pesos;
        }

        public static explicit operator Dolar(Euro e)
        {
            Dolar dolar = new Dolar(e.cantidad / Euro.GetCotizacion());
            return dolar;
        }


        public static bool operator !=(Euro e, Pesos p)
        {
            bool rta = false;

            if (e.cantidad != ((Euro)p).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            bool rta = false;

            if (e.cantidad == ((Euro)p).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            bool rta = false;

            if (e.cantidad != ((Euro)d).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            bool rta = false;

            if (e.cantidad == ((Euro)d).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            bool rta = false;

            if (e1.cantidad != e2.cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            bool rta = false;

            if (e1.cantidad == e2.cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            Euro rta = new Euro(e.cantidad - (((Euro)p).cantidad));
            return rta;
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            Euro rta = new Euro(e.cantidad + (((Euro)p).cantidad));
            return rta;
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            Euro rta = new Euro(e.cantidad - (((Euro)d).cantidad));
            return rta;
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            Euro rta = new Euro(e.cantidad + (((Euro)d).cantidad));
            return rta;
        }
    }
}

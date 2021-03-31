using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {

        private  double cantidad;
         private static double cotizRespectoDolar;

        public Dolar()
        {
            cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
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


        //objeto
        //Dolar dolar = new Dolar(5,1)
        //Euro euro = new euro(5,0.92)
        //Pesos pesos = nre Pesos(5,66)
        // Alumno alumno1 = new Alumno("Juan", "Perez", 30865445);

        //convercion explicita
        public static implicit operator Dolar(double d)
        {
            Dolar auxiliar = new Dolar(d);
            return auxiliar;
        }

        public static explicit operator Pesos(Dolar d)
        {
            Pesos pesos = new Pesos(d.cantidad * Pesos.GetCotizacion());
            return pesos;
        }

        public static explicit operator Euro(Dolar d)
        {
            Euro euro = new Euro(d.cantidad * Euro.GetCotizacion());
            return euro;
        }


        public static bool operator !=(Dolar d, Euro e)
        {
            bool rta = false;

            if (d.cantidad != ((Dolar)e).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            bool rta = false;

            if (d.cantidad == ((Dolar)e).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            bool rta = false;

            if (d.cantidad != ((Dolar)p).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            bool rta = false;

            if (d.cantidad == ((Dolar)p).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            bool rta = false;

            if (d1.cantidad != d2.cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            bool rta = false;

            if (d1.cantidad == d2.cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar rta = new Dolar(d.cantidad - (((Dolar)e).cantidad));
            return rta;
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar rta = new Dolar(d.cantidad + (((Dolar)e).cantidad));
            return rta;
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar rta = new Dolar(d.cantidad - (((Dolar)p).cantidad));
            return rta;
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar rta = new Dolar(d.cantidad + (((Dolar)p).cantidad));
            return rta;
        }

    }
}

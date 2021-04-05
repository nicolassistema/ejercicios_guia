using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {

        //atributos
        private double cantidad;
        private static double cotizRespectoDolar;

        //constructores
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

        //getter
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        //operadores de convercion
        public static explicit operator Euro(Dolar d)
        {
            Euro euro = new Euro(d.cantidad / Euro.GetCotizacion());
            return euro;
        }

        public static explicit operator Pesos(Dolar d)
        {
            Pesos peso = new Pesos(d.cantidad * Pesos.GetCotizacion());
            return peso;
        }

        public static implicit operator Dolar(double d)
        {
            Dolar dolar = new Dolar(d * Dolar.GetCotizacion());
            return dolar;
        }

        //operadores 
        public static bool operator ==(Dolar d, Euro e)
        {
            double aux = ((Dolar)e).GetCantidad();
            if (aux == d.GetCantidad())
            {
                return true;
            }
            return false;
        }


        public static bool operator !=(Dolar d, Euro e)
        {
            return !(e.GetCantidad() == d.GetCantidad());
        }



        public static bool operator ==(Dolar d, Pesos p)
        {

            if (d.GetCantidad() == ((Dolar)p).GetCantidad())
            {
                return true;
            }
            return false;
        }


        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d.GetCantidad() == p.GetCantidad());
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            if (d1.GetCantidad() == d2.GetCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1.GetCantidad() == d2.GetCantidad());
        }



        public static Dolar operator +(Dolar d, Euro e)
        {
            double aux;

            aux = ((Dolar)e).cantidad;

            Dolar rta = new Dolar(d.cantidad + aux);

            return rta;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            double aux;

            aux = ((Dolar)e).cantidad;

            Dolar rta = new Dolar(d.cantidad - aux);

            return rta;
        }


        public static Dolar operator +(Dolar d, Pesos p)
        {
            double aux;

            aux = ((Dolar)p).cantidad;

            Dolar rta = new Dolar(d.cantidad + aux);

            return rta;
        }


        public static Dolar operator -(Dolar d, Pesos p)
        {
            double aux;

            aux = ((Dolar)p).cantidad;

            Dolar rta = new Dolar(d.cantidad - aux);

            return rta;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {


        //atributos
        private double cantidad;
        private static double cotizRespectoDolar;

        //constructores
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

        //getter
        public double GetCantidad()
        {
            return cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }


        //operador de convercion

        public static explicit operator Dolar(Pesos p)
        {
            Dolar dolar = new Dolar(p.cantidad / Pesos.GetCotizacion());
            return dolar;
        }

        public static explicit operator Euro(Pesos p)
        {
            double aux;
            aux = ((Dolar)p).GetCantidad();
            Euro euro = new Euro(aux / Euro.GetCotizacion());
            return euro;
        }


        public static implicit operator Pesos(double p)
        {
            Pesos peso = new Pesos(p * Pesos.GetCotizacion());
            return peso;
        }


        //operadores

        public static bool operator ==(Pesos p, Dolar d)
        {
            float aux = (float)((Dolar)p).GetCantidad();
            float auxD = (float)d.GetCantidad();
            if (auxD == aux)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            if ((float)((Dolar)p).GetCantidad() == (float)((Dolar)e).GetCantidad())
            {

                return true;
            }
            return false;
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return (p != e);
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            if (p1.GetCantidad() == p2.GetCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p2.GetCantidad() == p2.GetCantidad());
        }



        public static Pesos operator +(Pesos p, Dolar d)
        {
            double aux;

            aux = ((Pesos)d).cantidad;

            Pesos rta = new Pesos(p.cantidad + aux);

            return rta;
        }


        public static Pesos operator -(Pesos p, Dolar d)
        {
            double aux;

            aux = ((Pesos)d).cantidad;

            Pesos rta = new Pesos(p.cantidad - aux);

            return rta;
        }


        public static Pesos operator +(Pesos p, Euro e)
        {
            double aux;

            aux = ((Pesos)e).cantidad;

            Pesos rta = new Pesos(p.cantidad + aux);

            return rta;
        }


        public static Pesos operator -(Pesos p, Euro e)
        {
            double aux;

            aux = ((Pesos)e).cantidad;

            Pesos rta = new Pesos(p.cantidad - aux);

            return rta;
        }

    }
}

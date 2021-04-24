using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Euro
    {

        //atributos
         private double cantidad;
          private  static double cotizRespectoDolar;


        //constructores
        public Euro()
        {
            Euro.cotizRespectoDolar = 1.08;
        }

        public Euro(double cantidad):this()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this( cantidad)
        {
           Euro.cotizRespectoDolar = cotizacion;
        }

        //setter
        public static void SetCotizacion(double numero)
        {
            Euro.cotizRespectoDolar = numero;
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

        //operador de convercion

        public static explicit operator Dolar(Euro e)
        {
      
            Dolar dolar = new Dolar(e.cantidad * Euro.GetCotizacion());
            return dolar.GetCantidad();
        }

        public static explicit operator Pesos(Euro e)
        {

            double aux = ((Dolar)e).GetCantidad();
            Pesos peso = new Pesos(aux * Pesos.GetCotizacion());
            return peso;
        }


        public static implicit operator Euro(double e)
        {
            Euro euro = new Euro(e);
            return euro;
        }

       


       


        //operadores

        public static bool operator ==(Euro e ,Dolar d)
        {
            double aux = ((Dolar)e).GetCantidad();
            if (aux == d.GetCantidad())
            {
                return true;
            }
            return false;
        }


        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }


        public static bool operator ==(Euro e, Pesos p)
        {
            float auxP = (float)((Dolar)p).GetCantidad();
            float auxE = (float)((Dolar)e).GetCantidad();
            if (auxE == auxP)
            {

                return true;
            }
            return false;
        }


        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }


        public static bool operator ==(Euro e1, Euro e2)
        {
            double auxE1 = ((Dolar)e1).GetCantidad();
            double auxE2 = ((Dolar)e2).GetCantidad();

            if (auxE1 == auxE2)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e2.GetCantidad() == e2.GetCantidad());
        }



        public static Euro operator +( Euro e ,Dolar d)
        {
            double aux;
            aux = ((Euro)d).cantidad;
            Euro rta = new Euro(e.cantidad + aux);
         
            return rta;
        }


        public static Euro operator -(Euro e, Dolar d)
        {
            double aux;

            aux = ((Euro)d).cantidad;

            Euro rta = new Euro(e.cantidad - aux);

            return rta;
        }


        public static Euro operator +(Euro e, Pesos p)
        {
            double aux;

            aux = ((Euro)p).cantidad;

            Euro rta = new Euro(e.cantidad + aux);

            return rta;
        }


        public static Euro operator -(Euro e, Pesos p)
        {
            double aux;

            aux = ((Euro)p).cantidad;

            Euro rta = new Euro(e.cantidad - aux);

            return rta;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejericicio_Nro_20
{
    class Program
    {
        static void Main(string[] args)
        {



            Dolar auxDolar = new Dolar(30);
            Pesos auxPeso = new Pesos(2560);
            Euro auxEuro = new Euro(8);

            Console.Title = "Ejercicio Nro 20";


            if (auxDolar == auxPeso)
            {
                Console.WriteLine("Son iguales");
            }

            if (auxPeso != auxDolar)
            {
                Console.WriteLine("Son distintos");
            }

            Dolar auxDolar2 = auxDolar + auxPeso;

            Console.WriteLine("Cantidad dolares: {0:#,###.00}", auxDolar2.GetCantidad());

            Pesos auxPeso2 = auxPeso + auxDolar;

            Console.WriteLine("Cantidad Pesos: {0:#,###.00}", auxPeso2.GetCantidad());
            //    Euro euro = new Euro(10, 0.809f);
            //    Dolar dolar = new Dolar(10);
            //    Pesos pesos = new Pesos(10, 20.1655f);

            //    Pesos p2 = 10;
            //    Pesos p3 = new Pesos(10);

            //    Euro euroAux = euro + dolar;
            //    Console.WriteLine("Euro + Dólar (€18,09xx): {0}", euroAux.GetCantidad());

            //euroAux = euro - dolar;
            //Console.WriteLine("Euro - Dólar (€18,09xx): {0}", euroAux.GetCantidad());

            //euroAux = euro + pesos;
            //    Console.WriteLine("Euro + Pesos (€10,40xx): {0}", euroAux.GetCantidad());
            //    Console.WriteLine("----------------------------------------------");

            //    Dolar dolarAux = dolar + euro;
            //    Console.WriteLine("Dólar + Euro (U$S22,36xx): {0}", dolarAux.GetCantidad());
            //    dolarAux = dolar + pesos;
            //    Console.WriteLine("Dólar + Pesos (U$S10,49xx): {0}", dolarAux.GetCantidad());
            //    Console.WriteLine("----------------------------------------------");

            //    Pesos pesoAux = pesos + euro;
            //    Console.WriteLine("Pesos + Euro ($259,26xx): {0}", pesoAux.GetCantidad());
            //    pesoAux = pesos + dolar;
            //    Console.WriteLine("Pesos + Dólar ($211,65xx): {0}", pesoAux.GetCantidad());

            //    Console.ReadKey();











        }
    }
}

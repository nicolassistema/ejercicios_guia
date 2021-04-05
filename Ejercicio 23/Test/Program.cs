using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moneda;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            //variables incializadas
            double dolar = 10.8;
            //double pesos = 6000;
            double pesos = 712.8;
            //double euro = 30;
            double euro = 10;

            //instancia de objetos
            Euro euroA = new Euro(euro);
            Dolar dolarA = new Dolar(dolar);
            Pesos pesosA = new Pesos(pesos);
            Console.WriteLine("************************************************************");
            //operadores de Convercion
            Dolar dP = (Dolar)pesosA;
            Dolar dE = (Dolar)euroA;

            Euro eP = (Euro)pesosA;
            Euro eD = (Euro)dolarA;

            Pesos pD = (Pesos)dolarA;
            Pesos pE = (Pesos)euroA;


            Console.WriteLine("De {0} pesos a Dolar {1}", pesos, dP.GetCantidad());
            Console.WriteLine("De {0} Euros a Dolar {1}", euro, dE.GetCantidad());
            Console.WriteLine("De {0} pesos a Euro {1}", pesos, eP.GetCantidad());
            Console.WriteLine("De {0} Dolar a Euro {1}", dolar, eD.GetCantidad());
            Console.WriteLine("De {0} Dolar a Pesos {1}", dolar, pD.GetCantidad());
            Console.WriteLine("De {0} Euros a Pesos {1}", euro, pE.GetCantidad());

            Console.WriteLine("************************************************************");

            //operaciones adicion

            Pesos pMasD= (pesosA + dolarA);
            Pesos pMasE = (pesosA + euroA);

            Dolar dMasP = (dolarA + pesosA);
            Dolar dMasE = (dolarA + euroA);

            Euro eMasD = (euroA+ dolarA);
            Euro eMasP = (euroA + pesosA);



            Console.WriteLine("De {0} pesos + Dolar {1}= {2} pesos", pesos, dolar, pMasD.GetCantidad());
            Console.WriteLine("De {0} pesos + Euro {1}= {2} pesos", pesos, euro, pMasE.GetCantidad());
            Console.WriteLine("De {0} dolar + Pesos {1}= {2} dolar", dolar, pesos, dMasP.GetCantidad());
            Console.WriteLine("De {0} dolar + Euros {1}= {2} dolar", dolar, euro, dMasE.GetCantidad());
            Console.WriteLine("De {0} euro + Dolar {1}= {2} euro", euro, dolar, eMasD.GetCantidad());
            Console.WriteLine("De {0} euro + Pesos {1}= {2} euro", euro, pesos, eMasP.GetCantidad());

            Console.WriteLine("************************************************************");
            // operaciones sustraccion

            Pesos pMenosD = (pesosA - dolarA);
            Pesos pMenosE = (pesosA - euroA);

            Dolar dMenosP = (dolarA - pesosA);
            Dolar dMenosE = (dolarA - euroA);

            Euro eMenosD = (euroA - dolarA);
            Euro eMenosP = (euroA - pesosA);



            Console.WriteLine("De {0} pesos - Dolar {1}= {2} pesos", pesos, dolar, pMenosD.GetCantidad());
            Console.WriteLine("De {0} pesos - Euro {1}= {2} pesos", pesos, euro, pMenosE.GetCantidad());
            Console.WriteLine("De {0} dolar - Pesos {1}= {2} dolar", dolar, pesos, dMenosP.GetCantidad());
            Console.WriteLine("De {0} dolar - Euros {1}= {2} dolar", dolar, euro, dMenosE.GetCantidad());
            Console.WriteLine("De {0} euro - Dolar {1}= {2} euro", euro, dolar, eMenosD.GetCantidad());
            Console.WriteLine("De {0} euro  Pesos {1}= {2} euro", euro, pesos, eMenosP.GetCantidad());
            Console.WriteLine("************************************************************");

            //operaciones igualdad
            Console.WriteLine(" {0} dolares es igual a {1} euros?", dolar, euro);
            if (dolarA == euroA)
            {
                Console.WriteLine("Si son iguales");
            }
            else if (dolarA != euroA)
            {
                Console.WriteLine("NO son iguales");
            }

            

            Console.WriteLine(" {0} dolares es igual a {1} pesos?", dolar, pesos);
            if (dolarA == pesosA)
            {
                Console.WriteLine("Si son iguales");
            }
            else if ((dolarA != pesosA))
            {
                Console.WriteLine("NO son iguales");
            }



            Console.WriteLine(" {0} dolares es igual a {1} dolar?", dolar, dolar);
            if (dolarA == dolarA)
            {
                Console.WriteLine("Si son iguales");
            }
            else if (dolarA != dolarA)
            {
                Console.WriteLine("NO son iguales");
            }

            Console.WriteLine("************************************************************");

            Console.WriteLine(" {0} euros  es igual a {1} dolares?", euro, dolar);
            if (euroA == dolarA)
            {
                Console.WriteLine("Si son iguales");
            }
            else if (euroA != dolarA)
            {
                Console.WriteLine("NO son iguales");
            }



            Console.WriteLine(" {0} euros es igual a {1} pesos?", euro, pesos);
            if (euroA == pesosA)
            {
                Console.WriteLine("Si son iguales");
            }
            else if (euroA != pesosA)
            {
                Console.WriteLine("NO son iguales");
            }



            Console.WriteLine(" {0} euro es igual a {1} euro?", euro, euro);
            if (euroA == euroA)
            {
                Console.WriteLine("Si son iguales");
            }
            else if (euroA != euroA)
            {
                Console.WriteLine("NO son iguales");
            }

            Console.WriteLine("************************************************************");


            Console.WriteLine(" {0} pesos  es igual a {1} dolares?", pesos, dolar);
            if (pesosA == dolarA)
            {
                Console.WriteLine("Si son iguales");
            }
            else if (pesosA != dolarA)
            {
                Console.WriteLine("NO son iguales");
            }



            Console.WriteLine(" {0} pesos es igual a {1} euros?", pesos, euro);
            if (pesosA == euroA)
            {
                Console.WriteLine("Si son iguales");
            }
            else if (pesosA != euroA)
            {
                Console.WriteLine("NO son iguales");
            }



            Console.WriteLine(" {0} pesos es igual a {1} pesos?", pesos, pesos);
            if (pesosA == pesosA)
            {
                Console.WriteLine("Si son iguales");
            }
            else if (pesosA != pesosA)
            {
                Console.WriteLine("NO son iguales");
            }



        }
    }
}

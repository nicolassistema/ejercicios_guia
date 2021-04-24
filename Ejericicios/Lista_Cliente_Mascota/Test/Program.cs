using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaClases;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {


            Cliente clienteUno = new Cliente("nicolas","letticugna","Juan b justo 8112","555-5555");
            /*  clienteUno.CambiarNombre("nicolas");
              clienteUno.CambiarApellido("letticugna");
              clienteUno.CambiarDomicilio("Juan b justo 8112  - CABA");
              clienteUno.CambiarTelefono("555-5555");*/

            string clienteCompleto = clienteUno.obtenerCliente();

            System.Console.WriteLine(clienteCompleto);



            Mascotas mascotaUno = new Mascotas("Bob", "Caniche-Cocker", "15-06-17", "ssa-s-ss");
            /*  clienteUno.CambiarNombre("nicolas");
              clienteUno.CambiarApellido("letticugna");
              clienteUno.CambiarDomicilio("Juan b justo 8112  - CABA");
              clienteUno.CambiarTelefono("555-5555");*/

            string mascotaCompleto = mascotaUno.obtenerMascota();

            System.Console.WriteLine(mascotaCompleto);



        }
    }
}

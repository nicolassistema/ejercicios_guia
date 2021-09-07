using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {


            
            string rutaFile;


            try
            {
                rutaFile = AppDomain.CurrentDomain.BaseDirectory+ "SystemOut__"+ DateTime.Now.ToString("yyyy-MM-dd_HH.mm.ss") + ".log";

                using (StreamWriter aux = new StreamWriter(rutaFile, true))//si es true anexa datos, si es false sobreescribe
                {


                    aux.WriteLine("Escribiendo archivo");
                    //aux.Close(); --> el Close() no hace falta por que cuando termina de ejecutar el scope del using, se cierra el archivo

                }

                Console.ReadKey();

            }
            catch (Exception)
            {

                throw;
            }



        }
    }
}

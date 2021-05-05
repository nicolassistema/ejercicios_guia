using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilbioteca
{
    public class Vaca : Animal
    {
        Clasificacion clasificacion;



        public Vaca(string nombre, int kilosAlimento): base (nombre, kilosAlimento)
        {
           
        }

        public Vaca(string nombre, int kilosAlimento,Clasificacion clasificacion) : this(nombre, kilosAlimento)
        {
            this.clasificacion = clasificacion;
        }

        public override bool ComBalanceado
        {
            get
            {
                return true;
            }
        }

        public override bool ComePasto
        {
            get
            {
                return true;
            }
        }

        public enum Clasificacion
         {
            Lechera,
            Normando,
            Pasiega,
            HolandoArgentina,
            Tudanca
        }


        public override string Datos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Datos());
            sb.AppendLine($"Clasificada como: {this.clasificacion}");
            return sb.ToString();
        }




    }
}

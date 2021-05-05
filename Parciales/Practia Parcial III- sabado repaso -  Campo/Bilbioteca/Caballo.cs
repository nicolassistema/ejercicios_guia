using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilbioteca
{
    public class Caballo : Animal
    {
        bool corredor;

        public Caballo(string nombre, int kilosAlimento): base(nombre, kilosAlimento)
        {
           
        }

        public Caballo(string nombre, int kilosAlimento, bool corredor): this(nombre, kilosAlimento)
        {
            this.corredor = corredor;
        }



        public override bool ComBalanceado
        {
            get
            {
                return false;
            }
        }

        public override bool ComePasto
        {
            get
            {
                return true;
            }
        }


        public override string Datos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Datos());
            sb.AppendLine($"Es de carreras: {this.corredor}");
            return sb.ToString();
        }
        


    }
}

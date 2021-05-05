using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilbioteca
{
    public abstract class Animal
    {
        int kilosAlimento;
        string nombre;


        protected Animal(string nombre, int kilosAlimento)
        {
            this.kilosAlimento = kilosAlimento;
            this.nombre = nombre;
        }

        public abstract bool ComBalanceado
        {
            get;
        }

        public abstract bool ComePasto
        {
            get;
        }

        public int KilosAlimento
        {
            get
            {
                return this.kilosAlimento;
            }
        }


        public virtual string Datos()
        {
  
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format($"{this.nombre} come {this.KilosAlimento}"));
            sb.AppendLine($"consume balanceado {this.ComBalanceado}");
            sb.AppendLine($"consume pasto {this.ComePasto}");

            return sb.ToString(); 
        }








    }
}

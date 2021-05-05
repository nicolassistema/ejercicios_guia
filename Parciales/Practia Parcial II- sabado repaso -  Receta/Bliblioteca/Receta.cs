using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bliblioteca
{
    public class Receta
    {
        private int capacidadDelContenedor;
        private List<Ingrediente> ingredientes;
        private static Tipo preparacion;

        private Tipo Preparacion
        {
            set
            {
               preparacion = value;
            }
        }

        public int CapacidadLibre()
        {
            int acumulador = capacidadDelContenedor;
            foreach (Ingrediente item in ingredientes)
            {
                acumulador -= item.Cantidad;
            }
            return acumulador;
        }

        public int CapacidadLibre(Ingrediente ingrediente)
        {
            return CapacidadLibre() - ingrediente.Cantidad;
        }


        public static bool operator +(Receta receta, Ingrediente ingrediente)
        {
            if (receta != null && ingrediente != null)
            {   
                if (receta.CapacidadLibre(ingrediente) >= 0)
                {
                    receta.ingredientes.Add(ingrediente);
                    return true;
                }
            }
            return false;
        }

        static Receta()
        {
            preparacion = Tipo.Clasica;
        }

        private Receta()
        {
            ingredientes = new List<Ingrediente>();
        }

        public Receta(int capacidad) : this()
        {
            this.capacidadDelContenedor = capacidad;
        }

        enum Tipo
        {
            Clasica,
            Especial
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Receta : {Receta.preparacion}");
            sb.AppendLine($"Capacitdad Libre : {this.CapacidadLibre()}");
            sb.AppendLine($"Capacitdad Total : {this.capacidadDelContenedor}");
            sb.AppendLine($"lista ingredientes : ");
            foreach (Ingrediente item in ingredientes)
            {
                sb.AppendLine($"{item.Informacion()}");
            }
            return sb.ToString();
        }



    }
}

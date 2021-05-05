using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilbioteca
{
    public class Campo
    {
        int alimentoDisponible;
        List<Animal> animales;
        static Tipo servicio;

        public int AlimentoComprometido()
        {
            int acumulador = 0;
            foreach (Animal item in animales)
            {
                acumulador += item.KilosAlimento;
            }
            return acumulador;
        }

        public int AlimentoComprometido(Animal animal)
        {
            return AlimentoComprometido() + animal.KilosAlimento;
        }


        static Campo()
        {
            servicio = Tipo.Engorde;
        }



        private Campo()
        {
             animales = new List<Animal>();
        }

        public Campo(int alimentoDisponible):this()
        {
            this.alimentoDisponible = alimentoDisponible;
        }


        public static bool operator +(Campo campo, Animal animal)
        {
            if (campo != null && animal != null)
            {
                if (  campo.AlimentoComprometido(animal) <= campo.alimentoDisponible)
                {
                    campo.animales.Add(animal);
                    return true;
                }
            }
            return false;
        }


        public Tipo TipoServicio
        {
            set { servicio = value; }
        }

        public enum Tipo
        {
            Pastoreo,
            Engorde
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Servicio del campo: {Campo.servicio}");
            sb.AppendLine($"Alimento comprometido {AlimentoComprometido()} de {alimentoDisponible}");
            sb.AppendLine("Lista de animales");
            sb.AppendLine("****************");
            foreach (Animal item in animales)
            {
                sb.AppendLine(item.Datos());
            }
            return sb.ToString();
        }


    }
}

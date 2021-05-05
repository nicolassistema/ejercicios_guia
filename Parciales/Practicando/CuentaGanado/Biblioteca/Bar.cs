using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public  class Bar
    {
        List<Empleado> empleados;
        List<Gente> gente;
        static Bar singleton;


        static Bar()
        {
            singleton = new Bar();
        }

        private Bar()
        {
            this.empleados = new List<Empleado>();
            this.gente = new List<Gente>();
        }



        public static Bar GetBar()
        {
            if (singleton is null)
            {
                singleton = new Bar();
            }
            return singleton;
        }

        public List<Empleado> Empleados 
        {
            get
            {
                return this.empleados;
            }
        }

        public List<Gente> Gente
        {
            get
            {
                return this.gente; 
            }
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DATOS DEL BAR");
            foreach (Empleado item in empleados)
            {
                sb.AppendLine(item.ToString());
            }

            foreach (Gente item in gente)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public static bool operator +(Bar b, Empleado e)
        {
            if (e.Validar())
            {
                if (b.empleados.Count == 0)
                {
                    b.empleados.Add(e);
                    return true;
                }
                else
                {
                    foreach (Empleado item in b.Empleados)
                    {
                        if (item != e)
                        {
                            b.empleados.Add(e);
                            return true;
                        }
                    }
                }
            }
            return false;
        }



        public static bool operator +(Bar b, Gente g)
        {
            int cantGentePosible = b.empleados.Count * 10;

            if (b.Gente.Count < cantGentePosible & g.Validar())
            {
                b.Gente.Add(g);
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}

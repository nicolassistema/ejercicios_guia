using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {

        List<string> paginas = new List<string>();

        public string this[int i]
        {

            get
            {
                if (i < this.paginas.Count)
                {
                    return this.paginas[i];
                }
                else
                {
                    return "";
                }
            }
            set
            {
                if (i < this.paginas.Count)
                {
                    this.paginas[i] = value;
                }
                else
                {
                    paginas.Add(value);
                }
            }
        }





    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
       public class Rectangulo
    {

        float area;
        float perimetro;
        Punto vertice1;
        Punto vertice2;
        Punto vertice3;
        Punto vertice4;


        public Rectangulo(Punto vertice1, Punto vertice2, Punto vertice3, Punto vertice4) 
        {
            this.vertice1 = vertice1;
            this.vertice2 = vertice2;
            this.vertice3 = vertice3;
            this.vertice4 = vertice4;
        }

        public Rectangulo(float area, float perimetro)
        {
            this.area = area;
            this.perimetro = perimetro;
        }

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
        }


       public Math DistanciaEntreDosPuntos(Punto vertice1, Punto vertice2)
        {

            return Math.Abs(val);
        }

      

        public static decimal Abs(decimal val)
        {
           
            return Math.Abs(val);
        }
            
  



        public float Area()
        {
            return;
        }

        public float Perimetro()
        {
            return;
        }


        public float getPerimetro(float baseRectangulo, float altura)
        {
           
            return baseRectangulo * altura;
        }

        public float getArea(float baseRectangulo, float altura)
        {


            return ((baseRectangulo + altura) * 2);
        }


    }


    
}

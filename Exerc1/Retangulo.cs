using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc1
{
    internal class Retangulo
    {
         int b;
         int h;
         int area;

        public Retangulo()
        {
            b = 0;
            h = 0;
        }

        public Retangulo(int b, int h)
        {
            this.b = b;
            this.h = h;
        }

        public void setBase(int b)
        {
            this.b = b;
        }

        public void setAltura(int h)
        {
            this.h = h;
        }

        public int getBase()
        {
            return this.b;
        }

        public int getAltura()
        {
            return this.h;
        }

        public int getArea()
        {
            return this.area;
        }

        public void Calcular()
        {
            this.area = this.b * this.h;
        }

    }
}

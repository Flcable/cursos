using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_1
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            double ar = Altura * Largura;
            return ar;
        }

        public double Perimetro()
        {
            double per = 2 * (Largura + Altura);
            return per;
        }

        public double Diagonal()
        {
            double diag = Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
            return diag;
        }
    }
}

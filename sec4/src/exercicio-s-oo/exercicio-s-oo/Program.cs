using System;
using System.Globalization;

namespace exercicio_s_oo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o as medidas do triangulo X:");
            double aX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double bX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double cX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o as medidas do triangulo Y:");
            double aY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double bY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double cY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (aX + bX + cX) / 2;
            double areaX = Math.Sqrt(p * (p-aX) * (p - bX) * (p  = cX) );
        }
    }
}

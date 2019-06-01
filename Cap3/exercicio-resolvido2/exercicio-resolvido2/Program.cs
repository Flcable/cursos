using System;
using System.Globalization;

namespace exercicio_resolvido2
{
    class Program
    {
        static void Main(string[] args)
        {
            double _base, altura, area, perimetro, diagonal;

            _base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = _base * altura;
            perimetro = 2 * (_base + altura);
            diagonal = Math.Sqrt(Math.Pow(_base, 2.0) + Math.Pow(altura, 2.0));

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();




        }
    }
}

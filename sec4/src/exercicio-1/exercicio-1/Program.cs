using System;
using System.Globalization;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre com os dados do Retangulo:");
            Console.Write("Altura: ");
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           

            Console.Write("Largula: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = ret.Area();
            double perimetro = ret.Perimetro();
            double diagonal = ret.Diagonal();

            Console.WriteLine("AREA = " + area.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + perimetro.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + diagonal.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}

using System;
using System.Globalization;

namespace exercicio_resolvido02
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, delta;

            string[] numeros = Console.ReadLine().Split();

            a = double.Parse(numeros[0], CultureInfo.InvariantCulture);
            b = double.Parse(numeros[1], CultureInfo.InvariantCulture);
            c = double.Parse(numeros[2], CultureInfo.InvariantCulture);

            delta = ((Math.Pow(b, 2.0)) - 4 * a * c);
            x1 = (-b + (Math.Sqrt(delta))) / (2.0 * a);
            x2 = (-b - (Math.Sqrt(delta))) / (2.0 * a);

            if (delta <= 0.0 || a == 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Console.WriteLine("R1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));

            }

            Console.ReadLine();

        }
    }
}

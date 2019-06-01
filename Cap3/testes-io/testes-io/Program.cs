using System;
using System.Globalization;

namespace testes_io
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double x = 10.35784;

            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));

            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
            */
            /*
            string x;
            int y;
            double z;
            string[] vet = Console.ReadLine().Split(' ');
            x = vet[0];
            y = int.Parse(vet[1]);
            z = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.ReadLine();
            */
            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A, B, C;
            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);
            Console.WriteLine("Raiz quadrada de " + x + " = " + A);
            Console.WriteLine("Raiz quadrada de " + y + " = " + B);
            Console.WriteLine("Raiz quadrada de 25 = " + C);
            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);
            Console.WriteLine(x + " elevado a " + y + " = " + A);
            Console.WriteLine(x + " elevado ao quadrado = " + B);
            Console.WriteLine("5 elevado ao quadrado = " + C);
            A = Math.Abs(y);
            B = Math.Abs(z);
            Console.WriteLine("Valor absoluto de " + y + " = " + A);
            Console.WriteLine("Valor absoluto de " + z + " = " + B);
            Console.ReadLine();
        }
    }
}

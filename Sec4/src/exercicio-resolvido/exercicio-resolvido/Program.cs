using System;
using System.Globalization;

namespace exercicio_resolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = nota1 + nota2;

            if (media <= 60.00)
            {
                Console.WriteLine("Nota Final = " + media.ToString("F1", CultureInfo.InvariantCulture) + " REPROVADO");
            }
            else
            {
                Console.WriteLine("Nota Final = " + media.ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}

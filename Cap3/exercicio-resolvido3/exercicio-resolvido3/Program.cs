using System;
using System.Globalization;

namespace exercicio_resolvido3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            double idade1, idade2, media;

            nome1 = Console.ReadLine();
            idade1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            nome2 = Console.ReadLine();
            idade2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (idade1 + idade2) / 2;

            Console.WriteLine("A idade media de " + nome1 + " e " + nome2 + " é de " + media.ToString("F1", CultureInfo.InvariantCulture) + " anos");

            Console.ReadLine();





        }
    }
}

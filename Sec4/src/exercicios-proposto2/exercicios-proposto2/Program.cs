using System;
using System.Globalization;

namespace exercicios_proposto2
{
    class Program
    {
        //             URI 1037, 1040 (use float), 1041, 1045, 1047, 1049, 1051

       
        static void Main(string[] args)
        // 1037
        {
            /*
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero < 0.0 || numero > 100.0){

                Console.WriteLine("Fora de Intervalo");

            }
            else if (numero <= 25.0){ 

                Console.WriteLine("Intervalo [0, 25]");

            }
            else if (numero <= 50.0){
                Console.WriteLine("Intervalo (25, 50]");

            }
            else if ( numero <= 75.0){
                Console.WriteLine("Intervalo (50, 75]");

            }
            else {
                Console.WriteLine("Intervalo (75, 100]");
            }
            Console.ReadLine(); 
            */
            string[] notas = Console.ReadLine().Split();
            float n1 = float.Parse(notas[0], CultureInfo.InvariantCulture);
            float n2 = float.Parse(notas[1], CultureInfo.InvariantCulture);
            float n3 = float.Parse(notas[2], CultureInfo.InvariantCulture);
            float n4 = float.Parse(notas[3], CultureInfo.InvariantCulture);

            float media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / 10;
            float nExame, mediaFinal;

            if (media >= 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno Aprovado.");
            }else if(media < 5.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno Reprovado.");
            }else
            {
                Console.WriteLine("Aluno em exame");
                nExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                mediaFinal = (media + nExame) / 2;
                if(mediaFinal >= 5.0)
                {
                    Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno em exame");
                    Console.WriteLine("Nota do exame:" + nExame.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno Aprovado.");
                    Console.WriteLine("Media Final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Media Final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno Reprovado.");
                }
               
            }
            
            Console.ReadLine();
        }
    }
}

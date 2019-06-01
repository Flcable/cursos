using System;
using System.Globalization;

namespace exercicio_R3 {
    class Program {
        static void Main(string[] args) {

            int N;
            int[] idades;
            double[] alturas;
            string[] nomes;

            N = int.Parse(Console.ReadLine());

            idades = new int[N];
            alturas = new double[N];
            nomes = new string[N];

            for (int i = 0; i < N; i++) {
                string[] linha = Console.ReadLine().Split(' ');
                nomes[i] = linha[0];
                idades[i] = int.Parse(linha[1]);
                alturas[i] = double.Parse(linha[2], CultureInfo.InvariantCulture);

            }

            double soma = 0.0;
            for (int i = 0; i < N; i++) {
                soma = soma + alturas[i];
            }

            int cont = 0;
            for (int i = 0; i < N; i++) {
                if (idades[i] < 16) {
                    cont++;
                }
            }

            double media = soma / N;
            double perc = (double) cont / N * 100.0;

            Console.WriteLine("A altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pessoas com menos de 16 anos: " + perc.ToString("F2", CultureInfo.InvariantCulture) + "%.");


            Console.ReadLine();
        }
    }
}

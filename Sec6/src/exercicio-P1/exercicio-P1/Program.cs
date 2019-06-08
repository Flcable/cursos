using System;
using System.Globalization;

namespace exercicio_P1 {
    class Program {
        static void Main(string[] args) {

            int n;
            double[] vet;

            n = int.Parse(Console.ReadLine());
            vet = new double[n];
            
            string[] linha = Console.ReadLine().Split();
            for (int i = 0; i < n; i++) {
                vet[i] = double.Parse(linha[i]);
            }

            for (int i = 0; i < n; i++) {

            }




                Console.ReadLine();
        }
    }
}

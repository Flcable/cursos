using System;


namespace exercicio_R1 {
    class Program {
        static void Main(string[] args) {

            int N;
            int[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new int[N];


            /*  */
            string[] linha = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) {
                vet[i] = int.Parse(linha[i]);
            }
            for (int i = 0; i < N; i++) {
                if (vet[i] < 0) {
                    Console.WriteLine(vet[i]);
                }
            }

            Console.ReadLine();
        }
    }
}

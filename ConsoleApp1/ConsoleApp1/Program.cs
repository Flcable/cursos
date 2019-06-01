using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo1,codigo2 , qtd1, qtd2;
            float preco1,preco2, vTotal;

            Console.WriteLine("Digite o codigo da peça: ");
            codigo1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a Quantidade de peças:");
            qtd1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Preço da peça: ");
            preco1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o codigo da peça: ");
            codigo2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a Quantidade de peças:");
            qtd2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Preço da peça: ");
            preco2 = Convert.ToSingle(Console.ReadLine());

            vTotal = preco1 + qtd1 + preco2 + qtd2;


            Console.WriteLine($"O Preço Final é: {vTotal}");

            Console.ReadKey();


        }
    }
}

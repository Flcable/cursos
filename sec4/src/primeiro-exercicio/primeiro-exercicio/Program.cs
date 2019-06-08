using System;
using System.Globalization;

namespace primeiro_exercicio

{
    class Program
    {
       
        static void Main(string[] args)
        {
            /* Pessoa h, m;
             h = new Pessoa();
             m = new Pessoa();

             Console.WriteLine("Digite o nome da pessoa:");
             m.Nome = Console.ReadLine();
             Console.WriteLine("Digite a idade da pessoa:");
             m.Idade = int.Parse(Console.ReadLine());

             Console.WriteLine("Digite o nome da pessoa:");
             h.Nome = Console.ReadLine();
             Console.WriteLine("Digite a idade da pessoa:");
             h.Idade = int.Parse(Console.ReadLine());

             if (h.Idade > m.Idade)
             {
                 Console.WriteLine(h.Nome +" é mais velho");
             }
             else
             {
                 Console.WriteLine(m.Nome + " é mais velha");
             }
             Console.ReadLine();
             */

            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Digite os dados do funcionario: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os dados do funcionario: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mSalaria = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine("Salario Medio: " + mSalaria.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }

    }
}

using System;
using System.Globalization;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.WriteLine("Digite os dados do funcionário: ");
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            


            Console.WriteLine("Funcionário " + func);

            Console.WriteLine();

            Console.WriteLine("Digite a porcentagem a aumentar o salario: ");
            double perc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(perc);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + func);


            Console.ReadLine();
        }
    }
}

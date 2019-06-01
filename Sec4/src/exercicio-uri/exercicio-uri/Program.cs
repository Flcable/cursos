using System;
using System.Globalization;

namespace exercicio_uri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //uri 1038
            int qtd, cod;
            double  total;

            string[] entrada = Console.ReadLine().Split(' ');

            cod = int.Parse(entrada[0]);
            qtd = int.Parse(entrada[1]);

            if (cod == 1)
            {
                total = qtd * 4.00;
            }else if (cod == 2)
            {
                total = qtd * 4.50;
            }else if(cod == 3)
            {
                total = qtd * 5.00;
            }else if ( cod == 4)
            {
                total = qtd * 2.00;
            }
            else 
            {
                total = qtd * 1.50;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
            */
            /*
            //uri 1044

           

            string[] numeros = Console.ReadLine().Split(' ');
            int A = int.Parse(numeros[0]);
            int B = int.Parse(numeros[1]);


            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("São Multiplus");
            }else
            {
                Console.WriteLine("Não são multiplus");
            }

            */
           
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double perc;
            if (salario <= 400.00){
                perc = 15.00;
                
            }
            else if (salario <= 800.00) {
                perc = 12.0;
             
            }
            else if (salario <= 1200.00){
                perc = 10.0;

            }
            else if (salario <= 2000.00){
               perc = 7.0;

            }
            else{
                perc = 4.0;
            }
            
            double reajuste = salario * perc / 100.0;
            double nSalario = salario + reajuste;

            Console.WriteLine("Novo Salario: " + nSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + perc.ToString("F0", CultureInfo.InvariantCulture) + " %");

            Console.ReadLine();


        }
    }
}

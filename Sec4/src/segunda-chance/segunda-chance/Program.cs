using System;
using System.Globalization;

namespace segunda_chance
{
    //Exercicios Uri 1035, 1038, 1044, 1046, 1048
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //-----------------------------------------------------------------1035-----------------------------------------------------
            string[] valores = Console.ReadLine().Split();
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);
            int C = int.Parse(valores[2]);
            int D = int.Parse(valores[3]);

            if (B > C && D > A && C + D > A + B && C >= 0 && D >= 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores Aceitos");
            }
            else
            {
                Console.WriteLine("Valores não aceitos");
            }

            Console.ReadLine();
            */


            /*
             * 
             * 
             * 
             * 
             * 
             * 
            //-----------------------------------------------1038----------------------------------------------------
            //*******************************************REFATORAR***************************************************
            string[] valores = Console.ReadLine().Split(' ');
            int cod = int.Parse(valores[0]);
            int qtd = int.Parse(valores[1]);

            double preco;
            if (cod == 1)
            {
                preco = qtd * 4.00;
                Console.WriteLine("Total: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));

            }else if (cod == 2)
            {
                preco = qtd * 4.50;
                Console.WriteLine("Total: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
            }else if (cod == 3)
            {
                preco = qtd * 5.00;
                Console.WriteLine("Total: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
            }else if (cod == 4)
            {
                preco = qtd * 2.00;
                Console.WriteLine("Total: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
            } else
            {
                preco = qtd * 1.50;
                Console.WriteLine("Total: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();

            */


            //-----------------------------------------------------1044--------------------------------------------
            /*
            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if ( A % B == 0 && B % A == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não são Multiplos");
            }
            Console.ReadLine();

            */

            //----------------------------------------------------------1046--------------------------------------------------------
            /*

            string[] valores = Console.ReadLine().Split(' ');
            int hInicial = int.Parse(valores[0]);
            int hFinal = int.Parse(valores[1]);
            int total;

            if (hInicial > hFinal )
            {
                total = 24 - hInicial + hFinal;
            }
            else if (hInicial < hFinal)
            {
                total = hFinal - hInicial;
            }
            else
            {
                total = 24;
            }

            Console.WriteLine("O JOGO DUROU " + total + " HORA(S)");
            Console.ReadLine();
            */

            
            //------------------------------------------------------1048---------------------------------------------------------------------
            //-----------------------------------------------------REFATORAR-----------------------------------------------------------------

            double salario, nSalario, percentual, reajuste;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.00)
            {
                percentual = 15;
                reajuste = salario * percentual / 100.00;
                nSalario = salario + reajuste;
                

            }
            else if (salario <= 800.00)
            {
                percentual = 12;
                reajuste = salario * percentual / 100.00;
                nSalario = salario + reajuste;

            }
            else if (salario <= 1200.00)
            {
                percentual = 10;
                reajuste = salario * percentual / 100.00;
                nSalario = salario + reajuste;

            }
            else if (salario <= 2000.00)
            {
                percentual = 7;
                reajuste = salario * percentual / 100.00;
                nSalario = salario + reajuste;
            }
            else
            {
                percentual = 4;
                reajuste = salario * percentual / 100.00;
                nSalario = salario + reajuste;
            }


            Console.WriteLine("Novo salario: " + nSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajueste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual " + percentual + " %");
            Console.ReadLine();
        }
    }
}

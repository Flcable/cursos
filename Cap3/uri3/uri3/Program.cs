using System;
using System.Globalization;

namespace uri3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Uri3
            int A, B, SOMA;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            SOMA = A + B;
            Console.WriteLine("SOMA = "+SOMA);
            */

            /*
            //uri1004
            int A, B, PROD;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            PROD = A * B;
            Console.WriteLine("PROD = " + PROD);
            */

            /*
            //uri1005

            double A, B, MEDIA;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            MEDIA = ((A * 3.5) + (B * 7.5)) /11;

            Console.WriteLine("MEDIA = "+MEDIA.ToString("F5"), CultureInfo.InvariantCulture);

            Console.ReadLine();
            */

            /*
            //uri 1006

            double A, B, C, MEDIA;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            MEDIA = ((A * 2) + (B * 3) + (C * 5)) / 10.0;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1"), CultureInfo.InvariantCulture);

            Console.ReadLine();
            */

            /*
            //uri1007

            int A, B, C, D, DIFERENCA;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            DIFERENCA = (A * B - C * D);

            Console.WriteLine("DIFERENCA = " + DIFERENCA);

            Console.ReadLine();
            */

            /*
            //uri1008

            int NUMBER, HWORKED;
            double SALARY, vHWORKED;

            NUMBER = int.Parse(Console.ReadLine());
            HWORKED = int.Parse(Console.ReadLine());
            vHWORKED = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            SALARY = HWORKED * vHWORKED;

            Console.WriteLine("NUMBER = " + NUMBER);
            Console.WriteLine("SALARY = U$ " + SALARY.ToString("F2"), CultureInfo.InvariantCulture);

            Console.ReadLine();

        */


            /*
                //uri1009
                string NAME;
                double SALARY, SALES, tSALARY;

                NAME = Console.ReadLine();
                SALARY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                SALES = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                tSALARY = SALES * 15.0 / 100 + SALARY;

                Console.WriteLine("TOTAL = R$ " + tSALARY.ToString("F2"), CultureInfo.InvariantCulture);

                Console.ReadLine();

            */


            /*
            //uri1010

            int qtd1, qtd2, cod1, cod2;
            double vUnitario1, vUnitario2, valorAPagar;

            string[] valores = Console.ReadLine().Split(' ');

            cod1 = int.Parse(valores[0]);
            qtd1 = int.Parse(valores[1]);
            vUnitario1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');

            cod2 = int.Parse(valores[0]);
            qtd2 = int.Parse(valores[1]);
            vUnitario2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valorAPagar = qtd1 * vUnitario1 + qtd2 * vUnitario2;

            Console.WriteLine("VALOR A PAGAR: R$ " + valorAPagar.ToString("F2"), CultureInfo.InvariantCulture);

            Console.ReadLine();

            */

            /*
            //uri1014

            //using System.Globalization;
            int distancia;
            double tComb, consumo;

            distancia = int.Parse(Console.ReadLine());
            tComb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumo = distancia / tComb;

            Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
            

            Console.ReadLine();

    */
            /*
                    //uri1014

                    int distancia, tempo;

                    distancia = int.Parse(Console.ReadLine());

                    tempo = distancia * 2;

                    Console.WriteLine(tempo + " minutos");

            */
            /*

            int tGasto, vMedia;

            tGasto = int.Parse(Console.ReadLine());
            vMedia = int.Parse(Console.ReadLine());

            double litros = (vMedia / 12.0) * tGasto;


            Console.WriteLine(litros.ToString("F3"), CultureInfo.InvariantCulture);

            Console.ReadLine();

            */
            /* Uri 1011
            double raio, total;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = (4 / 3.0) * 3.14159 * Math.Pow(raio, 3);

            Console.WriteLine("VOLUME = " + total.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();
            */

            /* uri 1012
            double A, B, C, TRIANGULO, CIRCULO, TRAPEZIO, QUADRADO, RETANGULO;

            string[] valores = Console.ReadLine().Split();
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            TRIANGULO = A * C / 2;
            CIRCULO = 3.14159 * C * C;
            TRAPEZIO = ((A + B) / 2) * C;
            QUADRADO = B * B;
            RETANGULO = A * B;

            Console.WriteLine("TRIANGULO: " + TRIANGULO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + CIRCULO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + TRAPEZIO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + QUADRADO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + RETANGULO.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();
            */
            /* uri 1013
            int a, b, c, maiorAB, maior;

            string[] valores = Console.ReadLine().Split(' ');

            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);
            c = int.Parse(valores[2]);

            maiorAB = (a + b + Math.Abs(a - b)) / 2;
            maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

            Console.WriteLine(maior + " eh o maior");

            Console.ReadLine();
            */

            double num1, num2, num3, num4, dist;

            string[] eixoX = Console.ReadLine().Split(' ');
            num1 = double.Parse(eixoX[0], CultureInfo.InvariantCulture);
            num3 = double.Parse(eixoX[1], CultureInfo.InvariantCulture);

            string[] eixoY = Console.ReadLine().Split(' ');
            num2 = double.Parse(eixoY[0], CultureInfo.InvariantCulture);
            num4 = double.Parse(eixoY[1], CultureInfo.InvariantCulture);
          

            dist = Math.Sqrt( Math.Pow((num2 - num1), 2) + Math.Pow((num4 - num3), 2) );


            Console.WriteLine(dist.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();















        }
    }
}

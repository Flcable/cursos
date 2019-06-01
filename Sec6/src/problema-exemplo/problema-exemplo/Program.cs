using System;
using System.Globalization;

namespace problema_exemplo {
    class Program {
        static void Main(string[] args) {
            int n; 
            double[] nV;

           

            n = int.Parse(Console.ReadLine());
            nV = new double[n];



            for (int i=0; i < n; i++) {
                nV[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < n; i++) {
                Console.WriteLine(nV[i].ToString("F1", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Globalization;
using System.Runtime.Intrinsics;
namespace Ex006 {
    class Program {
        static void Main(string[] args) {
            string[] V = Console.ReadLine().Split(' ');
            double A = double.Parse(V[0], CultureInfo.InvariantCulture);
            double B = double.Parse(V[1], CultureInfo.InvariantCulture);
            double C = double.Parse(V[2], CultureInfo.InvariantCulture);
            double pi = 3.14159;

            //a) 
            double tri = ((A * C) / (2.0));
            //b)
            double cir = (Math.Pow(C, 2)) * pi;
            //c)
            double trap = ((A + B) * C) / 2.0;
            //d)
            double quad = (Math.Pow(B, 2));
            //e)
            double ret = A * B;


            Console.WriteLine("TRIANGULO: " + tri.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + cir.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trap.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quad.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + ret.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}

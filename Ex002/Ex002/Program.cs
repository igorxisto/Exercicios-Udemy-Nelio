using System;
using System.Formats.Asn1;
using System.Globalization; 

namespace Ex002 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o valor do Raio de um circulo : ");
            double ray  = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Loading...");
            Double result = ((3.14159) * Math.Pow(ray, 2));
            Console.WriteLine(result.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
};
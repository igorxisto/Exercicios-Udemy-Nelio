using System;
namespace Ex003 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um número : ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número : ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número : ");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número : ");
            int D = int.Parse(Console.ReadLine());
            int Result = ((A * B) - (C * D));

            Console.WriteLine($"A diferença é : {Result}");

        }

    }
}
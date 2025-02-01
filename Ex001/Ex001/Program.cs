using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Ex001 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite dois números separados:");
            string[] vet = Console.ReadLine().Split(' ');
            int n1 = int.Parse(vet[0]);
            int n2 = int.Parse(vet[1]);


            Console.WriteLine(n1);
            Console.WriteLine(n2);
             int conta = n1 + n2;
            Console.WriteLine($"A soma dos números é : " );
            Console.WriteLine(conta);



        }
    };
}


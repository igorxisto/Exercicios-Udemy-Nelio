using System;
using System.Globalization;
using System.Net; 
namespace Ex005 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o código da peça, o número de peças e valor unitário de cada peça : ");
             string [] vet = Console.ReadLine().Split(' ');
            int id_peca1 = int.Parse(vet[0]);
            int qtd_peca1 = int.Parse(vet[1]);
            double value_peca1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double result1 = qtd_peca1 * value_peca1;

            Console.WriteLine("Digite o código da peça, o número de peças e valor unitário de cada peça : ");
            string[] v = Console.ReadLine().Split(' ');
            int id_peca2 = int.Parse(v[0]);
            int qtd_peca2 = int.Parse(v[1]);
            double value_peca2 = double.Parse(v[2], CultureInfo.InvariantCulture);

            double result2 = qtd_peca2 * value_peca2;

            double soma = result1 + result2;
            Console.WriteLine($"Valor a pagar : {soma:F2}", CultureInfo.InvariantCulture);

        }

    };
};
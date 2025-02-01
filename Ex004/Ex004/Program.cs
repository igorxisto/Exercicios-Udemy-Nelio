using System;
using System.Globalization;

namespace Ex004 {
    class Program {
        static void Main(string[] args){
            Console.WriteLine("Digite o ID do funcionário, horas trabalhadas e o salário : ");
            int id = int.Parse(Console.ReadLine());
            double Work_hour = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double wage = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double result = (wage * Work_hour); 

            Console.WriteLine($"Funcionário : {id}");
            Console.WriteLine($"Salary : U$ {result:F2}",CultureInfo.InvariantCulture);
           
        }
    }
}
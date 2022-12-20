using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3._1 {
    internal class Program {
        static void Main(string[] args) {

            int A, B, C, D;

            Console.WriteLine("Digite 4 valores:");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            int difference = A * B - C * D;

            Console.WriteLine($"DIFERENCA = {difference}");
             
        }
    }
}

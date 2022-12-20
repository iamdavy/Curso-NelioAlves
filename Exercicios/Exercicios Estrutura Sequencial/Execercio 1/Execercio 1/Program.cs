using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execercio_1 {
    internal class Program {
        static void Main(string[] args) {

            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            int sum1 = number1 + number2;
            Console.WriteLine($"SOMA = {sum1}");

            Console.WriteLine();

            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());

            int sum2 = number3 + number4;
            Console.WriteLine($"SOMA = {sum2}");

            Console.WriteLine();

            int number5 = int.Parse(Console.ReadLine());
            int number6 = int.Parse(Console.ReadLine());

            int sum3 = number5 + number6;
            Console.WriteLine($"SOMA = {sum3}");
        }
    }
}

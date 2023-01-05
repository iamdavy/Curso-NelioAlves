using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exemplo_1 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Insira um número: ");
            double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (number >= 0.0) {
                
                double root = Math.Sqrt(number);
                Console.WriteLine(root.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Número negativo!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_8 {
    internal class Program {
        static void Main(string[] args) {

            double wage, incomeTax;

            Console.WriteLine("Insira o valor do seu salário:");
            wage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (wage <= 2000.0) {
                incomeTax = 0.0;
            }
            else if (wage <= 3000.0) {
                incomeTax = (wage - 2000.0) * 0.08;
            }
            else if (wage <= 4500.0) {
                incomeTax = (wage - 3000.0) * 0.18 + 1000 * 0.08;
            }
            else {
                incomeTax = (wage - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (incomeTax == 0.0) {
                Console.WriteLine("Isento");
            }
            else
                Console.WriteLine("R$ " + incomeTax.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

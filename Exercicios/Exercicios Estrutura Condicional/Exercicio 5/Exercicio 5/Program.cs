using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_5 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira o código do produto e a quantidade:");
            string[] value = Console.ReadLine().Split(' ');
            int code = int.Parse(value[0]);
            int quantify = int.Parse(value[1]);

            double total;
            if (code == 1) {
                total = 4.0 * quantify;
            }
            else if (code == 2) {
                total = 4.5 * quantify;
            }
            else if (code == 3) {
                total = 5.0 * quantify;
            }
            else if (code == 4) {
                total = 2.0 * quantify;
            }
            else
                total = 1.5 * quantify;

            Console.WriteLine($"Total R${total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

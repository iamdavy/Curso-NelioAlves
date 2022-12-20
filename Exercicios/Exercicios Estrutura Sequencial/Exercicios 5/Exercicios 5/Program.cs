using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios_5 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite os códigos da peças, estoque delas e o valores:");

            string[] vectParts = Console.ReadLine().Split(' ');
            int code1 = int.Parse(vectParts[0]);
            int stock1 = int.Parse(vectParts[1]);
            double value1 = double.Parse(vectParts[2], CultureInfo.InvariantCulture);

            vectParts = Console.ReadLine().Split(' ');
            int code2 = int.Parse(vectParts[0]);
            int stock2 = int.Parse(vectParts[1]);
            double value2 = double.Parse(vectParts[2], CultureInfo.InvariantCulture);

            double valueAll = (stock1 * value1) + (stock2 * value2);

            Console.WriteLine($"VALOR A PAGAR: R$ {valueAll.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

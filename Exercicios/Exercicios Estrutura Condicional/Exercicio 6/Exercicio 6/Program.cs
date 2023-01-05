using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_6 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira qualquer valor:");
            double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(number < 0 || number > 100) {
                Console.WriteLine("Fora de Intervalo");
            }
            else if(number <= 25.00) {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if(number <= 50.00) {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if(number <= 75.0) {
                Console.WriteLine("Intervalo [50,75]");
            }
            else
                Console.WriteLine("Intervalo [75, 100]");
        }
    }
}

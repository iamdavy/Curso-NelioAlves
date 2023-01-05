using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira dois valores inteiros na mesma linha:");
            
            string[] values = Console.ReadLine().Split(' ');
            int number1 = int.Parse(values[0]);
            int number2 = int.Parse(values[1]);

            if(number1 % number2 == 0 || number2 % number1 == 0) {
                Console.WriteLine("Sao múltiplos");
            }
            else
                Console.WriteLine("Nao sao multiplos");
        }
    }
}

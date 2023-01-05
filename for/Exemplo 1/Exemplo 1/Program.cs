using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1 {
    internal class Program {
        static void Main(string[] args) {

            int soma = 0;

            Console.Write("Quantos números inteiros você vai digitar? ");
            int numbers =int.Parse(Console.ReadLine());

            for(int i = 0; i < numbers; i++) {
                Console.Write($"Valor #{i + 1}: ");
                int value = int.Parse(Console.ReadLine());
                soma+= value;
            }

            Console.WriteLine("Soma = " + soma);
        }
    }
}

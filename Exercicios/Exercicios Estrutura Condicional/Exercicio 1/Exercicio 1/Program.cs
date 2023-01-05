using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1 {
    internal class Program {
        static void Main(string[] args) {
            
            int numberInt;

            Console.WriteLine("Insira um número inteiro:");
            numberInt = int.Parse(Console.ReadLine());

            if (numberInt < 0) {
                Console.WriteLine("NEGATIVO");
            }
            else
                Console.WriteLine("NÃO NEGATIVO");
        }
            
    }
}

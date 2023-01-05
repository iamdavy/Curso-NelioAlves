using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2 {
    internal class Program {
        static void Main(string[] args) {

            int numberInt;

            Console.WriteLine("Insira um número inteiro:");
            numberInt = int.Parse(Console.ReadLine());

            if (numberInt % 2 == 0) {
                Console.WriteLine("PAR");
            }
            else
                Console.WriteLine("ÍMPAR");
        }
    }
}

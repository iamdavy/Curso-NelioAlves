using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_2 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Escreva os valores de X e Y:");

            string[] values = Console.ReadLine().Split(' ');
            double x = double.Parse(values[0]);
            double y = double.Parse(values[1]);

            while(x != 0 && y != 0) {
                if(x > 0 && y > 0) {
                    Console.WriteLine("Primeiro");
                }
                else if(x < 0 && y > 0) {
                    Console.WriteLine("Segundo");
                }
                else if(x < 0 && y < 0) {
                    Console.WriteLine("Terceiro");
                }
                else
                    Console.WriteLine("Quarto");

                values = Console.ReadLine().Split(' ');
                 x = double.Parse(values[0]);
                 y = double.Parse(values[1]);
            }
        }
    }
}

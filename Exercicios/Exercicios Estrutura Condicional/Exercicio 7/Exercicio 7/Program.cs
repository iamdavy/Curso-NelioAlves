using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_7 {
    internal class Program {
        static void Main(string[] args) {
            
            double valueX, valueY;

            Console.WriteLine("Escreva os valores de X e Y: ");
            string[] value = Console.ReadLine().Split(' ');
            valueX = double.Parse(value[0]);
            valueY = double.Parse(value[1]);

            if (valueX > 0.0 && valueY > 0.0) {
                Console.WriteLine("Q1");
            }
            else if (valueX < 0.0 && valueY > 0.0) {
                Console.WriteLine("Q2");
            }
            else if (valueX < 0.0 && valueY < 0.0) {
                Console.WriteLine("Q3");
            }
            else if (valueX > 0.0 && valueY < 0.0) {
                Console.WriteLine("Q4");
            }
            else
                Console.WriteLine("Origem");

        }
    }
}

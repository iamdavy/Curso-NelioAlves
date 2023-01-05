using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos {
    internal class Program {

        static int highestNumber(int numberOne, int numberTwo, int numberThree) {

            int bigger;

            if(numberOne > numberTwo && numberOne > numberThree) {
                bigger = numberOne;
            }
            else if(numberTwo > numberThree) {
                bigger = numberTwo;
            }
            else {
                bigger = numberThree;
            }

            return bigger;
        
        }
        static void Main(string[] args) {

            Console.WriteLine("Digite três números:");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            double resultado = highestNumber(number1, number2, number3);

            Console.WriteLine("Maior = " + resultado);
        }
    }
}

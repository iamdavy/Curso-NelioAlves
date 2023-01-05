using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4 {
    internal class Program {
        static void Main(string[] args) {

            int startTime, endTime, duration;

            Console.WriteLine("Insira a hora que começou e a hora que terminou o jogo:");

            string[] values = Console.ReadLine().Split(' ');
            startTime = int.Parse(values[0]);
            endTime = int.Parse(values[1]);

            if (startTime < endTime) {
                duration = endTime - startTime;
            }
            else
                duration = 24 - startTime + endTime;

            Console.WriteLine($"O jogo durou {duration} hora(s)");


        }
    }
}

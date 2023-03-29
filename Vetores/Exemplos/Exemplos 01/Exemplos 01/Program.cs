using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exemplos_01 {
    internal class Program {
        static void Main(string[] args) {

            int numberVect = int.Parse(Console.ReadLine());

            double[] vect = new double[numberVect];

            for(int i = 0; i < numberVect; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for(int i = 0; i < numberVect; i++) {
                sum += vect[i];
            }

            double avg = sum / numberVect;

            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

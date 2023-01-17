using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exemplo_01 {
    internal class Program {

        static double Pi = 3.14;
        static void Main(string[] args) {

            Console.Write("Entre o valor do raio: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circumference = Circumference(radius);
            Console.WriteLine("Circunferência: " + circumference.ToString("F2", CultureInfo.InvariantCulture));

            double volume = Volume(radius);
            Console.WriteLine("Volume = " + volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de Pi: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
        static double Circumference(double radiusFuc) {
            return 2.0 * Pi * radiusFuc;
        }

        static double Volume(double radiusFuc) {
            return 4.0 / 3.0 * Pi * Math.Pow(radiusFuc, 3.0);
        }
    }
}

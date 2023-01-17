using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Exemplo_01._2;

namespace Exemplo_01 {
    internal class Program {

       
        static void Main(string[] args) {

            Console.Write("Entre o valor do raio: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circumference = Calculator.Circumference(radius);
            Console.WriteLine("Circunferência: " + circumference.ToString("F2", CultureInfo.InvariantCulture));

            double volume = Calculator.Volume(radius);
            Console.WriteLine("Volume = " + volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de Pi: " + Calculator.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
       
    }
}

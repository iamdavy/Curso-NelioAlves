using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_6 {
    internal class Program {
        static void Main(string[] args) {

            double a, b, c, triangle, circule, trapeze, square, rectangle;

            Console.WriteLine("Digite 3 valores(mesma linha):");

            string[] values = Console.ReadLine().Split(' ');
            a = double.Parse(values[0], CultureInfo.InvariantCulture);
            b = double.Parse(values[1], CultureInfo.InvariantCulture);
            c = double.Parse(values[2], CultureInfo.InvariantCulture);

            triangle = a * c / 2;
            circule = 3.14159 * (c * c);
            trapeze = ((a + b) * c) / 2;
            square = b * b;
            rectangle = a * b;

            Console.WriteLine($"TRIANGULO: {triangle.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {circule.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {trapeze.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {square.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {rectangle.ToString("F3", CultureInfo.InvariantCulture)}");


        }
    }
}

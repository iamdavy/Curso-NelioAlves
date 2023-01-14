using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_01 {
    internal class Program {
        static void Main(string[] args) {

            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            rectangle.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            rectangle.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + rectangle.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + rectangle.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + rectangle.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exemplo {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite a largura do terreno:");
            double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o comprimento do terreno:");
            double length = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o preço por metro quadrado:");
            double pricePerMeter = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = width * length;
            double price = pricePerMeter * area;

            Console.WriteLine($"AREA = {area.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PRECO = {price.ToString("F2", CultureInfo.InvariantCulture)}");
            


        }
    }
}

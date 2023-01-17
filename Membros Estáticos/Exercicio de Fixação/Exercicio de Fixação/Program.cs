using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_de_Fixação {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação do dólar? ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dõlares você vai comprar? ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = CurrencyConverter.DollarToReal(value, price);
            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

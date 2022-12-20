using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_4 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o numero do funcionário:");
            int employee = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de horas trabalhadas por ele:");
            int workedHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor por hora:");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = workedHours * valuePerHour;

            Console.WriteLine($"NUMBER = {employee}");
            Console.WriteLine($"SALARY = U$ {salary.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}

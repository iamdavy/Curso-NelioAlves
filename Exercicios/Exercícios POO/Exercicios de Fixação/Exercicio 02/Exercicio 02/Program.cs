using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_02 {
    internal class Program {
        static void Main(string[] args) {

            Employee employee01 = new Employee();
            Employee employee02 = new Employee();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            employee01.name = Console.ReadLine();
            Console.Write("Salário: ");
            employee01.wage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            employee02.name = Console.ReadLine();
            Console.Write("Salário: ");
            employee02.wage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double averageSalary = (employee01.wage + employee02.wage) / 2;

            Console.WriteLine("Salário médio = " + averageSalary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

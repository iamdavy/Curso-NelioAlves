using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_02 {
    internal class Program {
        static void Main(string[] args) {

            Employee employee = new Employee();

            Console.Write("Nome: ");
            employee.Name = Console.ReadLine();
            Console.Write("Salário bruto: ");
            employee.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            employee.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + employee);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            employee.IncreaseSalary(porcentage);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + employee);

        }
    }
}

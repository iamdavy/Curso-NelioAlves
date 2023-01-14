using System.Globalization;

namespace Exercicio_02 {
    internal class Employee {

        public string Name;
        public double GrossSalary;
        public double Tax;

        public double NetSalary() {
            return GrossSalary - Tax;
        }

        public void IncreaseSalary(double porcentage) {
            GrossSalary += (GrossSalary * porcentage / 100.0);
        }

        public override string ToString() {
            return Name + ", $ " + NetSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_03 {
    internal class Program {
        static void Main(string[] args) {

            Student student = new Student();

            Console.Write("Nome do aluno: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            student.Grade01 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Grade02 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Grade03 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL: "
                + student.FinalGrade().ToString("F2", CultureInfo.InvariantCulture));

            if (student.Approved()) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " 
                    + student.RemainingGrade().ToString("F2", CultureInfo.InvariantCulture)
                    + " PONTOS");
            }

        }
    }
}

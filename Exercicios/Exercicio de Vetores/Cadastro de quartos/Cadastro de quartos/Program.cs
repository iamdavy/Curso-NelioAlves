using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_quartos {
    internal class Program {
        static void Main(string[] args) {
           
            Student[] vect = new Student[10];

            Console.Write("Quantos quartos serão alugados? ");
            int numbersBedrooms = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numbersBedrooms; i++) {

                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int bedroom = int.Parse(Console.ReadLine());

                vect[bedroom] = new Student(name, email);

            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for(int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}

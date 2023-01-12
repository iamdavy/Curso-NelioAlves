using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01 {
    internal class Program {
        static void Main(string[] args) {

            Person person01 = new Person();
            Person person02 = new Person();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            person01.name = Console.ReadLine();
            Console.Write("Idade: ");
            person01.age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            person02.name = Console.ReadLine();
            Console.Write("Idade: ");
            person02.age = int.Parse(Console.ReadLine());

            if(person01.age > person02.age) {
                Console.WriteLine($"Pessoa mais velha: {person01.name}");
            }
            else
                Console.WriteLine($"Pessoa mais velha: {person02.name}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira a senha: ");
            int password = int.Parse(Console.ReadLine());

            while(password != 2002) {
                Console.WriteLine("Senha invalida");
                password = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido");

        }
    }
}

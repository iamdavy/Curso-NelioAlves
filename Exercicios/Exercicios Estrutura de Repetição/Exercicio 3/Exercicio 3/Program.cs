using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3 {
    internal class Program {
        static void Main(string[] args) {

            int gasolina = 0, diesel = 0, alcool = 0;

            Console.WriteLine("Insira um dos codigos listados abaixo:");
            Console.WriteLine("1. Álcool");
            Console.WriteLine("2. Gasolina");
            Console.WriteLine("3. Diesel");
            Console.WriteLine("4. Fim");
            Console.WriteLine("");
            
            int code = int.Parse(Console.ReadLine());

            while(code != 4) {
                if(code == 1) {
                    alcool = alcool + 1;
                }
                else if(code == 2) {
                    gasolina = gasolina + 1;
                }
                else if( code == 3) {
                    diesel = diesel + 1;
                }

                code = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

        }
    }
}

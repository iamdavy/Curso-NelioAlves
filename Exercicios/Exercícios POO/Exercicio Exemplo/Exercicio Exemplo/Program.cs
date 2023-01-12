using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_Exemplo {
    internal class Program {
        static void Main(string[] args) {

            Product product = new Product();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            product.Name = Console.ReadLine();
            Console.Write("Preço: ");
            product.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            product.Total = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + product);

            Console.WriteLine();
            Console.Write("Dgite o número de produtos a ser adicionado ao estoque: ");
            int amountAdded = int.Parse(Console.ReadLine());
            product.AddProducts(amountAdded);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + product);
            
            Console.WriteLine();
            Console.Write("Dgite o número de produtos a ser removido do estoque: ");
            amountAdded = int.Parse(Console.ReadLine());
            product.RemoveProducts(amountAdded);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + product);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ContaBancaria {
    internal class Program {
        static void Main(string[] args) {

            Account account;

            Console.Write("Entre o número da conta: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string holder = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char response = char.Parse(Console.ReadLine());
            if (response == 's' || response == 'S') {
                Console.Write("Entre o valor do depósito inicial: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new Account(number, holder, initialDeposit);
            }
            else {
                account = new Account(number, holder);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(account);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Deposit(deposit);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.WithDraw(withdraw);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(account);


        }
    }
}

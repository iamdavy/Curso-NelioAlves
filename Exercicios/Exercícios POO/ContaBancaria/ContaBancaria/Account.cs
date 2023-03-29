using System.Globalization;

namespace ContaBancaria {
    internal class Account {
        
        public int Number { get; private set; }
        public string Name { get; set; }
        public double BankBalance { get; private set; }

        public Account(int number, string name) {
            Number = number;
            Name = name;
        }
        public Account(int number, string name, double bankBalance) : this(number, name) {
            BankBalance = bankBalance;
        }   
        public void Deposit(double amount) {
            BankBalance += amount;
        }
        public void WithDraw(double amount) {
            BankBalance -= amount + 5.0;
        }
        public override string ToString() {
            return "Conta "
                + Number
                + ", Titular: "
                + Name
                + ", Saldo: $ "
                + BankBalance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

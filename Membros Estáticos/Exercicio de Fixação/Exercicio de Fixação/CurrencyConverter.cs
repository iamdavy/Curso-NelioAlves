using System;
using System.Globalization;

namespace Exercicio_de_Fixação {
    internal class CurrencyConverter {

      public static double Iof = 6.0;

      public static double DollarToReal(double dollar, double amount) {
            
            double total = dollar * amount;

            return total + total * Iof / 100.0;
        }

    }
}

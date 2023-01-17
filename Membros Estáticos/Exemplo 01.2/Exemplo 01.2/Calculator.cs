using System;
using System.Globalization;

namespace Exemplo_01._2 {
    internal class Calculator {

        public static double Pi = 3.14;

        public static double Circumference(double radiusFuc) {
            return 2.0 * Pi * radiusFuc;
        }

        public static double Volume(double radiusFuc) {
            return 4.0 / 3.0 * Pi * Math.Pow(radiusFuc, 3.0);
        }
    }
}

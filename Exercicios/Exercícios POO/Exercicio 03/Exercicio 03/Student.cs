using System;
using System.Globalization;

namespace Exercicio_03 {
    internal class Student {

        public string Name;
        public double Grade01, Grade02, Grade03;

        public double FinalGrade() {
            return (Grade01 + Grade02 + Grade03);
        }
        
        public bool Approved() {
            if(FinalGrade() >= 60.0) {
                return true;
            }
            else {
                return false;
            }
        }
        public double RemainingGrade() {
            if (Approved()) {
                return 0.0;
            }
            else {
                return 60.0 - FinalGrade();
            }
        }

    }
}

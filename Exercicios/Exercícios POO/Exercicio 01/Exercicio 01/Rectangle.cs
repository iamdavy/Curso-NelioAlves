using System;

namespace Exercicio_01 {
    internal class Rectangle {

        public double Height;
        public double Width;

        public double Area() {
            return Width * Height;
        }
        public double Perimeter() {
            return 2 * (Width + Height);
        }
        public double Diagonal() {
            return Math.Sqrt((Width * Width) + (Height * Height));
        }

    }
}

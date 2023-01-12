using System.Globalization;

namespace Exercicio_Exemplo {
    internal class Product {

        public string Name;
        public double Price;
        public int Total;

        public double TotalQuantityInStock() {
            return Price * Total;
        }

        public void AddProducts(int quantity) {
            Total += quantity;
        }
        
        public void RemoveProducts(int quantity) {
            Total -= quantity;
        }


        public override string ToString() {
            return Name 
                + ", $ " 
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Total
                + " unidades, Total: $ "
                + TotalQuantityInStock().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}

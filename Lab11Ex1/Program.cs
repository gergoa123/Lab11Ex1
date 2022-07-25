
using System;

namespace Lab11Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Benzina", new Guid(), 5.2, new StrategieCombustibil(2));
            Product product1 = new Product("Chifla", new Guid(), 0.6, new StrategieAlimente());
            Product product2 = new Product("Keyboard", new Guid(), 250, new StrategieMenajere());

            product.get_Tag.Tipareste();
            product1.get_Tag.Tipareste();
            product2.get_Tag.Tipareste();
        }
    }
}

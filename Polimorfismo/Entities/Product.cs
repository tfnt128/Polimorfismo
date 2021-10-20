using System.Globalization;

namespace Polimorfismo.Entities
{
    class Product
    {
        //declarando variáveis
        public string Name { get; private set; }
        public double Price { get; protected set; }

        //construtor padrão e personalizado"
        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        //método para converter em string
        public virtual string PriceTag()
        {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}

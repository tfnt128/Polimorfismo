using System.Globalization;

namespace Polimorfismo.Entities
{
    class ImportedProduct : Product
    {
        //declarando variável
        public double CustomsFee { get; set; }

        //construtor padrão e personalizado com a herança de "Product"
        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        //método para o preço total coma a taxa
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        //método para converter em string
        public override string PriceTag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }

    }
}

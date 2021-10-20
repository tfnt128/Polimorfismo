using System;
using System.Globalization;

namespace Polimorfismo.Entities
{
    class UsedProduct : Product
    {
        //declarando variável
        public DateTime ManufactureDate { get; set; }

        //construtor padrão e personalizado com a herança de "Product"
        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }


        //método para converter em string
        public override string PriceTag()
        {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";

        }


    }
}

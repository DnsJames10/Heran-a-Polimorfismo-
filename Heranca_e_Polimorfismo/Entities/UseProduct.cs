

namespace Heranca_e_Polimorfismo.Entities
{
    internal class UseProduct :Product
    {
        public DateTime ManufactureDate { get; set; }
        public UseProduct() { }
        public UseProduct(string name, double price, DateTime manuFactureDate):base(name, price)
        {
            ManufactureDate = manuFactureDate;
        }
        public override string PriceTag()
        {
            return Name +" (used) $"+Price.ToString("f2")+" (Manufacture date: "+ManufactureDate+")";
        }
    }
}

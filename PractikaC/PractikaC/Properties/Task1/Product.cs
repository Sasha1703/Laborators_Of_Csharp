namespace PractikaC.Properties.Task1
{
    public class Product
    {
        private string name;
        private decimal prise;

        public string Name => name;

        public decimal Prise => prise;

        public Product(string name, decimal prise)
        {
            this.name = name;
            this.prise = prise;
        }

        public override string ToString()
        {
            return name + " costs " + prise;
        }
    }
}
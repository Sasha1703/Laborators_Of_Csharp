namespace PractikaC.Properties.Task1
{
    public class Wallet
    {
        private string exchange;
        private decimal value;

        public string Exchange => exchange;

        public decimal Value => value;

        public Wallet(string exchange, decimal value)
        {
            this.exchange = exchange;
            this.value = value;
        }
    }
}
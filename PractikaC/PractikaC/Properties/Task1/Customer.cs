using System;

namespace PractikaC.Properties.Task1
{
    public class Customer
    {
        private string name;
        private Wallet wallet;
        private Product[] pr;

        public string Name => name;

        public Customer(string name, string amount, decimal value)
        {
            wallet = new Wallet(amount, value);
            this.name = name;
        }

        void addCash(string exchange, decimal money)
        {
            wallet = new Wallet(exchange, money);
        }

        public void addGoods(Product[] product)
        {
            pr = product;
        }

        public void calculate()
        {
            for (int i = 0; i < pr.Length; i++)
            {
                int count = (int) (wallet.Value / pr[i].Prise);
                decimal zdacha = wallet.Value - pr[i].Prise * count;
                Console.WriteLine(name + " have a " + wallet.Value + " and he can buy a " +
                                  count + " " + pr[i].Name + "`s" + " and he will have in wallet " +
                                  zdacha +  " " + wallet.Exchange);
            }
        }
    }
}
using System;
using PractikaC.Properties.Task1;
using PractikaC.Properties.Task2;
using PractikaC.Properties.Task3;

namespace PractikaC
{
    internal class Program
    {
        public static void Main(string[] args)
        {
//            This is code for task #1
            
            Random random = new Random();
            Customer[] customers = new Customer[5];
            string[] names = new string[5] {"Vova", "Sasha", "Vlad", "Vadim", "Yulia"};
            string[] namesProduct = new string[5] {"Apple", "Orange", "Banana", "Lemon", "Potatoes"};
            
            Product[] products = new Product[5];
            
            for (var i = 0; i < products.Length; i++)
            {
                products[i] = new Product(namesProduct[i], random.Next(5, 30));
                Console.WriteLine(products[i]);
            }

            for (var i = 0; i < customers.Length; i++)
            {
                customers[i] = new Customer(names[i], "UAH", random.Next(0, 100));
                customers[i].addGoods(products);
                customers[i].calculate();
            }
            
            
            //This is code for task #2
            
            Ukrainian ukrainian = new Ukrainian();
            Poland poland = new Poland();
            American american = new American();
            
            //This is code for task #3
            
            SuperHero superman = new SuperHero("Superman");
            SuperHero spider_man = new SuperHero("Spider-man");
            
            superman.doSleep();
            superman.doRun();
            spider_man.doFight();
            spider_man.justUsePoverForce();
        }
    }
}
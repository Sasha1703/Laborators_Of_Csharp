using System;
using Laba_7.Properties.Task2;

namespace Laba_7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Task - 1
            CollectionOfCars collection = new CollectionOfCars(10);
            string[] nameOfCars = new[]{"Audi", "Mazda", "Lada", "Toyota", "BMW", "Tesla", "Kia", "Renault", "Ford", "Mercedes-Benz"};
            string[] colorOfCars = new[]{"Green", "Red", "Blue", "Green", "Blue", "Green", "Red", "Green", "Red", "Green"};
            int[] speedOfCars = new[] {222, 198, 145, 80, 250, 150, 238, 162, 187, 280};
            long[] ageOfCars = new long[] {2012, 2013, 1995, 2012, 1995, 2012, 2007, 2012, 2009, 2017};

            for (int i = 0; i < 10; i++)
            {
                collection.add(nameOfCars[i], colorOfCars[i], speedOfCars[i], ageOfCars[i]);
            }
            collection.find();
            
            //Task - 2
            GoogleGlass googleGlass = new GoogleGlass();
        }
    }
}
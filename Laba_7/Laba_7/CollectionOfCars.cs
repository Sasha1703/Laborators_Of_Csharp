using System;
using Laba_7.Properties;

namespace Laba_7
{
    public class CollectionOfCars
    {
        private static int size = 0;
        private static Car[] cars;
        
        public CollectionOfCars(int size)
        {
            cars = new Car[10];
        }

        public void add(string name, string color, int speed, long age)
        {
            Car car = new Car(name, color, speed, age);
            cars[size] = car;
            Console.WriteLine(car);
            size++;
        }

        public void find()
        {
            string str = Console.ReadLine();
            int count = str.IndexOf(' ');
            string colorOfCar = str.Substring(0, count);
            string ageOfCarSSS = str.Substring(count + 1, str.Length - count - 1);
            int ageOfCar = Convert.ToInt32(ageOfCarSSS);
            foreach (var car in cars)
            {
                if (car.Color.ToLower().Equals(colorOfCar.ToLower()) && (car.Age == ageOfCar))
                {
                    Console.WriteLine(car); 
                }
            }       
        }
    }
}
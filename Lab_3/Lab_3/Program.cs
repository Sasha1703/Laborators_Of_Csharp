using System;

namespace Lab_b
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int x, y;
            Console.Write("Enter your x : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your y : ");
            y = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && y < 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
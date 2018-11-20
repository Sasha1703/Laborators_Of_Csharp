using System;

namespace Lab_1
{
    internal class Program 
    {
        public static void Main(string[] args) 
        {
            int u, r;
            double d = 0;
            Console.Write("Enter voltage : ");
            u = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter resistance : ");
            r = Convert.ToInt32(Console.ReadLine());
            d = (double) u/r;
            Console.WriteLine("Your amperage is " + d);
        }
    }
}
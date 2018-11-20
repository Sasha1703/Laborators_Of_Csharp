using System;

namespace Lab_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int nn, nk;
            double result = 0;
            do
            {
                Console.Write("Enter under border : ");
                nn = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter upper border : ");
                nk = Convert.ToInt32(Console.ReadLine());
                if (!(0 <= nn && nn <= nk))
                {
                    Console.WriteLine("You write incorrect values, please enter correct !");
                }
            } while (!(0 <= nn && nn <= nk));
            for (int k = nn; k < nk; k++)
            {
                result += (Math.Pow(k, 2) + Math.Pow(-1, k) * (k - 1)) / (Math.Pow(k, 2) + 1);
            }
            Console.WriteLine("Result is - " + result);
        }
    }
}
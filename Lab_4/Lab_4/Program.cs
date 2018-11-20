using System;

namespace Lab_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n;
            Random random = new Random();
            Console.Write("Enter your size of array : ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = random.Next(0, 10);
            Console.Write(" \n Your arr : ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.Write(" \n Your odd number : ");
            for (int i = 0; i < arr.Length; i += 2)
                Console.Write(arr[i] + " ");
            Console.Write(" \n Your even number : ");
            for (int i = 1; i < arr.Length; i += 2)
                Console.Write(arr[i] + " ");
        }
    }
}
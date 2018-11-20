using System;

namespace Lab_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int size1, size2;
            Console.Write("Enter size of array : ");
            size1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter size of inner array : ");
            size2 = Convert.ToInt32(Console.ReadLine());
            int[][] arr = createArr(size1, size2);
            Console.WriteLine(arr.GetLength(0) + "    " + arr.GetLength(1));
            fillArr(arr, size1, size2);
            display(arr, size1, size2);
            Console.WriteLine("Sum of column = " + sumOfColumn(arr, size1, size2, false));
            Console.WriteLine("Sum of row = " + sumOfRow(arr, size1, size2, false));
        }
        
        public static int sumOfRow(int[][] arr, int size1, int size2, bool odd)
        {
            int result = 0;
            if (odd)
            {
                for (int i = 1; i < size1; i += 2)
                {
                    for (int j = 0; j < size2; j++)
                    {
                        result += arr[i][j];
                    }
                }
                return result;
            }
            else
            {
                for (int i = 0; i < size1; i += 2)
                {
                    for (int j = 0; j < size2; j++)
                    {
                        result += arr[i][j];
                    }
                }
                return result;
            }
        }
        

        public static int sumOfColumn(int[][] arr, int size1, int size2, bool odd)
        {
            int result = 0;
//            if (odd)
//            {
                for (int i = 0; i < size1; i++)
                {
                    if (odd)
                    {
                        for (int j = 0; j < size2; j += 2)
                        {
                            result += arr[i][j];
                        }   
                    }
                }
                return result;
//            }
//            else
//            {
//                for (int i = 0; i < size1; i++)
//                {
//                    for (int j = 0; j < size2; j += 2)
//                    {
//                        result += arr[i][j];
//                    }
//                }
//                return result;
//            }
        }

        public static int[][] createArr(int size1, int size2)
        {
            int[][] arr = new int[size1][];
            for (int i = 0; i < size1; i++)
            {
                arr[i] = new int[size2];
            }

            return arr;
        }

        public static void display(int[][] arr, int size1, int size2)
        {
            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void fillArr(int[][] arr, int size1, int size2)
        {
            Random rand = new Random();
            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    arr[i][j] = rand.Next(10);
                }
            }
        }
    }
}
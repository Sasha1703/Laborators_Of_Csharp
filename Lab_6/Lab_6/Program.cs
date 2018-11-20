using System;
using System.Globalization;
using System.Linq;

namespace Lab_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(reverseReccursive(str));
//            int i = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine(reverse(i));
//            double d = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine(reverse(d));
//            int[] array = new int[10];
//            randArr(array);
//            display(array);
//            reverseArray(array);
//            display(array);
        }

        public static void randArr(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 10);
            }
        }

        public static void display(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }

        public static void reverseArray(ref int[] array)
        {
            for (int i = 0; i < array.Length - i; i++)
            {
                int value = array[array.Length - i - 1];
                array[array.Length - i - 1] = array[i];
                array[i] = value;
            }
        }

        public static int[] reverse(ref int[] arr)
        {
            int[] arrRev = new int[arr.Length];
            int j = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                arrRev[j] = arr[i];
                j++;
            }

            return arrRev;
        }

        public static string reverse(double ggg)
        {
            string str = ggg.ToString(CultureInfo.InvariantCulture);
            return reverse(str);
        }

        public static string reverse(string str)
        {      
 
            if (isHaveDot(str))
            {
                string str1 = "", str2 = "";
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i].Equals(',') || str[i].Equals('.'))
                    {
                        break;
                    }
                    str1 += str[i];
                }
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    if (str[i].Equals(',') || str[i].Equals('.'))
                    {
                        break;
                    }
                    str2 += str[i];
                }
                return reverseReccursive(str1) + "," + str2;    
            }
            else
            {
                return reverseReccursive(str);
            }
        }

        public static bool isHaveDot(string str)
        {
            bool isHaveDot = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Equals(',') || str[i].Equals('.'))
                {
                    isHaveDot = true;
                }
            }
            return isHaveDot;
        }

        public static string reverseReccursive(string str)
        {
            if (str.Length > 0)
                return str[str.Length - 1] + reverseReccursive(str.Substring(0, str.Length - 1));
            else
                return str;
        }
            
        public static string reverse(int number) {
            string str = number.ToString();
            return reverse(str);
        }
    }
}
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Session_04___Assignment_05
{
    internal class Program
    {
        // Q1
        public static void swap(int x, int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }

        public static void swap2(ref int x,ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }

        //Q2
        public static int SumArr(int[] arr)
        {
            int sum = 0;
            arr = new int[] { 4, 5, 6 };
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static int SumArr2(ref int[] arr)
        {
            int sum = 0;
            arr = new int[] { 4, 5, 6 };
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        //Q3
        public static (int, int) SumAndSub(int num1, int num2, ref int sum, ref int sub)
        {
            sum = num1 + num2;
            sub = num1 - num2;
            return (sum, sub);
        }

        //Q4
        public static int SumDigits(int num)
        {
            int sum = 0;
            while(num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        //Q5
        public static bool IsPrime(int num)
        {
            int count = 0;
            for(int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                    count++;  
            }
            if(count == 2)
                return true;
            else 
                return false;
        }

        //Q6
        public static void MinMaxArray(int[] arr, ref int min, ref int max)
        {
            min = max  = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }
        }

        //Q7
        public static int Factorial(int num)
        {
            int fact = 1;
            for(int i = num; i > 0; i--)
            {
                fact *= i;
            }
            return fact;
        }

        //Q8
        public static void ChangeChar(ref string str,int pos, char letter)
        {
            str = str.Remove(pos, 1);
            str = str.Insert(pos, letter.ToString());
        }

        static void Main(string[] args)
        {
            #region Q1
            ////Pass by value means passing a copy of the variable to the method.
            ////Pass by reference means passing access to the variable to the method
            //int a = 3, b = 4;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine("passing by value:");
            //swap(a, b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //Console.WriteLine("passing by reference:");
            //swap2(ref a, ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            #endregion

            #region Q2
            ////passing by value means passing copy from the reference to the method
            ////passing by reference means passing the main reference to the method and accessing the same identity
            //int[] numbers = { 1, 2, 3 };
            //Console.WriteLine("passing by value: ");
            //Console.WriteLine(SumArr(numbers)); // 15
            //Console.WriteLine(numbers[0]); // 1

            //Console.WriteLine("passing by reference: ");
            //Console.WriteLine(SumArr2(ref numbers));
            //Console.WriteLine(numbers[0]);
            #endregion

            #region Q3
            //Console.Write("Enter number1: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter number2: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int sub = 0;
            //(sum, sub) = SumAndSub(num1, num2, ref sum, ref sub);
            //Console.WriteLine($"sumetion: {sum}, Subtraction: {sub}");
            #endregion

            #region Q4
            //Console.Write("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"The sum of the digits of the number {num} is: {SumDigits(num)}");
            #endregion

            #region Q5
            //Console.Write("Is prime: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(IsPrime(num));
            #endregion

            #region Q6
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //int min = 0;
            //int max = 0;

            //MinMaxArray(numbers, ref min, ref max);

            //Console.WriteLine($"Maximum: {max}, Minimum: {min}");
            #endregion

            #region Q7
            //Console.Write("Enter number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Factorial {num} is: {Factorial(num)}");
            #endregion

            #region Q8
            //string text = "abcdef";
            //ChangeChar(ref text, 0, 'm');
            //Console.WriteLine(text);
            #endregion














        }
    }
}

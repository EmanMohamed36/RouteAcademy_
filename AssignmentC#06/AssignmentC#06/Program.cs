using System.Buffers.Text;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace AssignmentC_06
{
    internal class Program
    {
        public static int ReadInteger()
        {
            bool isInt = true;
            int val;
            do
            {
                if (!isInt) Console.WriteLine("Wrong dataType value please enter integer!!");
                isInt = int.TryParse(Console.ReadLine(), out val);
            } while (!isInt);
            return val;
        }
        public static void PrintNumberOfTheQuestion(int num)
        {
            Console.WriteLine($"Question {num}: ");
        }

        public static (int sum, int diff) SumAndSub(int a, int b, char op1, char op2)
        { 
            int sum = 0 , diff = 0 ;
            if (op1 == '-') diff = a - b;
            if(op2 == '+') sum = a + b;
            return (sum, diff);
        }
        public static int SumDigit(string str)
        {
            int sum = 0 ;
            for (int i = 0; i < str.Length; i++)
            {
                sum += Convert.ToInt32(str[i].ToString());

            }
            return sum;
        }
        public static bool isPrime(int n)
        { 
            if(n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public static void MinMaxArray(int[] array, ref int min, ref int max)
        { 
            
            Array.Sort(array);
            max = array[array.Length - 1];
            min = array[0];
        }
        public static int Factorial(int n)
        {
            int res = 1;
            for (int i = 2; i <= n; i++) res *= i;
            return res;
        }
        public static string ChangeChar(string str, int pos, char c)
        {
            if (pos < 0 || pos >= str.Length)
            {
                Console.WriteLine("Invalid position.");
                return str;
            }
            char[] chars = str.ToCharArray();
            chars[pos] = c;
            string res = new string(chars);
            return res;
        }
        static void Main(string[] args)
        {
            #region Q1
            /*
                 Pass by Value (default):
                    A copy of the variable is passed to the function.

                    Changes made inside the function do not affect the original variable.

                 Pass by Reference (ref keyword):
                    The original variable is passed.

                    Changes made inside the function do affect the original variable.
             */

            #endregion

            #region Q2
            /*
                 Pass by Value (default for reference types):
                    A copy of the reference (pointer) is passed.

                    Changes to the object's contents inside the method affect the original object.

                    But reassigning the reference inside the method does not affect the original reference outside.

                Pass by Reference (ref keyword):
                    The reference itself is passed by reference.

                    You can modify the object’s contents and reassign the reference to a new object, affecting the caller's variable.
             */
            #endregion

            #region Q3 
            //3- Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            PrintNumberOfTheQuestion(3);

            Console.Write("Enter First Number: ");
            int number1 = ReadInteger();

            Console.Write("Enter Second Number: ");
            int number2 = ReadInteger();
            char op1 = '-', op2 = '+';
            var result = SumAndSub(number1, number2, op1, op2);
            Console.WriteLine($"Summation: {result.sum}\nDifference: {result.diff}");

            #endregion

            #region Q4
            //4.Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number. 

            PrintNumberOfTheQuestion(4);
            Console.Write("Enter Number: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Summation: {SumDigit(input)}");


            #endregion

            #region Q5
            //5- Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            PrintNumberOfTheQuestion(5);
            Console.Write("Enter Number to check if prime or not: ");
            int number = ReadInteger();

            if (isPrime(number))
            {
                Console.WriteLine($"{number} is prime");
            }
            else
            {
                Console.WriteLine($"{number} is not prime");
            }

            #endregion

            #region Q6
            //6- Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            PrintNumberOfTheQuestion(6);

            Console.Write("Enter Size of the Array: ");
            int size = ReadInteger();
            Console.WriteLine("Enter elements of the array: ");
            int[] array_6 = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                array_6[i] = ReadInteger();
            }
            int maxValue = 0;
            int minValue = 0;
            MinMaxArray(array_6, ref minValue, ref  maxValue);
            Console.WriteLine($"Minimum element: {minValue}\nMaximum element: {maxValue}");

            #endregion

            #region Q7
            //7- Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            PrintNumberOfTheQuestion(7);
            Console.Write("Enter the Number to calculate factorial: ");
            int Num = ReadInteger();
            int fact = Factorial(Num);
            Console.WriteLine($"Factorial: {fact}");
            #endregion

            #region Q8
            //8- Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter
            PrintNumberOfTheQuestion(8);
            Console.Write("Enter String: ");
            string inputString = Console.ReadLine();
            Console.Write("Enter position you want to replace: ");
            int pos = ReadInteger();
            Console.Write("Enter character you want to replace: ");
            bool isChar = char.TryParse(Console.ReadLine(), out char ch);
            string replacedString = ChangeChar(inputString,pos, ch);
            Console.WriteLine($"ReplacedString: {replacedString}");
            #endregion
        }
    }
}

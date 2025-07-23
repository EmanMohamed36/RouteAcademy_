using System.Runtime.CompilerServices;

namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q6
            //6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            Console.Write("Enter an integer to print all number between 1 to the number: ");
            bool isNumber = int.TryParse(Console.ReadLine(), out int number);

            Console.Write("1");
            for (int i = 2; i <= number; i++)
            {
                Console.Write(", " + i);
            }
            Console.WriteLine();
            #endregion

            #region Q7
            //7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            Console.Write("Enter an integer to print Multiplication table: ");
            bool isNum = int.TryParse(Console.ReadLine(), out int num);

            for (int i = 1; i <= 12; i++)
            {
                Console.Write(i * num + " ");
            }
            Console.WriteLine();
            #endregion

            #region Q8
            //8- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            Console.Write("Enter an integer to print Even number between 1 to Number: ");
            bool isN = int.TryParse(Console.ReadLine(), out int n);
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();


            #endregion

            #region Q9
            //9- Write a program that takes two integers then prints the power.
            Console.WriteLine("Enter two Number to get the power: ");
            bool isN1 = int.TryParse(Console.ReadLine(), out int n1);
            bool isN2 = int.TryParse(Console.ReadLine(), out int n2);
            int res = 1;
            for (int i = 1; i <= n2; i++)
            {
                res *= n1;
            }
            Console.WriteLine("Result Power Using looping : " + res);
            Console.WriteLine("Result Power Using built in function: " + Math.Pow(n1, n2));
            #endregion

            #region Q10
            //10- Write a program to enter marks of five subjects and calculate total, average and percentage.
            Console.Write("Enter marks of five subjects : ");

            string? input = Console.ReadLine();
            string[] parts = input.Split(' ');
            
            double[] marks = new double[5];
            for (int i = 0; i < 5; i++)
            {
                bool isInteger = double.TryParse(parts[i], out double intRes);
                if (isInteger) marks[i] = intRes;
                else marks[i] = 0;
            }
            double total = 0;
            foreach (int i in marks)
            {
                total += i;
            }
            int average = (int)(total / 5);
            int percentage = (int)((total / 500) * 100);

            Console.WriteLine($"Total: {(int)total}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Percentage: {percentage}");
            #endregion

            #region Q11
            //11- Write a program to input the month number and print the number of days in that month.
            
            Console.Write("Enter month Number to get Number of days: ");
            bool isMonth = int.TryParse(Console.ReadLine(), out int monthNumber);
            int days;
            switch (monthNumber)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                case 2:
                    days = 28;
                    break;
                default:
                    days = 0;
                    Console.WriteLine("Invalid Month Number");
                    break;

            }
            if(days > 0)
            Console.WriteLine($"Number of days in Month {monthNumber} is {days}");
            #endregion

            #region Q12
            //12- Write a program to create a Simple Calculator.
            Console.WriteLine("Enter two Number and operation : ");
            Console.Write("Enter Number1: ");
            bool isNum1 = double.TryParse(Console.ReadLine() , out double num1); 
            Console.Write("Enter Number2: ");
            bool isNum2 = double.TryParse(Console.ReadLine(), out double num2);
            Console.Write("Enter Operation: ");
            bool isOp = char.TryParse(Console.ReadLine(), out char op);
            double result;
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Can't devide by zero");
                            return; 
                    }
                    else result = num1 / num2;
                    break;
                default:
                    result = 0;
                    break;
            }
            Console.WriteLine($"{num1} {op} {num2} = {result}");

            #endregion

            #region Q13
            //13- Write a program to allow the user to enter a string and print the REVERSE of it.
           Console.Write("Enter String to reverse it: ");
            string? word = Console.ReadLine();
            string reverseWrod = "";
            for (int i = word.Length - 1; i >= 0; i--)
            { 
                reverseWrod += word[i];
            }
            Console.WriteLine("Reversed Word using Looping: " + reverseWrod);

            string reverseWord2 = new string (word.Reverse().ToArray());
            Console.WriteLine( "Reversed Word Using Built in Function: "+ reverseWord2);

            #endregion

            #region Q14
            //Write a program to allow the user to enter int and print the REVERSED of it.
            Console.Write("Enter Integer Number to reverse it: ");
            bool isOriginalNumber = int.TryParse (Console.ReadLine(), out int originalNumber);
            string reversedNumber = "";
            while (originalNumber > 0)
            {
                reversedNumber += Convert.ToString(originalNumber % 10);
                originalNumber /= 10;
            }
            Console.WriteLine($"Reversed Number is: {reversedNumber}");

            #endregion

            #region Q15
            //15- Write a program in C# Sharp to find prime numbers within a range of numbers.
            Console.WriteLine("Enter Range to Find Prime Numbers:");
            Console.Write("Input starting number of range: ");
            bool isStartNumber = int.TryParse(Console.ReadLine(), out int startNumber);
            Console.Write("Input ending number of range : ");
            bool isEndNumber = int.TryParse(Console.ReadLine(), out int endNumber);
            Console.Write("Prime Numbers: ");

            for (int i = (startNumber == 1 ?startNumber + 1: startNumber) ; i <= endNumber; i++)
            {
                bool flag = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag) Console.Write(i + " ");
            }
            #endregion

            #region Q17
            //17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
           Console.WriteLine("Enter three point to determine whether these points lie on a single straight line");
            Console.Write("First poin(x,y): ");
            string[] a = Console.ReadLine().Split();
            bool isX1 = int.TryParse(a[0], out int x1);
            bool isY1 = int.TryParse(a[1] , out int y1);

            Console.Write("Second poin(x,y): ");
            string[] b = Console.ReadLine().Split();
            bool isX2 = int.TryParse(b[0], out int x2);
            bool isY2 = int.TryParse(b[1], out int y2);
            
            Console.Write("Third poin(x,y): ");
            string[] c = Console.ReadLine().Split();
            bool isX3 = int.TryParse(c[0], out int x3);
            bool isY3 = int.TryParse(c[1], out int y3);

            double Area = .5 * Math.Abs(x1*(y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
            if (Area == 0) Console.WriteLine($"({x1},{y1}) ({x2},{y2}) ({x3},{y3}) lie on a single straight line");
            else
                Console.WriteLine($"({x1},{y1}) ({x2},{y2}) ({x3},{y3}) (don't) lie on a single straight line");

            #endregion

            #region Q18
            /*18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
            - If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
            - If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
            - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
            - If the worker takes more than 5 hours, they are required to leave the company. 
            To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
            */
            Console.Write("Enter duration required to complete a specific task: ");
            bool isDuration = double.TryParse(Console.ReadLine(), out double duration);
            if (duration >= 2 && duration <= 3)
            {
                Console.WriteLine("they are considered highly efficient");
            }
            else if (duration > 3 && duration <= 4)
            {
                Console.WriteLine("they are instructed to increase their speed.");

            }
            else if (duration > 4 && duration <= 5)
            {
                Console.WriteLine("they are provided with training to enhance their speed");

            }
            else if (duration > 5)
            { 
                Console.WriteLine("they are required to leave the company.");

            }
            #endregion
        }
    }
}

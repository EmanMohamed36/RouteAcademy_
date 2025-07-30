using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace AssignmentC_05
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
            }while (!isInt);
            return val;
        }
        public static void PrintNumberOfTheQuestion(int num)
        {
            Console.WriteLine($"Question {num}: ");
        }
        static void Main(string[] args)
        {
            #region Q19
            //19 . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            PrintNumberOfTheQuestion(19);

            Console.Write("Enter the size of matrix to print Identity matrix: ");
            int n = ReadInteger();
            int[,] identityMatrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) identityMatrix[i, j] = 1;
                    else identityMatrix[i, j] = 0;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(identityMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }



            #endregion

            #region Q20
            //20 - Write a program in C# Sharp to find the sum of all elements of the array.
            PrintNumberOfTheQuestion(20);


            Console.Write("Enter size of the array: ");
            int sizeArray = ReadInteger();
            int[] ArraySum = new int[sizeArray];
            Console.WriteLine("Enter elements of the array: ");
            for (int i = 0; i < sizeArray; i++)
            {
                Console.Write($"Element {i + 1}: ");
                ArraySum[i] = ReadInteger();
            }
            int sum = 0;
            foreach (int i in ArraySum)
            {
                sum += i;
            }
            Console.WriteLine($"Summation: {sum}");

            #endregion

            #region Q21
            //21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            PrintNumberOfTheQuestion(21);


            Console.Write("Enter size of the first array: ");
            int sizeArray1 = ReadInteger();
            int[] Array1 = new int[sizeArray1];
            int[] mergedArray = new int[2 * sizeArray1];

            Console.WriteLine("Enter Elements of the First Array");
            for (int i = 0; i < sizeArray1; i++)
            {
                Console.Write($"Element {i + 1}: ");
                Array1[i] = ReadInteger();
                mergedArray[i] = Array1[i];
            }

            Console.Write("Enter size of the second array: ");
            int sizeArray2 = ReadInteger();
            int[] Array2 = new int[sizeArray2];
            Console.WriteLine("Enter Elements of the second Array");
            for (int i = 0; i < sizeArray2; i++)
            {
                Console.Write($"Element {i + 1}: ");
                Array2[i] = ReadInteger();
                mergedArray[i + sizeArray1] = Array2[i];
            }

            Array.Sort(mergedArray);

            Console.Write("Sorted Array: ");
            foreach (int i in mergedArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            #endregion

            #region Q22
            //22- Write a program in C# Sharp to count the frequency of each element of an array.
            PrintNumberOfTheQuestion(22);


            Console.Write("Enter Size of the Array: ");
            int sizeArrayOriginal = ReadInteger();
            Console.WriteLine("Enter Elements of the  Array");
            int[] originalArray = new int[sizeArrayOriginal];
            for (int i = 0; i < sizeArrayOriginal; i++)
            {
                Console.Write($"Element {i + 1}: ");
                originalArray[i] = ReadInteger();

            }
            Dictionary<int, int> freqArray = new Dictionary<int, int>();
            foreach (int num in originalArray)
            {
                if (freqArray.ContainsKey(num)) freqArray[num]++;
                else freqArray[num] = 1;
            }
            foreach (var pair in freqArray)
            {
                Console.WriteLine($"freq[{pair.Key}]: {pair.Value}");

            }



            #endregion

            #region Q23
            //23- Write a program in C# Sharp to find maximum and minimum element in an array

            PrintNumberOfTheQuestion(23);


            Console.Write("Enter Size of the Array: ");
            int sizeArray_ = ReadInteger();
            Console.WriteLine("Enter Elements of the  Array");
            int[] Array_ = new int[sizeArray_];
            for (int i = 0; i < sizeArray_; i++)
            {
                Console.Write($"Element {i + 1}: ");
                Array_[i] = ReadInteger();

            }
            Array.Sort(Array_);
            Console.WriteLine($"Maximum Element: {Array_[sizeArray_ - 1]}\nMinimum Element: {Array_[0]}");
            #endregion

            #region Q24
            //24- Write a program in C# Sharp to find the second largest element in an array.

            PrintNumberOfTheQuestion(24);


            Console.Write("Enter Size of the Array: ");
            int sizeArray_24 = ReadInteger();

            Console.WriteLine("Enter Elements of the  Array");
            int[] array_24 = new int[sizeArray_24];
            for (int i = 0; i < sizeArray_24; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array_24[i] = ReadInteger();

            }
            Array.Sort(array_24);
            Console.WriteLine($"Second Maximum Element: {array_24[sizeArray_24 - 2]}");

            #endregion

            #region Q25
            PrintNumberOfTheQuestion(25);


            Console.Write("Enter Size of the Array: ");
            int sizeArray_25 = ReadInteger();

            Console.WriteLine("Enter Elements of the  Array");
            int[] array_25 = new int[sizeArray_25];
            for (int i = 0; i < sizeArray_25; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array_25[i] = ReadInteger();

            }
            Dictionary<int, (int first, int second)> dic = new Dictionary<int, (int, int)>();
            for (int i = 0; i < sizeArray_25; i++)
            {
                int value = array_25[i];
                if (dic.ContainsKey(value))
                {

                    var temp = dic[value];
                    temp.second = i;

                    dic[value] = temp;
                }
                else
                {

                    dic[value] = (i, i);
                }

            }
            int maxDis = 0;
            foreach (var i in dic)
            {

                maxDis = Math.Max(maxDis, i.Value.second - i.Value.first - 1);
            }
            Console.WriteLine($"Maximum Distance: {maxDis}");
            #endregion

            #region Q26
            //26- Given a list of space separated words, reverse the order of the words.
            PrintNumberOfTheQuestion(26);

            Console.WriteLine("Enter Separated Wrods");
            string? input = Console.ReadLine();
            string[] Strings = input.Split(" ");
            Array.Reverse(Strings);
            foreach (string str in Strings)
            {
                Console.Write(str + " ");
            }
            #endregion

            #region Q27
            //Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            PrintNumberOfTheQuestion(27);

            Console.Write("Enter number of rows: ");
            int row = ReadInteger();

            Console.Write("Enter number of columns: ");
            int col = ReadInteger();

            int[,] firstArray = new int[row, col];
            int[,] secondArray = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"Element [{i}][{j}]: ");

                    firstArray[i, j] = ReadInteger();
                }
            }
            secondArray = firstArray;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(secondArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endregion

            #region Q28
            //28- Write a Program to Print One Dimensional Array in Reverse Order

            PrintNumberOfTheQuestion(28);


            Console.Write("Enter Size of the Array: ");
            int sizeArray_28 = ReadInteger();

            Console.WriteLine("Enter Elements of the  Array");
            int[] array_28 = new int[sizeArray_28];
            for (int i = 0; i < sizeArray_28; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array_28[i] = ReadInteger();

            }
            Array.Reverse(array_28);
            Console.WriteLine("Reversed Array: ");
            foreach (int i in array_28)
            { 
                Console.Write(i + " ");
            }


            #endregion




        }
    }
}

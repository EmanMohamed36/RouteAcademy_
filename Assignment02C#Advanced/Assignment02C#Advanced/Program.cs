using System.Collections;

namespace Assignment02C_Advanced
{
    internal class Program
    {
        public static int ReadInt()
        {
            bool isInt;
            int number;
            do
            {
                isInt = int.TryParse(Console.ReadLine(), out  number);
                if (!isInt) Console.WriteLine("Enter Integer value");
            }
            while (!isInt);
            return number;
        }
        static void Main(string[] args)
        {
            #region Q1 
            /*
                You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
             */
            ArrayList list = new ArrayList() { 1, 2, 3, 4, 5, 6 };
            Helper.ReverseArrayList(list);

            Console.Write("Reversed ArrayList: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            #endregion

            Console.WriteLine();

            #region Q2
            /*
                You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.
             */
            List<int> Numbers = new List<int>() { 1, 2, 4, 5, 6, 7 };
            List<int> Result = Helper.EvenNumbers(Numbers);
            Console.Write("Even Numbers: ");
            foreach (int i in Result)
            {
                Console.Write(i + " ");
            }
            #endregion

            Console.WriteLine();

            #region Q3 
            //
            FixedSizeList<int> CustomList = new FixedSizeList<int>(5);
            CustomList.Add(1);
            CustomList.Add(2);
            CustomList.Add(3);
            CustomList.Add(4);
            CustomList.Add(5);

            Console.WriteLine(CustomList.GetElementListByIndex(4));
            #endregion

            Console.WriteLine();

            #region Q4
            Console.Write("Enter size Array: ");
            int sizeArray = ReadInt();

            Console.Write("Enter Number of queries: ");
            int queryN = ReadInt();

            Console.WriteLine("Enter Array Elements: ");
            int[] array = new int[sizeArray];
            for (int i = 0; i < sizeArray; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                array[i] = ReadInt();
                //Console.WriteLine() ;
            }

            Array.Sort(array);
            Console.WriteLine("Enter queries");

            int q = 1;

            while (q <= queryN)
            {
                Console.Write($"Enter Query {q}: ");

                int target = ReadInt();
                Console.WriteLine("numbers in array that is greater than " + target + " is: " + Helper.SpecificBinarySearch(array, target));
                q++;
            }

            #endregion

            #region Q5
            /*
                Given a number N and an array of N numbers. Determine if it's palindrome or not.
             */
            Console.Write("Enter size of the Array: ");
            int N = ReadInt();
            Console.WriteLine("Enter Array Elements: ");
            int[] palindArray = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                palindArray[i] = ReadInt();
            }
            bool isPalindrome = Helper.isPalindrome(palindArray);
            Console.Write("Is array palindrome: ");
            if (isPalindrome)
            {
                Console.WriteLine("YES");

            }
            else
                Console.WriteLine("NO");

            #endregion

            #region Q6
            /*
             * Given an array, implement a function to remove duplicate elements from an array.
             */
            Console.Write("Enter size of the Array: ");
            int sizeDArray = ReadInt();
            Console.WriteLine("Enter Array Elements: ");
            int[] DuplicateArray = new int[sizeDArray];
            for (int i = 0; i < sizeDArray; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                DuplicateArray[i] = ReadInt();
               
            }
            DuplicateArray = Helper.RemoveDuplicateFromArray(DuplicateArray);
            Console.WriteLine("Array After duplicate:");
            foreach (int i in DuplicateArray)
            { 
                Console.Write(i + " ");
            }


            #endregion

            #region Q7
            /*
                Given an array list , implement a function to remove all odd numbers from it.
             */
            Console.WriteLine();
            Console.Write("Enter size of the Array: ");
            int numberOfElements = ReadInt();
            Console.WriteLine("Enter ArrayList Elements: ");
            ArrayList listWithoutOdds = new ArrayList();

            for (int i = 0; i < numberOfElements; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                int x = ReadInt();
                listWithoutOdds.Add( x);

            }
            Helper.RemoveOddsFromArrayList(listWithoutOdds);
            

            #endregion
        }
    }
}

namespace Assignment1AdvancedC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1)BubbleSort
            /*
                The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm 
                And implement the code of this optimized bubble sort algorithm

             */
            int[] array = { 5, 1, 2, 7, 8, 9, 3 };
            Helper<int>.BubbleSort(array);
            foreach (int i in array)
            { 
                Console.Write(i + " ");
            }

            #endregion

            #region Q2)
            Console.WriteLine();
            Range<int> range = new Range<int>(4,9);
            int value = 1;
            bool isInRange = range.isInRange(value);
            Console.WriteLine($"{value} is in range 4 and 9?  {isInRange}");
            int length = range.GetLength();
            Console.WriteLine($"The Length of the  range 4 and 9?  {length}");


            #endregion


        }
    }
}

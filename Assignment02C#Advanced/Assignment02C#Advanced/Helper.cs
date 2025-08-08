using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02C_Advanced
{
    internal class Helper
    {
       
        public static void ReverseArrayList(ArrayList list)
        {
            if (list is not null)
            { 
                int left = 0;
                int right = list.Count - 1;
                while (left < right)
                {
                    object temp = list[left];
                    list[left] = list[right];
                    list[right] = temp;
                    right--;
                    left++;
                }
            
            }
        
        }

        public static List<int> EvenNumbers(List<int> list)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < list.Count; i++)
            { 
                if(list[i] % 2 == 0) result.Add(list[i]);
            }
            return result;
        }

        public static int SpecificBinarySearch(int[]array, int target)
        {
            if (array is  null)
            throw new ArgumentNullException("array is empty");
            int N = array.Length;
            int l = 0;
            int r = N - 1;
            int minIdx = int.MaxValue;
            while (l <= r)
            {
                int mid = (l + r) / 2;

                if (array[mid] > target)
                { 
                    r = mid - 1;
                    minIdx = Math.Min(minIdx, mid);
                    
                
                }
                else
                    l = mid + 1;
            }
            if(minIdx == int.MaxValue) return 0;
            return N - minIdx;
        }

        public static bool isPalindrome(int[] array)
        { 
            int size= array.Length;
            for (int i = 0, j = size - 1; i < j; i++, j--)
            { 
                if(array[i] != array[j]) return false;
            }
            return true;
        
        }
        public static int[] RemoveDuplicateFromArray(int[] DuplicateArray)
        {

            int size = DuplicateArray.Length;

            
            Dictionary<int, int> DC = new Dictionary<int, int>();

            for (int i = 0; i < size; i++)
            {
                if (DC.ContainsKey(DuplicateArray[i]))
                {
                    DC[DuplicateArray[i]]++;
                }
                else DC.Add(DuplicateArray[i], 1);
            }
            int[] result = new int[DC.Count];
            int index = 0;
            foreach ( int i in DC.Keys)
            { 
                result[index++] = i;
            }

            return result;
        }

        public static void RemoveOddsFromArrayList(ArrayList listWithoutOdds)
        {
            for(int i = 0; i < listWithoutOdds.Count; i++ )
            {

                if ((int)listWithoutOdds[i] % 2 != 0)
                {
                    listWithoutOdds.RemoveAt(i);
                }
            }
            Console.Write("Array List without odds: ");
            foreach (int i in listWithoutOdds)
            {
                Console.Write(i + " ");
            }

        }
    }
}

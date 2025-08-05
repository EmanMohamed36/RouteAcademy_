using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1AdvancedC_
{
    internal class Helper<T> where T :IComparable
    {
        public static void Swap(ref T x, ref T y)
        { 
            T temp = x;
            x = y;
            y = temp;
        }
        public static void BubbleSort(T[] array)
        {
            if (array is not null) {
            
                int n = array.Length;
                for(int i = 0; i < n; i++)
                {
                    bool isSwaped = false;
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (array[j].CompareTo(array[j + 1]) > 0)
                        { 
                            Swap(ref array[j], ref array[j + 1]);
                            isSwaped = true;
                            
                        }
                    }
                    if(!isSwaped) break;
                }
                
            }
        }
    }
}

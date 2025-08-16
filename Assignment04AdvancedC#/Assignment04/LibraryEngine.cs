using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal class LibraryEngine
    {
        public static void ProcessBooksUsingBuiltInDelegate<T>(List<Book> bList, Func<Book ,T> delegateFunc)
        {
            if (bList is not null && delegateFunc is not null)
            { 
                foreach (Book book in bList)
                {
                    Console.WriteLine(delegateFunc(book));
                }
            
            }
        }
        public static void ProcessBooksUsingUserDefineDelegate(List<Book> bList, UserDelegateType<Book> delegateFunc)
        {
            if (bList is not null && delegateFunc is not null)
            {
                foreach (Book book in bList)
                {
                    Console.WriteLine(delegateFunc(book));
                }

            }
        }
        
    }
}

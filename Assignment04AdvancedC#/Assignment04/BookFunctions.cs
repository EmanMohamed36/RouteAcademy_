using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    public delegate string UserDelegateType<T>(T b);
    internal class BookFunctions
    {
        public static string GetTitle(Book B)
        { 
            return B.Title;
        }
        public static string GetAuthors(Book B)
        {
            string Authors = string.Join(",", B.Authors);
            return Authors;
        }
        public static string GetPrice(Book B)
        {
            string price = Convert.ToString(B.Price);
            return price;
        }
    }
}

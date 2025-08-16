namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("NNN", "science", ["eman", "Mohamed"], new DateTime(2020, 4, 3), 333);
            Book b2 = new Book("eee", "Math", ["eman", "Mohamed"], new DateTime(2020, 4, 3), 333);
            List<Book> list = new List<Book>() { b1,b2};
            #region built in delegate
            Console.WriteLine("use built in delegate Func");
            Func<Book, string> GetPrice = new Func<Book, string>(BookFunctions.GetPrice);
            Func<Book, string> GetTitle = new Func<Book, string>(BookFunctions.GetTitle);
            Func<Book, string> GetAuthors = new Func<Book, string>(BookFunctions.GetAuthors);
            Console.WriteLine("Titles of the books");
            LibraryEngine.ProcessBooksUsingBuiltInDelegate(list, GetTitle);
            Console.WriteLine("Authors of the books");
            LibraryEngine.ProcessBooksUsingBuiltInDelegate(list, GetAuthors);
            Console.WriteLine("Price of the books");

            LibraryEngine.ProcessBooksUsingBuiltInDelegate(list, GetPrice);

            #endregion

            #region User defined delegate
            Console.WriteLine("use user-defined  delegate ");

            UserDelegateType<Book> GetPrice02 = new UserDelegateType<Book>(BookFunctions.GetPrice);
            UserDelegateType<Book> GetTitle02 = new UserDelegateType<Book>(BookFunctions.GetTitle);
            UserDelegateType<Book> GetAuthors02 = new UserDelegateType<Book>(BookFunctions.GetAuthors);
            Console.WriteLine("Titles of the books");
            LibraryEngine.ProcessBooksUsingUserDefineDelegate(list, GetTitle02);
            Console.WriteLine("Authors of the books");
            LibraryEngine.ProcessBooksUsingUserDefineDelegate(list, GetAuthors02);
            Console.WriteLine("Price of the books");

            LibraryEngine.ProcessBooksUsingUserDefineDelegate(list, GetPrice02);

            #endregion

            #region Anonymous Method
            Func<Book, string> isbnDelegate = delegate (Book b)
            {
                return b.ISBN;
            };
            Console.WriteLine("ISBN of the books");
            LibraryEngine.ProcessBooksUsingBuiltInDelegate(list, isbnDelegate);
            #endregion

            #region Lambda Expression 
            Func<Book, DateTime> publicationDateDelegate = b => b.PublicationDate;
            LibraryEngine.ProcessBooksUsingBuiltInDelegate(list, publicationDateDelegate);

            #endregion
        }
    }
}

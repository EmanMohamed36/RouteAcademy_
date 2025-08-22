using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;
using static Assignment01Linq.ListGenerator;
namespace Assignment01Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Element Operators
            Console.WriteLine("LINQ - Element Operators");
            #region Q1
            // 1). Get first Product out of Stock
            var result01 = ProductList.Where(p => p.UnitsInStock == 0).First();
            Console.WriteLine($"Q1)First Product out of Stock: {result01}");


            #endregion
            #region Q2
            //2)Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            var result02 = ProductList.Where(p => p.UnitPrice > 1000);

            if (result02.Count() > 0)
            {
                Console.WriteLine($"2)First Product whose Price > 1000: {result02.First()}");

            }
            else Console.WriteLine("Q2)First Product whose Price > 1000: Null");


            #endregion
            #region Q3
            //3) Retrieve the second number greater than 5 
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            Array.Sort(Arr);
            var result03 = Arr.Where(e => e > 5).ToArray();
            Console.WriteLine($"Q3)second number greater than 5: {result03[1]}");


            #endregion

            #endregion


            #region LINQ - Aggregate Operators
            Console.WriteLine("LINQ - Aggregate Operators");
            #region Q1
            //1) Uses Count to get the number of odd numbers in the array

            int result04 = Arr.Where(e => e % 2 == 1).Count();
            Console.WriteLine($"Q1)the number of odd numbers in the array: {result04}");


            #endregion
            #region Q2
            //2) Return a list of customers and how many orders each has.

            Console.WriteLine("Q2)a list of customers and how many orders each has:");
            var result05 = CustomerList.Select(c => new { c.CustomerID, c.CustomerName, NumberOfOrders = c.Orders.Count() });
            foreach (var item in result05)
            {
                Console.WriteLine(item);
            }


            #endregion
            #region Q3

           // 3.Return a list of categories and how many products each has
            Console.WriteLine("Q3)a list of categories and how many products each has:");
            var result06 = ProductList.GroupBy(p => p.Category).Select(g => new { CategoryName = g.Key, ProductCount = g.Count() });
            foreach (var item in result06)
            {
                Console.WriteLine(item);
            }

            #endregion
            #region Q4

            //4. Get the total of the numbers in an array.
            var result07 = Arr.Sum();
            Console.WriteLine($"Q4. Get the total of the numbers in an array: {result07}");

            #endregion
            #region Q9
            //9. Get the total units in stock for each product category

            var result08 = ProductList.GroupBy(p => p.Category).Select(g => new { CategoryName = g.Key, TotalUnitsInStock = g.Sum(p => p.UnitsInStock) });
            Console.WriteLine("Q9. Get the total units in stock for each product category");
            foreach (var item in result08)
            {
                Console.WriteLine(item);
            }

            #endregion
            #region Q10
            //10.Get the cheapest price among each category's products
            Console.WriteLine("10. Get the cheapest price among each category's products");
            var result09 = ProductList.GroupBy(p => p.Category).Select(g => new { CategoryName = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) });
            foreach (var item in result09)
            {
                Console.WriteLine(item);
            }


            #endregion
            #region Q11

            //11. Get the products with the cheapest price in each category (Use Let)

            Console.WriteLine("Q11. Get the products with the cheapest price in each category (Use Let)");
            var query =
            from p in ProductList
            group p by p.Category into g
            let minPrice = g.Min(x => x.UnitPrice)
            from p in g
            where p.UnitPrice == minPrice
            select new { p.Category, p.ProductName, p.UnitPrice };

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Q12

            //12. Get the most expensive price among each category's products.

            Console.WriteLine("12. Get the most expensive price among each category's products.");
            var result10 = ProductList.GroupBy(p => p.Category).Select(g => new { CategoryName = g.Key, CheapestPrice = g.Max(p => p.UnitPrice) });
            foreach (var item in result10)
            {
                Console.WriteLine(item);
            }
            #endregion


            #region Q13

            Console.WriteLine("13. Get the products with the most expensive price in each category.");
            var query02 =
            from p in ProductList
            group p by p.Category into g
            let maxPrice = g.Max(x => x.UnitPrice)
            from p in g
            where p.UnitPrice == maxPrice
            select new { p.Category, p.ProductName, p.UnitPrice };

            foreach (var item in query02)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Q14
            // 14. Get the average price of each category's products. 
            Console.WriteLine("14. Get the average price of each category's products.");

            var result11 = ProductList.GroupBy(p => p.Category).Select(g => new { CategoryName = g.Key, CheapestPrice = g.Average(p => p.UnitPrice) });
            foreach (var item in result11)
            {
                Console.WriteLine(item);
            }

            #endregion

            #endregion

            #region LINQ - Ordering Operators
            Console.WriteLine("LINQ - Ordering Operators");
            #region Q1
            Console.WriteLine("Q1. Sort a list of products by name");
            var result12 = ProductList.OrderBy(p => p.ProductName ?? string.Empty);
            foreach (var item in result12)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Q2
            Console.WriteLine("Q2. Uses a custom comparer to do a case-insensitive sort of the words in an array.");
            String[] Words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var result13 = Words.OrderBy(w => w , StringComparer.OrdinalIgnoreCase);
            foreach (var item in result13)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Q3
            Console.WriteLine("Q3. Sort a list of products by units in stock from highest to lowest."); 
            var result14 = ProductList.OrderByDescending(p => p.UnitsInStock);
            foreach (var item in result14)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Q4
            Console.WriteLine("Q4.Sort a list of digits, first by length of their name, and then alphabetically by the name itself.");
            string[] Arr02 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var result15 = Arr02.OrderBy(w => w.Length).ThenBy(w => w);
            foreach (var item in result15)
            { 
                Console.WriteLine(item);
            }

            #endregion

            #region Q5
            Console.WriteLine("Q5. Sort first by-word length and then by a case-insensitive sort of the words in an array");
            var result16 = Words.OrderBy(w => w.Length).ThenBy(w => w,StringComparer.OrdinalIgnoreCase);

            foreach (var item in result16)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Q6
            Console.WriteLine("Q6. Sort a list of products, first by category, and then by unit price, from highest to lowest.");
            var result17 = ProductList.OrderBy(p => p.ProductName).ThenByDescending(p => p.UnitPrice);
            foreach (var item in result17)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Q7
            Console.WriteLine("Q7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.");
            var result18 = Words.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);
            foreach (var item in result18)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Q8
            Console.WriteLine("Q8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the originalArray.");
            var result19 = Arr02.Where(w => w.Length > 1 && w[1] == 'i').Reverse();
            foreach (var item in result19)
            {
                Console.WriteLine(item);
            }
            #endregion
            #endregion

            #region LINQ – Transformation Operators
            Console.WriteLine("LINQ – Transformation Operators");
            #region Q1

            Console.WriteLine("Q1. Return a sequence of just the names of a list of products.");
            var result20 = ProductList.Select(p => p.ProductName);
            foreach (var item in result20)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Q2
            Console.WriteLine("Q2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).");
            var result21 = Words.Select(w => new {UpperCase = w.ToUpper() , LowerCase = w.ToLower()});
            foreach (var item in result21)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region Q3
            Console.WriteLine("Q3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.");
            var result22 = ProductList.Select(p =>new { p.ProductName , p.Category,Price = p.UnitPrice});
            foreach (var item in result22)
            {
                Console.WriteLine(item);
            }

            #endregion
            #region Q4
            Console.WriteLine("Q4. Number : In-place?");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result23 = numbers.Select((n, i) => new { n, i,result = n == i });
            foreach (var item in result23)
            {
                Console.WriteLine($"{item.n}: {item.result}");
            }
            #endregion
            #region Q5
            Console.WriteLine("Q5. Pairs where a < b");
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var result24 = from a in numbersA
                           from b in numbersB
                           where a < b
                           select new { A = a, B = b };

            foreach (var item in result24)
            {
                Console.WriteLine($"{item.A} is less than {item.B}");
            }
            #endregion

            #region Q6 
            Console.WriteLine("6. Select all orders where the order total is less than 500.00.");
            var result25 = CustomerList.SelectMany(c => c.Orders).Where(c => c.Total < 500);
          
            foreach (var item in result25)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region Q7
            Console.WriteLine("Q7. Select all orders where the order was made in 1998 or later");
            var result26 = CustomerList.SelectMany(c => c.Orders).Where(c => c.OrderDate.Year >= 1998);

            foreach (var item in result26)
            {
                Console.WriteLine(item);
            }

            #endregion
            #endregion

        }


    }
}

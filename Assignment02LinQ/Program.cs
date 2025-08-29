using static Assignment02LinQ.ListGenerators;
namespace Assignment02LinQ
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

            #region Q5
            Console.WriteLine("Q5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).");

            string[] WordsFile = File.ReadAllLines("dictionary_english.txt");

            var res2_05 = WordsFile.Sum(w => w.Length);
            Console.WriteLine($"Total number of characters: {res2_05}");
            #endregion

            #region Q6

            Console.WriteLine("6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).");

            var res2_06 = WordsFile.MinBy(w => w.Length);
            Console.WriteLine($"Length of shortest word: {res2_06}");
            #endregion

            #region Q7

            Console.WriteLine("7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).");

            var res2_07 = WordsFile.MaxBy(w => w.Length);
            Console.WriteLine($"Length of Longest word: {res2_07}");
            #endregion

            #region Q8

            Console.WriteLine("8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).");

            var res2_08 = WordsFile.Average(w => w.Length);
            Console.WriteLine($"Length of Longest word: {res2_08}");
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


            #region LINQ - Set Operators
            Console.WriteLine("LINQ - Set Operators");

            #region Q1

            Console.WriteLine("Q1. Find the unique Category names from Product List");
            var res3_01 = ProductList.Select(p => p.Category).Distinct().ToList();

            foreach (var item in res3_01)
            {
                Console.WriteLine(item);
            }

            #endregion


            #region Q2

            Console.WriteLine("Q2. Produce a Sequence containing the unique first letter from both product and customer names.");
            var res3_02 = ProductList.Select(p => p.ProductName[0]).Union(CustomerList.Select(c => c.CustomerName[0]));

            foreach (var item in res3_02)
            {
                Console.WriteLine(item);
            }

            #endregion


            #region Q3

            Console.WriteLine("Q3. Create one sequence that contains the common first letter from both product and customer names.");
            var res3_03 = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerName[0]));

            foreach (var item in res3_03)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Q4

            Console.WriteLine("Q4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.");
            var res3_04 = ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CustomerName[0]));

            foreach (var item in res3_04)
            {
                Console.WriteLine(item);
            }

            #endregion


            #region Q5

            Console.WriteLine("Q5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates");
            var res3_05 = ProductList.Select(p => p.ProductName.Length >= 3 ? p.ProductName
            .Substring(p.ProductName.Length - 3):p.ProductName)
            .Concat(CustomerList.Select(c => c.CustomerName.Length >= 3 ?c.CustomerName
            .Substring(c.CustomerName.Length - 3) : c.CustomerName ));

            foreach (var item in res3_05)
            {
                Console.WriteLine(item);
            }

            #endregion




            #endregion

            #region LINQ - Quantifiers

            Console.WriteLine("LINQ - Quantifiers");
            
            #region Q1.
            Console.WriteLine(" Q1)Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.");

            string[] words = File.ReadAllLines("dictionary_english.txt");
            bool res4_01 = words.Any(w => w.Contains("ei"));
            Console.WriteLine(res4_01 ? "Words contain ei": "Words don't contain ei");

            #endregion

            #region Q2.
            Console.WriteLine(" Q2. Return a grouped a list of products only for categories that have at least one product that is out of stock.");

            var res4_02 = ProductList.GroupBy(p => p.Category).Where(g => g.Any(p => p.UnitsInStock == 0)).ToList();

            foreach (var item in res4_02)
            {
                Console.WriteLine($"Category: {item.Key}");
                foreach (var product in item)
                    Console.WriteLine($"   {product.ProductName} (Stock: {product.UnitsInStock})");
            }

            #endregion

            #region Q3.
            Console.WriteLine(" Q3. Return a grouped a list of products only for categories that have all of their products in stock.");

            var res4_03 = ProductList.GroupBy(p => p.Category).Where(g => g.All(p => p.UnitsInStock > 0)).ToList();

            foreach (var item in res4_03)
            {
                Console.WriteLine($"Category: {item.Key}");
                foreach (var product in item)
                    Console.WriteLine($"   {product.ProductName} (Stock: {product.UnitsInStock})");
            }

            #endregion


            #endregion

            #region LINQ – Grouping Operators


            Console.WriteLine("LINQ – Grouping Operators");
            #region Q1
            Console.WriteLine("1.Use group by to partition a list of numbers by their remainder when divided by 5");
           
            List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            var groups = numbers
                .GroupBy(n => n % 5);

            foreach (var g in groups)
            {
                Console.WriteLine($"Numbers with remender of {g.Key} when divide by 5:");
                foreach (var num in g)
                    Console.WriteLine(num);
            }
            #endregion


            #region Q2
            Console.WriteLine("Q2.Uses group by to partition a list of words by their first letter.");


            var res5_02 = words.GroupBy(w => w[0]);

            foreach (var g in res5_02)
            {
                Console.WriteLine($"Letter: {g.Key}");
                foreach (var W in g.Take(5))
                    Console.WriteLine(W);
            }
            #endregion


            #region Q3
            Console.WriteLine("Q3.Use Group By with a custom comparer that matches words that are consists of the same Characters Together");

            String[] Arr5_03 = { "from", "salt", "earn", " last", "near", "form" };
            var res5_03 = Arr5_03.GroupBy(w => new string(w.Trim().OrderBy(c => c).ToArray()));

            foreach (var g in res5_03)
            {
                Console.WriteLine($"key: {g.Key}");
                foreach (var W in g)
                    Console.WriteLine(W);
            }
            #endregion


            #endregion
        }
    }
}

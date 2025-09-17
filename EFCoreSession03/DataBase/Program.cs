using DataBase.Models;

namespace DataBase
{
    internal class Program
    {
        static void Main(string[] args)
        {


            using NorthwindContext context = new NorthwindContext();
            //Select 
            //  int no = 5;
            ////var res=  context.Categories.FromSqlRaw("select top ({0}) * from Categories",no);
            //var res=  context.Categories.FromSqlInterpolated($"select top ({no}) * from Categories");

            //  foreach (var item in res)
            //  {
            //      Console.WriteLine(item.CategoryName);
            //  }

            //DML

            //int catId = 1;
            //string newName = "Beverages";


            ////context.Database.ExecuteSqlRaw("update Categories set CategoryName = {0} where CategoryId = {1}",newName,catId);
            //context.Database.ExecuteSqlInterpolated($"update Categories set CategoryName = {newName} where CategoryId = {catId}");


            NorthwindContextProcedures contextProcedures = new NorthwindContextProcedures(context);

            //var res = contextProcedures.SelectAllCategoriesAsync().Result;
            var res = contextProcedures.SalesByCategoryAsync("Beverages", "2018").Result;


            foreach (var item in res)
            {
                Console.WriteLine($"{item.ProductName} ,, {item.TotalPurchase}");
            }


        }
    }
}

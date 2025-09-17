using MappingInheritance.Data;
using MappingInheritance.Data.Models;

namespace MappingInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using MyCompanyContext myCompanyContext = new MyCompanyContext();

            #region TPCT
            //var emp01 = new FullTimeEmployee()
            //{
            //    Name="Rana",
            //    Age=20,
            //    Address="Mansoura",
            //    Salary=3_000,
            //    StartDate=DateTime.Now,
            //};

            //var emp02 = new PartTimeEmployee()
            //{
            //    Name = "Mai",
            //    Age = 30,
            //    Address = "Giza",
            //    CountOfHrs=15,
            //    HourRate=250
            //};


            //myCompanyContext.FullTimeEmployees.Add(emp01);
            //myCompanyContext.PartTimeEmployees.Add(emp02);

            //myCompanyContext.SaveChanges();



            //var fullTimeEmp = myCompanyContext.FullTimeEmployees.FirstOrDefault();

            //if(fullTimeEmp is not null)
            //Console.WriteLine(fullTimeEmp.Name); 
            #endregion

            #region TPH

            var emp01 = new FullTimeEmployee()
            {
                Name = "Mohamed",
                Age = 20,
                Address = "Ismailia",
                Salary = 3_000,
                StartDate = DateTime.Now,
            };

            var emp02 = new PartTimeEmployee()
            {
                Name = "Eman",
                Age = 30,
                Address = "Cairo",
                CountOfHrs = 15,
                HourRate = 250
            };


            myCompanyContext.Employees.Add(emp01);
            myCompanyContext.Employees.Add(emp02);

            myCompanyContext.SaveChanges();

            //var res = myCompanyContext.Employees.ToList();
            //if (res is not null)
            //{

            //    foreach (var item in res.OfType<FullTimeEmployee>())
            //    {
            //        Console.WriteLine($"{item.Name} ,,");
            //    }


            //   }


            #endregion
        }
    }
}

namespace AssignmentOOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees[] EmpArr = new Employees[3];
            EmpArr[0] = new Employees(1, "Eman", Gender.Female, SecurityPrivileges.DBA, 5000, new(14, 2, 2002));
            EmpArr[1] = new Employees(2, "Mohamed", Gender.Male, SecurityPrivileges.guest, 7000, new(14, 2, 2025));
            EmpArr[2] = new Employees(3, "Hassan", Gender.Male, SecurityPrivileges.guest | SecurityPrivileges.DBA
                |SecurityPrivileges.Developer|SecurityPrivileges.secretary, 20000, new(14, 4, 2025));

           // EmpArr[2].securityLevel |= SecurityPrivileges.DBA;
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Data of Employee {i + 1}");
                Console.WriteLine(EmpArr[i]);
                Console.WriteLine("-----------------------------");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AssignmentOOP02
{
    [Flags]
    public enum SecurityPrivileges
    {
        guest = 1,
        Developer = 2,
        secretary = 4,
        DBA = 8
    }
    public enum Gender
    {
        Female = 0,
        F = 0,
        Male = 1,
        M = 1
    }
    internal class Employees
    {
        public int id { set; get; }
        public string name { set; get; }

        public Gender gender { set; get; }
        public SecurityPrivileges securityLevel { set; get; }
        public HiringDate hiringDate { set; get; }
        
        private decimal salary;

        public Employees(int _id, string _name, Gender _gender, SecurityPrivileges _securityLevel,
                           decimal _salary, HiringDate _hiringDate)
        { 
            id = _id;
            name = _name;
            gender = _gender;
            securityLevel = _securityLevel;
            Salary = _salary;
            hiringDate = _hiringDate;
        }
       public decimal Salary
        {
            get { return salary; }
            set { salary = value < 6_000 ? 6_000:value; }
        }

        public override string ToString()
        {
            return $"Id: {id} , Name: {name} ,Gender: {gender}\n Salary: {string.Format("{0:C}", salary)} ,SecurityLevel: {securityLevel} ,HiringDate: ( {hiringDate} )";
        }

    }
}

using Demo.DAL.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Repositories
{
    public class DepartmentRepository(ApplicationDbContext _context) : IDepartmentRepository
    //primary constructor
    //repository encapsulate DbContext 
    {
        //CRUD Operation

        // Get By Id
        public Department? GetById(int id) => _context.Departments.Find(id);
        //{
        //    var department = _context.Departments.Find(id);
        //    return department;
        //}

        // Get All Departments

        public IEnumerable<Department> GetAll(bool withTracking = false)
        {
            if (withTracking) return _context.Departments.ToList(); //withTracking = true → “I want live objects, connected to the database. If I change them, EF will save the changes.”
            else return _context.Departments.AsNoTracking().ToList();//withTracking = false → “I only want a snapshot (copy) of the data to look at. I don’t plan to change and save it.”
        }

        //Add Department

        public int Add(Department department)
        {
            _context.Departments.Add(department);
            return _context.SaveChanges();//number of rows affected
        }

        //update Department

        public int Update(Department department)
        {
            _context.Departments.Update(department);
            return _context.SaveChanges();
        }

        //Delete Department

        public int Remove(Department department)
        {
            _context.Departments.Remove(department);
            return _context.SaveChanges();
        }
    }
}

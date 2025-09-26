

namespace Demo.DAL.Repositories
{
    //primary constructor .Net 8 Feature
    internal class DepartmentRepository(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;
       
        public Department? GetById(int id)
        {
            var department = _context.Departments.Find(id);
            return department;
        }


    }
}

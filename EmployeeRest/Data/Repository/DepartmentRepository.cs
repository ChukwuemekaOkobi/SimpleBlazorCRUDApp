using Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeRest.Data.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext _context;

        public DepartmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Department GetDepartment(int departmentId)
        {
            return _context.Departments
                .FirstOrDefault(d => d.Id == departmentId);
        }

        public IEnumerable<Department> GetDepartments()
        {
            return _context.Departments;
        }
    }
}


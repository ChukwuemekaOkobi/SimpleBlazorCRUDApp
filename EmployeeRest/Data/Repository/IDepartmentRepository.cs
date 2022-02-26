using Models;
using System.Collections.Generic;

namespace EmployeeRest.Data.Repository
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
        Department GetDepartment(int Id);
    }
}


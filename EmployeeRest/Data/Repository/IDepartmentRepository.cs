﻿using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeRest.Data.Repository
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int Id);
    }
}


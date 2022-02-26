using Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeRest.Data.Repository
{
    public  interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int Id);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        void DeleteEmployee(int Id);
    }
}


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

        Task<Employee> GetEmployeeByEmail(string email);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);


        Task DeleteEmployee(int Id);
        Task<IEnumerable<Employee>> Search(string name, Gender? gender);
    }
}


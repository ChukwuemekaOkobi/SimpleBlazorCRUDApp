using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorAppWasm.Services
{
    public interface IEmployeeService
    {
      Task<IEnumerable<Employee>> GetEmployees();
      Task<Employee> GetEmployee(int v);

      Task<Employee> UpdateEmployee(int id, Employee employee);
        Task<Employee> CreateEmployee(Employee newEmployee);
        Task DeleteEmployee(int id);
    }
}

using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorAppWasm.Services
{
    public interface IEmployeeService
    {
      Task<IEnumerable<Employee>> GetEmployees();

    }
}

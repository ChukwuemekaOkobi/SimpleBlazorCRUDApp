using Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System;

namespace BlazorAppWasm.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Employee> GetEmployee(int v)
        {
            return await _httpClient.GetFromJsonAsync<Employee>($"api/Employee/{v}");
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _httpClient.GetFromJsonAsync<Employee[]>("api/Employee");
        }

        public async Task<Employee> UpdateEmployee(int id, Employee employee)
        {
            var result = await _httpClient.PutAsJsonAsync($"api/Employee/{id}", employee);

            if(result.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return null;
            }

           return await result.Content.ReadFromJsonAsync<Employee>();
        }

        public async Task<Employee> CreateEmployee(Employee newEmployee)
        {
            var result = await _httpClient.PostAsJsonAsync($"api/Employee", newEmployee);

            if (result.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return null;
            }

            return await result.Content.ReadFromJsonAsync<Employee>();
        }
    }
}

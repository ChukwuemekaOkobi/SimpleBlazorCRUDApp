using BlazorAppWasm.Services;
using Microsoft.AspNetCore.Components;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppWasm.Pages
{
    public partial class EmployeeList
    {
        public IEnumerable<Employee> Employees { get; set; }


        [Inject]
        public IEmployeeService  Service { get; set; }

        public EmployeeList()
        {

        }


        protected override async Task OnInitializedAsync()
        {
             await LoadEmployees();
     
        }

        private async Task LoadEmployees()
        {
            Employees = await Service.GetEmployees();
        }

       
    }
}

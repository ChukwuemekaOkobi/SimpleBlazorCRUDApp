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
        public bool ShowFooter { get; set; } = true;


        [Inject]
        public IEmployeeService  Service { get; set; }

       
        protected int SelectedEmployeesCount { get; set; } = 0;

        public EmployeeList()
        {

        }
        protected void EmployeeSelectionChanged(bool isSelected)
        {
            if (isSelected)
            {
                SelectedEmployeesCount++;
            }
            else
            {
                SelectedEmployeesCount--;
            }
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

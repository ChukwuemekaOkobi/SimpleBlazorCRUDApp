
using BlazorAppWasm.Services;
using BlazorAppWasm.ViewModels;
using Components;
using Microsoft.AspNetCore.Components;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppWasm.Pages
{
    public partial class EditEmployee
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Inject]
        public IDepartmentService DepartmentService { get; set; }

        [Inject]
        public NavigationManager NavigationService { get; set; }

        public ConfirmMessage DeleteConfirmation { get; set; }
        public string PageHeaderText { get; set; }
        public Employee Employee { get; set; } = new Employee();

        public EditEmployeeModel EditEmployeeModel { get; set; } = new EditEmployeeModel();

      

        public List<Department> Departments { get; set; } = new List<Department>();

       // public string DepartmentId { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            _ = int.TryParse(Id, out int employeeId); 

            if(employeeId != 0)
            {
                Employee = await EmployeeService.GetEmployee(employeeId);
                PageHeaderText = $"Edit {Employee.FirstName}";
            }
            else
            {
                Employee = new Employee
                {
                    DepartmentId = 1,
                    DateOfBirth = DateTime.Now,
                    PhotoUrl = "images/sam.jpg"
                };

                PageHeaderText = "Create Employee";

            }


            EditEmployeeModel = new EditEmployeeModel
            {
                DepartmentId = Employee.DepartmentId,
                Email = Employee.Email,
                DateOfBirth = Employee.DateOfBirth,
                FirstName = Employee.FirstName,
                LastName = Employee.LastName,
                Gender = Employee.Gender,
                Id = Employee.Id,
                PhotoUrl = Employee.PhotoUrl,
                Department = Employee.Department,
                ConfirmEmail = Employee.Email

            };

            Departments = (await DepartmentService.GetDepartments()).ToList();
           // DepartmentId = Employee.DepartmentId.ToString();
        }

        protected async Task SubmitForm()
        {
            Employee = EditEmployeeModel;

            Employee result;
            if (Employee.Id != 0)
            {
                result = await EmployeeService.UpdateEmployee(Employee.Id, Employee);
                
            }
            else
            {
                result = await EmployeeService.CreateEmployee(Employee);
            }
            if (result != null)
            {
                NavigationService.NavigateTo("/");
            }


        }

        protected void Delete_Click()
        {
            DeleteConfirmation.Show();
        }

        protected async Task ConfirmDelete_Click(bool isConfirmed)
        {

            if (isConfirmed)
            {
                await EmployeeService.DeleteEmployee(Employee.Id);

                NavigationService.NavigateTo("/");
            }
        }
    }
}

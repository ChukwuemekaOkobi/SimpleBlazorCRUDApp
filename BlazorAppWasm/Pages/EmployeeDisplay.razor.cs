using Components;
using Microsoft.AspNetCore.Components;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppWasm.Pages
{
    public partial class EmployeeDisplay
    {
        [Parameter]

        public Employee Employee { get; set; }

        [Parameter]
        public bool ShowFooter { get; set; }

        protected bool IsSelected { get; set; }

        [Parameter]
        public EventCallback<bool> OnEmployeeSelection { get; set; }

        [Parameter]
        public EventCallback<int> OnEmployeeDelete { get; set; }

        public ConfirmMessage DeleteConfirmation { get; set; }

        protected async Task CheckBoxChanged(ChangeEventArgs e)
        {
            IsSelected = (bool)e.Value;
            await OnEmployeeSelection.InvokeAsync(IsSelected);
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

                await OnEmployeeDelete.InvokeAsync(Employee.Id);
            }
        }

    }
}

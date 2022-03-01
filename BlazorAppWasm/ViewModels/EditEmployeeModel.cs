using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppWasm.ViewModels
{
    public class EditEmployeeModel : Employee
    {
        [Compare("Email", ErrorMessage = "Emails must match")]
        public string ConfirmEmail { get; set; }
    }
}

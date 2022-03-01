using Models.CustomValidator;
using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [EmailValidator(AllowedDomain = "sporty.com",
            ErrorMessage = "Domain must be sporty.com")]
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public string PhotoUrl { get; set; }

        public Department Department { get; set; }
    }
}

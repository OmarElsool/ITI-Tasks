using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required, MinLength(4)]
        [Remote("checking", "Student", AdditionalFields = "Id")]
        public string Username { get; set; }
        public string Name { get; set; }
        public string? StdImg { get; set; }
        [Required, StringLength(15, MinimumLength = 3)]
        public string Password { get; set; }
        [Compare("Password")]
        [Display(Name = "Confirm Password")]
        public string CPassword { get; set; }

    }
}

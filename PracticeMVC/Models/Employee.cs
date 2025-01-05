using System.ComponentModel.DataAnnotations;

namespace PracticeMVC.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "The name filed must be required!")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Name must be between 3 to 15 characters!")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string Desigation { get; set; }
        public int Salary { get; set; }
        public int Married { get; set; }

        public string Description { get; set; }

    }

    public enum Gender { 
        Male, Female,
    }
}

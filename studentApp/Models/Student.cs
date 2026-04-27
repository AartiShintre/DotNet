using System.ComponentModel.DataAnnotations;

namespace StudentApp.Models   // ✅ FIXED - lowercase 's', correct name
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Range(1, 100)]
        public int Marks { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
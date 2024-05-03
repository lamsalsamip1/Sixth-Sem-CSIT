using System.ComponentModel.DataAnnotations;

namespace StudentMVC.Models
{
    public class Student
    {
        [Key]
        public int student_id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string email { get; set; }

        public DateOnly date_of_birth { get; set; }

        public char gender { get; set; }

        [Required]
        public  string phone_number { get; set; }

        public int faculty_id { get; set; }
        public virtual Faculty? Faculty { get; set; }
    }
}

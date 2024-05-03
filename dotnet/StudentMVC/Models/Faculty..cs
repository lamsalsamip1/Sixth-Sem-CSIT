using System.ComponentModel.DataAnnotations;

namespace StudentMVC.Models
{
    public class Faculty
    {
       
        [Key]
        public int faculty_id { get; set; }

        [Required]
        public string name { get; set; }

        public virtual List<Student>? Students { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace PlayerValidaton.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int user_id { get; set; }

        [Required(ErrorMessage = "Email is requird")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email is invalid")]
        public string email { get; set; }

        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "At least 8 characters")]
        public string password { get; set; }

        public string? UserType { get; set; }
    }
}


using System.ComponentModel.DataAnnotations;

namespace PlayerValidaton.Models
{
    public class Player
    {

        [Key]
        public int player_id { get; set; }

        [Required(ErrorMessage = "Player Name is required")]
        [StringLength(50, ErrorMessage = "Name must be of max 50 characters")]
        public string player_name { get; set; }

        [Range(16,45,ErrorMessage ="Age must me between 16-45")]
        public int age { get; set; }

        [Required(ErrorMessage ="Nationality must be entered")]
        public string nationality { get; set; }

        public string position { get; set; }

        public DateOnly contract_expiry { get; set; }
    }
}

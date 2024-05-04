using System.Numerics;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int product_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public int stock { get; set; }
        public DateOnly updated_at { get; set; }

        [ForeignKey("category_id")]
        public int category_id {  get; set; }

        public virtual Category Category { get; set; }
    }
}

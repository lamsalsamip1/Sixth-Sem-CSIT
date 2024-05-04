using System.ComponentModel.DataAnnotations;

namespace ProductsAPI.Models
{
    public class Product
    {
        [Key]
        public int product_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public int stock {  get; set; }
        public int category_id { get; set; }
        public virtual Category? Category { get; set; }

    }
}


using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;
using ProductAPI.Data;

namespace ProductAPI.Models
{
    public class Category
    {
        [Key]
        [JsonIgnore]
        public int category_id { get; set; }
        public string category_name { get; set; }

        [JsonIgnore]
        public virtual List<Product>? Products { get; set; }
    }


}


using System.ComponentModel.DataAnnotations;

namespace Mango.Web.Models
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } 
        public double Price { get; set; }
        public string? ProductDescription { get; set; }
        public string? CategoryName { get; set; }
        public string ImageUrl { get; set; } 

    }
}

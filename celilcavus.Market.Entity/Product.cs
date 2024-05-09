
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace celilcavus.Market.Entity
{
    public class Product : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        [NotMapped]
        public IFormFile? Image { get; set; }
        public string? ImageName { get; set; }
        public double Price{ get; set; }
        public int CategoryId { get; set; }
        [NotMapped]
        public Category? Category { get; set; }

        public int SellerId { get; set; }
        [NotMapped]
        public Seller? Seller { get; set; }
    }
}

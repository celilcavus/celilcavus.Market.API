using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celilcavus.Market.Entity
{
    public class Seller:BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Adress { get; set; }

        [NotMapped]
        public IFormFile? Image { get; set; }
        public string? ImageName { get; set; }


        public List<Product>? Products { get; set; }
        public string GetFullName() => string.Concat(Name, " ", LastName);
    }
}

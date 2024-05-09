using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celilcavus.Market.Entity
{
    public class Category:BaseEntity
    {
        public int Id { get; set; }
        
        public string? Name { get; set; }

        [NotMapped]
        public Product? Product { get; set; }
    }
}

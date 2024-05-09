using celilcavus.Market.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celilcavus.Market.Model.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();


            builder.HasOne(x => x.Category).WithOne(x => x.Product).HasForeignKey<Product>(x => x.CategoryId);

        }
    }
}

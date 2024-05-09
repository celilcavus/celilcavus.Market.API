using celilcavus.Market.Entity;
using celilcavus.Market.Model.Interfaces;
using Microsoft.AspNetCore.Http;


namespace celilcavus.Market.Model.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProduct,Images
    {
        public ProductRepository(MarketContext context) : base(context)
        {
        }

        
    }
}

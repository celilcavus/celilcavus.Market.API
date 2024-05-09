using celilcavus.Market.Entity;
using celilcavus.Market.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celilcavus.Market.Model.Repository
{
    public class SellerRepository : BaseRepository<Seller>, ISeller
    {
        public SellerRepository(MarketContext context) : base(context)
        {
        }
    }
}

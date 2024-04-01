using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Models;

namespace TrendyolApp.Services
{
    public class LikedProductService
    {
        public TrendyolDbContext _dbContext;
        
        public LikedProductService(TrendyolDbContext dbContext)
        {
            _dbContext = dbContext;
        }

    }
}

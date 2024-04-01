using Microsoft.EntityFrameworkCore;
using System.Linq;
using TrendyolApp.Models;

namespace TrendyolApp.Services.Classes
{
    public class AdminService
    {
        private readonly TrendyolDbContext _dbContext;

        public AdminService(TrendyolDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void ChangeOrderStatus(Orders order, string newStatus)
        {
            if (order != null)
            {
                order.Status = newStatus;
                _dbContext.SaveChanges();
            }
        }
    }
}

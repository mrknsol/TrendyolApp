using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Models;

namespace TrendyolApp.Services.Classes
{
    public class IncreaseBalanceService
    {
        public bool IncreaseBalance(User currentUser, string password, int amount)
        {
            if (BCrypt.Net.BCrypt.Verify(password, currentUser.Password))
            {
                
                return true;
            }
            return false;
        }
    }
}

using FinancesTracking.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracking.Controller
{
    public class ShowBalanceController
    {
        public decimal GetBalance(User user)
        {
            return user.Balance;
        }
    }
}

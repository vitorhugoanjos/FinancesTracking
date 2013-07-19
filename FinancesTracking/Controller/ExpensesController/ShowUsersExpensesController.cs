using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Model;
using FinancesTracking.Persistence;

namespace FinancesTracking.Controller
{
    public class ShowUsersExpensesController
    {
        public List<Expense> GetUserExpenses(User user)
        {
            return Factory.GetFactory().GetExpensesRepository().GetUserExpenses(user);
        }
    }
}

using FinancesTracking.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracking.Persistence
{
    public interface IExpensesRepository
    {
        void RegisterExpense(Expense expense);
        void RemoveExpense(Expense expense);
        List<Expense> GetAllExpenses();
        List<Expense> GetUserExpenses(User user);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Model;
using FinancesTracking.Persistence;

namespace FinancesTracking.Controller
{
    public class RegisterExpenseController
    {

        public void CreateExpense(User user, string comment, double amount, Category category, DateTime date)
        { 
            Expense expense = new Expense(user, comment, amount, category, date);
            Factory.GetFactory().GetExpensesRepository().RegisterExpense(expense);
        }
    }
}
